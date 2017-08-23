using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NetworkVisualization_Visualization
{
    public partial class ReadWriteStatus : Form
    {
        public ReadWriteStatus()
        {
            InitializeComponent();
        }
        ObjectAccess.ConnectDB dbObject = new ObjectAccess.ConnectDB();

        private void ReadWriteStatus_Load(object sender, EventArgs e)
        {
            GraphicalInfo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 503; i++)
            {
                Application.DoEvents();
                GraphicalInfo();
            }
        }
        public void GraphicalInfo()
        {
            datagrid_ReadLatency.DataSource = dbObject.get_ReadAndWriteLatency();
            sec1_dr_01248_dv.DataSource = dbObject.DBTrackMaintenanceCheck();
            Application.DoEvents();
            ////////////////////////////////////////////////////////////////

            double ReadLatency = 0, WriteLatency = 0, ReadLatency1 = 0, WriteLatency1 = 0;
            int count = 1;
            foreach (DataRow sec4_dr_01248_rw in dbObject.get_ReadAndWriteLatency().Rows)
            {
                if (count == 1)
                {
                    ReadLatency = Convert.ToDouble(sec4_dr_01248_rw[0].ToString());
                    WriteLatency = Convert.ToDouble(sec4_dr_01248_rw[1].ToString());
                }
                
                if (count == 2)
                {
                    ReadLatency1 = Convert.ToDouble(sec4_dr_01248_rw[0].ToString());
                    WriteLatency1 = Convert.ToDouble(sec4_dr_01248_rw[1].ToString());

                } count++;
            }

            double[] yValues12 = { ReadLatency, ReadLatency1, WriteLatency, WriteLatency1 };
            string[] xNames12 = { "Read Latency on Data File", "Read Latency on Log File", "Write Latency on Data File", "Write Latency on Log File" };
            ch1_Vis_valMa.Series[0].Points.DataBindXY(xNames12, yValues12);
            ch1_Vis_valMa.ChartAreas[0].Area3DStyle.Enable3D = true;

            ////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////

            double AvgBPRead = 0, AvgBPWrite = 0, AvgBPTransfer = 0;
            double AvgBPRead1 = 0, AvgBPWrite1 = 0, AvgBPTransfer1 = 0;
            ch2_Vis_valMa98.DataSource = null;
            ch2_Vis_valMa98.Visible = false;
            int count1 = 1;
            foreach (DataRow sec4_dr_01248_rw in dbObject.get_ReadAndWriteLatency().Rows)
            {
                if (count1 == 1)
                {
                    AvgBPRead = Convert.ToDouble(sec4_dr_01248_rw[3].ToString());
                    AvgBPWrite = Convert.ToDouble(sec4_dr_01248_rw[4].ToString());
                    AvgBPTransfer = Convert.ToDouble(sec4_dr_01248_rw[5].ToString());
                }
                
                if (count1 == 2)
                {
                    AvgBPRead1 = Convert.ToDouble(sec4_dr_01248_rw[3].ToString());
                    AvgBPWrite1 = Convert.ToDouble(sec4_dr_01248_rw[4].ToString());
                    AvgBPTransfer1 = Convert.ToDouble(sec4_dr_01248_rw[5].ToString());

                } count1++;
            }
           
            Application.DoEvents();
            ch2_Vis_valMa98.Visible = true;
            Thread.Sleep(1200);
            double[] yValues121 = {  AvgBPRead1,  AvgBPWrite1,  AvgBPTransfer1 };
            string[] xNames121 = { "Average Bytes Per Read in Log file :" + AvgBPRead1.ToString(), "Average Write Bytes" + AvgBPWrite1.ToString(), "Average Transfer Bytes : " + AvgBPTransfer1.ToString() };
            ch2_Vis_valMa98.Series[0].Points.DataBindXY(xNames121,yValues121);
            ch2_Vis_valMa98.ChartAreas[0].Area3DStyle.Enable3D = true;


            ////////////////////////////////////////////////////////////////

            double totalReads = 0, BytesWritten= 0, totalwrites = 0;
            
            ch3_Vis_valMa98.DataSource = null;
            ch3_Vis_valMa98.Visible = false;
          
            foreach (DataRow sec4_dr_01248_rw in dbObject.DBTrackMaintenanceCheck().Rows)
            {

                totalwrites = Convert.ToDouble(sec4_dr_01248_rw[0].ToString());
                BytesWritten = Convert.ToDouble(sec4_dr_01248_rw[1].ToString());
                totalReads = Convert.ToDouble(sec4_dr_01248_rw[2].ToString());
                 
            }

            Application.DoEvents();
            ch3_Vis_valMa98.Visible = true;
            Thread.Sleep(1200);
            double[] yValues_New = { totalwrites, BytesWritten, totalReads };
            string[] xNames_New = { "Total Writes :" + totalwrites.ToString(), "Bytes Written :" + BytesWritten.ToString(), "Total Reads :" + totalReads.ToString() };
            ch3_Vis_valMa98.Series[0].Points.DataBindXY(xNames_New, yValues_New);
            ch3_Vis_valMa98.ChartAreas[0].Area3DStyle.Enable3D = true;
















            Application.DoEvents();
            ////////////////////////////////////////////////////////////////
            Thread.Sleep(2200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserContextValue SecurityEvents = new UserContextValue();
            SecurityEvents.Show(); this.Hide();

        }
    }
}

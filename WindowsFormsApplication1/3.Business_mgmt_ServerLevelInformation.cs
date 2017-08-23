using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using ZedGraph;
using System.Windows.Forms.DataVisualization.Charting;
namespace NetworkVisualization_Visualization
{
    public partial class ServerLevelInformation : Form
    {
        public ServerLevelInformation()
        {
            InitializeComponent();
        }
        ObjectAccess.ConnectDB dbO = new ObjectAccess.ConnectDB();

        private void ServerLevelInformation_Load(object sender, EventArgs e)
        {

            SetSize();

            ch2_Vis_valMa98.Visible = true;

            string cpuBusy = null, ioBusy = null, Idle = null;
            foreach (DataRow sec4_dr_01248_rw in dbO.GetServerDetails1().Rows)
            {
                cpuBusy = sec4_dr_01248_rw[0].ToString();
                ioBusy = sec4_dr_01248_rw[1].ToString();
                Idle = sec4_dr_01248_rw[2].ToString();

            }


            string PacketReceived = null, PacketsSent = null, PacketsError = null;
            foreach (DataRow sec4_dr_01248_rw in dbO.GetServerDetails2().Rows)
            {
                PacketReceived = sec4_dr_01248_rw[0].ToString();
                PacketsSent = sec4_dr_01248_rw[1].ToString();
                PacketsError = sec4_dr_01248_rw[2].ToString();
            }


            DataTable dt1 = new DataTable();
            dt1.Columns.Add("DataInfo");
            dt1.Columns.Add("DataValue");
            DataRow dr_dt10 = dt1.NewRow();
            dr_dt10[0] = "CpuBusy";
            dr_dt10[1] = cpuBusy;
            dt1.Rows.Add(dr_dt10);
            DataRow dr_dt11 = dt1.NewRow();
            dr_dt11[0] = "IOBusy";
            dr_dt11[1] = ioBusy;
            dt1.Rows.Add(dr_dt11);
            DataRow dr_dt21 = dt1.NewRow();
            dr_dt21[0] = "Idle";
            dr_dt21[1] = Idle;
            dt1.Rows.Add(dr_dt21);
            sec2_dr_01248_dv.DataSource = dbO.GetServerDetails2();




            int PacketReceivedVal = PacketReceived.IndexOf("(");
            int PacketReceived1 = Convert.ToInt32(PacketReceived.Substring(0, PacketReceivedVal));
            int PacketsSentVal = PacketsSent.IndexOf("(");
            int PacketsSent1 = Convert.ToInt32(PacketsSent.Substring(0, PacketsSentVal));
            int PacketsErrorVal = PacketsError.IndexOf("(");
            int PacketsError1 = Convert.ToInt32(PacketsError.Substring(0, PacketsErrorVal));

            double[] yValues1 = { PacketReceived1, PacketsSent1, PacketsError1 };
            string[] xNames1 = { "Packet Received", "Packets Sent", "Packets Error" };

            ch1_Vis_valMa.Series[0].Points.DataBindXY(xNames1, yValues1);
            ch1_Vis_valMa.ChartAreas[0].Area3DStyle.Enable3D = true; 
        }

        private void ch2_Vis_valMa98_Click(object sender, EventArgs e)
        {

        }
        private void SetSize()
        {
           
        }

        private void CreateGraph(ZedGraphControl zgc, int cpuBusy1, int ioBusy1, int Idle1)
        {
            GraphPane myPane = zgc.GraphPane;

            myPane.Title.Text = "My Test Graph";
            myPane.XAxis.Title.Text = "X Value";
            myPane.YAxis.Title.Text = "My Y Axis";

            PointPairList list = new PointPairList();

            list.Add(1, cpuBusy1);
            list.Add(2, ioBusy1);
            list.Add(3, Idle1);
            

            LineItem myCurve = myPane.AddCurve("My Curve", list, Color.Blue,
                                   SymbolType.Circle);
            myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            myCurve.Symbol.Fill = new Fill(Color.White);

            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);

            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            zgc.AxisChange();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServerLevelDataInformation SLDI = new ServerLevelDataInformation();
            SLDI.Show(); this.Hide();
            
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSize();

            ch2_Vis_valMa98.Visible = true;

            string cpuBusy = null, ioBusy = null, Idle = null;
            foreach (DataRow sec4_dr_01248_rw in dbO.GetServerDetails1().Rows)
            {
                cpuBusy = sec4_dr_01248_rw[0].ToString();
                ioBusy = sec4_dr_01248_rw[1].ToString();
                Idle = sec4_dr_01248_rw[2].ToString();

            }
            DataTable sec4_UDet_01248_tb = new DataTable();
            sec4_UDet_01248_tb.Columns.Add("DataInfo");
            sec4_UDet_01248_tb.Columns.Add("DataValue");
            DataRow dr_dt = sec4_UDet_01248_tb.NewRow();
            dr_dt[0] = "CpuBusy";
            dr_dt[1] = cpuBusy;
            sec4_UDet_01248_tb.Rows.Add(dr_dt);
            DataRow dr_dt1 = sec4_UDet_01248_tb.NewRow();
            dr_dt1[0] = "IOBusy";
            dr_dt1[1] = ioBusy;
            sec4_UDet_01248_tb.Rows.Add(dr_dt1);
            DataRow dr_dt2 = sec4_UDet_01248_tb.NewRow();
            dr_dt2[0] = "Idle";
            dr_dt2[1] = Idle;
            sec4_UDet_01248_tb.Rows.Add(dr_dt2);
            sec1_dr_01248_dv.DataSource = sec4_UDet_01248_tb;
            int cpuBusyIndex = cpuBusy.IndexOf("(");
            int cpuBusy1 = Convert.ToInt32(cpuBusy.Substring(0, cpuBusyIndex));
            int ioBusyIndex = ioBusy.IndexOf("(");
            int ioBusy1 = Convert.ToInt32(ioBusy.Substring(0, ioBusyIndex));
            int IdleIndex = Idle.IndexOf("(");
            int Idle1 = Convert.ToInt32(Idle.Substring(0, IdleIndex));
            
            double[] yValues = { cpuBusy1, ioBusy1, Idle1 };
            string[] xNames = { "CPU Busy", "IO Busy", "Idle" };
            ch2_Vis_valMa98.Series[0].Points.DataBindXY(xNames, yValues);
            ch2_Vis_valMa98.ChartAreas[0].Area3DStyle.Enable3D = true;



        }
    }
}

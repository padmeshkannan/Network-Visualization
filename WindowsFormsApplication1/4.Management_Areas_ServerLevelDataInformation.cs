using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkVisualization_Visualization
{
    public partial class ServerLevelDataInformation : Form
    {
        public ServerLevelDataInformation()
        {
            InitializeComponent();
        }
        ObjectAccess.ConnectDB dbO = new ObjectAccess.ConnectDB();

        private void ServerLevelDataInformation_Load(object sender, EventArgs e)
        {
            sec3_dr_01248_dv.DataSource = dbO.GetServerDetails3();
            sec4_dr_01248_dv.DataSource = dbO.GetServerDetails();


            string TotalRead = null, TotalWrite = null, TotalError = null, Connections = null;
            foreach (DataRow sec4_dr_01248_rw in dbO.GetServerDetails3().Rows)
            {
                TotalRead = sec4_dr_01248_rw[0].ToString();
                TotalWrite = sec4_dr_01248_rw[1].ToString();
                TotalError = sec4_dr_01248_rw[2].ToString();
                Connections = sec4_dr_01248_rw[3].ToString();
            }

            int TotalReadVal = TotalRead.IndexOf("(");
            int TotalRead1 = Convert.ToInt32(TotalRead.Substring(0, TotalReadVal));
            int TotalWriteVal = TotalWrite.IndexOf("(");
            int TotalWrite1 = Convert.ToInt32(TotalWrite.Substring(0, TotalWriteVal));
            int TotalErrorVal = TotalError.IndexOf("(");
            int TotalError1 = Convert.ToInt32(TotalError.Substring(0, TotalErrorVal));
            int ConnectionsVal = Connections.IndexOf("(");
            int ConnectionsVal1 = Convert.ToInt32(Connections.Substring(0, ConnectionsVal));

            double[] yValues12 = { TotalRead1, TotalWrite1, TotalError1, ConnectionsVal1 };
            string[] xNames12 = { "Total Read", "Total Write", "Total Error", "Total Connections" };
            ch3_Vis_valMa98.Series[0].Points.DataBindXY(xNames12, yValues12);
            ch3_Vis_valMa98.ChartAreas[0].Area3DStyle.Enable3D = true;

            string Process_KernelTime_ms = null, Process_UserTime_ms = null;

            
          
                
            sec1_dr_01248_dv.DataSource = dbO.get_ServerProcessInformation();
            foreach (DataRow sec4_dr_01248_rw in dbO.get_ServerProcessInformation().Rows)
            {
                Process_KernelTime_ms = sec4_dr_01248_rw[0].ToString();
                Process_UserTime_ms = sec4_dr_01248_rw[1].ToString();
               
            }
            int Process_KernelTime_ms1 = Convert.ToInt32(Process_KernelTime_ms);
            int Process_UserTime_ms1 = Convert.ToInt32(Process_UserTime_ms);

                  
            DataTable dt123 = new DataTable();
            dt123.Columns.Add("Type of Operation");
            dt123.Columns.Add("Milli Second");
            DataRow dr123 = dt123.NewRow();
            dr123[0] = "process_kernel_time_ms";
            dr123[1] =     Process_KernelTime_ms1.ToString();
             DataRow dr1234 = dt123.NewRow();
              dr1234[0] = "process_user_time_ms";
            dr1234[1] =     Process_UserTime_ms1.ToString();
           dt123.Rows.Add(dr123);
             dt123.Rows.Add(dr1234);
             sec1_dr_01248_dv.DataSource = dt123;


            double[] yValues121 = { Process_KernelTime_ms1, Process_UserTime_ms1 };
            string[] xNames121 = { "Process Kernel Mind in M Sec", "Process User Time in M Sec" };
            ch1_Vis_valMa.Series[0].Points.DataBindXY(xNames121,yValues121 );
            ch1_Vis_valMa.ChartAreas[0].Area3DStyle.Enable3D = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadWriteStatus RWS = new ReadWriteStatus();
            RWS.Show(); this.Hide();
        }

        private void ch1_Vis_valMa_Click(object sender, EventArgs e)
        {

        }
    }
}

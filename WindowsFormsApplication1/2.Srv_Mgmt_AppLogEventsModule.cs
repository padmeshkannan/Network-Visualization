using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CiscoVisualizationValues;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkVisualization_Visualization
{
    public partial class AppLogEventsModule : Form
    {
        public AppLogEventsModule()
        {
            InitializeComponent();
        } SqlConnection conn;

        ObjectAccess.ConnectDB dbO = new ObjectAccess.ConnectDB();
        CiscoVisualizationValues.CiscoVisualizationValues CiscoVisualizationValues = new CiscoVisualizationValues.CiscoVisualizationValues();


            public void OpenDB()
        {
            conn = new SqlConnection(@"Data Source=TEST-PC\PADMESH;Integrated Security=true;Initial Catalog=NetworkVisualization");
            //(ConfigurationManager.AppSettings["DBConnection"].ToString());          
            conn.Open();
        }

        private void AppLogEventsModule_Load(object sender, EventArgs e)
        { 
            ///////////////////////////////////////////////////

            DataSet ds3 = dbO.GetErrorInfo();
            view_disp3_dg.DataSource = ds3.Tables[2];
            chart3.Visible = true;
            string countInfo31 = null, Authentication = null;
            double[] yValues3 = new double[10]; int i11 = 0; string[] xNames3 = new string[10];
            foreach (DataRow dr in GetErrorInfo().Tables[2].Rows)
            {
                countInfo31 = dr[0].ToString();
                int countInfo4 = Convert.ToInt32(countInfo31);
                yValues3[i11] = countInfo4;

                Authentication = dr[CiscoVisualizationValues.CiscoInformationValue()].ToString();
                xNames3[i11] = Authentication;
                i11++;
            }
            chart3.Series[0].Points.DataBindXY(xNames3, yValues3);
            chart3.ChartAreas[0].Area3DStyle.Enable3D = true;
            ///////////////////////////////////////////////////

            DataSet ds4 = dbO.GetErrorInfo();
            view_disp4_dg.DataSource = ds4.Tables[3];
            chart4.Visible = true;
            string countInfo41 = null, Protocol = null;
            double[] yValues4 = new double[10]; int i14 = 0; string[] xNames4 = new string[10];
            foreach (DataRow dr in GetErrorInfo().Tables[3].Rows)
            {
                countInfo41 = dr[0].ToString();
                int countInfo4 = Convert.ToInt32(countInfo41);
                yValues4[i14] = countInfo4;

                Protocol = dr[CiscoVisualizationValues.CiscoInformationValue()].ToString();
                xNames4[i14] = Protocol;
                i14++;
            }
            chart4.Series[0].Points.DataBindXY(xNames4, yValues4);
            chart4.ChartAreas[0].Area3DStyle.Enable3D = true;
            /////////////////////////////////////

        }
        public DataSet
              GetErrorInfo()
        {
            OpenDB();

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("GetErrorInfo1", conn);

            cmd.CommandType = CommandType.StoredProcedure;


            adapter.SelectCommand = cmd;

            adapter.Fill(ds);
            conn.Close();

            return (ds);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServerLevelInformation sli = new ServerLevelInformation();
            sli.Show(); this.Hide();
        }
    }
}

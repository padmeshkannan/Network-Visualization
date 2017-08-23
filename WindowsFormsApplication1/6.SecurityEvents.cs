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
    public partial class UserContextValue : Form
    {
        public UserContextValue()
        {
            InitializeComponent();
        }
        CiscoVisualizationValues.CiscoVisualizationValues CiscoVisualizationValues = new CiscoVisualizationValues.CiscoVisualizationValues();

        ObjectAccess.ConnectDB dbO = new ObjectAccess.ConnectDB();
        private void UserContextValue_Load(object sender, EventArgs e)
        {
            DataSet ds1 = dbO.getusercontexts()
;
            sec2_dr_01248_dv.DataSource = ds1.Tables[1];

            ch1_Vis_valMa.Visible = true;
            string C_Inf_cisco_UVal = null, Permission = null;
            double[] yValues = new double[25]; int i = 0; string[] xNames = new string[25];
            foreach (DataRow sec4_dr_01248_rw in dbO.getusercontexts().Tables[1].Rows)
            {
                C_Inf_cisco_UVal = sec4_dr_01248_rw[0].ToString();
                int C_Inf_cisco_UVal1 = Convert.ToInt32(C_Inf_cisco_UVal);
                yValues[i] = C_Inf_cisco_UVal1;

                Permission = sec4_dr_01248_rw[CiscoVisualizationValues.CiscoInformationValue()].ToString();
                xNames[i] = Permission;
                i++;

            }
            ch1_Vis_valMa.Series[0].Points.DataBindXY(xNames, yValues);
            ch1_Vis_valMa.ChartAreas[0].Area3DStyle.Enable3D = true;
           


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = dbO.getusercontexts()
;
            sec2_dr_01248_dv.DataSource = ds1.Tables[1];

            DataTable dtval = new DataTable();
            DataColumn sec4_UDet_01248_tb = new DataColumn("cnt");
            DataColumn dt1 = new DataColumn("Permission");
            dtval.Columns.Add(sec4_UDet_01248_tb);
            dtval.Columns.Add(dt1);

            string val = comboBox1.SelectedItem.ToString();
            int index = 0;
            foreach (DataRow sec4_dr_01248_rw in ds1.Tables[1].Rows)
            {
                index = sec4_dr_01248_rw[1].ToString().IndexOf(val);

                if (index>0)
                {

                    DataRow dr1 = dtval.NewRow();
                    dtval.Rows.Add(dr1);
                }
            }

            sec2_dr_01248_dv.DataSource = dtval;

        }
    }
}

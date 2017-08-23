using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CiscoVisualizationValues;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkVisualization_Visualization
{
    public partial class UserContexts : Form
    {
        public UserContexts()
        {
            InitializeComponent();
        }
        ObjectAccess.ConnectDB dbO = new ObjectAccess.ConnectDB();
        CiscoVisualizationValues.CiscoVisualizationValues CiscoVisualizationValues = new CiscoVisualizationValues.CiscoVisualizationValues();

        private void UserContexts_Load(object sender, EventArgs e)
        {
            
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppLogEventsModule app = new AppLogEventsModule();
            app.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

       
        
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = progressBar1.Value + 1;
                //label3.Visible = true;
                //label3.Text = "Please Wait While we are checking Authentication...";

                if (progressBar1.Value == progressBar1.Maximum / 10)
                {

                    DataSet ds = dbO.getusercontexts()
;
                    view_disp1_dg.DataSource = ds.Tables[0];
                    /////////////////////////

                }
                 
                
                if (progressBar1.Value == progressBar1.Maximum / 6)
                {

                    /////////////////////////
                    DataSet ds2 = dbO.getusercontexts()
        ;
                    view_disp3_dg.DataSource = ds2.Tables[2];
           
                }
                if (progressBar1.Value == progressBar1.Maximum / 3)
                {

                    //////////////////////////
                    DataSet ds3 = dbO.getusercontexts()
        ;
                    view_disp4_dg.DataSource = ds3.Tables[3];
            

                }
                if (progressBar1.Value == progressBar1.Maximum / 2)
                {

                    //////////////////////////
                    DataSet ds4 = dbO.getusercontexts()
        ;
                    view_disp5_dg.DataSource = ds4.Tables[6];
                    //////////////////////////

                }
                if (progressBar1.Value == progressBar1.Maximum)
                {

                    DataSet ds5 = dbO.getusercontexts()
;
                    view_disp6_dg.DataSource = ds5.Tables[7];
                    //////////////////////////

                }
            }
            catch (Exception ex) { }
        }
    }
}

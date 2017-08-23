using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace InputApplication
{
    public partial class InputApplication : Form
    {
        public InputApplication()
        {
            InitializeComponent();
        }
            
        SqlConnection conn,conn1;

        private string sqlpri;
        public string sql
        {
            get
            {
                return sqlpri;
            }
            set
            {
                sqlpri = value;
            }
        }
      
        public void OpenDB()
        {
            conn = new SqlConnection(@"Data Source=KAASHIV-PC\VENKAT;Integrated Security=true;Initial Catalog=NetworkVisualization");
            //(ConfigurationManager.AppSettings["DBConnection"].ToString());          
            conn.Open();
            conn1 = new SqlConnection(@"Data Source=KAASHIV-PC\VENKAT;Integrated Security=true;Initial Catalog=master");
            //(ConfigurationManager.AppSettings["DBConnection"].ToString());          
            conn1.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {

                
            OpenDB();


            string strCmd = "update  CoLocationTable set geoval=null";


            SqlCommand cmd1 = new SqlCommand(strCmd, conn);
            int i = 0;
            i = cmd1.ExecuteNonQuery();


            DataSet ds_1 = new DataSet();
            SqlDataAdapter adapter_1 = new SqlDataAdapter();
            SqlCommand cmd_1 = new SqlCommand("select ID,latitude,longitude from CoLocationTable", conn);

            cmd_1.CommandType = CommandType.Text;


            adapter_1.SelectCommand = cmd_1;

            adapter_1.Fill(ds_1);

            foreach (DataRow dr in ds_1.Tables[0].Rows)
            {


                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("distance_CalculateInputPlace", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@latitude", SqlDbType.Float));
                cmd.Parameters.Add(new SqlParameter("@longitude", SqlDbType.Float));
                cmd.Parameters[0].Value = Convert.ToInt32( dr[0].ToString());
                cmd.Parameters[1].Value = float.Parse(dr[1].ToString(), CultureInfo.InvariantCulture.NumberFormat);
                cmd.Parameters[2].Value = float.Parse(dr[2].ToString(), CultureInfo.InvariantCulture.NumberFormat);

                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();


                Application.DoEvents();
                
            }
            conn.Close();

           
        }
    }
}

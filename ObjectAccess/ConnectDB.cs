using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ObjectAccess
{
    public class ConnectDB
    {
        SqlConnection sec4_on_01248_cn;

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
      
        public void sec4_on_01248_db()
        {
            sec4_on_01248_cn = new SqlConnection(@"Data Source=TEST-PC\PADMESH;Integrated Security=true;Initial Catalog=NetworkVisualization");
            //(ConfigurationManager.AppSettings["DBConnection"].ToString());          
            sec4_on_01248_cn.Open();
        }
         ProcessVisualizeLibrary.ProcessVisualizeLibrary VisulizeLibrary = new ProcessVisualizeLibrary.ProcessVisualizeLibrary();

         public DataTable
                  SysAdminDetails()
         {
             sec4_on_01248_db();

             DataSet sec4_UDet_01248_se = new DataSet();
             SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
             SqlCommand sec4_dap_01248_cd = new SqlCommand("SysAdmin_proc", sec4_on_01248_cn);

             sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;


             sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

             sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
             sec4_on_01248_cn.Close();

             return (sec4_UDet_01248_se.Tables[0]);
         }


         public DataTable
                   getApppagesinfo()
         {
             sec4_on_01248_db();

             DataSet sec4_UDet_01248_se = new DataSet();
             SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
             SqlCommand sec4_dap_01248_cd = new SqlCommand("getApppagesinfo", sec4_on_01248_cn);

             sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;


             sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

             sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
             sec4_on_01248_cn.Close();

             return (sec4_UDet_01248_se.Tables[0]);
         }


         public DataSet
              getusercontexts()
         {
             sec4_on_01248_db();

             DataSet sec4_UDet_01248_se = new DataSet();
             SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
             SqlCommand sec4_dap_01248_cd = new SqlCommand("getusercontexts", sec4_on_01248_cn);

             sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;


             sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

             sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
             sec4_on_01248_cn.Close();

             return (sec4_UDet_01248_se);
         }


         public DataTable
                 GetUserDetails()
         {
             sec4_on_01248_db();

             DataSet sec4_UDet_01248_se = new DataSet();
             SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
             SqlCommand sec4_dap_01248_cd = new SqlCommand("SystemBasedUser_proc", sec4_on_01248_cn);

             sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;
             sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

             sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
             sec4_on_01248_cn.Close();

             return (sec4_UDet_01248_se.Tables[0]);
         }


        public int VerifyCredentials(string usrName, string pwd)
        {
            sec4_on_01248_db();

            DataSet sec4_UDet_01248_se = new DataSet();
            SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
            SqlCommand sec4_dap_01248_cd = new SqlCommand("sp_VerifyCredentials", sec4_on_01248_cn);

            sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;
            sec4_dap_01248_cd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 50));
            sec4_dap_01248_cd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
            sec4_dap_01248_cd.Parameters[0].Value = usrName;
            sec4_dap_01248_cd.Parameters[1].Value = pwd;

            sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

            sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
            sec4_on_01248_cn.Close();

            return ((int)sec4_UDet_01248_se.Tables[0].Rows[0][0]);
        }

        public DataSet
             GetErrorInfo()
        {
            sec4_on_01248_db();

            DataSet sec4_UDet_01248_se = new DataSet();
            SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
            SqlCommand sec4_dap_01248_cd = new SqlCommand("GetErrorInfo1", sec4_on_01248_cn);

            sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;


            sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

            sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
            sec4_on_01248_cn.Close();

            return (sec4_UDet_01248_se);
        }

        public int AddNewUser(string strFName, string strLName,
          string Mobile,
           string UName, string Pwd,
             string SecurityQue, string SecurityAns,
           string City)
        {
            sec4_on_01248_db();
            string strCmd = "insert into [tblUserDetails] ([FirstName], [LastName],mobile,Username,Password,City,[SecurityQuestion],[SecurityAnswer]) values ('" + strFName + "','" + strLName + "','" + Mobile + "','" + UName + "','" + Pwd + "','" + SecurityQue + "','" + SecurityAns + "','" + City + "')";


            SqlCommand sec4_dap_01248_cd = new SqlCommand(strCmd, sec4_on_01248_cn);
            int i = 0;
            i = sec4_dap_01248_cd.ExecuteNonQuery();
            sec4_on_01248_cn.Close();
            return i;
        }
 
        
           public DataTable
                  GetServerDetails()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               SqlCommand sec4_dap_01248_cd = new SqlCommand(VisulizeLibrary.ServerMonitorClass(), sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;
               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se.Tables[0]);
           }
           public DataTable
                    GetVMDiskSpace()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               SqlCommand sec4_dap_01248_cd = new SqlCommand("VM_DiskSpace", sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;
               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se.Tables[0]);
           }
           public DataTable
                 GetServerDetails1()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               string val = VisulizeLibrary.ServerMonitorClass();
               SqlCommand sec4_dap_01248_cd = new SqlCommand(VisulizeLibrary.ServerMonitorClass(), sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;


               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se.Tables[1]);
           }

           public DataTable
                 GetServerDetails2()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               SqlCommand sec4_dap_01248_cd = new SqlCommand(VisulizeLibrary.ServerMonitorClass(), sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure; 
               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se.Tables[2]);
           }

           public DataTable
                 GetServerDetails3()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               SqlCommand sec4_dap_01248_cd = new SqlCommand(VisulizeLibrary.ServerMonitorClass(), sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure; 
               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se.Tables[3]);
           }
           public DataSet
                  GetNetworkTraceUtility1()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               SqlCommand sec4_dap_01248_cd = new SqlCommand("GetServerNetworkTrace", sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure;


               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se );
           }

           public DataTable
                    get_SystemInformation()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               SqlCommand sec4_dap_01248_cd = new SqlCommand("select     cpu_count,    hyperthread_ratio,    physical_memory_in_bytes / 1048576 as 'mem_MB',    virtual_memory_in_bytes / 1048576 as 'virtual_mem_MB',    max_workers_count,    os_error_mode,    os_priority_class, scheduler_count,max_workers_count  from     sys.dm_os_sys_info ", sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.Text;


               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se).Tables[0];
           }
           public DataTable
                     get_SystemGeneralInformation()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               SqlCommand sec4_dap_01248_cd = new SqlCommand("select serverproperty('MachineName') MachineName,serverproperty('ServerName') ServerInstanceName,replace(cast(serverproperty('Edition')as varchar),'Edition','') EditionInstalled,serverproperty('productVersion') ProductBuildLevel,serverproperty('productLevel') SPLevel,serverproperty('Collation') Collation_Type,serverproperty('IsClustered') [IsClustered?],convert(varchar,getdate(),102) QueryDate  ", sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.Text; 
               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd;

               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se).Tables[0];
           }
       
             public DataTable
                     get_ServerProcessInformation()
           {
               sec4_on_01248_db();

               DataSet sec4_UDet_01248_se = new DataSet();
               SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
               SqlCommand sec4_dap_01248_cd = new SqlCommand(" select    process_kernel_time_ms,process_user_time_ms  from     sys.dm_os_sys_info ",sec4_on_01248_cn);

               sec4_dap_01248_cd.CommandType = CommandType.Text; 
               sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd; 
               sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
               sec4_on_01248_cn.Close();

               return (sec4_UDet_01248_se).Tables[0];
           }
             public DataTable
                       get_ReadAndWriteLatency()
             {
                 sec4_on_01248_db();

                 DataSet sec4_UDet_01248_se = new DataSet();
                 SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
                 SqlCommand sec4_dap_01248_cd = new SqlCommand("ReadAndWriteLatency ", sec4_on_01248_cn); 
                 sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure; 
                 sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd; 
                 sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
                 sec4_on_01248_cn.Close();

                 return (sec4_UDet_01248_se).Tables[0];
             }
         public DataTable
                       DBTrackMaintenanceCheck()
             {
                 sec4_on_01248_db();

                 DataSet sec4_UDet_01248_se = new DataSet();
                 SqlDataAdapter sec4_dap_01248_ar = new SqlDataAdapter();
                 SqlCommand sec4_dap_01248_cd = new SqlCommand("DBTrackMaintenanceCheck ", sec4_on_01248_cn); 
                 sec4_dap_01248_cd.CommandType = CommandType.StoredProcedure; 
                 sec4_dap_01248_ar.SelectCommand = sec4_dap_01248_cd; 
                 sec4_dap_01248_ar.Fill(sec4_UDet_01248_se);
                 sec4_on_01248_cn.Close();

                 return (sec4_UDet_01248_se).Tables[0];
             }
        

    }
}

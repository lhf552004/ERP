using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ERP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string computerName = System.Net.Dns.GetHostName();
                SearchStr.connectingstring = "Data Source=" + computerName + "\\SQLEXPRESS;Initial Catalog=ERPDatabase;Integrated Security=True";
                SqlConnection connt = new SqlConnection(SearchStr.connectingstring);
                if (connt.State == ConnectionState.Closed) { connt.Open(); }

                string sql = "SELECT Count(*) FROM [ERPDatabase].[dbo].[User] where Level >6";
                SqlCommand cmd = new SqlCommand(sql, connt);
                object o = cmd.ExecuteScalar();
                int i = int.Parse(o.ToString());
                if (i == 0)
                {
                    string sup = "insert into [ERPDatabase].[dbo].[User] ([Ident],[Name],[Description],[Level],[Department],[password],[ModifyUser]) values('Super','Super','This is super user',255,'Su','ntmaster','Super')";
                    SqlCommand cmdupdate = new SqlCommand(sup, connt);
                    cmdupdate.ExecuteNonQuery();
                }
                string users = "select Name from [ERPDatabase].[dbo].[User]";
                SqlCommand cmddd = new SqlCommand(users, connt);
                SqlDataReader readdd = cmddd.ExecuteReader();
                while (readdd.Read())
                {
                    SearchStr.users.Add(readdd[0].ToString().Trim());

                }
                readdd.Close();
            }
            catch (SqlException e)
            {

                throw e;
            }
            
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new Login());
        }
    }
}

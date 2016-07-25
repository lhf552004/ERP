using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.SqlClient;

namespace ERP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string name = "";

        private void Login_Load(object sender, EventArgs e)
        {
            foreach (string theName in SearchStr.users )
            {

                NamecomboBox.Items.Add(theName);
            }

            
            


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {



            if (keyData == Keys.Escape)
            {
                this.Close();
                return false;
            } if (keyData == Keys.Enter)
            {



                _login();
            }

            return false;
        }



        private bool _login()
        {
            try
            {
                SqlConnection connt = new SqlConnection(SearchStr.connectingstring);
                if (connt.State == ConnectionState.Closed)
                {
                    connt.Open();
                }

                string sql = "select count(*) from [ERPDatabase].[dbo].[User] where Name ='" + NamecomboBox.SelectedItem.ToString() + "'and password='" + PasswordtextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connt);
                int k = int.Parse(cmd.ExecuteScalar().ToString());
                if (k == 1)
                {
                    SearchStr.CurrentUser = NamecomboBox.SelectedItem.ToString();
                    
                    this.Visible = false;
                    ERP.MainWinForm mad = new MainWinForm();
                    mad.ShowDialog();
                    this.Close();
                   
                    //RMS.Main mad = new Main();
                    //mad.ShowDialog();
                }
                else
                {
                    label2.Text = "用户名或密码输入错误,请重新输入";
                }
                if (connt.State == ConnectionState.Open)
                {
                    connt.Close();
                }
                return true;

            }
            catch (Exception e)
            {
                throw e;
            }
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _login();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

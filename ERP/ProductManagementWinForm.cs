using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ERP
{
    public partial class ProductManagementWinForm : Form
    {
        public ProductManagementWinForm()
        {
            InitializeComponent();
        }

        private void ProductManagementWinForm_Load(object sender, EventArgs e)
        {
            _loadData();
            _updateControlText(0);
        }
        private SqlConnection connt = new SqlConnection(SearchStr.connectingstring);
        private SqlDataAdapter sad;
        private DataSet ds;
        private void _loadData()
        {
            try
            {
                if (connt.State == ConnectionState.Closed) { connt.Open(); }
                string sql = "select Ident as 代码,Name as 名称,Category as 种类,Price as 价格 from Product group by Name,Ident,Category,Price order by Price";
                sad = new SqlDataAdapter(sql, connt);
                ds = new DataSet();
                sad.Fill(ds, "sel");
                ProductGridView.DataSource = ds.Tables["sel"];
            }
            catch (Exception err)
            {
                throw err;
            }
            

 
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            string theIdent = "";
            string theName = "";
            byte theCategory =0;
            
            string sel = "";

            try
            {
                if (DialogWinForm.ShowDialogWinForm(ref theIdent,ref theName,ref theCategory) == true)
                {
                    if (connt.State == ConnectionState.Closed) { connt.Open(); }
                    sel = "select count(*) from [ERPDatabase].[dbo].[Product] where [Ident] = '" + theIdent + "'";
                    SqlCommand cmd = new SqlCommand(sel, connt);
                    int theNum = int.Parse(cmd.ExecuteScalar().ToString());
                    if (theNum > 0)
                    {
                        throw new Exception("物料代码已存在!");
                    }
                    else
                    {
                        sel = "insert into [ERPDatabase].[dbo].[Product] ([Ident],[Name],[Category],[Price],[ModifyUser],[CreationDate]) values('" + theIdent + "','" + theName + "'," + theCategory +",0,'" + SearchStr.CurrentUser +"','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        SqlCommand insertCmd = new SqlCommand(sel, connt);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException err)
            {
                throw err;
            }
            catch (Exception err2)
            {
                throw err2;
            }

            _loadData();
        }

        private void ProductGridView_SelectionChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// get all field from the database
        /// </summary>
        /// <param name="theIdent"></param>
        /// <returns></returns>
        private DataRow _getCurrentRow(string theIdent)
        {
            try
            {
                string sql = "select [Ident],[Name],[Category],[Price],[Description],[ModifyUser],[CreationDate],[ModifyDate] from [ERPDatabase].[dbo].[Product] Where [Ident] = '" + theIdent + "'";
                sad = new SqlDataAdapter(sql, connt);
                ds = new DataSet();
                sad.Fill(ds, "sel");
                currentTable = ds.Tables["sel"];
                if (currentTable != null)
                {
                    return currentTable.Rows[0];
                }
                else
                {
                    return null;
                }

            }
            catch (SqlException e)
            {

                throw e;
            }
            
        }
        private DataTable currentTable;
        private DataGridViewRow currentGridViewRow;

        private void _updateControlText(int theIndex)
        {
            try
            {
                currentGridViewRow = (DataGridViewRow)ProductGridView.Rows[theIndex];
                if (currentGridViewRow == null)
                {
                    throw new Exception("the row is null");

                }
                else
                {
                    //get the data from the gridview directly
                    ProdIdent.Text = currentGridViewRow.Cells[0].Value.ToString();
                    ProdName.Text = currentGridViewRow.Cells[1].Value.ToString();
                    ProdCategory.Text = Enum.GetName(typeof(ProductCategory), int.Parse(currentGridViewRow.Cells[2].Value.ToString()));
                    ProdPrice.Text = currentGridViewRow.Cells[3].Value.ToString();
                    // update other control
                    DataRow currentRow = _getCurrentRow(ProdIdent.Text);
                    ProdDescription.Text = currentRow[4].ToString();
                    ModifyUser.Text = currentRow[5].ToString();
                    CreationDate.Text = currentRow[6].ToString();
                    ModifyDate.Text = currentRow[7].ToString();

                }
            }
            catch (SqlException e)
            {
                throw e;
            }

            
           
            
        }
        private int currentIndex; 
        private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            _updateControlText(e.RowIndex);
            //currentGridViewRow = (DataGridViewRow)ProductGridView.Rows[e.RowIndex];
            
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (connt.State == ConnectionState.Closed) { connt.Open(); }

            string sel = "insert into [ERPDatabase].[dbo].[Product] ([Ident],[Name],[Category],[Price],[ModifyUser],[CreationDate]) values('" + ProdIdent.Text.Trim() + "-1','" + ProdName.Text.Trim() + "'," + (byte)(ProductCategory)Enum.Parse(typeof(ProductCategory),ProdCategory.Text) + ",0,'" + SearchStr.CurrentUser + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            SqlCommand insertCmd = new SqlCommand(sel, connt);
            insertCmd.ExecuteNonQuery();
            _loadData();
            _updateControlText(currentIndex);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }
       
    }
}

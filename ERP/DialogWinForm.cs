using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP;

namespace ERP
{
    public partial class DialogWinForm : Form
    {
        public DialogWinForm()
        {
            InitializeComponent();
        }
        public static bool ShowDialogWinForm(ref string theIdent,ref string theName,ref byte theCategory)
        {
            DialogWinForm theForm = new DialogWinForm();
            theForm.ShowDialog();

            bool theResult = false;
            if (theForm.DialogResult == DialogResult.OK)
            {
                theIdent = theForm.ProdIdent.Text;
                theName = theForm.ProdName.Text;
                theCategory = (byte)(ProductCategory)Enum.Parse(typeof(ProductCategory), theForm.ProdCategory.Text);
                theResult= true;
            }
            else if (theForm.DialogResult == DialogResult.Cancel)
            {
                
            }
            theForm.Close();
            return theResult;

        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }

        private void _setEnableOfConfirmButton(object sender,EventArgs e)
        {
            if (this.ProdIdent.Text.Trim() != "" && this.ProdName.Text.Trim() != "" && this.ProdCategory.Text.Trim() != "")
            {
                this.ConfirmButton.Enabled = true;
            }
            else
            {
                this.ConfirmButton.Enabled = false ;
 
            }
 
        }
       

        private void DialogWinForm_Load(object sender, EventArgs e)
        {
            foreach(string temp in Enum.GetNames(typeof(ProductCategory)))
            {
                ProdCategory.Items.Add(temp);
            }
            // to do for the product category
            ProdCategory.Text = Enum.GetName(typeof(ProductCategory), ProductCategory.Undefined);

            this.ProdIdent.TextChanged += new System.EventHandler(this._setEnableOfConfirmButton);
            this.ProdName.TextChanged += new System.EventHandler(this._setEnableOfConfirmButton);
            this.ProdCategory.TextChanged += new System.EventHandler(this._setEnableOfConfirmButton);
        }








        internal static bool ShowDialogWinForm(string theIdent, string theName, ProductCategory theCategory)
        {
            throw new NotImplementedException();
        }
    }
}

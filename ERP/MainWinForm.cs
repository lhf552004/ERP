using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class MainWinForm : Form
    {
        public MainWinForm()
        {
            InitializeComponent();
        }

        private void ProductManagement_Click(object sender, EventArgs e)
        {
            ProductManagementWinForm proWF = new ProductManagementWinForm();
            proWF.ShowDialog();
            
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            ExitConfirmWinForm exitform = new ExitConfirmWinForm();
            exitform.ShowDialog();
        }

        private void MainWinForm_Load(object sender, EventArgs e)
        {
            int theX = UserNamelabel.Location.X;
            int theY = this.Location.Y -UserNamelabel.Width;

            UserNamelabel.Location = new Point(theX,theY);
            UserNamelabel.Text = SearchStr.CurrentUser;
        }

   
       
    }
}

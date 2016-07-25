namespace ERP
{
    partial class MainWinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductHandling = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.StockStatic = new System.Windows.Forms.ToolStripMenuItem();
            this.Receipt = new System.Windows.Forms.ToolStripMenuItem();
            this.Dispatch = new System.Windows.Forms.ToolStripMenuItem();
            this.Agent = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductHandling,
            this.StockStatic,
            this.Receipt,
            this.Dispatch,
            this.Agent,
            this.Admin,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProductHandling
            // 
            this.ProductHandling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductManagement});
            this.ProductHandling.Name = "ProductHandling";
            this.ProductHandling.Size = new System.Drawing.Size(67, 20);
            this.ProductHandling.Text = "物料处理";
            // 
            // ProductManagement
            // 
            this.ProductManagement.Name = "ProductManagement";
            this.ProductManagement.Size = new System.Drawing.Size(122, 22);
            this.ProductManagement.Text = "物料管理";
            this.ProductManagement.Click += new System.EventHandler(this.ProductManagement_Click);
            // 
            // StockStatic
            // 
            this.StockStatic.Name = "StockStatic";
            this.StockStatic.Size = new System.Drawing.Size(67, 20);
            this.StockStatic.Text = "库存统计";
            // 
            // Receipt
            // 
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(43, 20);
            this.Receipt.Text = "收货";
            // 
            // Dispatch
            // 
            this.Dispatch.Name = "Dispatch";
            this.Dispatch.Size = new System.Drawing.Size(43, 20);
            this.Dispatch.Text = "发货";
            // 
            // Agent
            // 
            this.Agent.Name = "Agent";
            this.Agent.Size = new System.Drawing.Size(55, 20);
            this.Agent.Text = "代理商";
            // 
            // Admin
            // 
            this.Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserManagementMenuItem,
            this.LoginMenuItem,
            this.LogoutMenuItem,
            this.ExitMenuItem});
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(43, 20);
            this.Admin.Text = "管理";
            // 
            // UserManagementMenuItem
            // 
            this.UserManagementMenuItem.Name = "UserManagementMenuItem";
            this.UserManagementMenuItem.Size = new System.Drawing.Size(122, 22);
            this.UserManagementMenuItem.Text = "用户管理";
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(122, 22);
            this.LoginMenuItem.Text = "登录";
            // 
            // LogoutMenuItem
            // 
            this.LogoutMenuItem.Name = "LogoutMenuItem";
            this.LogoutMenuItem.Size = new System.Drawing.Size(122, 22);
            this.LogoutMenuItem.Text = "注销";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(549, 11);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(0, 12);
            this.UserNamelabel.TabIndex = 2;
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(43, 20);
            this.HelpMenu.Text = "帮助";
            // 
            // MainWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 262);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWinForm";
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWinForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProductHandling;
        private System.Windows.Forms.ToolStripMenuItem ProductManagement;
        private System.Windows.Forms.ToolStripMenuItem Admin;
        private System.Windows.Forms.ToolStripMenuItem UserManagementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Receipt;
        private System.Windows.Forms.ToolStripMenuItem Dispatch;
        private System.Windows.Forms.ToolStripMenuItem StockStatic;
        private System.Windows.Forms.ToolStripMenuItem Agent;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
    }
}
namespace ERP
{
    partial class ProductManagementWinForm
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
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DetailPage = new System.Windows.Forms.TabPage();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.ProdCategory = new System.Windows.Forms.TextBox();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.ProdDescription = new System.Windows.Forms.TextBox();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdIdent = new System.Windows.Forms.TextBox();
            this.Identlabel = new System.Windows.Forms.Label();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModifyDate = new System.Windows.Forms.TextBox();
            this.ModifyDatelabel = new System.Windows.Forms.Label();
            this.ModifyUser = new System.Windows.Forms.TextBox();
            this.CreationDate = new System.Windows.Forms.TextBox();
            this.ModifyUserlabel = new System.Windows.Forms.Label();
            this.CreationDatelabel = new System.Windows.Forms.Label();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.ListgroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.DetailPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.HistoryPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ButtonGroupBox.SuspendLayout();
            this.ListgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(6, 19);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowTemplate.Height = 23;
            this.ProductGridView.Size = new System.Drawing.Size(396, 150);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellClick);
            this.ProductGridView.SelectionChanged += new System.EventHandler(this.ProductGridView_SelectionChanged);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(17, 20);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 35);
            this.NewButton.TabIndex = 1;
            this.NewButton.Text = "新建";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(17, 66);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 35);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "复制";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(17, 112);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 35);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DetailPage);
            this.tabControl1.Controls.Add(this.HistoryPage);
            this.tabControl1.Location = new System.Drawing.Point(10, 182);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 173);
            this.tabControl1.TabIndex = 4;
            // 
            // DetailPage
            // 
            this.DetailPage.Controls.Add(this.ModifyButton);
            this.DetailPage.Controls.Add(this.groupBox1);
            this.DetailPage.Location = new System.Drawing.Point(4, 22);
            this.DetailPage.Name = "DetailPage";
            this.DetailPage.Padding = new System.Windows.Forms.Padding(3);
            this.DetailPage.Size = new System.Drawing.Size(515, 147);
            this.DetailPage.TabIndex = 0;
            this.DetailPage.Text = "细节";
            this.DetailPage.UseVisualStyleBackColor = true;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(415, 11);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 35);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "修改";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProdPrice);
            this.groupBox1.Controls.Add(this.Pricelabel);
            this.groupBox1.Controls.Add(this.ProdCategory);
            this.groupBox1.Controls.Add(this.Categorylabel);
            this.groupBox1.Controls.Add(this.ProdDescription);
            this.groupBox1.Controls.Add(this.Descriptionlabel);
            this.groupBox1.Controls.Add(this.ProdName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProdIdent);
            this.groupBox1.Controls.Add(this.Identlabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常规";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Location = new System.Drawing.Point(264, 82);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(100, 21);
            this.ProdPrice.TabIndex = 9;
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(199, 87);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(29, 12);
            this.Pricelabel.TabIndex = 8;
            this.Pricelabel.Text = "价格";
            // 
            // ProdCategory
            // 
            this.ProdCategory.Location = new System.Drawing.Point(61, 82);
            this.ProdCategory.Name = "ProdCategory";
            this.ProdCategory.Size = new System.Drawing.Size(100, 21);
            this.ProdCategory.TabIndex = 7;
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(7, 87);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(29, 12);
            this.Categorylabel.TabIndex = 6;
            this.Categorylabel.Text = "种类";
            // 
            // ProdDescription
            // 
            this.ProdDescription.Location = new System.Drawing.Point(61, 49);
            this.ProdDescription.Multiline = true;
            this.ProdDescription.Name = "ProdDescription";
            this.ProdDescription.Size = new System.Drawing.Size(303, 21);
            this.ProdDescription.TabIndex = 5;
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Location = new System.Drawing.Point(7, 54);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(29, 12);
            this.Descriptionlabel.TabIndex = 4;
            this.Descriptionlabel.Text = "备注";
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(264, 16);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(100, 21);
            this.ProdName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "名称";
            // 
            // ProdIdent
            // 
            this.ProdIdent.Location = new System.Drawing.Point(61, 16);
            this.ProdIdent.Name = "ProdIdent";
            this.ProdIdent.Size = new System.Drawing.Size(100, 21);
            this.ProdIdent.TabIndex = 1;
            // 
            // Identlabel
            // 
            this.Identlabel.AutoSize = true;
            this.Identlabel.Location = new System.Drawing.Point(7, 21);
            this.Identlabel.Name = "Identlabel";
            this.Identlabel.Size = new System.Drawing.Size(29, 12);
            this.Identlabel.TabIndex = 0;
            this.Identlabel.Text = "代码";
            // 
            // HistoryPage
            // 
            this.HistoryPage.Controls.Add(this.groupBox2);
            this.HistoryPage.Location = new System.Drawing.Point(4, 22);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryPage.Size = new System.Drawing.Size(515, 147);
            this.HistoryPage.TabIndex = 1;
            this.HistoryPage.Text = "历史";
            this.HistoryPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModifyDate);
            this.groupBox2.Controls.Add(this.ModifyDatelabel);
            this.groupBox2.Controls.Add(this.ModifyUser);
            this.groupBox2.Controls.Add(this.CreationDate);
            this.groupBox2.Controls.Add(this.ModifyUserlabel);
            this.groupBox2.Controls.Add(this.CreationDatelabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "历史";
            // 
            // ModifyDate
            // 
            this.ModifyDate.Location = new System.Drawing.Point(361, 11);
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.Size = new System.Drawing.Size(100, 21);
            this.ModifyDate.TabIndex = 3;
            // 
            // ModifyDatelabel
            // 
            this.ModifyDatelabel.AutoSize = true;
            this.ModifyDatelabel.Location = new System.Drawing.Point(283, 20);
            this.ModifyDatelabel.Name = "ModifyDatelabel";
            this.ModifyDatelabel.Size = new System.Drawing.Size(53, 12);
            this.ModifyDatelabel.TabIndex = 2;
            this.ModifyDatelabel.Text = "修改日期";
            // 
            // ModifyUser
            // 
            this.ModifyUser.Location = new System.Drawing.Point(84, 45);
            this.ModifyUser.Name = "ModifyUser";
            this.ModifyUser.Size = new System.Drawing.Size(100, 21);
            this.ModifyUser.TabIndex = 1;
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(84, 11);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(100, 21);
            this.CreationDate.TabIndex = 1;
            // 
            // ModifyUserlabel
            // 
            this.ModifyUserlabel.AutoSize = true;
            this.ModifyUserlabel.Location = new System.Drawing.Point(6, 54);
            this.ModifyUserlabel.Name = "ModifyUserlabel";
            this.ModifyUserlabel.Size = new System.Drawing.Size(41, 12);
            this.ModifyUserlabel.TabIndex = 0;
            this.ModifyUserlabel.Text = "修改人";
            // 
            // CreationDatelabel
            // 
            this.CreationDatelabel.AutoSize = true;
            this.CreationDatelabel.Location = new System.Drawing.Point(6, 20);
            this.CreationDatelabel.Name = "CreationDatelabel";
            this.CreationDatelabel.Size = new System.Drawing.Size(53, 12);
            this.CreationDatelabel.TabIndex = 0;
            this.CreationDatelabel.Text = "创建日期";
            // 
            // ButtonGroupBox
            // 
            this.ButtonGroupBox.Controls.Add(this.NewButton);
            this.ButtonGroupBox.Controls.Add(this.DeleteButton);
            this.ButtonGroupBox.Controls.Add(this.CopyButton);
            this.ButtonGroupBox.Location = new System.Drawing.Point(408, 9);
            this.ButtonGroupBox.Name = "ButtonGroupBox";
            this.ButtonGroupBox.Size = new System.Drawing.Size(114, 159);
            this.ButtonGroupBox.TabIndex = 5;
            this.ButtonGroupBox.TabStop = false;
            // 
            // ListgroupBox
            // 
            this.ListgroupBox.Controls.Add(this.ProductGridView);
            this.ListgroupBox.Controls.Add(this.ButtonGroupBox);
            this.ListgroupBox.Location = new System.Drawing.Point(4, -3);
            this.ListgroupBox.Name = "ListgroupBox";
            this.ListgroupBox.Size = new System.Drawing.Size(529, 179);
            this.ListgroupBox.TabIndex = 6;
            this.ListgroupBox.TabStop = false;
            // 
            // ProductManagementWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 367);
            this.Controls.Add(this.ListgroupBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductManagementWinForm";
            this.Text = "物料管理";
            this.Load += new System.EventHandler(this.ProductManagementWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.DetailPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HistoryPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ButtonGroupBox.ResumeLayout(false);
            this.ListgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DetailPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.GroupBox ListgroupBox;
        private System.Windows.Forms.TextBox ProdDescription;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProdIdent;
        private System.Windows.Forms.Label Identlabel;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.TextBox ProdCategory;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.TabPage HistoryPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CreationDate;
        private System.Windows.Forms.Label CreationDatelabel;
        private System.Windows.Forms.TextBox ModifyDate;
        private System.Windows.Forms.Label ModifyDatelabel;
        private System.Windows.Forms.TextBox ModifyUser;
        private System.Windows.Forms.Label ModifyUserlabel;
        private System.Windows.Forms.Button ModifyButton;
    }
}
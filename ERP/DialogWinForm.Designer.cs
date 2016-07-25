namespace ERP
{
    partial class DialogWinForm
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
            this.Identlabel = new System.Windows.Forms.Label();
            this.ProdIdent = new System.Windows.Forms.TextBox();
            this.ProdCategory = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Namelabel = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Identlabel
            // 
            this.Identlabel.AutoSize = true;
            this.Identlabel.Location = new System.Drawing.Point(22, 15);
            this.Identlabel.Name = "Identlabel";
            this.Identlabel.Size = new System.Drawing.Size(29, 12);
            this.Identlabel.TabIndex = 0;
            this.Identlabel.Text = "代码";
            // 
            // ProdIdent
            // 
            this.ProdIdent.Location = new System.Drawing.Point(123, 15);
            this.ProdIdent.Name = "ProdIdent";
            this.ProdIdent.Size = new System.Drawing.Size(100, 21);
            this.ProdIdent.TabIndex = 1;
            // 
            // ProdCategory
            // 
            this.ProdCategory.Enabled = false;
            this.ProdCategory.FormattingEnabled = true;
            this.ProdCategory.Location = new System.Drawing.Point(123, 79);
            this.ProdCategory.Name = "ProdCategory";
            this.ProdCategory.Size = new System.Drawing.Size(100, 20);
            this.ProdCategory.TabIndex = 2;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Location = new System.Drawing.Point(12, 127);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 32);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(158, 127);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 32);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(22, 47);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(29, 12);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "名称";
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(123, 47);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(100, 21);
            this.ProdName.TabIndex = 1;
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(22, 79);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(29, 12);
            this.Categorylabel.TabIndex = 5;
            this.Categorylabel.Text = "种类";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Identlabel);
            this.groupBox1.Controls.Add(this.Categorylabel);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Controls.Add(this.ProdCategory);
            this.groupBox1.Controls.Add(this.ProdName);
            this.groupBox1.Controls.Add(this.ProdIdent);
            this.groupBox1.Location = new System.Drawing.Point(10, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // DialogWinForm
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 180);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogWinForm";
            this.Load += new System.EventHandler(this.DialogWinForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Identlabel;
        private System.Windows.Forms.TextBox ProdIdent;
        private System.Windows.Forms.ComboBox ProdCategory;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
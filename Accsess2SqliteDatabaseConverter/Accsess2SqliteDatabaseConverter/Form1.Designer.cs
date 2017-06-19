namespace Accsess2SqliteDatabaseConverter
{
    partial class Form1
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
            this.btn_select_acces = new System.Windows.Forms.Button();
            this.txtAccessPath = new System.Windows.Forms.TextBox();
            this.checkTableNames = new System.Windows.Forms.CheckedListBox();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_select_acces
            // 
            this.btn_select_acces.Location = new System.Drawing.Point(283, 10);
            this.btn_select_acces.Name = "btn_select_acces";
            this.btn_select_acces.Size = new System.Drawing.Size(136, 23);
            this.btn_select_acces.TabIndex = 0;
            this.btn_select_acces.Text = "select Access Db";
            this.btn_select_acces.UseVisualStyleBackColor = true;
            this.btn_select_acces.Click += new System.EventHandler(this.btn_select_acces_Click);
            // 
            // txtAccessPath
            // 
            this.txtAccessPath.Location = new System.Drawing.Point(13, 13);
            this.txtAccessPath.Name = "txtAccessPath";
            this.txtAccessPath.Size = new System.Drawing.Size(264, 20);
            this.txtAccessPath.TabIndex = 1;
            // 
            // checkTableNames
            // 
            this.checkTableNames.FormattingEnabled = true;
            this.checkTableNames.Location = new System.Drawing.Point(13, 69);
            this.checkTableNames.Name = "checkTableNames";
            this.checkTableNames.Size = new System.Drawing.Size(120, 184);
            this.checkTableNames.TabIndex = 2;
            this.checkTableNames.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkTableNames_ItemCheck);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(153, 39);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 3;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Un check all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(283, 56);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(136, 61);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(153, 159);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(70, 25);
            this.lblstatus.TabIndex = 6;
            this.lblstatus.Text = "status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "select tables to export";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.checkTableNames);
            this.Controls.Add(this.txtAccessPath);
            this.Controls.Add(this.btn_select_acces);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select_acces;
        private System.Windows.Forms.TextBox txtAccessPath;
        private System.Windows.Forms.CheckedListBox checkTableNames;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label label1;
    }
}


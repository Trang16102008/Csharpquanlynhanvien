namespace Csharpquanlynhanvien
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
            this.btnthem = new System.Windows.Forms.Button();
            this.lblquanlynhanvien = new System.Windows.Forms.Label();
            this.lbsten = new System.Windows.Forms.ListBox();
            this.lblnhaphovaten = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(514, 105);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblquanlynhanvien
            // 
            this.lblquanlynhanvien.AutoSize = true;
            this.lblquanlynhanvien.Location = new System.Drawing.Point(365, 27);
            this.lblquanlynhanvien.Name = "lblquanlynhanvien";
            this.lblquanlynhanvien.Size = new System.Drawing.Size(91, 13);
            this.lblquanlynhanvien.TabIndex = 1;
            this.lblquanlynhanvien.Text = "quản lý nhân viên";
            this.lblquanlynhanvien.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbsten
            // 
            this.lbsten.FormattingEnabled = true;
            this.lbsten.Location = new System.Drawing.Point(236, 261);
            this.lbsten.Name = "lbsten";
            this.lbsten.Size = new System.Drawing.Size(425, 147);
            this.lbsten.TabIndex = 2;
            // 
            // lblnhaphovaten
            // 
            this.lblnhaphovaten.AutoSize = true;
            this.lblnhaphovaten.Location = new System.Drawing.Point(288, 63);
            this.lblnhaphovaten.Name = "lblnhaphovaten";
            this.lblnhaphovaten.Size = new System.Drawing.Size(79, 13);
            this.lblnhaphovaten.TabIndex = 3;
            this.lblnhaphovaten.Text = "nhập họ và tên";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(157, 105);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 20);
            this.txtSo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblnhaphovaten);
            this.Controls.Add(this.lbsten);
            this.Controls.Add(this.lblquanlynhanvien);
            this.Controls.Add(this.btnthem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lblquanlynhanvien;
        private System.Windows.Forms.ListBox lbsten;
        private System.Windows.Forms.Label lblnhaphovaten;
        private System.Windows.Forms.TextBox txtSo;
    }
}


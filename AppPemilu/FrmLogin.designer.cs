﻿namespace AppPemilu
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMasuk = new ns1.BunifuImageButton();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMasuk)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnMasuk);
            this.panel2.Controls.Add(this.chkShowPass);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(102, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 251);
            this.panel2.TabIndex = 0;
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.Transparent;
            this.btnMasuk.Image = global::AppPemilu.Properties.Resources.btnLogin;
            this.btnMasuk.ImageActive = null;
            this.btnMasuk.Location = new System.Drawing.Point(78, 186);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(247, 42);
            this.btnMasuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMasuk.TabIndex = 3;
            this.btnMasuk.TabStop = false;
            this.btnMasuk.Zoom = 10;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Font = new System.Drawing.Font("PF Encore Sans Pro Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.ForeColor = System.Drawing.Color.White;
            this.chkShowPass.Location = new System.Drawing.Point(135, 149);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(138, 21);
            this.chkShowPass.TabIndex = 2;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtUsr, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPswd, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(43, 37);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(303, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppPemilu.Properties.Resources.businessman;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // txtUsr
            // 
            this.txtUsr.BackColor = System.Drawing.Color.DarkCyan;
            this.txtUsr.Font = new System.Drawing.Font("PF Encore Sans Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsr.ForeColor = System.Drawing.Color.White;
            this.txtUsr.Location = new System.Drawing.Point(60, 3);
            this.txtUsr.Multiline = true;
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(237, 38);
            this.txtUsr.TabIndex = 2;
            this.txtUsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPswd
            // 
            this.txtPswd.BackColor = System.Drawing.Color.DarkCyan;
            this.txtPswd.Font = new System.Drawing.Font("PF Encore Sans Pro Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPswd.ForeColor = System.Drawing.Color.White;
            this.txtPswd.Location = new System.Drawing.Point(60, 56);
            this.txtPswd.Multiline = true;
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '*';
            this.txtPswd.Size = new System.Drawing.Size(237, 41);
            this.txtPswd.TabIndex = 3;
            this.txtPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPswd_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPemilu.Properties.Resources.PASSWORD;
            this.pictureBox1.Location = new System.Drawing.Point(3, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PF Encore Sans Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(90, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::AppPemilu.Properties.Resources.cancel;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(565, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(23, 31);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // FrmLogin
            // 
            this.BackgroundImage = global::AppPemilu.Properties.Resources.Bitmap_in_Layout_IMK_cdr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 522);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMasuk)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkShowPass;
        private ns1.BunifuImageButton btnMasuk;
        private ns1.BunifuImageButton bunifuImageButton2;
    }
}


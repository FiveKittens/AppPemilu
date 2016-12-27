namespace AppPemilu
{
    partial class input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(input));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuara = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnClose = new ns1.BunifuImageButton();
            this.btnSubmit = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PF Encore Sans Pro Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 SUARA UNTUK  :";
            // 
            // txtSuara
            // 
            this.txtSuara.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSuara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuara.Font = new System.Drawing.Font("PF Encore Sans Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuara.Location = new System.Drawing.Point(142, 110);
            this.txtSuara.Multiline = true;
            this.txtSuara.Name = "txtSuara";
            this.txtSuara.Size = new System.Drawing.Size(158, 158);
            this.txtSuara.TabIndex = 3;
            this.txtSuara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSuara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuara_KeyDown);
            this.txtSuara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuara_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::AppPemilu.Properties.Resources.btnCancel;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(278, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 58);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageActive = null;
            this.btnSubmit.Location = new System.Drawing.Point(26, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 58);
            this.btnSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Zoom = 10;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(441, 395);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSuara);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "input";
            this.Text = "input";
            this.Activated += new System.EventHandler(this.input_Activated);
            this.Load += new System.EventHandler(this.input_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuara_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSuara;
        private ns1.BunifuImageButton btnSubmit;
        private ns1.BunifuImageButton btnClose;
    }
}
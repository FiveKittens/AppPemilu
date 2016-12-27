namespace AppPemilu
{
    partial class Rekap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRekap = new System.Windows.Forms.DataGridView();
            this.nama_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomor_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suara_masuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_suara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekap)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRekap
            // 
            this.dgvRekap.AllowUserToAddRows = false;
            this.dgvRekap.AllowUserToDeleteRows = false;
            this.dgvRekap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRekap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRekap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRekap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRekap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRekap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_calon,
            this.nomor_calon,
            this.suara_masuk,
            this.waktu_suara});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRekap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRekap.Location = new System.Drawing.Point(32, 33);
            this.dgvRekap.Name = "dgvRekap";
            this.dgvRekap.RowTemplate.Height = 24;
            this.dgvRekap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRekap.Size = new System.Drawing.Size(822, 503);
            this.dgvRekap.TabIndex = 0;
            // 
            // nama_calon
            // 
            this.nama_calon.DataPropertyName = "nama_calon";
            this.nama_calon.HeaderText = "Nama";
            this.nama_calon.Name = "nama_calon";
            // 
            // nomor_calon
            // 
            this.nomor_calon.DataPropertyName = "nomor_calon";
            this.nomor_calon.HeaderText = "Nomor";
            this.nomor_calon.Name = "nomor_calon";
            // 
            // suara_masuk
            // 
            this.suara_masuk.DataPropertyName = "suara_masuk";
            this.suara_masuk.HeaderText = "Jumlah Suara";
            this.suara_masuk.Name = "suara_masuk";
            // 
            // waktu_suara
            // 
            this.waktu_suara.DataPropertyName = "waktu_suara";
            this.waktu_suara.HeaderText = "Waktu Update Suara";
            this.waktu_suara.Name = "waktu_suara";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblJam);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(878, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 174);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 5);
            this.panel2.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("PF Encore Sans Pro", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(3, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(289, 54);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "dd-mm-yyyy";
            // 
            // lblJam
            // 
            this.lblJam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJam.AutoSize = true;
            this.lblJam.Font = new System.Drawing.Font("PF Encore Sans Pro Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.ForeColor = System.Drawing.Color.White;
            this.lblJam.Location = new System.Drawing.Point(68, 71);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(192, 47);
            this.lblJam.TabIndex = 1;
            this.lblJam.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPemilu.Properties.Resources.Layout_IMK_Jam;
            this.pictureBox1.Location = new System.Drawing.Point(0, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Rekap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppPemilu.Properties.Resources.Bitmap_in_Layout_IMK_cdr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRekap);
            this.Name = "Rekap";
            this.Size = new System.Drawing.Size(1223, 689);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRekap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn suara_masuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_suara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

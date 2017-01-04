namespace AppPemilu
{
    partial class Manage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPartai0 = new System.Windows.Forms.TextBox();
            this.txtNama0 = new System.Windows.Forms.TextBox();
            this.txtNomor0 = new System.Windows.Forms.TextBox();
            this.btnSubmit0 = new ns1.BunifuFlatButton();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new ns1.BunifuFlatButton();
            this.txtPartai1 = new System.Windows.Forms.TextBox();
            this.txtNama1 = new System.Windows.Forms.TextBox();
            this.txtNomor1 = new System.Windows.Forms.TextBox();
            this.btnSubmit1 = new ns1.BunifuFlatButton();
            this.pbCalon1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCalon1 = new System.Windows.Forms.DataGridView();
            this.nomor_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partai_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gambar_calon = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new ns1.BunifuFlatButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalon1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(78, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1063, 576);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.txtPartai0);
            this.tabPage1.Controls.Add(this.txtNama0);
            this.tabPage1.Controls.Add(this.txtNomor0);
            this.tabPage1.Controls.Add(this.btnSubmit0);
            this.tabPage1.Controls.Add(this.pictureBox0);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1055, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TAMBAHKAN CALON KE DAFTAR HITUNG";
            // 
            // txtPartai0
            // 
            this.txtPartai0.Location = new System.Drawing.Point(502, 285);
            this.txtPartai0.Name = "txtPartai0";
            this.txtPartai0.Size = new System.Drawing.Size(246, 34);
            this.txtPartai0.TabIndex = 32;
            // 
            // txtNama0
            // 
            this.txtNama0.Location = new System.Drawing.Point(502, 238);
            this.txtNama0.Name = "txtNama0";
            this.txtNama0.Size = new System.Drawing.Size(246, 34);
            this.txtNama0.TabIndex = 31;
            // 
            // txtNomor0
            // 
            this.txtNomor0.Location = new System.Drawing.Point(502, 189);
            this.txtNomor0.Name = "txtNomor0";
            this.txtNomor0.Size = new System.Drawing.Size(246, 34);
            this.txtNomor0.TabIndex = 30;
            // 
            // btnSubmit0
            // 
            this.btnSubmit0.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit0.BorderRadius = 0;
            this.btnSubmit0.ButtonText = "Submit";
            this.btnSubmit0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit0.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmit0.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit0.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmit0.Iconimage = null;
            this.btnSubmit0.Iconimage_right = null;
            this.btnSubmit0.Iconimage_right_Selected = null;
            this.btnSubmit0.Iconimage_Selected = null;
            this.btnSubmit0.IconMarginLeft = 0;
            this.btnSubmit0.IconMarginRight = 0;
            this.btnSubmit0.IconRightVisible = false;
            this.btnSubmit0.IconRightZoom = 0D;
            this.btnSubmit0.IconVisible = false;
            this.btnSubmit0.IconZoom = 90D;
            this.btnSubmit0.IsTab = false;
            this.btnSubmit0.Location = new System.Drawing.Point(486, 355);
            this.btnSubmit0.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSubmit0.Name = "btnSubmit0";
            this.btnSubmit0.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit0.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSubmit0.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmit0.selected = false;
            this.btnSubmit0.Size = new System.Drawing.Size(114, 46);
            this.btnSubmit0.TabIndex = 29;
            this.btnSubmit0.Text = "Submit";
            this.btnSubmit0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit0.Textcolor = System.Drawing.Color.White;
            this.btnSubmit0.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit0.Click += new System.EventHandler(this.btnSubmit0_Click);
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.Color.White;
            this.pictureBox0.Location = new System.Drawing.Point(140, 164);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(169, 237);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox0.TabIndex = 22;
            this.pictureBox0.TabStop = false;
            this.pictureBox0.Click += new System.EventHandler(this.pictureBox0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Partai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "No. Calon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nama";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.txtPartai1);
            this.tabPage2.Controls.Add(this.txtNama1);
            this.tabPage2.Controls.Add(this.txtNomor1);
            this.tabPage2.Controls.Add(this.btnSubmit1);
            this.tabPage2.Controls.Add(this.pbCalon1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvCalon1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1055, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MEMPERBAHARUI CALON DI DAFTAR HITUNG";
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = false;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = false;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(502, 355);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(114, 46);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPartai1
            // 
            this.txtPartai1.Location = new System.Drawing.Point(511, 285);
            this.txtPartai1.Multiline = true;
            this.txtPartai1.Name = "txtPartai1";
            this.txtPartai1.Size = new System.Drawing.Size(246, 35);
            this.txtPartai1.TabIndex = 35;
            // 
            // txtNama1
            // 
            this.txtNama1.Location = new System.Drawing.Point(511, 238);
            this.txtNama1.Multiline = true;
            this.txtNama1.Name = "txtNama1";
            this.txtNama1.Size = new System.Drawing.Size(246, 35);
            this.txtNama1.TabIndex = 34;
            // 
            // txtNomor1
            // 
            this.txtNomor1.Location = new System.Drawing.Point(511, 189);
            this.txtNomor1.Multiline = true;
            this.txtNomor1.Name = "txtNomor1";
            this.txtNomor1.Size = new System.Drawing.Size(246, 35);
            this.txtNomor1.TabIndex = 33;
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit1.BorderRadius = 0;
            this.btnSubmit1.ButtonText = "Update";
            this.btnSubmit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit1.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmit1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmit1.Iconimage = null;
            this.btnSubmit1.Iconimage_right = null;
            this.btnSubmit1.Iconimage_right_Selected = null;
            this.btnSubmit1.Iconimage_Selected = null;
            this.btnSubmit1.IconMarginLeft = 0;
            this.btnSubmit1.IconMarginRight = 0;
            this.btnSubmit1.IconRightVisible = false;
            this.btnSubmit1.IconRightZoom = 0D;
            this.btnSubmit1.IconVisible = false;
            this.btnSubmit1.IconZoom = 90D;
            this.btnSubmit1.IsTab = false;
            this.btnSubmit1.Location = new System.Drawing.Point(350, 355);
            this.btnSubmit1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSubmit1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmit1.selected = false;
            this.btnSubmit1.Size = new System.Drawing.Size(114, 46);
            this.btnSubmit1.TabIndex = 20;
            this.btnSubmit1.Text = "Update";
            this.btnSubmit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit1.Textcolor = System.Drawing.Color.White;
            this.btnSubmit1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit1.Click += new System.EventHandler(this.btnSubmit1_Click);
            // 
            // pbCalon1
            // 
            this.pbCalon1.BackColor = System.Drawing.Color.White;
            this.pbCalon1.Location = new System.Drawing.Point(140, 164);
            this.pbCalon1.Name = "pbCalon1";
            this.pbCalon1.Size = new System.Drawing.Size(169, 237);
            this.pbCalon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalon1.TabIndex = 13;
            this.pbCalon1.TabStop = false;
            this.pbCalon1.Click += new System.EventHandler(this.pbCalon1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Partai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "No. Calon";
            // 
            // dgvCalon1
            // 
            this.dgvCalon1.AllowUserToAddRows = false;
            this.dgvCalon1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalon1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalon1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalon1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalon1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalon1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomor_calon,
            this.nama_calon,
            this.partai_calon,
            this.gambar_calon});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalon1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalon1.Location = new System.Drawing.Point(811, 164);
            this.dgvCalon1.Name = "dgvCalon1";
            this.dgvCalon1.ReadOnly = true;
            this.dgvCalon1.RowTemplate.Height = 24;
            this.dgvCalon1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalon1.Size = new System.Drawing.Size(159, 298);
            this.dgvCalon1.TabIndex = 12;
            this.dgvCalon1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalon1_CellClick);
            // 
            // nomor_calon
            // 
            this.nomor_calon.DataPropertyName = "nomor_calon";
            this.nomor_calon.HeaderText = "NOMOR";
            this.nomor_calon.Name = "nomor_calon";
            this.nomor_calon.ReadOnly = true;
            // 
            // nama_calon
            // 
            this.nama_calon.DataPropertyName = "nama_calon";
            this.nama_calon.HeaderText = "NAMA";
            this.nama_calon.Name = "nama_calon";
            this.nama_calon.ReadOnly = true;
            // 
            // partai_calon
            // 
            this.partai_calon.DataPropertyName = "partai_calon";
            this.partai_calon.HeaderText = "PARTAI";
            this.partai_calon.Name = "partai_calon";
            this.partai_calon.ReadOnly = true;
            // 
            // gambar_calon
            // 
            this.gambar_calon.DataPropertyName = "gambar_calon";
            this.gambar_calon.HeaderText = "Pic";
            this.gambar_calon.Name = "gambar_calon";
            this.gambar_calon.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nama";
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Reset All";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = null;
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = false;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = false;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(655, 355);
            this.btnReset.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(114, 46);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Reset All";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppPemilu.Properties.Resources.Bitmap_in_Layout_IMK_cdr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tabControl1);
            this.Name = "Manage";
            this.Size = new System.Drawing.Size(1223, 689);
            this.Load += new System.EventHandler(this.Manage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ns1.BunifuFlatButton btnSubmit1;
        private System.Windows.Forms.PictureBox pbCalon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCalon1;
        private System.Windows.Forms.Label label6;
        private ns1.BunifuFlatButton btnSubmit0;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartai0;
        private System.Windows.Forms.TextBox txtNama0;
        private System.Windows.Forms.TextBox txtNomor0;
        private System.Windows.Forms.TextBox txtPartai1;
        private System.Windows.Forms.TextBox txtNama1;
        private System.Windows.Forms.TextBox txtNomor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn partai_calon;
        private System.Windows.Forms.DataGridViewImageColumn gambar_calon;
        private ns1.BunifuFlatButton btnDelete;
        private ns1.BunifuFlatButton btnReset;
    }
}

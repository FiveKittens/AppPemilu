namespace AppPemilu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOut = new ns1.BunifuFlatButton();
            this.expandCollapsePanel2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.btnPrint = new ns1.BunifuFlatButton();
            this.btnCabut = new ns1.BunifuFlatButton();
            this.btnInput = new ns1.BunifuFlatButton();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.btnRekap = new ns1.BunifuFlatButton();
            this.btnManage = new ns1.BunifuFlatButton();
            this.btnCount = new ns1.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNama = new ns1.BunifuCustomLabel();
            this.lblID = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new ns1.BunifuImageButton();
            this.btnDispose = new ns1.BunifuImageButton();
            this.paneLoad = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDispose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.expandCollapsePanel2);
            this.panel1.Controls.Add(this.expandCollapsePanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 716);
            this.panel1.TabIndex = 0;
            // 
            // btnOut
            // 
            this.btnOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOut.BorderRadius = 0;
            this.btnOut.ButtonText = "Log Out";
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOut.Iconimage")));
            this.btnOut.Iconimage_right = null;
            this.btnOut.Iconimage_right_Selected = null;
            this.btnOut.Iconimage_Selected = null;
            this.btnOut.IconMarginLeft = 0;
            this.btnOut.IconMarginRight = 0;
            this.btnOut.IconRightVisible = true;
            this.btnOut.IconRightZoom = 0D;
            this.btnOut.IconVisible = true;
            this.btnOut.IconZoom = 90D;
            this.btnOut.IsTab = false;
            this.btnOut.Location = new System.Drawing.Point(95, 606);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOut.selected = false;
            this.btnOut.Size = new System.Drawing.Size(335, 37);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Log Out";
            this.btnOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOut.Textcolor = System.Drawing.Color.White;
            this.btnOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // expandCollapsePanel2
            // 
            this.expandCollapsePanel2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel2.Controls.Add(this.btnPrint);
            this.expandCollapsePanel2.Controls.Add(this.btnCabut);
            this.expandCollapsePanel2.Controls.Add(this.btnInput);
            this.expandCollapsePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandCollapsePanel2.ExpandedHeight = 234;
            this.expandCollapsePanel2.IsExpanded = true;
            this.expandCollapsePanel2.Location = new System.Drawing.Point(0, 332);
            this.expandCollapsePanel2.Name = "expandCollapsePanel2";
            this.expandCollapsePanel2.Size = new System.Drawing.Size(430, 199);
            this.expandCollapsePanel2.TabIndex = 2;
            this.expandCollapsePanel2.Text = "Sub Menu";
            this.expandCollapsePanel2.UseAnimation = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.ButtonText = "Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 90D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(95, 140);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(335, 37);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCabut
            // 
            this.btnCabut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCabut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCabut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCabut.BorderRadius = 0;
            this.btnCabut.ButtonText = "Cabut Suara";
            this.btnCabut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCabut.DisabledColor = System.Drawing.Color.Gray;
            this.btnCabut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCabut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCabut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCabut.Iconimage")));
            this.btnCabut.Iconimage_right = null;
            this.btnCabut.Iconimage_right_Selected = null;
            this.btnCabut.Iconimage_Selected = null;
            this.btnCabut.IconMarginLeft = 0;
            this.btnCabut.IconMarginRight = 0;
            this.btnCabut.IconRightVisible = true;
            this.btnCabut.IconRightZoom = 0D;
            this.btnCabut.IconVisible = true;
            this.btnCabut.IconZoom = 90D;
            this.btnCabut.IsTab = false;
            this.btnCabut.Location = new System.Drawing.Point(95, 95);
            this.btnCabut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCabut.Name = "btnCabut";
            this.btnCabut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCabut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCabut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCabut.selected = false;
            this.btnCabut.Size = new System.Drawing.Size(335, 37);
            this.btnCabut.TabIndex = 2;
            this.btnCabut.Text = "Cabut Suara";
            this.btnCabut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCabut.Textcolor = System.Drawing.Color.White;
            this.btnCabut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabut.Click += new System.EventHandler(this.btnCabut_Click);
            // 
            // btnInput
            // 
            this.btnInput.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInput.BorderRadius = 0;
            this.btnInput.ButtonText = "Input Suara";
            this.btnInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInput.DisabledColor = System.Drawing.Color.Gray;
            this.btnInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInput.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInput.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInput.Iconimage")));
            this.btnInput.Iconimage_right = null;
            this.btnInput.Iconimage_right_Selected = null;
            this.btnInput.Iconimage_Selected = null;
            this.btnInput.IconMarginLeft = 0;
            this.btnInput.IconMarginRight = 0;
            this.btnInput.IconRightVisible = true;
            this.btnInput.IconRightZoom = 0D;
            this.btnInput.IconVisible = true;
            this.btnInput.IconZoom = 90D;
            this.btnInput.IsTab = false;
            this.btnInput.Location = new System.Drawing.Point(95, 50);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInput.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInput.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInput.selected = false;
            this.btnInput.Size = new System.Drawing.Size(335, 37);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Input Suara";
            this.btnInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInput.Textcolor = System.Drawing.Color.White;
            this.btnInput.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.btnRekap);
            this.expandCollapsePanel1.Controls.Add(this.btnManage);
            this.expandCollapsePanel1.Controls.Add(this.btnCount);
            this.expandCollapsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandCollapsePanel1.ExpandedHeight = 234;
            this.expandCollapsePanel1.IsExpanded = true;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(0, 136);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(430, 196);
            this.expandCollapsePanel1.TabIndex = 1;
            this.expandCollapsePanel1.Text = "Main Menu";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // btnRekap
            // 
            this.btnRekap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRekap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRekap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRekap.BorderRadius = 0;
            this.btnRekap.ButtonText = "Rekap";
            this.btnRekap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRekap.DisabledColor = System.Drawing.Color.Gray;
            this.btnRekap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRekap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRekap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRekap.Iconimage")));
            this.btnRekap.Iconimage_right = null;
            this.btnRekap.Iconimage_right_Selected = null;
            this.btnRekap.Iconimage_Selected = null;
            this.btnRekap.IconMarginLeft = 0;
            this.btnRekap.IconMarginRight = 0;
            this.btnRekap.IconRightVisible = true;
            this.btnRekap.IconRightZoom = 0D;
            this.btnRekap.IconVisible = true;
            this.btnRekap.IconZoom = 90D;
            this.btnRekap.IsTab = false;
            this.btnRekap.Location = new System.Drawing.Point(95, 140);
            this.btnRekap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRekap.Name = "btnRekap";
            this.btnRekap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRekap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRekap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRekap.selected = false;
            this.btnRekap.Size = new System.Drawing.Size(335, 37);
            this.btnRekap.TabIndex = 3;
            this.btnRekap.Text = "Rekap";
            this.btnRekap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRekap.Textcolor = System.Drawing.Color.White;
            this.btnRekap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRekap.Click += new System.EventHandler(this.btnRekap_Click);
            // 
            // btnManage
            // 
            this.btnManage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManage.BorderRadius = 0;
            this.btnManage.ButtonText = "Manage Data Calon";
            this.btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManage.DisabledColor = System.Drawing.Color.Gray;
            this.btnManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnManage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnManage.Iconimage")));
            this.btnManage.Iconimage_right = null;
            this.btnManage.Iconimage_right_Selected = null;
            this.btnManage.Iconimage_Selected = null;
            this.btnManage.IconMarginLeft = 0;
            this.btnManage.IconMarginRight = 0;
            this.btnManage.IconRightVisible = true;
            this.btnManage.IconRightZoom = 0D;
            this.btnManage.IconVisible = true;
            this.btnManage.IconZoom = 90D;
            this.btnManage.IsTab = false;
            this.btnManage.Location = new System.Drawing.Point(95, 97);
            this.btnManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnManage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnManage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManage.selected = false;
            this.btnManage.Size = new System.Drawing.Size(335, 37);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "Manage Data Calon";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManage.Textcolor = System.Drawing.Color.White;
            this.btnManage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnCount
            // 
            this.btnCount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCount.BorderRadius = 0;
            this.btnCount.ButtonText = "Penghitung Suara";
            this.btnCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCount.DisabledColor = System.Drawing.Color.Gray;
            this.btnCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCount.Iconimage")));
            this.btnCount.Iconimage_right = null;
            this.btnCount.Iconimage_right_Selected = null;
            this.btnCount.Iconimage_Selected = null;
            this.btnCount.IconMarginLeft = 0;
            this.btnCount.IconMarginRight = 0;
            this.btnCount.IconRightVisible = true;
            this.btnCount.IconRightZoom = 0D;
            this.btnCount.IconVisible = true;
            this.btnCount.IconZoom = 90D;
            this.btnCount.IsTab = false;
            this.btnCount.Location = new System.Drawing.Point(95, 52);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCount.selected = false;
            this.btnCount.Size = new System.Drawing.Size(335, 37);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Penghitung Suara";
            this.btnCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCount.Textcolor = System.Drawing.Color.White;
            this.btnCount.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.lblNama);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 136);
            this.panel3.TabIndex = 0;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.White;
            this.lblNama.Location = new System.Drawing.Point(197, 70);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(84, 30);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(197, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 30);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "id";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(94, 70);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 30);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Nama";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(94, 33);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(37, 30);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPemilu.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnDispose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(430, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::AppPemilu.Properties.Resources._checked;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1150, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 29);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnDispose
            // 
            this.btnDispose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDispose.BackColor = System.Drawing.Color.Transparent;
            this.btnDispose.Image = global::AppPemilu.Properties.Resources.cancel;
            this.btnDispose.ImageActive = null;
            this.btnDispose.Location = new System.Drawing.Point(1188, 3);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(32, 29);
            this.btnDispose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDispose.TabIndex = 0;
            this.btnDispose.TabStop = false;
            this.btnDispose.Zoom = 10;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
            // 
            // paneLoad
            // 
            this.paneLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneLoad.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paneLoad.Location = new System.Drawing.Point(430, 27);
            this.paneLoad.Name = "paneLoad";
            this.paneLoad.Size = new System.Drawing.Size(1223, 689);
            this.paneLoad.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.Location = new System.Drawing.Point(6, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(116, 23);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Dashboard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.expandCollapsePanel2.ResumeLayout(false);
            this.expandCollapsePanel2.PerformLayout();
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDispose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
        private ns1.BunifuFlatButton btnPrint;
        private ns1.BunifuFlatButton btnRekap;
        private ns1.BunifuFlatButton btnManage;
        private ns1.BunifuFlatButton btnCount;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel2;
        private ns1.BunifuFlatButton btnCabut;
        private ns1.BunifuFlatButton btnInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuCustomLabel lblNama;
        private ns1.BunifuCustomLabel lblID;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel paneLoad;
        private ns1.BunifuImageButton btnDispose;
        private ns1.BunifuImageButton btnMinimize;
        private ns1.BunifuFlatButton btnOut;
        private System.Windows.Forms.Label lblHeader;
    }
}


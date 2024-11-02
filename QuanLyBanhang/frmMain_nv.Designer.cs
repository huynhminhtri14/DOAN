namespace QuanLyBanhang
{
    partial class frmMain_nv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain_nv));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.hdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhmuc,
            this.mnuHoadon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(185, 366);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.AutoSize = false;
            this.mnuFile.BackColor = System.Drawing.Color.Aqua;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Image = global::QuanLyBanhang.Properties.Resources.account_cog_icon_137995;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(195, 60);
            this.mnuFile.Text = "&Tài Khoản";
            // 
            // mnuThoat
            // 
            this.mnuThoat.BackColor = System.Drawing.Color.Aqua;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(222, 24);
            this.mnuThoat.Text = "Thông Tin Tài Khoản";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.AutoSize = false;
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachhang});
            this.mnuDanhmuc.Image = global::QuanLyBanhang.Properties.Resources.category_add_button_icon_icons_com_71724;
            this.mnuDanhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(200, 60);
            this.mnuDanhmuc.Text = "&Quản Lý Thông Tin";
            this.mnuDanhmuc.Click += new System.EventHandler(this.mnuDanhmuc_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.BackColor = System.Drawing.Color.Aqua;
            this.mnuKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.mnuKhachhang.Size = new System.Drawing.Size(222, 24);
            this.mnuKhachhang.Text = "&Khách hàng";
            this.mnuKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click_1);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.AutoSize = false;
            this.mnuHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hdToolStripMenuItem});
            this.mnuHoadon.Image = global::QuanLyBanhang.Properties.Resources.shoppaymentorderbuy_23_icon_icons_com_73884;
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(193, 60);
            this.mnuHoadon.Text = "&Danh Mục";
            // 
            // hdToolStripMenuItem
            // 
            this.hdToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.hdToolStripMenuItem.Name = "hdToolStripMenuItem";
            this.hdToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.hdToolStripMenuItem.Text = "Hóa Đơn";
            this.hdToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hdToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain_nv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain_nv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_nv_FormClosing_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem hdToolStripMenuItem;
    }
}
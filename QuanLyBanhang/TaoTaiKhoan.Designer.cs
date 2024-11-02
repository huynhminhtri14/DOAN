namespace QuanLyBanhang
{
    partial class TaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoTaiKhoan));
            this.cb_tk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_cv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbtk = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_tk = new System.Windows.Forms.DataGridView();
            this.cb_tnv = new System.Windows.Forms.ComboBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btdk = new System.Windows.Forms.Button();
            this.txt_TKtenKH = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.eye_lock = new System.Windows.Forms.PictureBox();
            this.eye_open = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_open)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_tk
            // 
            this.cb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tk.FormattingEnabled = true;
            this.cb_tk.Location = new System.Drawing.Point(118, 20);
            this.cb_tk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_tk.Name = "cb_tk";
            this.cb_tk.Size = new System.Drawing.Size(188, 25);
            this.cb_tk.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(344, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Chức vụ";
            // 
            // cb_cv
            // 
            this.cb_cv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cv.FormattingEnabled = true;
            this.cb_cv.Items.AddRange(new object[] {
            "Admin",
            "Nhân Viên"});
            this.cb_cv.Location = new System.Drawing.Point(428, 20);
            this.cb_cv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_cv.Name = "cb_cv";
            this.cb_cv.Size = new System.Drawing.Size(188, 25);
            this.cb_cv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên người dùng";
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(428, 67);
            this.txtmk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(163, 23);
            this.txtmk.TabIndex = 4;
            this.txtmk.TextChanged += new System.EventHandler(this.txtmk_TextChanged);
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbmk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbmk.Location = new System.Drawing.Point(344, 70);
            this.lbmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(66, 17);
            this.lbmk.TabIndex = 24;
            this.lbmk.Text = "Mật khẩu";
            // 
            // lbtk
            // 
            this.lbtk.AutoSize = true;
            this.lbtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbtk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbtk.Location = new System.Drawing.Point(9, 20);
            this.lbtk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtk.Name = "lbtk";
            this.lbtk.Size = new System.Drawing.Size(71, 17);
            this.lbtk.TabIndex = 23;
            this.lbtk.Text = "Tài khoản";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_xoa.Location = new System.Drawing.Point(511, 116);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 46);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_tk);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 177);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(630, 159);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // dgv_tk
            // 
            this.dgv_tk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tk.Location = new System.Drawing.Point(2, 18);
            this.dgv_tk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_tk.Name = "dgv_tk";
            this.dgv_tk.ReadOnly = true;
            this.dgv_tk.RowHeadersWidth = 51;
            this.dgv_tk.RowTemplate.Height = 24;
            this.dgv_tk.Size = new System.Drawing.Size(626, 139);
            this.dgv_tk.TabIndex = 0;
            this.dgv_tk.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tk_CellEnter);
            this.dgv_tk.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_tk_CellFormatting);
            // 
            // cb_tnv
            // 
            this.cb_tnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tnv.FormattingEnabled = true;
            this.cb_tnv.Location = new System.Drawing.Point(118, 67);
            this.cb_tnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_tnv.Name = "cb_tnv";
            this.cb_tnv.Size = new System.Drawing.Size(188, 25);
            this.cb_tnv.TabIndex = 36;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Sua.Location = new System.Drawing.Point(380, 116);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 46);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btdk
            // 
            this.btdk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btdk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btdk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btdk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdk.ForeColor = System.Drawing.Color.Black;
            this.btdk.Image = ((System.Drawing.Image)(resources.GetObject("btdk.Image")));
            this.btdk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btdk.Location = new System.Drawing.Point(233, 116);
            this.btdk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btdk.Name = "btdk";
            this.btdk.Size = new System.Drawing.Size(110, 46);
            this.btdk.TabIndex = 5;
            this.btdk.Text = "Thêm";
            this.btdk.UseVisualStyleBackColor = false;
            this.btdk.Click += new System.EventHandler(this.btdk_Click);
            // 
            // txt_TKtenKH
            // 
            this.txt_TKtenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TKtenKH.Location = new System.Drawing.Point(2, 128);
            this.txt_TKtenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TKtenKH.Name = "txt_TKtenKH";
            this.txt_TKtenKH.Size = new System.Drawing.Size(112, 23);
            this.txt_TKtenKH.TabIndex = 38;
            this.txt_TKtenKH.Text = "Nhập Tên NV";
            this.txt_TKtenKH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TKtenKH_MouseClick);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(125, 117);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(92, 44);
            this.btn_timkiem.TabIndex = 37;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // eye_lock
            // 
            this.eye_lock.Image = global::QuanLyBanhang.Properties.Resources.eye_lock;
            this.eye_lock.Location = new System.Drawing.Point(595, 67);
            this.eye_lock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eye_lock.Name = "eye_lock";
            this.eye_lock.Size = new System.Drawing.Size(21, 23);
            this.eye_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eye_lock.TabIndex = 39;
            this.eye_lock.TabStop = false;
            this.eye_lock.Click += new System.EventHandler(this.eye_lock_Click);
            // 
            // eye_open
            // 
            this.eye_open.Image = global::QuanLyBanhang.Properties.Resources.eye_open;
            this.eye_open.Location = new System.Drawing.Point(595, 67);
            this.eye_open.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eye_open.Name = "eye_open";
            this.eye_open.Size = new System.Drawing.Size(21, 22);
            this.eye_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eye_open.TabIndex = 40;
            this.eye_open.TabStop = false;
            this.eye_open.Click += new System.EventHandler(this.eye_open_Click);
            // 
            // TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(630, 336);
            this.Controls.Add(this.eye_open);
            this.Controls.Add(this.eye_lock);
            this.Controls.Add(this.txt_TKtenKH);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.cb_tnv);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.cb_tk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_cv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btdk);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.lbtk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "TaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài Khoản Ngươi Dùng";
            this.Load += new System.EventHandler(this.TaoTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_tk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_cv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btdk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Label lbtk;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_tk;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox cb_tnv;
        private System.Windows.Forms.TextBox txt_TKtenKH;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.PictureBox eye_lock;
        private System.Windows.Forms.PictureBox eye_open;
    }
}
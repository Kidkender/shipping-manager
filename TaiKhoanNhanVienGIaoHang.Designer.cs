namespace QLVNNhaNam
{
    partial class TaiKhoanNhanVienGIaoHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKhieuBai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dgvDSDonHang = new System.Windows.Forms.DataGridView();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDuKienGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhtrangDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiphiVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1454, 833);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnlogout);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtusername);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1446, 804);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hệ thống quản lý giao hàng ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnrefresh);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnKhieuBai);
            this.tabPage2.Controls.Add(this.btnXacNhan);
            this.tabPage2.Controls.Add(this.dgvDSDonHang);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1446, 804);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(864, 410);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 58);
            this.button3.TabIndex = 22;
            this.button3.Text = "Danh sách đơn hàng cần nhận (đổi/trả) ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 410);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 58);
            this.button2.TabIndex = 21;
            this.button2.Text = "Danh sách đơn hàng cần giao trong ngày";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thống kê danh sách đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKhieuBai
            // 
            this.btnKhieuBai.Enabled = false;
            this.btnKhieuBai.Location = new System.Drawing.Point(1093, 410);
            this.btnKhieuBai.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhieuBai.Name = "btnKhieuBai";
            this.btnKhieuBai.Size = new System.Drawing.Size(176, 58);
            this.btnKhieuBai.TabIndex = 19;
            this.btnKhieuBai.Text = "Yêu cầu khiếu nại đơn hàng";
            this.btnKhieuBai.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(23, 410);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(182, 58);
            this.btnXacNhan.TabIndex = 18;
            this.btnXacNhan.Text = "Xác nhận đơn hàng đã giao";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dgvDSDonHang
            // 
            this.dgvDSDonHang.AllowUserToDeleteRows = false;
            this.dgvDSDonHang.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDSDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDH,
            this.Ngaydathang,
            this.NgayDuKienGiao,
            this.NgayNhanHang,
            this.TinhtrangDH,
            this.LyDo,
            this.PTTT,
            this.ChiphiVC});
            this.dgvDSDonHang.Location = new System.Drawing.Point(23, 29);
            this.dgvDSDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSDonHang.Name = "dgvDSDonHang";
            this.dgvDSDonHang.RowHeadersWidth = 51;
            this.dgvDSDonHang.Size = new System.Drawing.Size(1216, 346);
            this.dgvDSDonHang.TabIndex = 13;
            this.dgvDSDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonHang_CellClick);
            this.dgvDSDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonHang_CellContentClick);
            // 
            // txtusername
            // 
            this.txtusername.Enabled = false;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(509, 132);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(297, 34);
            this.txtusername.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Xin chào :";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaDH";
            this.MaDH.HeaderText = "Mã đơn hàng";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.Width = 125;
            // 
            // Ngaydathang
            // 
            this.Ngaydathang.DataPropertyName = "Ngaydathang";
            this.Ngaydathang.HeaderText = "Ngày đặt hàng";
            this.Ngaydathang.MinimumWidth = 6;
            this.Ngaydathang.Name = "Ngaydathang";
            this.Ngaydathang.Width = 125;
            // 
            // NgayDuKienGiao
            // 
            this.NgayDuKienGiao.DataPropertyName = "NgayDuKienGiao";
            this.NgayDuKienGiao.HeaderText = "Ngày dự kiến giao hàng";
            this.NgayDuKienGiao.MinimumWidth = 6;
            this.NgayDuKienGiao.Name = "NgayDuKienGiao";
            this.NgayDuKienGiao.Width = 125;
            // 
            // NgayNhanHang
            // 
            this.NgayNhanHang.DataPropertyName = "NgayNhanHang";
            this.NgayNhanHang.HeaderText = "Ngày xác nhận đã nhận hàng";
            this.NgayNhanHang.MinimumWidth = 6;
            this.NgayNhanHang.Name = "NgayNhanHang";
            this.NgayNhanHang.Width = 125;
            // 
            // TinhtrangDH
            // 
            this.TinhtrangDH.DataPropertyName = "TinhtrangDH";
            this.TinhtrangDH.HeaderText = "Tình trạng đơn hàng";
            this.TinhtrangDH.MinimumWidth = 6;
            this.TinhtrangDH.Name = "TinhtrangDH";
            this.TinhtrangDH.Width = 125;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 125;
            // 
            // PTTT
            // 
            this.PTTT.DataPropertyName = "PTTT";
            this.PTTT.HeaderText = "Phương thức thanh toán";
            this.PTTT.MinimumWidth = 6;
            this.PTTT.Name = "PTTT";
            this.PTTT.Width = 125;
            // 
            // ChiphiVC
            // 
            this.ChiphiVC.DataPropertyName = "ChiphiVC";
            this.ChiphiVC.HeaderText = "Chi phí vận chuyển";
            this.ChiphiVC.MinimumWidth = 6;
            this.ChiphiVC.Name = "ChiphiVC";
            this.ChiphiVC.Width = 125;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(223, 410);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(183, 58);
            this.btnrefresh.TabIndex = 23;
            this.btnrefresh.Text = "Làm mới";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(538, 251);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(194, 34);
            this.btnlogout.TabIndex = 13;
            this.btnlogout.Text = "Đăng Xuất";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // TaiKhoanNhanVienGIaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 878);
            this.Controls.Add(this.tabControl1);
            this.Name = "TaiKhoanNhanVienGIaoHang";
            this.Text = "TaiKhoanNhanVienGIaoHang";
            this.Load += new System.EventHandler(this.TaiKhoanNhanVienGIaoHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDSDonHang;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKhieuBai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDuKienGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhtrangDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiphiVC;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnlogout;
    }
}
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKhieuBai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dgvDSDonHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDuKienGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhtrangDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiphiVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnlogout);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtusername);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(972, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(404, 204);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(146, 28);
            this.btnlogout.TabIndex = 13;
            this.btnlogout.Text = "Đăng Xuất";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Xin chào :";
            // 
            // txtusername
            // 
            this.txtusername.Enabled = false;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(382, 107);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(224, 28);
            this.txtusername.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hệ thống quản lý giao hàng ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(966, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnrefresh.Location = new System.Drawing.Point(163, 343);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(154, 54);
            this.btnrefresh.TabIndex = 23;
            this.btnrefresh.Text = "Làm mới";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(643, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 54);
            this.button3.TabIndex = 22;
            this.button3.Text = "Danh sách đơn hàng cần nhận (đổi/trả) ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(483, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 54);
            this.button2.TabIndex = 21;
            this.button2.Text = "Danh sách đơn hàng cần giao trong ngày";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(323, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 54);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thống kê danh sách đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKhieuBai
            // 
            this.btnKhieuBai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKhieuBai.Enabled = false;
            this.btnKhieuBai.Location = new System.Drawing.Point(803, 343);
            this.btnKhieuBai.Name = "btnKhieuBai";
            this.btnKhieuBai.Size = new System.Drawing.Size(156, 54);
            this.btnKhieuBai.TabIndex = 19;
            this.btnKhieuBai.Text = "Yêu cầu khiếu nại đơn hàng";
            this.btnKhieuBai.UseVisualStyleBackColor = true;
            this.btnKhieuBai.Click += new System.EventHandler(this.btnKhieuBai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.Location = new System.Drawing.Point(3, 343);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(154, 54);
            this.btnXacNhan.TabIndex = 18;
            this.btnXacNhan.Text = "Xác nhận đơn hàng đã giao";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dgvDSDonHang
            // 
            this.dgvDSDonHang.AllowUserToAddRows = false;
            this.dgvDSDonHang.AllowUserToDeleteRows = false;
            this.dgvDSDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDSDonHang, 6);
            this.dgvDSDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDonHang.Location = new System.Drawing.Point(3, 3);
            this.dgvDSDonHang.Name = "dgvDSDonHang";
            this.dgvDSDonHang.ReadOnly = true;
            this.dgvDSDonHang.RowHeadersWidth = 51;
            this.dgvDSDonHang.Size = new System.Drawing.Size(956, 334);
            this.dgvDSDonHang.TabIndex = 13;
            this.dgvDSDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonHang_CellClick);
            this.dgvDSDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonHang_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaDH";
            this.MaDH.HeaderText = "Mã đơn hàng";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.ReadOnly = true;
            // 
            // Ngaydathang
            // 
            this.Ngaydathang.DataPropertyName = "Ngaydathang";
            this.Ngaydathang.HeaderText = "Ngày đặt hàng";
            this.Ngaydathang.MinimumWidth = 6;
            this.Ngaydathang.Name = "Ngaydathang";
            this.Ngaydathang.ReadOnly = true;
            // 
            // NgayDuKienGiao
            // 
            this.NgayDuKienGiao.DataPropertyName = "NgayDuKienGiao";
            this.NgayDuKienGiao.HeaderText = "Ngày dự kiến giao hàng";
            this.NgayDuKienGiao.MinimumWidth = 6;
            this.NgayDuKienGiao.Name = "NgayDuKienGiao";
            this.NgayDuKienGiao.ReadOnly = true;
            // 
            // NgayNhanHang
            // 
            this.NgayNhanHang.DataPropertyName = "NgayNhanHang";
            this.NgayNhanHang.HeaderText = "Ngày xác nhận đã nhận hàng";
            this.NgayNhanHang.MinimumWidth = 6;
            this.NgayNhanHang.Name = "NgayNhanHang";
            this.NgayNhanHang.ReadOnly = true;
            // 
            // TinhtrangDH
            // 
            this.TinhtrangDH.DataPropertyName = "TinhtrangDH";
            this.TinhtrangDH.HeaderText = "Tình trạng đơn hàng";
            this.TinhtrangDH.MinimumWidth = 6;
            this.TinhtrangDH.Name = "TinhtrangDH";
            this.TinhtrangDH.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // PTTT
            // 
            this.PTTT.DataPropertyName = "PTTT";
            this.PTTT.HeaderText = "Phương thức thanh toán";
            this.PTTT.MinimumWidth = 6;
            this.PTTT.Name = "PTTT";
            this.PTTT.ReadOnly = true;
            // 
            // ChiphiVC
            // 
            this.ChiphiVC.DataPropertyName = "ChiphiVC";
            this.ChiphiVC.HeaderText = "Chi phí vận chuyển";
            this.ChiphiVC.MinimumWidth = 6;
            this.ChiphiVC.Name = "ChiphiVC";
            this.ChiphiVC.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDSDonHang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKhieuBai, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnrefresh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnXacNhan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 400);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // TaiKhoanNhanVienGIaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 430);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaiKhoanNhanVienGIaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoanNhanVienGIaoHang";
            this.Load += new System.EventHandler(this.TaiKhoanNhanVienGIaoHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
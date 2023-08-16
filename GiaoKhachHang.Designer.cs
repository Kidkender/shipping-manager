namespace QLVNNhaNam
{
    partial class GiaoKhachHang
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
            this.btnDoiHang = new System.Windows.Forms.Button();
            this.btnKhieuBai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnYeuTH = new System.Windows.Forms.Button();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.cbxPTTT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSanPham = new System.Windows.Forms.DataGridView();
            this.STTSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSDonHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDuKienGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1625, 834);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnlogout);
            this.tabPage1.Controls.Add(this.btnDoiHang);
            this.tabPage1.Controls.Add(this.btnKhieuBai);
            this.tabPage1.Controls.Add(this.btnXacNhan);
            this.tabPage1.Controls.Add(this.btnYeuTH);
            this.tabPage1.Controls.Add(this.btnHuyDon);
            this.tabPage1.Controls.Add(this.cbxPTTT);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblUserName);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtMaDH);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1617, 805);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Theo dõi đơn hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDoiHang
            // 
            this.btnDoiHang.Location = new System.Drawing.Point(939, 327);
            this.btnDoiHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiHang.Name = "btnDoiHang";
            this.btnDoiHang.Size = new System.Drawing.Size(221, 58);
            this.btnDoiHang.TabIndex = 19;
            this.btnDoiHang.Text = "Đổi hàng";
            this.btnDoiHang.UseVisualStyleBackColor = true;
            this.btnDoiHang.Click += new System.EventHandler(this.btnDoiHang_Click);
            // 
            // btnKhieuBai
            // 
            this.btnKhieuBai.Enabled = false;
            this.btnKhieuBai.Location = new System.Drawing.Point(1421, 369);
            this.btnKhieuBai.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhieuBai.Name = "btnKhieuBai";
            this.btnKhieuBai.Size = new System.Drawing.Size(176, 39);
            this.btnKhieuBai.TabIndex = 18;
            this.btnKhieuBai.Text = "Yêu cầu khiếu nại đơn hàng";
            this.btnKhieuBai.UseVisualStyleBackColor = true;
            this.btnKhieuBai.Click += new System.EventHandler(this.btnKhieuBai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(629, 327);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(221, 58);
            this.btnXacNhan.TabIndex = 17;
            this.btnXacNhan.Text = "Xác nhận đã nhận hàng";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.button3_ClickAsync);
            // 
            // btnYeuTH
            // 
            this.btnYeuTH.Location = new System.Drawing.Point(319, 327);
            this.btnYeuTH.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeuTH.Name = "btnYeuTH";
            this.btnYeuTH.Size = new System.Drawing.Size(221, 58);
            this.btnYeuTH.TabIndex = 16;
            this.btnYeuTH.Text = "Yêu cầu trả hàng";
            this.btnYeuTH.UseVisualStyleBackColor = true;
            this.btnYeuTH.Click += new System.EventHandler(this.btnYeuTH_Click);
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Location = new System.Drawing.Point(15, 327);
            this.btnHuyDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(221, 58);
            this.btnHuyDon.TabIndex = 15;
            this.btnHuyDon.Text = "Hủy đơn hàng";
            this.btnHuyDon.UseVisualStyleBackColor = true;
            this.btnHuyDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxPTTT
            // 
            this.cbxPTTT.Enabled = false;
            this.cbxPTTT.FormattingEnabled = true;
            this.cbxPTTT.Items.AddRange(new object[] {
            "Nhận hàng khi thanh toán",
            "Thanh toán qua momo",
            "Thanh toán thẻ ATM"});
            this.cbxPTTT.Location = new System.Drawing.Point(589, 134);
            this.cbxPTTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPTTT.Name = "cbxPTTT";
            this.cbxPTTT.Size = new System.Drawing.Size(229, 24);
            this.cbxPTTT.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSSanPham);
            this.groupBox2.Location = new System.Drawing.Point(939, 416);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(672, 374);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm theo đơn hàng";
            // 
            // dgvDSSanPham
            // 
            this.dgvDSSanPham.AllowUserToAddRows = false;
            this.dgvDSSanPham.AllowUserToDeleteRows = false;
            this.dgvDSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTSanPham,
            this.TSP,
            this.SL,
            this.DG,
            this.TT});
            this.dgvDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSanPham.Location = new System.Drawing.Point(4, 19);
            this.dgvDSSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSSanPham.Name = "dgvDSSanPham";
            this.dgvDSSanPham.ReadOnly = true;
            this.dgvDSSanPham.RowHeadersWidth = 51;
            this.dgvDSSanPham.Size = new System.Drawing.Size(664, 351);
            this.dgvDSSanPham.TabIndex = 11;
            this.dgvDSSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSanPham_CellContentClick);
            // 
            // STTSanPham
            // 
            this.STTSanPham.HeaderText = "STT";
            this.STTSanPham.MinimumWidth = 6;
            this.STTSanPham.Name = "STTSanPham";
            this.STTSanPham.ReadOnly = true;
            // 
            // TSP
            // 
            this.TSP.HeaderText = "Tên sản phẩm";
            this.TSP.MinimumWidth = 6;
            this.TSP.Name = "TSP";
            this.TSP.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DG
            // 
            this.DG.HeaderText = "Đơn giá";
            this.DG.MinimumWidth = 6;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            // 
            // TT
            // 
            this.TT.HeaderText = "Thành tiền";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSDonHang);
            this.groupBox1.Location = new System.Drawing.Point(4, 421);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(927, 374);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơng hàng";
            // 
            // dgvDSDonHang
            // 
            this.dgvDSDonHang.AllowUserToAddRows = false;
            this.dgvDSDonHang.AllowUserToDeleteRows = false;
            this.dgvDSDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDH,
            this.NDH,
            this.NgayDuKienGiao,
            this.NNH,
            this.TTDH,
            this.LyDo,
            this.PTTT,
            this.NVGH,
            this.CPVN});
            this.dgvDSDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDonHang.Location = new System.Drawing.Point(4, 19);
            this.dgvDSDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSDonHang.Name = "dgvDSDonHang";
            this.dgvDSDonHang.ReadOnly = true;
            this.dgvDSDonHang.RowHeadersWidth = 51;
            this.dgvDSDonHang.Size = new System.Drawing.Size(919, 351);
            this.dgvDSDonHang.TabIndex = 2;
            this.dgvDSDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonHang_CellClick);
            this.dgvDSDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonHang_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaDH
            // 
            this.MaDH.HeaderText = "Mã đơn hàng";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.ReadOnly = true;
            // 
            // NDH
            // 
            this.NDH.HeaderText = "Ngày đặt hàng";
            this.NDH.MinimumWidth = 6;
            this.NDH.Name = "NDH";
            this.NDH.ReadOnly = true;
            // 
            // NgayDuKienGiao
            // 
            this.NgayDuKienGiao.HeaderText = "Ngày dự kiến giao hàng";
            this.NgayDuKienGiao.MinimumWidth = 6;
            this.NgayDuKienGiao.Name = "NgayDuKienGiao";
            this.NgayDuKienGiao.ReadOnly = true;
            // 
            // NNH
            // 
            this.NNH.HeaderText = "Ngày xác nhận đã nhận hàng";
            this.NNH.MinimumWidth = 6;
            this.NNH.Name = "NNH";
            this.NNH.ReadOnly = true;
            // 
            // TTDH
            // 
            this.TTDH.HeaderText = "Tình trạng đơn hàng";
            this.TTDH.MinimumWidth = 6;
            this.TTDH.Name = "TTDH";
            this.TTDH.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // PTTT
            // 
            this.PTTT.HeaderText = "Phương thức thanh toán";
            this.PTTT.MinimumWidth = 6;
            this.PTTT.Name = "PTTT";
            this.PTTT.ReadOnly = true;
            // 
            // NVGH
            // 
            this.NVGH.HeaderText = "Nhân viên giao hàng";
            this.NVGH.MinimumWidth = 6;
            this.NVGH.Name = "NVGH";
            this.NVGH.ReadOnly = true;
            // 
            // CPVN
            // 
            this.CPVN.HeaderText = "Chi phí vận chuyển";
            this.CPVN.MinimumWidth = 6;
            this.CPVN.Name = "CPVN";
            this.CPVN.ReadOnly = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(159, 26);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(232, 32);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Nguyễn Văn Test";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVNNhaNam.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(1385, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(135, 130);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.ReadOnly = true;
            this.txtMaDH.Size = new System.Drawing.Size(153, 22);
            this.txtMaDH.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phương thức thanh toán";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(1003, 31);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(172, 33);
            this.btnlogout.TabIndex = 20;
            this.btnlogout.Text = "Đăng xuất";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // GiaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 833);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiaoKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoKhachHang";
            this.Load += new System.EventHandler(this.GiaoKhachHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSDonHang;
        private System.Windows.Forms.DataGridView dgvDSSanPham;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxPTTT;
        private System.Windows.Forms.Button btnKhieuBai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnYeuTH;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Button btnDoiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDuKienGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPVN;
        private System.Windows.Forms.Button btnlogout;
    }
}
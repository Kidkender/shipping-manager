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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnKhieuBai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.lblUserName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1358, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(117, 22);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(111, 16);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Nguyễn Văn Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xin chào";
            // 
            // dgvDSDonHang
            // 
            this.dgvDSDonHang.AllowUserToDeleteRows = false;
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
            this.dgvDSDonHang.Location = new System.Drawing.Point(23, 29);
            this.dgvDSDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSDonHang.Name = "dgvDSDonHang";
            this.dgvDSDonHang.RowHeadersWidth = 51;
            this.dgvDSDonHang.Size = new System.Drawing.Size(1216, 346);
            this.dgvDSDonHang.TabIndex = 13;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // MaDH
            // 
            this.MaDH.HeaderText = "Mã đơn hàng";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.Width = 125;
            // 
            // NDH
            // 
            this.NDH.HeaderText = "Ngày đặt hàng";
            this.NDH.MinimumWidth = 6;
            this.NDH.Name = "NDH";
            this.NDH.Width = 125;
            // 
            // NgayDuKienGiao
            // 
            this.NgayDuKienGiao.HeaderText = "Ngày dự kiến giao hàng";
            this.NgayDuKienGiao.MinimumWidth = 6;
            this.NgayDuKienGiao.Name = "NgayDuKienGiao";
            this.NgayDuKienGiao.Width = 125;
            // 
            // NNH
            // 
            this.NNH.HeaderText = "Ngày xác nhận đã nhận hàng";
            this.NNH.MinimumWidth = 6;
            this.NNH.Name = "NNH";
            this.NNH.Width = 125;
            // 
            // TTDH
            // 
            this.TTDH.HeaderText = "Tình trạng đơn hàng";
            this.TTDH.MinimumWidth = 6;
            this.TTDH.Name = "TTDH";
            this.TTDH.Width = 125;
            // 
            // LyDo
            // 
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 125;
            // 
            // PTTT
            // 
            this.PTTT.HeaderText = "Phương thức thanh toán";
            this.PTTT.MinimumWidth = 6;
            this.PTTT.Name = "PTTT";
            this.PTTT.Width = 125;
            // 
            // NVGH
            // 
            this.NVGH.HeaderText = "Nhân viên giao hàng";
            this.NVGH.MinimumWidth = 6;
            this.NVGH.Name = "NVGH";
            this.NVGH.Width = 125;
            // 
            // CPVN
            // 
            this.CPVN.HeaderText = "Chi phí vận chuyển";
            this.CPVN.MinimumWidth = 6;
            this.CPVN.Name = "CPVN";
            this.CPVN.Width = 125;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(23, 410);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(221, 58);
            this.btnXacNhan.TabIndex = 18;
            this.btnXacNhan.Text = "Xác nhận đơn hàng đã giao";
            this.btnXacNhan.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thống kê danh sách đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 410);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 58);
            this.button2.TabIndex = 21;
            this.button2.Text = "Danh sách đơn hàng cần giao trong ngày";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(828, 410);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 58);
            this.button3.TabIndex = 22;
            this.button3.Text = "Danh sách đơn hàng cần nhận (đổi/trả) ";
            this.button3.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDSDonHang;
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
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKhieuBai;
    }
}
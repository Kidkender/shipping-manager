namespace QLVNNhaNam
{
    partial class NhapLyDo
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
            this.noteLyDo = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDSDonHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDuKienGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // noteLyDo
            // 
            this.noteLyDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLyDo.Location = new System.Drawing.Point(4, 19);
            this.noteLyDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noteLyDo.Name = "noteLyDo";
            this.noteLyDo.Size = new System.Drawing.Size(581, 373);
            this.noteLyDo.TabIndex = 0;
            this.noteLyDo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noteLyDo);
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(589, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập lý do đổi/trả đơn hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 759);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gửi lý do đổi/trả đơn hàng.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.CPVN});
            this.dgvDSDonHang.Location = new System.Drawing.Point(20, 457);
            this.dgvDSDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSDonHang.Name = "dgvDSDonHang";
            this.dgvDSDonHang.RowHeadersWidth = 51;
            this.dgvDSDonHang.Size = new System.Drawing.Size(1097, 276);
            this.dgvDSDonHang.TabIndex = 3;
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
            this.NgayDuKienGiao.HeaderText = "Ngày xác nhận đã nhận hàng.";
            this.NgayDuKienGiao.MinimumWidth = 6;
            this.NgayDuKienGiao.Name = "NgayDuKienGiao";
            this.NgayDuKienGiao.Width = 125;
            // 
            // NNH
            // 
            this.NNH.HeaderText = "Ngày đổi/trả dự kiến";
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
            // CPVN
            // 
            this.CPVN.HeaderText = "Chi phí vận chuyển";
            this.CPVN.MinimumWidth = 6;
            this.CPVN.Name = "CPVN";
            this.CPVN.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 759);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Gửi yêu cầu đổi/trả đơn hàng.";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NhapLyDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 880);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDSDonHang);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhapLyDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập lý do";
            this.Load += new System.EventHandler(this.NhapLyDo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox noteLyDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvDSDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDuKienGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPVN;
        private System.Windows.Forms.Button button3;
    }
}
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // noteLyDo
            // 
            this.noteLyDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLyDo.Location = new System.Drawing.Point(3, 16);
            this.noteLyDo.Name = "noteLyDo";
            this.noteLyDo.Size = new System.Drawing.Size(820, 125);
            this.noteLyDo.TabIndex = 0;
            this.noteLyDo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noteLyDo);
            this.groupBox1.Location = new System.Drawing.Point(20, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập lý do đổi/trả đơn hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gửi lý do đổi/trả đơn hàng.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.CPVN});
            this.dgvDSDonHang.Location = new System.Drawing.Point(20, 39);
            this.dgvDSDonHang.Name = "dgvDSDonHang";
            this.dgvDSDonHang.ReadOnly = true;
            this.dgvDSDonHang.RowHeadersWidth = 51;
            this.dgvDSDonHang.Size = new System.Drawing.Size(823, 335);
            this.dgvDSDonHang.TabIndex = 3;
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
            this.NgayDuKienGiao.HeaderText = "Ngày xác nhận đã nhận hàng.";
            this.NgayDuKienGiao.MinimumWidth = 6;
            this.NgayDuKienGiao.Name = "NgayDuKienGiao";
            this.NgayDuKienGiao.ReadOnly = true;
            // 
            // NNH
            // 
            this.NNH.HeaderText = "Ngày đổi/trả dự kiến";
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
            // CPVN
            // 
            this.CPVN.HeaderText = "Chi phí vận chuyển";
            this.CPVN.MinimumWidth = 6;
            this.CPVN.Name = "CPVN";
            this.CPVN.ReadOnly = true;
            // 
            // NhapLyDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 633);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDSDonHang);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhapLyDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
    }
}
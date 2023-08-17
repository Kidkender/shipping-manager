namespace QLVNNhaNam
{
    partial class KhieuNaiDonHang
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
            this.txtkn = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteLyDo
            // 
            this.noteLyDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLyDo.Location = new System.Drawing.Point(0, 0);
            this.noteLyDo.Name = "noteLyDo";
            this.noteLyDo.Size = new System.Drawing.Size(826, 517);
            this.noteLyDo.TabIndex = 1;
            this.noteLyDo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtkn);
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 322);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập lý do khiếu nại đơn hàng";
            // 
            // txtkn
            // 
            this.txtkn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtkn.Location = new System.Drawing.Point(3, 16);
            this.txtkn.Name = "txtkn";
            this.txtkn.Size = new System.Drawing.Size(436, 303);
            this.txtkn.TabIndex = 0;
            this.txtkn.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Gửi yêu cầu khiếu nại đơn hàng.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KhieuNaiDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.noteLyDo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KhieuNaiDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KhieuNaiDonHang";
            this.Load += new System.EventHandler(this.KhieuNaiDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox noteLyDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtkn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}
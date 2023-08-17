using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVNNhaNam
{
    public partial class KhieuNaiDonHang : Form
    {
        QLVC_NhaNamv2Entities conectionDB = new QLVC_NhaNamv2Entities();
      
        public string maDh =null;
    
        public string EmailNV { get; set; }

        public KhieuNaiDonHang()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string noiDung = txtkn.Text; // Lấy nội dung từ TextBox

            if ( string.IsNullOrWhiteSpace(noiDung))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin để cập nhật nội dung.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


           

            try
            {
                var orderToUpdate = conectionDB.DonHangs.FirstOrDefault(dh => dh.MaDH == maDh);

                if (orderToUpdate != null)
                {
                    orderToUpdate.LyDo = noiDung;
                    conectionDB.SaveChanges();

                    MessageBox.Show("Cập nhật nội dung thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã đơn hàng để cập nhật nội dung.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }

        private void KhieuNaiDonHang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoanNhanVienGIaoHang frmnv = new TaiKhoanNhanVienGIaoHang(EmailNV);
            frmnv.Show();
            this.Hide();
        }
    }
}

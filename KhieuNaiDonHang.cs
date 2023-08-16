using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVNNhaNam
{
    public partial class KhieuNaiDonHang : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=QLVC_NhaNamv2;User ID=sa;Password=1";

        public string maDh =null;
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


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE DonHang SET LyDo = @LyDo WHERE MaDH = @MaDH";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LyDo", noiDung);
                    command.Parameters.AddWithValue("@MaDH", maDh);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật nội dung thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã đơn hàng để cập nhật nội dung.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void KhieuNaiDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVNNhaNam
{
    public partial class DangNhap_Khach : Form
    {
        string connectionString = "Data Source=21.241.123.176,1433;Initial Catalog=QLVC_NhaNamv2;User ID=sa;Password=123";

        public DangNhap_Khach()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndn_Click(object sender, EventArgs e)
        {
            string email = txtuser.Text;
            string password = txtpass.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn kiểm tra tài khoản
                string query = "SELECT COUNT(*) FROM TaiKhoanKhachHang WHERE EmailNV = @Email AND MatKhau = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        GiaoKhachHang gkh = new GiaoKhachHang();
                        gkh.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại email và mật khẩu.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dnk = new DangNhap();
            dnk.Show();
        }
    }
}

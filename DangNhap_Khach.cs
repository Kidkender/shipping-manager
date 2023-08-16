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
    public partial class DangNhap_Khach : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=QLVC_NhaNamv2;User ID=sa;Password=1";

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
            string makh = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn kiểm tra tài khoản
                string query = "SELECT COUNT(*) FROM TaiKhoanKhachHang WHERE EmailKH = @Email AND MatKhau = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        makh=GetMaKHByEmail(email);

                        GiaoKhachHang gkh = new GiaoKhachHang();
                        gkh.maKH = makh;
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

        public string GetMaKHByEmail(string email)
        {
            string maKH = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MaKH FROM TaiKhoanKhachHang WHERE EmailKH = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maKH = reader["MaKH"].ToString();
                        }
                    }
                }
            }

            return maKH;
        }

        private void DangNhap_Khach_Load(object sender, EventArgs e)
        {

        }
    }
}

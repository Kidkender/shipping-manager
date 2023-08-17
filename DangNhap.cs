using QLVNNhaNam.Service;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLVNNhaNam
{
    public partial class DangNhap : Form

    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectDB"].ConnectionString;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
                    }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;

            SQLService sql = new SQLService();
            var result = sql.DangNhap(email, password);
            if (result)
            {
                MessageBox.Show("Đăng nhập thành công!");
                TaiKhoanNhanVienGIaoHang taiKhoanNhanVienGiaoHangForm = new TaiKhoanNhanVienGIaoHang(email);
                taiKhoanNhanVienGiaoHangForm.emailNv = email;
                taiKhoanNhanVienGiaoHangForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại email và mật khẩu.");
            }
        }

        private void btnwithguess_Click(object sender, EventArgs e)
        {
            DangNhap_Khach dnk = new DangNhap_Khach();
            dnk.Show();
            this.Hide();
        }
    }
}

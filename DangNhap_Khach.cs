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

namespace QLVNNhaNam
{
    public partial class DangNhap_Khach : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectDB"].ConnectionString;

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
            string makh = "";

            SQLService sql = new SQLService();
            makh = sql.DangNhap_Khach1(email, password);
            if (!string.IsNullOrEmpty(makh))
            {
                MessageBox.Show("Đăng nhập thành công!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dnk = new DangNhap();
            dnk.Show();
            this.Hide();
        }

        private void DangNhap_Khach_Load(object sender, EventArgs e)
        {

        }
    }
}

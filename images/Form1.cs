using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAMH__2321112005604_LTC_NET_Nhom6
{
    public partial class Frm_LogIn : Form
    {
        public Frm_LogIn()
        {
            InitializeComponent();
        }

        //Sau khi điền đầy đủ thông tin và chọn button đăng nhập:
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Nếu người dùng chọn phân quyền là khách hàng:
            if (rbtnNVGH.Checked)
            {
                TaiKhoanNhanVien.LogInNhanVien(txtEmail, txtPasswword, rbtnNVGH, this);
            }
            //Nếu người dùng chọn phân quyền là nhân viên quản lý:
            if (rbtnNVQL.Checked)
            {
                TaiKhoanNhanVien.LogInNhanVien(txtEmail, txtPasswword, rbtnNVQL,this);
            }
            //Nếu người dùng chọn phân quyền là nhân viên giao hàng:
            if (rbtnKH.Checked)
            {
                TaiKhoanKhachHang.LogInKhachHang(txtEmail, txtPasswword, this);
            }    
        }
        //Ẩn hiện button đăng nhập khi thay đổi email, mật khẩu hoặc radio button:
        private void txtPasswword_TextChanged(object sender, EventArgs e)
        {
            if (rbtnKH.Checked || rbtnNVGH.Checked || rbtnNVQL.Checked)
            {
                if (txtEmail.Text != "" && txtPasswword.Text != "")
                    btnLogin.Enabled = true;
                else btnLogin.Enabled = false;

            }
            else btnLogin.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (rbtnKH.Checked || rbtnNVGH.Checked || rbtnNVQL.Checked)
            {
                if (txtEmail.Text != "" && txtPasswword.Text != "")
                    btnLogin.Enabled = true;
                else btnLogin.Enabled = false;
            }
            else btnLogin.Enabled = false;
        }

        //Khi chọn button thoát:
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }

        private void Frm_LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}

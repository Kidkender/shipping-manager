using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVNNhaNam.Class
{
    public partial class TaiKhoanNhanVien
    {
        //Phương thức đăng nhập theo hệ thống theo chức vụ nhân viên:
        //public static void LogInNhanVien(TextBox txtemail, TextBox txtpass, RadioButton rbtn, Form login)
        //{
        //    try
        //    {
        //        using (var db = new QLVC_NhaNamEntities())
        //        {
        //            //Lấy ra mã nhân viên nếu đúng email, mật khẩu và chức vụ
        //            var result = from tk in db.TaiKhoanNhanViens.Where(tk => tk.EmailNV == txtemail.Text && tk.MatKhau == txtpass.Text && tk.NhanVien.ChucVu == rbtn.Text) select tk.MaNV;
        //            //Lấy ra mật khẩu tài khoản trong cơ sở dữ liệu
        //            var passw = from tk in db.TaiKhoanNhanViens.Where(tk => tk.EmailNV == txtemail.Text) select tk.MatKhau;
        //            //Nếu tồn tại kq manv khác null và chức vụ là nvql thì hiện home dành cho nvql và ẩn giao diện login
        //            if (result.ToList().Count > 0 && rbtn.Text == "Nhân viên quản lý")
        //            {

        //                //Khai báo home nvql:
        //                Home_TrangChuNhanVienQuanLy homequanly = new Home_TrangChuNhanVienQuanLy();
        //                homequanly.Message = txtemail.Text;
        //                homequanly.Login = login;
        //                txtemail.Text = txtpass.Text = "";
        //                login.Hide();
        //                homequanly.ShowDialog();

        //            }
        //            ///Nếu tồn tại kq manv khác null và chức vụ là nvql thì hiện home dành cho nvgh và ẩn giao diện login
        //            else if (result.ToList().Count > 0 && rbtn.Text == "Nhân viên giao hàng")
        //            {

        //                //Khái báo home nvgh:
        //                Home_TrangChuNhanVienGiaoHang homenvgiaohang = new Home_TrangChuNhanVienGiaoHang();
        //                homenvgiaohang.Message = txtemail.Text;
        //                homenvgiaohang.Login = login;
        //                txtemail.Text = txtpass.Text = "";
        //                login.Hide();
        //                homenvgiaohang.ShowDialog();
        //            }
        //            //Nếu tài khoản null và password cũng null thì thông báo
        //            else if (result.ToList().Count == 0 && passw.ToList().Count == 0)
        //            {
        //                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo");
        //            }
        //            //Nếu sai mật khẩu thì hiện thông báo
        //            else if (passw.ToString() != txtpass.Text)
        //            {
        //                MessageBox.Show("Sai mật khẩu!", "Thông báo");
        //                txtpass.Focus();
        //                txtpass.Clear();
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }

    public partial class TaiKhoanKhachHang
    {
        //public static void LogInKhachHang(TextBox txtemail, TextBox txtpass, Form login)
        //{
        //    try
        //    {
        //        using (var db = new QLVC_NhaNamEntities())
        //        {
        //            //Lấy ra mã khách hàng nếu đúng email, mật khẩu:
        //            var result = from tk in db.TaiKhoanKhachHangs.Where(tk => tk.EmailKH == txtemail.Text && tk.MatKhau == txtpass.Text) select tk.MaKH;
        //            //Lấy ra mật khẩu tài khoản trong cơ sở dữ liệu:
        //            var passw = from tk in db.TaiKhoanKhachHangs.Where(tk => tk.EmailKH == txtemail.Text) select tk.MatKhau;
        //            //Nếu tồn tại kq manv khác null và chức vụ là nvql thì hiện home dành cho khách hàng và ẩn giao diện login:
        //            if (result.ToList().Count > 0)
        //            {

        //                //Khái báo home khách hàng:
        //                var homekhachhang = new Home_TrangChuKhachHang();
        //                homekhachhang.Message = txtemail.Text;
        //                homekhachhang.Login = login;
        //                txtemail.Text = txtpass.Text = "";
        //                login.Close();
        //                homekhachhang.ShowDialog();

        //                txtemail.Text = txtpass.Text = "";
        //            }
        //            //Nếu tài khoản null và passwor cũng null thì thông báo
        //            else if (result.ToList().Count == 0 && passw.ToList().Count == 0)
        //            {
        //                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo");
        //            }
        //            //Nếu sai mật khẩu thì hiện thông báo
        //            else if (passw.ToString() != txtpass.Text)
        //            {
        //                MessageBox.Show("Sai mật khẩu!", "Thông báo");
        //                txtpass.Focus();
        //                txtpass.Clear();
        //            }



        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

    }
}

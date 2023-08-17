using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QLVNNhaNam.Service
{
    public class SQLService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectDB"].ConnectionString;

        public bool DangNhap1(string email,string password)
        {
            try
            {
                using (var context = new QLVC_NhaNamv2Entities())
                {
                    // Truy vấn kiểm tra tài khoản
                    var count = context.TaiKhoanNhanViens
                        .Where(tk => tk.EmailNV == email && tk.MatKhau == password)
                        .Count();

                    return count > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public string DangNhap_Khach1(string email,string password)
        {
            try
            {
                using (var context = new QLVC_NhaNamv2Entities())
                {
                    var account = context.TaiKhoanKhachHangs
                        .FirstOrDefault(tk => tk.EmailKH == email && tk.MatKhau == password);

                    if (account != null)
                    {
                        return account.MaKH;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception)
            {
                return "";
            }


        }

        public string GetMaKHByEmail1(string email)
        {
            using (QLVC_NhaNamv2Entities context = new QLVC_NhaNamv2Entities())
            {
                var taiKhoan = context.TaiKhoanKhachHangs.FirstOrDefault(tk => tk.EmailKH == email);

                if (taiKhoan != null)
                {
                    return taiKhoan.MaKH;
                }
            }

            return null;
        }




        public DataTable LoadOrderData1(string email)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (QLVC_NhaNamv2Entities context = new QLVC_NhaNamv2Entities())
                {
                    var query = from dh in context.DonHangs
                                join nv in context.NhanViens on dh.MaNV equals nv.MaNV
                                where nv.EmailNV == email
                                select new
                                {
                                    dh.MaDH,
                                    dh.Ngaydathang,
                                    dh.Ngaydukiengiao,
                                    dh.NgayNhanHang,
                                    dh.TinhtrangDH,
                                    dh.LyDo,
                                    dh.PTTT,
                                    dh.ChiphiVC
                                };

                    var result = query.ToList();

                    dataTable.Columns.Add("STT");
                    dataTable.Columns.Add("MaDH", typeof(string));
                    dataTable.Columns.Add("Ngaydathang", typeof(DateTime));
                    dataTable.Columns.Add("Ngaydukiengiao", typeof(DateTime));
                    dataTable.Columns.Add("NgayNhanHang", typeof(DateTime));
                    dataTable.Columns.Add("TinhtrangDH", typeof(string));
                    dataTable.Columns.Add("LyDo", typeof(string));
                    dataTable.Columns.Add("PTTT", typeof(string));
                    dataTable.Columns.Add("ChiphiVC", typeof(double));

                    int index = 1;
                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            index,
                            item.MaDH,
                            item.Ngaydathang,
                            item.Ngaydukiengiao,
                            item.NgayNhanHang,
                            item.TinhtrangDH,
                            item.LyDo,
                            item.PTTT,
                            item.ChiphiVC
                        );
                        index++;
                    }
                }
            }
            catch (Exception)
            {
            }
            return dataTable;
        }




        public string LoadEmployeeInfo1(string email)
        {
            string result = "";
            try
            {
                using (QLVC_NhaNamv2Entities context = new QLVC_NhaNamv2Entities())
                {
                    var query = from nv in context.NhanViens
                                where nv.EmailNV == email
                                select nv.TenNV;

                    result = query.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }



        public bool UpdateTinhTrangDH1(string maDH)
        {
            bool result = false;
            try
            {
                DateTime currentDate = DateTime.Now;
                DateTime currentDateOnly = DateTime.Today;

                DateTime today = DateTime.Today;

                using (QLVC_NhaNamv2Entities context = new QLVC_NhaNamv2Entities())
                {
                    var donHang = context.DonHangs.FirstOrDefault(dh => dh.MaDH == maDH);
                    if (donHang != null)
                    {
                        donHang.TinhtrangDH = "đã giao";
                        donHang.NgayNhanHang = currentDate;
                        context.SaveChanges();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }


        public DataTable LoadOrderData_Now1(string email)
        {
            DataTable dataTable = new DataTable();
            try
            {
                DateTime today = DateTime.Today;
                DateTime currentDate = DateTime.Now;
                DateTime currentDateOnly = DateTime.Today;
                Console.WriteLine("Dang test ngay", currentDateOnly);
                using (QLVC_NhaNamv2Entities context = new QLVC_NhaNamv2Entities())
                {
                    var query = from dh in context.DonHangs
                    join nv in context.NhanViens on dh.MaNV equals nv.MaNV
                                where nv.EmailNV == email && dh.Ngaydukiengiao.Value == DateTime.Today
                                select dh;

                    dataTable.Columns.Add("STT");
                    dataTable.Columns.Add("MaDH", typeof(string));
                    dataTable.Columns.Add("Ngaydathang", typeof(DateTime));
                    dataTable.Columns.Add("Ngaydukiengiao", typeof(DateTime));
                    dataTable.Columns.Add("NgayNhanHang", typeof(DateTime));
                    dataTable.Columns.Add("TinhtrangDH", typeof(string));
                    dataTable.Columns.Add("LyDo", typeof(string));
                    dataTable.Columns.Add("PTTT", typeof(string));
                    dataTable.Columns.Add("ChiphiVC", typeof(double));
                    var result = query.ToList();

                    int index = 1;
                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            index,
                            item.MaDH,
                            item.Ngaydathang,
                            item.Ngaydukiengiao,
                            item.NgayNhanHang,
                            item.TinhtrangDH,
                            item.LyDo,
                            item.PTTT,
                            item.ChiphiVC
                        );
                        index++;
                    }
                }
            }
            catch (Exception)
            {
            }
            return dataTable;
        }




        public DataTable LoadOrderData_DoiHang1(string email)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (QLVC_NhaNamv2Entities context = new QLVC_NhaNamv2Entities())
                {
                    var query = from dh in context.DonHangs
                                join nv in context.NhanViens on dh.MaNV equals nv.MaNV
                                where nv.EmailNV == email && (dh.TinhtrangDH.Contains("đổi") || dh.TinhtrangDH.Contains("trả")) 
                                select new
                                {
                                    dh.MaDH,
                                    dh.Ngaydathang,
                                    dh.Ngaydukiengiao,
                                    dh.NgayNhanHang,
                                    dh.TinhtrangDH,
                                    dh.LyDo,
                                    dh.PTTT,
                                    dh.ChiphiVC
                                };

                    var result = query.ToList();

                    dataTable.Columns.Add("STT");
                    dataTable.Columns.Add("MaDH", typeof(string));
                    dataTable.Columns.Add("Ngaydathang", typeof(DateTime));
                    dataTable.Columns.Add("Ngaydukiengiao", typeof(DateTime));
                    dataTable.Columns.Add("NgayNhanHang", typeof(DateTime));
                    dataTable.Columns.Add("TinhtrangDH", typeof(string));
                    dataTable.Columns.Add("LyDo", typeof(string));
                    dataTable.Columns.Add("PTTT", typeof(string));
                    dataTable.Columns.Add("ChiphiVC", typeof(double));

                    int index = 1;
                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            index,
                            item.MaDH,
                            item.Ngaydathang,
                            item.Ngaydukiengiao,
                            item.NgayNhanHang,
                            item.TinhtrangDH,
                            item.LyDo,
                            item.PTTT,
                            item.ChiphiVC
                        );
                        index++;
                    }
                }
            }
            catch (Exception)
            {
            }
            return dataTable;
        }

    }
}

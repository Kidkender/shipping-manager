using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVNNhaNam.Class
{
    public class TinhThoiGian
    {
    //    /// <summary>
    //    /// Tính thời gian dự kiến nhận hàng của đơn hàng
    //    /// </summary>
    //    public static void TinhTGNhanDuKien()
    //    {
    //        try
    //        {
    //            using (var db = new QLVC_NhaNamEntities())
    //            {
    //                //Đổ từ sql vào list:
    //                var dsdh = db.DonHangs.Include("Donvivanchuyen").Include("KhachHang").ToList();

    //                //Dùng vòng lặp để tính ngày dự kiến giao của từng đơn hàng:
    //                foreach (var d in dsdh)
    //                {
    //                    //Đơn hàng do nhân viên giao hàng thuộc đơn vị Giao hàng tiết kiệm, ViettelPost, Giao Hàng Nhanh giao:
    //                    //Nếu địa chỉ khách hàng thuộc Hồ Chí Minh hoặc Hà Nội thì ngày dự kiến giao hàng là 3 ngày kể từ ngày đặt hàng. 
    //                    //Nếu địa chỉ khác thì ngày dự kiến giao hàng là 5 ngày kể từ ngày đặt hàng.
    //                    if (d.TenDV == "Giao hàng tiết kiệm" ||
    //                        d.Donvivanchuyen.TenDV == "ViettelPost" ||
    //                        d.Donvivanchuyen.TenDV == "Giao Hàng Nhanh")
    //                    {
    //                        if (d.KhachHang.DiaChiKH.Contains("HCM") || d.KhachHang.DiaChiKH.Contains("Hà Nội"))
    //                        {
    //                            d.Ngaydukiengiao = Convert.ToDateTime(d.Ngaydathang).AddDays(3);
    //                        }
    //                        else d.Ngaydukiengiao = Convert.ToDateTime(d.Ngaydathang).AddDays(5);
    //                    }
    //                    //Đơn hàng do nhân viên giao hàng thuộc đơn vị J & T Express giao: 
    //                    //Nếu địa chỉ khách hàng thuộc Hồ Chí Minh hoặc Hà Nội thì ngày dự kiến giao hàng là 3 ngày kể từ ngày đặt hàng. 
    //                    //Nếu địa chỉ khác thì ngày dự kiến giao hàng là 6 ngày kể từ ngày đặt hàng.
    //                    else if (d.Donvivanchuyen.TenDV == "J&T Express")
    //                    {
    //                        if (d.KhachHang.DiaChiKH.Contains("HCM") || d.KhachHang.DiaChiKH.Contains("Hà Nội"))
    //                        {
    //                            d.Ngaydukiengiao = Convert.ToDateTime(d.Ngaydathang).AddDays(3);
    //                        }
    //                        else d.Ngaydukiengiao = Convert.ToDateTime(d.Ngaydathang).AddDays(6);
    //                    }
    //                    //Đơn hàng do nhân viên giao hàng thuộc đơn vị Ahamove, GrabExpress, Lalamove, Nhã Nam giao:
    //                    //Nếu địa chỉ khách hàng thuộc Hồ Chí Minh hoặc Hà Nội thì ngày dự kiến giao hàng là ngày đặt hàng.
    //                    else if (d.Donvivanchuyen.TenDV == "Ahamove" ||
    //                            d.Donvivanchuyen.TenDV == "GrabExpress" ||
    //                            d.Donvivanchuyen.TenDV == "Lalamove" ||
    //                            d.Donvivanchuyen.TenDV == "Nhã Nam")
    //                    {
    //                        d.Ngaydukiengiao = d.Ngaydathang;
    //                    }
    //                    //Đơn hàng do nhân viên giao hàng thuộc Bưu điện giao:
    //                    //ngày dự kiến giao hàng là 5 ngày kể từ ngày đặt hàng.
    //                    else if (d.Donvivanchuyen.TenDV == "Bưu điện Việt Nam")
    //                    {
    //                        d.Ngaydukiengiao = Convert.ToDateTime(d.Ngaydathang).AddDays(5);
    //                    }

    //                    //Tìm đơn hàng có thông tin tương ứng trong csdl sau đó lưu lại ngày dự kiến giao:
    //                    DonHang dh = db.DonHangs.Where(don => don.MaDH == d.MaDH).FirstOrDefault();
    //                    dh.Ngaydukiengiao = d.Ngaydukiengiao;
    //                    db.SaveChanges();
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }
    //    }
    
    }
}

using QLVNNhaNam.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVNNhaNam
{
    public partial class ThaoTacHuyDon : Form
    {
        public delegate void DataSavedHandler();
        public event DataSavedHandler OnDataSaved;
        QLVC_NhaNamv2Entities conectionDB = new QLVC_NhaNamv2Entities();

        public string maDH { get; set; }
        public string tinhTrang { get; set; }
        public ThaoTacHuyDon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(noteLyDo.Text))
                {
                    MessageBox.Show("Vui lòng nhập lý do");
                    return;
                }


                DialogResult result = MessageBox.Show(EnumField.MessageHuyDon, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xử lý khi người dùng nhấn "Yes"
                    var query = (from dh in conectionDB.DonHangs
                                 join nv in conectionDB.NhanViens on dh.MaNV equals nv.MaNV
                                 join dv in conectionDB.Donvivanchuyens on nv.MaDV equals dv.MaDV
                                 join kh in conectionDB.KhachHangs on dh.MaKH equals kh.MaKH
                                 where dh.MaDH == maDH
                                 select new
                                 {
                                     dh.MaDH,
                                     TenDonViVanChuyen = dv.TenDV,
                                     DiaChiKhachHang = kh.DiaChiKH
                                 }).FirstOrDefault();
                    if (query != null)
                    {
                        var data = conectionDB.DonHangs.Where(x => x.MaDH == maDH).FirstOrDefault();
                        data.TinhtrangDH = tinhTrang;
                        data.LyDo = noteLyDo.Text.ToString().Trim();

                        var isDoiHang = tinhTrang.ToString() == EnumField.DoiHuyDon;


                        //Đơn hàng do nhân viên giao hàng thuộc đơn vị Giao hàng tiết kiệm, ViettelPost, Giao Hàng Nhanh giao:
                        //Nếu địa chỉ khách hàng thuộc Hồ Chí Minh hoặc Hà Nội thì ngày dự kiến giao hàng là 3 ngày kể từ ngày đặt hàng. 
                        //Nếu địa chỉ khác thì ngày dự kiến giao hàng là 5 ngày kể từ ngày đặt hàng.

                        if (isDoiHang)
                        {
                            var doubleDay = 2;
                            if (query.TenDonViVanChuyen == "Giao hàng tiết kiệm" || query.TenDonViVanChuyen == "ViettelPost" ||
                         query.TenDonViVanChuyen == "Giao Hàng Nhanh")
                            {
                                if (query.DiaChiKhachHang.Contains("HCM") || query.DiaChiKhachHang.Contains("Hà Nội"))
                                {
                                    data.Ngaydukiengiao = Convert.ToDateTime(data.NgayNhanHang).AddDays(3 * doubleDay);
                                }
                                else data.Ngaydukiengiao = Convert.ToDateTime(data.NgayNhanHang).AddDays(5 * doubleDay);
                            }
                            //Đơn hàng do nhân viên giao hàng thuộc đơn vị J & T Express giao: 
                            //Nếu địa chỉ khách hàng thuộc Hồ Chí Minh hoặc Hà Nội thì ngày dự kiến giao hàng là 3 ngày kể từ ngày đặt hàng. 
                            //Nếu địa chỉ khác thì ngày dự kiến giao hàng là 6 ngày kể từ ngày đặt hàng.
                            else if (query.TenDonViVanChuyen == "J&T Express")
                            {
                                if (query.DiaChiKhachHang.Contains("HCM") || query.DiaChiKhachHang.Contains("Hà Nội"))
                                {
                                    data.Ngaydukiengiao = Convert.ToDateTime(data.NgayNhanHang).AddDays(3 * doubleDay);
                                }
                                else data.Ngaydukiengiao = Convert.ToDateTime(data.NgayNhanHang).AddDays(6 * doubleDay);
                            }
                            //Đơn hàng do nhân viên giao hàng thuộc đơn vị Ahamove, GrabExpress, Lalamove, Nhã Nam giao:
                            //Nếu địa chỉ khách hàng thuộc Hồ Chí Minh hoặc Hà Nội thì ngày dự kiến giao hàng là ngày đặt hàng.
                            else if (query.TenDonViVanChuyen == "Ahamove" ||
                                    query.TenDonViVanChuyen == "GrabExpress" ||
                                   query.TenDonViVanChuyen == "Lalamove" ||
                                    query.TenDonViVanChuyen == "Nhã Nam")
                            {
                                data.Ngaydukiengiao = data.NgayNhanHang;
                            }
                            //Đơn hàng do nhân viên giao hàng thuộc Bưu điện giao:
                            //ngày dự kiến giao hàng là 5 ngày kể từ ngày đặt hàng.
                            else if (query.TenDonViVanChuyen == "Bưu điện Việt Nam")
                            {
                                data.Ngaydukiengiao = Convert.ToDateTime(data.NgayNhanHang).AddDays(5 * doubleDay);
                            }
                        }
                        else
                        {
                            data.Ngaydukiengiao = null;
                        }



                        conectionDB.SaveChanges();

                        // Thông báo cho Form1
                        OnDataSaved?.Invoke();
                    }



                    // Đóng Form2
                    this.Close();

                }
                else if (result == DialogResult.No)
                {
                    return;
                }



            }
            catch (Exception ex)
            {


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

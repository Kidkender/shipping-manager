using QLVNNhaNam.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVNNhaNam
{
    public partial class GiaoKhachHang : Form
    {
        QLVC_NhaNamv2Entities conectionDB = new QLVC_NhaNamv2Entities();
        public string maKH ;

        public GiaoKhachHang()
        {
            InitializeComponent();
        }

        private void GiaoKhachHang_Load(object sender, EventArgs e)
        {
            this.reloadData();
        }


        private void dgvDSDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Đảm bảo người dùng không click vào tiêu đề cột và tiêu đề dòng
            {
                dgvDSSanPham.Rows.Clear();
                DataGridViewRow selectedRow = dgvDSDonHang.Rows[e.RowIndex];
                var maDH = selectedRow.Cells["MaDH"]?.Value.ToString();
                var pttt = selectedRow.Cells["PTTT"]?.Value.ToString();
                var tt = selectedRow.Cells["TTDH"]?.Value?.ToString();

                this.ResetButton(tt);

                txtMaDH.Text = maDH.ToString();
                cbxPTTT.Text = pttt.ToString();

                var result = conectionDB.ChiTietDHs.Include(db => db.SanPham).Where(x => x.MaDH == maDH)
                .Select(x => new
                {
                    TenSanPham = x.SanPham.TenSP,
                    SoLuong = x.SLDat,
                    DonGia = x.SanPham.Dongiaban,
                    ThanhTien = x.SLDat * x.SanPham.Dongiaban
                }).ToList();

                //Thêm dữ liệu vào DataGridView
                if (result.Count > 0 && result != null)
                {
                    int index = 1;
                    foreach (var item in result)
                    {
                        // Thêm dòng mới với dữ liệu cho từng cột tương ứng
                        dgvDSSanPham.Rows.Add(
                            index.ToString(),
                            item.TenSanPham,
                            item.SoLuong,
                            item.DonGia,
                            item.ThanhTien
                        );
                        index++;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin đơn hàng");
                return;

            }


            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                ThaoTacHuyDon form = new ThaoTacHuyDon();
                form.maDH = txtMaDH.Text;
                form.Text = "Lý do " + clickedButton.Text;
                form.tinhTrang = EnumField.DaNhanDon;
                form.OnDataSaved += reloadData;
                form.ShowDialog();
            }

        }

        private void button3_ClickAsync(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin đơn hàng");
                return;
            }


            DialogResult result = MessageBox.Show(EnumField.MessageNhanDon, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xử lý khi người dùng nhấn "Yes"
                var data = conectionDB.DonHangs.Where(x => x.MaDH == txtMaDH.Text).FirstOrDefault();
                data.TinhtrangDH = EnumField.DaNhanDon;
                data.NgayNhanHang = DateTime.Now;
                conectionDB.SaveChanges();
                this.reloadData();

            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        public void reloadData()
        {
            var khachHang = conectionDB.KhachHangs.FirstOrDefault(kh => kh.MaKH == maKH);
            if (khachHang != null)
            {
                lblUserName.Text = "Xin chào: " + khachHang.TenKH; // Hiển thị tên khách hàng trong Label
            }
            else
            {
                lblUserName.Text = "Khách hàng không tồn tại"; // Xử lý khi không tìm thấy mã khách hàng
            }

            dgvDSDonHang.Rows.Clear();

            var query = (from dh in conectionDB.DonHangs
                         join nv in conectionDB.NhanViens on dh.MaNV equals nv.MaNV
                         join dv in conectionDB.Donvivanchuyens on nv.MaDV equals dv.MaDV
                         join kh in conectionDB.KhachHangs on dh.MaKH equals kh.MaKH
                         where dh.MaKH == maKH
                         select new DonHangDTO
                         {
                             MaDH = dh.MaDH,
                             TenNV = nv.TenNV,
                             Ngaydathang = dh.Ngaydathang,
                             Ngaydukiengiao = dh.Ngaydukiengiao,
                             PTTT = dh.PTTT,
                             TinhtrangDH = dh.TinhtrangDH,
                             ChiphiVC = dh.ChiphiVC,
                             LyDo = dh.LyDo,
                             NgayNhanHang = dh.NgayNhanHang,
                             TenDV = dv.TenDV,
                             DiaChiKH = kh.DiaChiKH
                         }).ToList();


            var result = query.ToList();

            if (result.Count > 0 && result != null)
            {
                int index = 1;
                foreach (var item in result)
                {
                    // Thêm dòng mới với dữ liệu cho từng cột tương ứng

                    if (item.TinhtrangDH != EnumField.DoiHuyDon)
                    {

                        if (item.TenDV == "Giao hàng tiết kiệm" || item.TenDV == "ViettelPost" ||
                     item.TenDV == "Giao Hàng Nhanh")
                        {
                            if (item.DiaChiKH.Contains("HCM") || item.DiaChiKH.Contains("Hà Nội"))
                            {
                                item.Ngaydukiengiao = Convert.ToDateTime(item.Ngaydathang).AddDays(3);
                            }
                            else item.Ngaydukiengiao = Convert.ToDateTime(item.Ngaydathang).AddDays(5);
                        }
                        //Đơn hàng do nhân viên giao hàng thuộc đơn vị J & T Express giao: 
                        //Nếu địa chỉ khách hàng thuộc Hồ Chí Minh hoặc Hà Nội thì ngày dự kiến giao hàng là 3 ngày kể từ ngày đặt hàng. 
                        //Nếu địa chỉ khác thì ngày dự kiến giao hàng là 6 ngày kể từ ngày đặt hàng.
                        else if (item.TenDV == "J&T Express")
                        {
                            if (item.DiaChiKH.Contains("HCM") || item.DiaChiKH.Contains("Hà Nội"))
                            {
                                item.Ngaydukiengiao = Convert.ToDateTime(item.Ngaydathang).AddDays(3);
                            }
                            else item.Ngaydukiengiao = Convert.ToDateTime(item.Ngaydathang).AddDays(6);
                        }
                        //Đơn hàng do nhân viên giao hàng thuộc đơn vị Ahamove, GrabExpress, Lalamove, Nhã Nam giao:
                        //Nếu địa chỉ khách hàng thuộc Hồ Chí Minh hoặc Hà Nội thì ngày dự kiến giao hàng là ngày đặt hàng.
                        else if (item.TenDV == "Ahamove" ||
                                item.TenDV == "GrabExpress" ||
                                item.TenDV == "Lalamove" ||
                                item.TenDV == "Nhã Nam")
                        {
                            item.Ngaydukiengiao = item.Ngaydathang;
                        }
                        //Đơn hàng do nhân viên giao hàng thuộc Bưu điện giao:
                        //ngày dự kiến giao hàng là 5 ngày kể từ ngày đặt hàng.
                        else if (item.TenDV == "Bưu điện Việt Nam")
                        {
                            item.Ngaydukiengiao = Convert.ToDateTime(item.Ngaydathang).AddDays(5);
                        }
                    }


                    dgvDSDonHang.Rows.Add(
                        index.ToString(),
                        item.MaDH,
                        item.Ngaydathang?.ToString("dd/MM/yyyy"),
                        item.Ngaydukiengiao?.ToString("dd/MM/yyyy"),
                        item.NgayNhanHang?.ToString("dd/MM/yyyy"),
                        item.TinhtrangDH,
                        item.LyDo,
                        item.PTTT,
                        item.TenNV,
                        item.ChiphiVC.ToString()
                    );
                    index++;
                }
            }
        }

        private void ResetButton(string tt)
        {
            if (string.IsNullOrEmpty(tt))
            {
                this.btnKhieuBai.Enabled = false;
                this.btnYeuTH.Enabled = false;
                this.btnDoiHang.Enabled = false;
                this.btnXacNhan.Enabled = true;
                this.btnHuyDon.Enabled = true;
            }
            else if (tt == EnumField.DaNhanDon)
            {
                this.btnKhieuBai.Enabled = true;
                this.btnYeuTH.Enabled = true;
                this.btnDoiHang.Enabled = true;
                this.btnXacNhan.Enabled = false;
                this.btnHuyDon.Enabled = true;
            }
            else if (tt == EnumField.DaHuyDon)
            {
                this.btnXacNhan.Enabled = false;
                this.btnDoiHang.Enabled = false;
                this.btnYeuTH.Enabled = false;
                this.btnHuyDon.Enabled = false;

                this.btnKhieuBai.Enabled = false;
            }
            else if (tt == EnumField.DoiHuyDon)
            {
                this.btnXacNhan.Enabled = false;
                this.btnDoiHang.Enabled = false;
                this.btnYeuTH.Enabled = false;
                this.btnKhieuBai.Enabled = false;
                this.btnDoiHang.Enabled = false;

            }
            else
            {
                this.btnXacNhan.Enabled = true;
                this.btnDoiHang.Enabled = false;
                this.btnKhieuBai.Enabled = false;
                this.btnYeuTH.Enabled = false;
                this.btnHuyDon.Enabled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnYeuTH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin đơn hàng");
                return;

            }


            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                NhapLyDo form = new NhapLyDo();
                form.maDH = txtMaDH.Text;
                form.Text = "Lý do " + clickedButton.Text;
                form.tinhTrang = EnumField.TraDon;
                form.OnDataSaved += reloadData;
                form.ShowDialog();

            }

        }

        private void btnKhieuBai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin đơn hàng");
                return;

            }


            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                NhapLyDo form = new NhapLyDo();
                form.maDH = txtMaDH.Text;
                form.Text = "Lý do " + clickedButton.Text;
                form.tinhTrang = EnumField.KhieuNaiDon;
                form.OnDataSaved += reloadData;
                form.ShowDialog();

            }
        }

        private void btnDoiHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin đơn hàng");
                return;

            }


            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                NhapLyDo form = new NhapLyDo();
                form.maDH = txtMaDH.Text;
                form.Text = "Lý do " + clickedButton.Text;
                form.tinhTrang = EnumField.DoiHuyDon;
                form.OnDataSaved += reloadData;
                form.ShowDialog();

            }
        }

        private void dgvDSSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DangNhap_Khach dnk = new DangNhap_Khach();
            dnk.Show();
            this.Hide();
        }
    }
}

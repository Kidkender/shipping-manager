using CrystalDecisions.CrystalReports.Engine;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CrystalDecisions.CrystalReports.Engine;
using QLVNNhaNam.Report;
using QLVNNhaNam.Service;

namespace QLVNNhaNam
{
    public partial class TaiKhoanNhanVienGIaoHang : Form
    {
        public TaiKhoanNhanVienGIaoHang(string email)
        {
            InitializeComponent();
            originalDataTable = new DataTable(); // Khởi tạo DataTable

            LoadEmployeeInfo(email);

            LoadOrderData(email);
            dgvDSDonHang.CellFormatting += dgvDSDonHang_CellFormatting;

        }

        private void TaiKhoanNhanVienGIaoHang_Load(object sender, EventArgs e)
        {

        }

        private void dgvDSDonHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvDSDonHang.Columns["Ngaydathang"].Index ||
                e.ColumnIndex == dgvDSDonHang.Columns["Ngaydukiengiao"].Index ||
                e.ColumnIndex == dgvDSDonHang.Columns["NgayNhanHang"].Index)
            {
                if (e.Value != null)
                {
                    string dateString = e.Value.ToString();
                    DateTime date;
                    if (DateTime.TryParseExact(dateString, "MM/dd/yyyy h:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        e.Value = date.ToString("dd/MM/yyyy");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void LoadOrderData(string email)
        {
            SQLService sql = new SQLService();
            var data = sql.LoadOrderData(email);
            dgvDSDonHang.DataSource = data;
            dgvDSDonHang.Columns["Ngaydathang"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSDonHang.Columns["NgayDuKienGiao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSDonHang.Columns["NgayNhanHang"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public string emailNv;
        public string getEmail(string email)
        {
            string username = email;
            return username;
        }

        private void LoadEmployeeInfo(string email)
        {
            SQLService sql = new SQLService();
            var data = sql.LoadEmployeeInfo(email);
            txtusername.Text = data;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvDSDonHang.CurrentRow;

            // Kiểm tra xem có hàng nào đang được chọn trong DataGridView
            if (selectedRow != null)
            {
                // Lấy giá trị MaDH từ dòng đang được chọn
                //                string maDH = dgvDSDonHang.SelectedRows[1].Cells["MaDH"].Value.ToString();
                string maDH = selectedRow.Cells["MaDH"].Value.ToString();

                Console.WriteLine(maDH);
                // Thực hiện cập nhật dữ liệu vào cơ sở dữ liệu
                UpdateTinhTrangDH(maDH);
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại dữ liệu trong DataGridView
                LoadOrderData(emailNv);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateTinhTrangDH(string maDH)
        {
            SQLService sql = new SQLService();
            sql.UpdateTinhTrangDH(maDH);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị MaDH từ dòng được chọn
                string maDH = dgvDSDonHang.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                string Ngaydathang = dgvDSDonHang.Rows[e.RowIndex].Cells["Ngaydathang"].Value.ToString();

                btnKhieuBai.Enabled = true;
                // In giá trị MaDH ra màn hình
                MessageBox.Show("MaDH của dòng được chọn: " + maDH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLService sql = new SQLService();
            var data = sql.LoadOrderData_Now(emailNv);
            dgvDSDonHang.DataSource = data;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadOrderData(emailNv);
        }

        private DataTable originalDataTable; // Lưu trữ dữ liệu gốc

        private void button3_Click(object sender, EventArgs e)
        {
            SQLService sql = new SQLService();
            var data = sql.LoadOrderData_DoiHang(emailNv);
            dgvDSDonHang.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Excel Files|*.xlsx";
            //saveFileDialog.Title = "Chọn vị trí lưu tệp Excel";

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    using (ExcelPackage excelPackage = new ExcelPackage())
            //    {
            //        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

            //        // Ghi tên cột vào tệp Excel
            //        for (int col = 0; col < dgvDSDonHang.Columns.Count; col++)
            //        {
            //            worksheet.Cells[1, col + 1].Value = dgvDSDonHang.Columns[col].HeaderText;
            //        }

            //        // Ghi dữ liệu từ DataGridView vào tệp Excel
            //        for (int row = 0; row < dgvDSDonHang.Rows.Count; row++)
            //        {
            //            for (int col = 0; col < dgvDSDonHang.Columns.Count; col++)
            //            {
            //                worksheet.Cells[row + 2, col + 1].Value = dgvDSDonHang.Rows[row].Cells[col].Value;
            //            }
            //        }

            //        // Lưu tệp Excel
            //        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
            //        excelPackage.SaveAs(excelFile);
            //    }

            //    MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dgvDSDonHang.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in dgvDSDonHang.Rows)
            {
                DataRow newRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    newRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(newRow);
            }

            ReportDonHang reportDonHang = new ReportDonHang();
            reportDonHang.SetDataSource(dataTable);

            formReport form = new formReport();
            form.crystalReportViewer1.ReportSource = reportDonHang;
            form.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn đăng xuất hay không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Close();

                // Hiển thị lại giao diện đăng nhập
                DangNhap loginForm = new DangNhap();
                loginForm.Show();
            }
        }

        private void btnKhieuBai_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvDSDonHang.CurrentRow;

            // Kiểm tra xem có hàng nào đang được chọn trong DataGridView
            if (selectedRow != null)
            {
                // Lấy giá trị MaDH từ dòng đang được chọn
                //                string maDH = dgvDSDonHang.SelectedRows[1].Cells["MaDH"].Value.ToString();
                string maDH = selectedRow.Cells["MaDH"].Value.ToString();

                Console.WriteLine(maDH);

                KhieuNaiDonHang kn = new KhieuNaiDonHang();
                kn.maDh = maDH;
                kn.EmailNV = emailNv;
                kn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

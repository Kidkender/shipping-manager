using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLVNNhaNam
{
    public partial class TaiKhoanNhanVienGIaoHang : Form
    {
        string connectionString = "Data Source=21.241.123.176,1433;Initial Catalog=QLVC_NhaNamv2;User ID=sa;Password=123";

        public TaiKhoanNhanVienGIaoHang(string email)
        {
            InitializeComponent();
            originalDataTable = new DataTable(); // Khởi tạo DataTable

            LoadEmployeeInfo(email);

            LoadOrderData(email);

        }

        private void TaiKhoanNhanVienGIaoHang_Load(object sender, EventArgs e)
        {

        }

        private void LoadOrderData(string email)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT dh.MaDH, dh.Ngaydathang, dh.Ngaydukiengiao, dh.NgayNhanHang, dh.TinhtrangDH, " +
                    "dh.LyDo, dh.PTTT, dh.ChiphiVC FROM DonHang dh " +
                    "INNER JOIN NhanVien nv ON dh.MaNV = nv.MaNV WHERE nv.EmailNV = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);

                    dataTable.Columns.Add("STT", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["STT"] = i + 1;
                    }
                    // Gán dữ liệu vào DataGridView

                    dgvDSDonHang.DataSource = dataTable;


                }
            }
        }
        public string emailNv;
        public string getEmail(string email)
        {
            string username = email;
            return username;
        }

        private void LoadEmployeeInfo(string email)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT TenNV FROM NhanVien WHERE EmailNV = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string tennv = reader["TenNV"].ToString();
                        txtusername.Text = tennv;
                    }

                    reader.Close();
                }
            }
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE DonHang SET TinhtrangDH = N'đã giao' WHERE MaDH = @MaDH";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaDH", maDH);
                    command.ExecuteNonQuery();
                }
            }
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

                // In giá trị MaDH ra màn hình
                MessageBox.Show("MaDH của dòng được chọn: " + maDH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM DonHang WHERE Ngaydukiengiao = @Ngaydukiengiao";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ngaydukiengiao", today);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvDSDonHang.DataSource = dataTable;
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadOrderData(emailNv);
        }
        private DataTable originalDataTable; // Lưu trữ dữ liệu gốc

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT dh.MaDH, dh.Ngaydathang, dh.Ngaydukiengiao, dh.NgayNhanHang, dh.TinhtrangDH, " +
                    "dh.LyDo, dh.PTTT, dh.ChiphiVC FROM DonHang dh " +
                    "INNER JOIN NhanVien nv ON dh.MaNV = nv.MaNV WHERE nv.EmailNV = @Email and TinhtrangDH LIKE N'%đổi%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", emailNv);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);

                    dataTable.Columns.Add("STT", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["STT"] = i + 1;
                    }
                    // Gán dữ liệu vào DataGridView

                    dgvDSDonHang.DataSource = dataTable;


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn vị trí lưu tệp Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    // Ghi tên cột vào tệp Excel
                    for (int col = 0; col < dgvDSDonHang.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dgvDSDonHang.Columns[col].HeaderText;
                    }

                    // Ghi dữ liệu từ DataGridView vào tệp Excel
                    for (int row = 0; row < dgvDSDonHang.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvDSDonHang.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dgvDSDonHang.Rows[row].Cells[col].Value;
                        }
                    }

                    // Lưu tệp Excel
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(excelFile);
                }

                MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}

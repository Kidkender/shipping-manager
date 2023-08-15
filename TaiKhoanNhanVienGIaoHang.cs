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
    public partial class TaiKhoanNhanVienGIaoHang : Form
    {
        string connectionString = "Data Source=21.241.123.176,1433;Initial Catalog=QLVC_NhaNamv2;User ID=sa;Password=123";

        public TaiKhoanNhanVienGIaoHang(string email)
        {
            InitializeComponent();
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

                string query = "SELECT dh.MaDH, dh.Ngaydathang, dh.Ngaydukiengiao, dh.NgayNhanHang, dh.TinhtrangDH, dh.LyDo, dh.PTTT, dh.ChiphiVC FROM DonHang dh INNER JOIN NhanVien nv ON dh.MaNV = nv.MaNV WHERE nv.EmailNV = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvDSDonHang.DataSource = dataTable;
                }
            }
        }
        public string getEmail(string email)
        {
            string username=email;
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

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

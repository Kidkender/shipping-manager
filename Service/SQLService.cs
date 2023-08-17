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

namespace QLVNNhaNam.Service
{
    public class SQLService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectDB"].ConnectionString;

        public bool DangNhap(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Truy vấn kiểm tra tài khoản
                    string query = "SELECT COUNT(*) FROM TaiKhoanNhanVien WHERE EmailNV = @Email AND MatKhau = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string DangNhap_Khach(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Truy vấn kiểm tra tài khoản
                    string query = "SELECT COUNT(*) FROM TaiKhoanKhachHang WHERE EmailKH = @Email AND MatKhau = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0) return GetMaKHByEmail(email);
                        else return "";
                    }
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string GetMaKHByEmail(string email)
        {
            string maKH = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MaKH FROM TaiKhoanKhachHang WHERE EmailKH = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maKH = reader["MaKH"].ToString();
                        }
                    }
                }
            }

            return maKH;
        }

        public DataTable LoadOrderData(string email)
        {
            DataTable db = new DataTable();
            try
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

                        adapter.Fill(db);

                        db.Columns.Add("STT", typeof(int));
                        //dataTable.Columns.Add("NgaydukiengiaoFormatted", typeof(string)); // Tạo cột mới có kiểu chuỗi
                        // dataTable.Columns["Ngaydukiengiao"].DataType = typeof(string);


                        for (int i = 0; i < db.Rows.Count; i++)
                        {
                            db.Rows[i]["STT"] = i + 1;
                        }

                    }
                }
            }
            catch (Exception)
            {
            }
            return db;
        }

        public string LoadEmployeeInfo(string email)
        {
            string result = "";
            try
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
                            result = tennv;
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        public bool UpdateTinhTrangDH(string maDH)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE DonHang SET TinhtrangDH = N'đã giao' WHERE MaDH = @MaDH";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MaDH", maDH);
                        result = command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        public DataTable LoadOrderData_Now(string email)
        {
            DataTable db = new DataTable();
            try
            {
                DateTime today = DateTime.Today;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM DonHang dh"
                       + "INNER JOIN NhanVien nv ON dh.MaNV = nv.MaNV WHERE nv.EmailNV = @Email AND  dh.Ngaydukiengiao = @Ngaydukiengiao"; ;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ngaydukiengiao", today);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(db);
                    }
                }
            }
            catch (Exception)
            {
            }
            return db;
        }

        public DataTable LoadOrderData_DoiHang(string email)
        {
            DataTable db = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT dh.MaDH, dh.Ngaydathang, dh.Ngaydukiengiao, dh.NgayNhanHang, dh.TinhtrangDH, " +
                        "dh.LyDo, dh.PTTT, dh.ChiphiVC FROM DonHang dh " +
                        "INNER JOIN NhanVien nv ON dh.MaNV = nv.MaNV WHERE nv.EmailNV = @Email and TinhtrangDH LIKE N'%đổi%'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        adapter.Fill(db);

                        db.Columns.Add("STT", typeof(int));
                        for (int i = 0; i < db.Rows.Count; i++)
                        {
                            db.Rows[i]["STT"] = i + 1;
                        }

                    }
                }
            }
            catch (Exception)
            {
            }
            return db;
        }
    }
}

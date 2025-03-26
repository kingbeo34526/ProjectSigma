using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienDAL
    {
        //
        // Đăng nhập, tạo tài khoản, quên mật khẩu
        //
        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau)
            };

            int count = Convert.ToInt32(DataProvider.ExecuteScalar(query, parameters));
            return count > 0;
        }
        public bool TaoTaiKhoan(string ten, string tenDangNhap, string email, int phanQuyen, string matKhauMaHoa)
        {
            string query = "INSERT INTO NhanVien (Ten, TenDangNhap, MatKhau, Email, PhanQuyen) VALUES (@Ten, @TenDangNhap, @MatKhau, @Email, @PhanQuyen)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Ten", ten),
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhauMaHoa),
                new SqlParameter("@Email", email),
                new SqlParameter("@PhanQuyen", phanQuyen)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
        public string LayMatKhau(string tenDangNhap)
        {
            string query = "SELECT MatKhau FROM NhanVien WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters = { new SqlParameter("@TenDangNhap", tenDangNhap) };

            object result = DataProvider.ExecuteScalar(query, parameters);
            return result?.ToString();
        }
        public bool CapNhatMatKhau(string tenDangNhap, string matKhauMoi)
        {
            string query = "UPDATE NhanVien SET MatKhau = @MatKhauMoi WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MatKhauMoi", matKhauMoi),
                new SqlParameter("@TenDangNhap", tenDangNhap)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
        public DataRow LayNhanVienTheoEmail(string email)
        {
            string query = "SELECT * FROM NhanVien WHERE Email = @Email";
            SqlParameter[] parameters = { new SqlParameter("@Email", email) };

            DataTable dt = DataProvider.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
        public int LayQuyen(string tenDangNhap)
        {
            string query = "SELECT PhanQuyen FROM NhanVien WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters = { new SqlParameter("@TenDangNhap", tenDangNhap) };

            object result = DataProvider.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }
        //
        // Quản lí nhân viên
        //
        public static List<NhanVienDTO> LayDanhSachNhanVien()
        {
            List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM NhanVien");

            foreach (DataRow row in data.Rows)
            {
                dsNhanVien.Add(new NhanVienDTO
                {
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    Ten = row["Ten"].ToString(),
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    Email = row["Email"].ToString(),
                    PhanQuyen = Convert.ToInt32(row["PhanQuyen"])
                });
            }
            return dsNhanVien;
        }
        //public static bool ThemNhanVien(NhanVienDTO nv)
        //{
        //    string query = "INSERT INTO NhanVien (Ten, TenDangNhap, MatKhau, Email, PhanQuyen) VALUES (@Ten, @TenDangNhap, @MatKhau, @Email, @PhanQuyen)";
        //    SqlParameter[] parameters = {
        //        new SqlParameter("@Ten", nv.Ten),
        //        new SqlParameter("@TenDangNhap", nv.TenDangNhap),
        //        new SqlParameter("@MatKhau", nv.MatKhau),
        //        new SqlParameter("@Email", nv.Email),
        //        new SqlParameter("@PhanQuyen", nv.PhanQuyen)
        //    };
        //    return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        //}
        public static bool SuaNhanVien(NhanVienDTO nv)
        {
            string query = "UPDATE NhanVien SET Ten = @Ten, Email = @Email, PhanQuyen = @PhanQuyen WHERE MaNV = @MaNV";
            SqlParameter[] parameters = {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@Ten", nv.Ten),
                new SqlParameter("@Email", nv.Email),
                new SqlParameter("@PhanQuyen", nv.PhanQuyen)
            };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
        public static DataTable TimKiemNhanVien(string keyword)
        {
            string query = "SELECT * FROM NhanVien WHERE Ten LIKE @keyword OR Email LIKE @keyword OR TenDangNhap LIKE @keyword";
            SqlParameter[] parameters =
            {
                new SqlParameter("@keyword", "%" + keyword + "%")
            };
            return DataProvider.ExecuteQuery(query, parameters);
        }
        public static bool XoaNhanVien(int maNV)
        {
            string query = @"
            DELETE FROM NhanVien WHERE MaNV = @MaNV;
        
            DECLARE @maxID INT;
            SELECT @maxID = ISNULL(MAX(MaNV), 0) FROM NhanVien;
            DBCC CHECKIDENT ('NhanVien', RESEED, @maxID);";

            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}

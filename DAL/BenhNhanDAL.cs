﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BenhNhanDAL
    {
        public static DataTable LayDanhSachBenhNhan()
        {
            string query = "SELECT * FROM BenhNhan";
            return DataProvider.ExecuteQuery(query);
        }
        public static DataTable GetAllBenhNhan()
        {
            string query = "SELECT MaBenhNhan, HoTen FROM BenhNhan";
            return DataProvider.ExecuteQuery(query);
        }
        public static int GetTotalBenhNhan()
        {
            string query = "SELECT COUNT(*) FROM BenhNhan";
            return (int)DataProvider.ExecuteScalar(query);
        }
        public static DataTable GetBenhNhanByTrangThai(string trangThai)
        {
            string query = @"
            SELECT bn.*, ISNULL(hskb.TrangThai, '') AS TrangThai
            FROM BenhNhan bn
            LEFT JOIN HoSoKhamBenh hskb ON bn.MaBenhNhan = hskb.MaBenhNhan";

            // Nếu chọn "Tất cả", không lọc theo Trạng Thái
            if (trangThai != "Tất cả")
            {
                query += " WHERE hskb.TrangThai = @trangThai";
            }

            SqlParameter[] parameters = { new SqlParameter("@trangThai", trangThai) };
            return trangThai == "Tất cả"
                ? DataProvider.ExecuteQuery(query)
                : DataProvider.ExecuteQuery(query, parameters);
        }
        public static DataTable GetBenhNhanByBacSi(int? maBacSi)
        {
            string query = @"SELECT bn.*, nv.Ten AS BacSiDamNhiem
                             FROM BenhNhan bn
                             LEFT JOIN HoSoKhamBenh hskb ON bn.MaBenhNhan = hskb.MaBenhNhan
                             LEFT JOIN NhanVien nv ON hskb.MaBacSi = nv.MaNV
                             WHERE (@MaBacSi IS NULL OR hskb.MaBacSi = @MaBacSi)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaBacSi", (object)maBacSi ?? DBNull.Value)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }
        public static DataTable GetAllTrangThai()
        {
            string query = "SELECT DISTINCT TrangThai FROM HoSoKhamBenh";
            return DataProvider.ExecuteQuery(query);
        }
        public static bool ThemBenhNhan(BenhNhanDTO benhNhan)
        {
            string query = "INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, CanCuocCongDan, Email) " +
                           "VALUES (@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @CCCD, @Email)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@HoTen", benhNhan.HoTen),
                new SqlParameter("@NgaySinh", benhNhan.NgaySinh),
                new SqlParameter("@GioiTinh", benhNhan.GioiTinh),
                new SqlParameter("@DiaChi", benhNhan.DiaChi),
                new SqlParameter("@SoDienThoai", benhNhan.SoDienThoai),
                new SqlParameter("@CCCD", benhNhan.CanCuocCongDan),
                new SqlParameter("@Email", benhNhan.Email)
            };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool SuaBenhNhan(BenhNhanDTO benhNhan)
        {
            string query = "UPDATE BenhNhan SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                           "DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, CanCuocCongDan = @CCCD, Email = @Email WHERE MaBenhNhan = @MaBenhNhan";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaBenhNhan", benhNhan.MaBenhNhan),
                new SqlParameter("@HoTen", benhNhan.HoTen),
                new SqlParameter("@NgaySinh", benhNhan.NgaySinh),
                new SqlParameter("@GioiTinh", benhNhan.GioiTinh),
                new SqlParameter("@DiaChi", benhNhan.DiaChi),
                new SqlParameter("@SoDienThoai", benhNhan.SoDienThoai),
                new SqlParameter("@CCCD", benhNhan.CanCuocCongDan),
                new SqlParameter("@Email", benhNhan.Email)
            };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool XoaBenhNhan(int maBenhNhan)
        {
            string query = "DELETE FROM BenhNhan WHERE MaBenhNhan = @MaBenhNhan";
            SqlParameter[] parameters = { new SqlParameter("@MaBenhNhan", maBenhNhan) };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public static DataTable TimKiemBenhNhan(string tuKhoa)
        {
            string query = "SELECT * FROM BenhNhan WHERE HoTen LIKE @TuKhoa OR CanCuocCongDan LIKE @TuKhoa";
            SqlParameter[] parameters = { new SqlParameter("@TuKhoa", "%" + tuKhoa + "%") };
            return DataProvider.ExecuteQuery(query, parameters);
        }
        public static string LayTenBenhNhan(int maBenhNhan)
        {
            string query = "SELECT HoTen FROM BenhNhan WHERE MaBenhNhan = @MaBenhNhan";
            SqlParameter[] parameters = { new SqlParameter("@MaBenhNhan", maBenhNhan) };
            object result = DataProvider.ExecuteScalar(query, parameters);
            return result?.ToString() ?? "";
        }
        public static string GetEmailByMaHoSo(int maHoSo)
        {
            string query = @"
            SELECT b.Email 
            FROM BenhNhan b
            INNER JOIN HoSoKhamBenh hskb ON b.MaBenhNhan = hskb.MaBenhNhan
            WHERE hskb.MaHoSo = @MaHoSo";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoSo", maHoSo)
            };

            var result = DataProvider.ExecuteScalar(query, parameters);
            return result?.ToString();
        }
        public static string GetTenBenhNhanByMaHoSo(int maHoSo)
        {
            string query = @"SELECT bn.HoTen 
                     FROM BenhNhan bn 
                     INNER JOIN HoSoKhamBenh hs ON bn.MaBenhNhan = hs.MaBenhNhan 
                     WHERE hs.MaHoSo = @MaHoSo";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoSo", SqlDbType.Int) { Value = maHoSo }
            };

            object result = DataProvider.ExecuteScalar(query, parameters);
            return result != null ? result.ToString() : "Không xác định";
        }

        public static bool KiemTraTonTaiTrongPhieuKham(int maBenhNhan)
        {
            string query = "SELECT COUNT(*) FROM HoSoKhamBenh WHERE MaBenhNhan = @MaBenhNhan";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaBenhNhan", maBenhNhan)
            };

            int count = (int)DataProvider.ExecuteScalar(query, parameters);
            return count > 0;
        }
        public static bool KiemTraCCCDTonTai(string cccd)
        {
            string query = "SELECT COUNT(*) FROM BenhNhan WHERE CanCuocCongDan = @CCCD";
            SqlParameter[] parameters = { new SqlParameter("@CCCD", cccd) };
            int count = (int)DataProvider.ExecuteScalar(query, parameters);
            return count > 0;
        }
        public static bool KiemTraSDTTonTai(string sdt)
        {
            string query = "SELECT COUNT(*) FROM BenhNhan WHERE SoDienThoai = @SDT";
            SqlParameter[] parameters = { new SqlParameter("@SDT", sdt) };
            int count = (int)DataProvider.ExecuteScalar(query, parameters);
            return count > 0;
        }
    }
}

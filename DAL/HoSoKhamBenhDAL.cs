using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HoSoKhamBenhDAL
    {
        //public static DataTable GetAllHoSo()
        //{
        //    string query = "SELECT * FROM HoSoKhamBenh";
        //    return DataProvider.ExecuteQuery(query);
        //}
        public static DataTable GetAllHoSo()
        {
            string query = @"
            SELECT hskb.MaHoSo, hskb.MaBenhNhan, bn.HoTen, hskb.TrangThai 
            FROM HoSoKhamBenh hskb
            JOIN BenhNhan bn ON hskb.MaBenhNhan = bn.MaBenhNhan";

            return DataProvider.ExecuteQuery(query);
        }
        public static DataTable TimKiemHoSoTheoTen(string tenBenhNhan)
        {
            string query = @"
            SELECT hskb.MaHoSo, hskb.MaBenhNhan, bn.HoTen, hskb.TrangThai 
            FROM HoSoKhamBenh hskb
            JOIN BenhNhan bn ON bn.MaBenhNhan = hskb.MaBenhNhan
            WHERE bn.HoTen LIKE @ten";

            SqlParameter[] parameters = { new SqlParameter("@ten", "%" + tenBenhNhan + "%") };
            return DataProvider.ExecuteQuery(query, parameters);
        }
        public static DataTable GetAllBacSi()
        {
            string query = "SELECT MaNV, Ten FROM NhanVien WHERE PhanQuyen = 2";
            return DataProvider.ExecuteQuery(query);
        }
        public static DataTable GetHoSoById(int maHoSo)
        {
            string query = "SELECT * FROM HoSoKhamBenh WHERE MaHoSo = @MaHoSo";
            SqlParameter[] parameters = { new SqlParameter("@MaHoSo", maHoSo) };
            return DataProvider.ExecuteQuery(query, parameters);
        }

        public static bool InsertHoSo(HoSoKhamBenhDTO hoSo)
        {
            string query = "INSERT INTO HoSoKhamBenh (MaBenhNhan, MaBacSi, TrieuChung, KetQuaKham, NgayHen, TrangThai) " +
                           "VALUES (@MaBenhNhan, @MaBacSi, @TrieuChung, @KetQuaKham, @NgayHen, @TrangThai)";
            SqlParameter[] parameters = {
                new SqlParameter("@MaBenhNhan", hoSo.MaBenhNhan),
                new SqlParameter("@MaBacSi", hoSo.MaBacSi),
                new SqlParameter("@TrieuChung", hoSo.TrieuChung),
                new SqlParameter("@KetQuaKham", hoSo.KetQuaKham),
                new SqlParameter("@NgayHen", hoSo.NgayHen),
                new SqlParameter("@TrangThai", hoSo.TrangThai)
            };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool UpdateHoSo(HoSoKhamBenhDTO hoSo)
        {
            string query = "UPDATE HoSoKhamBenh SET MaBenhNhan = @MaBenhNhan, MaBacSi = @MaBacSi, TrieuChung = @TrieuChung, " +
                           "KetQuaKham = @KetQuaKham, NgayHen = @NgayHen, TrangThai = @TrangThai WHERE MaHoSo = @MaHoSo";
            SqlParameter[] parameters = {
                new SqlParameter("@MaHoSo", hoSo.MaHoSo),
                new SqlParameter("@MaBenhNhan", hoSo.MaBenhNhan),
                new SqlParameter("@MaBacSi", hoSo.MaBacSi),
                new SqlParameter("@TrieuChung", hoSo.TrieuChung),
                new SqlParameter("@KetQuaKham", hoSo.KetQuaKham),
                new SqlParameter("@NgayHen", hoSo.NgayHen),
                new SqlParameter("@TrangThai", hoSo.TrangThai)
            };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
        public static DataTable GetHoSoByTrangThai(string trangThai)
        {
            string query = "SELECT * FROM HoSoKhamBenh WHERE TrangThai = @TrangThai";
            SqlParameter[] parameters = { new SqlParameter("@TrangThai", trangThai) };
            return DataProvider.ExecuteQuery(query, parameters);
        }
    }
}

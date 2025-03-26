using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DonThuocDAL
    {
        public DataTable LayDanhSachDonThuoc(int maHoSo)
        {
            string query = "SELECT * FROM DonThuoc WHERE MaHoSo = @MaHoSo";
            SqlParameter[] parameters = { new SqlParameter("@MaHoSo", maHoSo) };
            return DataProvider.ExecuteQuery(query, parameters);
        }

        //public DataTable LayChiTietDonThuoc(int maDonThuoc)
        //{
        //    string query = "SELECT * FROM ChiTietDonThuoc WHERE MaDonThuoc = @MaDonThuoc";
        //    SqlParameter[] parameters = { new SqlParameter("@MaDonThuoc", maDonThuoc) };
        //    return DataProvider.ExecuteQuery(query, parameters);
        //}
        public DataTable LayChiTietDonThuoc(int maDonThuoc)
        {
            string query = @"
                SELECT MaChiTiet, t.TenThuoc, ct.SoLuong
                FROM ChiTietDonThuoc ct
                JOIN Thuoc t ON ct.MaThuoc = t.MaThuoc
                WHERE ct.MaDonThuoc = @MaDonThuoc";

            SqlParameter[] parameters = { new SqlParameter("@MaDonThuoc", maDonThuoc) };
            return DataProvider.ExecuteQuery(query, parameters);
        }


        public int ThemDonThuoc(DonThuocDTO donThuoc)
        {
            string query = "INSERT INTO DonThuoc (MaHoSo, NgayLap) VALUES (@MaHoSo, @NgayLap)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaHoSo", donThuoc.MaHoSo),
                new SqlParameter("@NgayLap", donThuoc.NgayLap)
            };
            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        public void XoaChiTietDonThuoc(int maDonThuoc)
        {
            string query = "DELETE FROM ChiTietDonThuoc WHERE MaDonThuoc = @MaDonThuoc";
            SqlParameter[] parameters = { new SqlParameter("@MaDonThuoc", maDonThuoc) };
            DataProvider.ExecuteNonQuery(query, parameters);
        }

        public void XoaDonThuoc(int maDonThuoc)
        {
            string query = "DELETE FROM DonThuoc WHERE MaDonThuoc = @MaDonThuoc";
            SqlParameter[] parameters = { new SqlParameter("@MaDonThuoc", maDonThuoc) };
            DataProvider.ExecuteNonQuery(query, parameters);
        }

    }
}

using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ChiTietDonThuocDAL
    {
        public int ThemChiTietDonThuoc(ChiTietDonThuocDTO chiTiet)
        {
            string query = "INSERT INTO ChiTietDonThuoc (MaDonThuoc, MaThuoc, SoLuong) VALUES (@MaDonThuoc, @MaThuoc, @SoLuong)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDonThuoc", chiTiet.MaDonThuoc),
                new SqlParameter("@MaThuoc", chiTiet.MaThuoc),
                new SqlParameter("@SoLuong", chiTiet.SoLuong)
            };
            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        public int XoaChiTietDonThuoc(int maChiTiet)
        {
            string query = "DELETE FROM ChiTietDonThuoc WHERE MaChiTiet = @MaChiTiet";
            SqlParameter[] parameters = { new SqlParameter("@MaChiTiet", maChiTiet) };
            return DataProvider.ExecuteNonQuery(query, parameters);
        }
        public static void SuaChiTietDonThuoc(ChiTietDonThuocDTO chiTiet)
        {
            string query = "UPDATE ChiTietDonThuoc SET MaThuoc = @MaThuoc, SoLuong = @SoLuong WHERE MaChiTiet = @MaChiTiet";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaThuoc", chiTiet.MaThuoc),
                new SqlParameter("@SoLuong", chiTiet.SoLuong),
                new SqlParameter("@MaChiTiet", chiTiet.MaChiTiet) // Dùng giá trị có sẵn
            };

            DataProvider.ExecuteNonQuery(query, parameters);
        }
    }
}

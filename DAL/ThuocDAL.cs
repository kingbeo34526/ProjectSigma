using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThuocDAL
    {
        public static DataTable GetAllThuoc()
        {
            string query = "SELECT * FROM Thuoc";
            return DataProvider.ExecuteQuery(query);
        }
        public static List<ThuocDTO> LayDanhSachThuoc(string keyword = "")
        {
            List<ThuocDTO> danhSachThuoc = new List<ThuocDTO>();
            string query = "SELECT * FROM Thuoc WHERE TenThuoc LIKE @Keyword";
            SqlParameter[] parameters = { new SqlParameter("@Keyword", "%" + keyword + "%") };

            DataTable data = DataProvider.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                danhSachThuoc.Add(new ThuocDTO(
                    int.Parse(row["MaThuoc"].ToString()),
                    row["TenThuoc"].ToString(),
                    int.Parse(row["DonViThuoc"].ToString()),
                    int.Parse(row["SoLuong"].ToString()),
                    decimal.Parse(row["Gia"].ToString())
                ));
            }

            return danhSachThuoc;
        }

        public void ThemThuoc(string tenThuoc, int donVi, int soLuong, decimal gia)
        {
            string query = "INSERT INTO Thuoc (TenThuoc, DonViThuoc, SoLuong, Gia) VALUES (@TenThuoc, @DonViThuoc, @SoLuong, @Gia)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenThuoc", tenThuoc),
                new SqlParameter("@DonViThuoc", donVi),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@Gia", gia)
            };
            DataProvider.ExecuteNonQuery(query, parameters);
        }

        public void SuaThuoc(int maThuoc, string tenThuoc, int donVi, int soLuong, decimal gia)
        {
            string query = "UPDATE Thuoc SET TenThuoc = @TenThuoc, DonViThuoc = @DonViThuoc, SoLuong = @SoLuong, Gia = @Gia WHERE MaThuoc = @MaThuoc";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaThuoc", maThuoc),
                new SqlParameter("@TenThuoc", tenThuoc),
                new SqlParameter("@DonViThuoc", donVi),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@Gia", gia)
            };
            DataProvider.ExecuteNonQuery(query, parameters);
        }

        public void XoaThuoc(int maThuoc)
        {
            string query = "DELETE FROM Thuoc WHERE MaThuoc = @MaThuoc";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaThuoc", maThuoc)
            };
            DataProvider.ExecuteNonQuery(query, parameters);
        }
    }
}

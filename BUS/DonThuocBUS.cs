using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DAL;
using DTO;

namespace BUS
{
    public class DonThuocBUS
    {
        private DonThuocDAL donThuocDAL = new DonThuocDAL();

        public DataTable LayDanhSachDonThuoc(int maHoSo)
        {
            return donThuocDAL.LayDanhSachDonThuoc(maHoSo);
        }

        public DataTable LayChiTietDonThuoc(int maDonThuoc)
        {
            return donThuocDAL.LayChiTietDonThuoc(maDonThuoc);
        }

        public bool ThemDonThuoc(DonThuocDTO donThuoc)
        {
            return donThuocDAL.ThemDonThuoc(donThuoc) > 0;
        }

        public void XoaDonThuoc(int maDonThuoc)
        {
            try
            {
                donThuocDAL.XoaChiTietDonThuoc(maDonThuoc);  // Xóa chi tiết đơn thuốc trước
                donThuocDAL.XoaDonThuoc(maDonThuoc);         // Xóa đơn thuốc
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa đơn thuốc: " + ex.Message);
            }
        }

        public bool CapNhatDonThuoc(int maDonThuoc, int soLuong)
        {
            string query = "UPDATE ChiTietDonThuoc SET SoLuong = @SoLuong WHERE MaDonThuoc = @MaDonThuoc";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDonThuoc", maDonThuoc),
                new SqlParameter("@SoLuong", soLuong),
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool HasDonThuocByMaHoSo(int maHoSo)
        {
            return DataProvider.ExecuteQuery($"SELECT COUNT(*) FROM DonThuoc WHERE MaHoSo = {maHoSo}")
                .Rows[0][0].ToString() != "0";
        }
        public static string GetDonThuocHtml(int maHoSo)
        {
            var donThuoc = DonThuocDAL.GetByMaHoSo(maHoSo);
            if (donThuoc == null) return "<p>Không có đơn thuốc nào.</p>";

            int maDonThuoc = Convert.ToInt32(donThuoc["MaDonThuoc"]);
            DataTable chiTiet = ChiTietDonThuocDAL.GetByMaDonThuoc(maDonThuoc);

            StringBuilder html = new StringBuilder();
            html.Append("<table border='1' cellpadding='5' cellspacing='0'><tr><th>Tên thuốc</th><th>Đơn vị</th><th>Số lượng</th></tr>");

            foreach (DataRow row in chiTiet.Rows)
            {
                html.Append($"<tr><td>{row["TenThuoc"]}</td><td>{row["DonViThuoc"]}</td><td>{row["SoLuong"]}</td></tr>");
            }

            html.Append("</table>");
            return html.ToString();
        }
    }
}

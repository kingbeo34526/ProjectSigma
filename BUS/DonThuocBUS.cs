using System;
using System.Data;
using System.Data.SqlClient;
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

    }
}

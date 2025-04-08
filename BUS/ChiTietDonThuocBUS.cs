using DAL;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class ChiTietDonThuocBUS
    {
        private ChiTietDonThuocDAL chiTietDonThuocDAL = new ChiTietDonThuocDAL();

        public bool ThemChiTietDonThuoc(ChiTietDonThuocDTO chiTiet)
        {
            return chiTietDonThuocDAL.ThemChiTietDonThuoc(chiTiet) > 0;
        }

        public bool XoaChiTietDonThuoc(int maChiTiet)
        {
            return chiTietDonThuocDAL.XoaChiTietDonThuoc(maChiTiet) > 0;
        }
        public void SuaChiTietDonThuoc(ChiTietDonThuocDTO chiTiet)
        {
            ChiTietDonThuocDAL.SuaChiTietDonThuoc(chiTiet);
        }
    }
}

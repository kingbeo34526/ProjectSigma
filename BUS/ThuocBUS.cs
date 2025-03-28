using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThuocBUS
    {

        private ThuocDAL thuocDAL = new ThuocDAL();
        public static DataTable GetAllThuoc()
        {
            return ThuocDAL.GetAllThuoc();
        }
        public static List<ThuocDTO> TimKiemThuoc(string keyword)
        {
            return ThuocDAL.LayDanhSachThuoc(keyword);
        }
        public int GetTotalThuoc()
        {
            return ThuocDAL.GetTotalThuoc();
        }
        public void ThemThuoc(string tenThuoc, int donVi, int soLuong, decimal gia)
        {
            thuocDAL.ThemThuoc(tenThuoc, donVi, soLuong, gia);
        }

        public void SuaThuoc(int maThuoc, string tenThuoc, int donVi, int soLuong, decimal gia)
        {
            thuocDAL.SuaThuoc(maThuoc, tenThuoc, donVi, soLuong, gia);
        }

        public void XoaThuoc(int maThuoc)
        {
            thuocDAL.XoaThuoc(maThuoc);
        }
    }
}

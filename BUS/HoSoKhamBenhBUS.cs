using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class HoSoKhamBenhBUS
    {
        public static DataTable GetAllHoSo()
        {
            return HoSoKhamBenhDAL.GetAllHoSo();
        }
        public static DataTable GetAllBacSi()
        {
            return HoSoKhamBenhDAL.GetAllBacSi();
        }
        public static DataTable GetHoSoById(int maHoSo)
        {
            return HoSoKhamBenhDAL.GetHoSoById(maHoSo);
        }

        public static bool InsertHoSo(HoSoKhamBenhDTO hoSo)
        {
            return HoSoKhamBenhDAL.InsertHoSo(hoSo);
        }
        public static DataTable TimKiemHoSoTheoTen(string tenBenhNhan)
        {
            return HoSoKhamBenhDAL.TimKiemHoSoTheoTen(tenBenhNhan);
        }
        public static bool UpdateHoSo(HoSoKhamBenhDTO hoSo)
        {
            return HoSoKhamBenhDAL.UpdateHoSo(hoSo);
        }
        public static DataTable GetHoSoByTrangThai(string trangThai)
        {
            return HoSoKhamBenhDAL.GetHoSoByTrangThai(trangThai);
        }
    }
}

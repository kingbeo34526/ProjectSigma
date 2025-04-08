using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BenhNhanBUS
    {
        public static DataTable LayDanhSachBenhNhan()
        {
            return BenhNhanDAL.LayDanhSachBenhNhan();
        }
        public static DataTable GetAllBenhNhan()
        {
            return BenhNhanDAL.GetAllBenhNhan();
        }
        public static DataTable GetBenhNhanByBacSi(int? maBacSi)
        {
            return BenhNhanDAL.GetBenhNhanByBacSi(maBacSi);
        }
        public int GetTotalBenhNhan()
        {
            return BenhNhanDAL.GetTotalBenhNhan();
        }

        public DataTable GetBenhNhanByTrangThai(string trangThai)
        {
            return BenhNhanDAL.GetBenhNhanByTrangThai(trangThai);
        }

        public DataTable GetAllTrangThai()
        {
            return BenhNhanDAL.GetAllTrangThai();
        }
        public static bool ThemBenhNhan(BenhNhanDTO benhNhan)
        {
            return BenhNhanDAL.ThemBenhNhan(benhNhan);
        }

        public static bool SuaBenhNhan(BenhNhanDTO benhNhan)
        {
            return BenhNhanDAL.SuaBenhNhan(benhNhan);
        }

        public static bool XoaBenhNhan(int maBenhNhan)
        {
            return BenhNhanDAL.XoaBenhNhan(maBenhNhan);
        }

        public static DataTable TimKiemBenhNhan(string tuKhoa)
        {
            return BenhNhanDAL.TimKiemBenhNhan(tuKhoa);
        }
        public static string LayTenBenhNhan(int maBenhNhan)
        {
            return BenhNhanDAL.LayTenBenhNhan(maBenhNhan);
        }
        public static bool KiemTraTonTaiTrongPhieuKham(int maBenhNhan)
        {
            return BenhNhanDAL.KiemTraTonTaiTrongPhieuKham(maBenhNhan);
        }
        public static bool KiemTraCCCDTonTai(string cccd)
        {
            return BenhNhanDAL.KiemTraCCCDTonTai(cccd);
        }
        public static bool KiemTraSDTTonTai(string sdt)
        {
            return BenhNhanDAL.KiemTraSDTTonTai(sdt);
        }        
        public static string GetEmailByMaHoSo(int MaHoSo)
        {
            return BenhNhanDAL.GetEmailByMaHoSo(MaHoSo);
        }
        public static string GetTenBenhNhanByMaHoSo(int maHoSo)
        {
            return BenhNhanDAL.GetTenBenhNhanByMaHoSo(maHoSo);
        }
    }
}

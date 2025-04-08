using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuocDTO
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int DonViThuoc { get; set; } // 1: Viên, 2: Gói, 3: Hộp
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }


        public ThuocDTO(int maThuoc, string tenThuoc, int donViThuoc, int soLuong, decimal gia)
        {
            MaThuoc = maThuoc;
            TenThuoc = tenThuoc;
            DonViThuoc = donViThuoc;
            SoLuong = soLuong;
            Gia = gia;
        }
    }
}


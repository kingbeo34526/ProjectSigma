using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhanDTO
    {
        public int MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; } // 1: Nam, 2: Nữ
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string CanCuocCongDan { get; set; }
    }
}

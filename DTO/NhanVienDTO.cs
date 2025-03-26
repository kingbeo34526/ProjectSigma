using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string Ten { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public int PhanQuyen { get; set; }
        public string PhanQuyenHienThi
        {
            get
            {
                return PhanQuyen == 1 ? "Quản lý" : (PhanQuyen == 2 ? "Bác sĩ" : "Lễ tân");
            }
        }
    }

}

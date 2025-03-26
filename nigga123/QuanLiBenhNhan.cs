using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace nigga123
{
    public partial class QuanLiBenhNhan : Form
    {
        public QuanLiBenhNhan()
        {
            InitializeComponent();
        }
        private void QuanLiBenhNhan_Load(object sender, EventArgs e)
        {
            LoadDanhSachBenhNhan();
            DgvBenhNhan.SelectionChanged += DgvBenhNhan_SelectionChanged;
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
        }
        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(TxtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập số CMND/CCCD!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!RbNam.Checked && !RbNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadDanhSachBenhNhan()
        {
            DataTable dt = BenhNhanBUS.LayDanhSachBenhNhan();

            // Kiểm tra nếu chưa có cột hiển thị giới tính thì thêm vào
            if (!dt.Columns.Contains("GioiTinhHienThi"))
                dt.Columns.Add("GioiTinhHienThi", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                // Kiểm tra giá trị trước khi chuyển đổi
                int gioiTinh = Convert.ToInt32(row["GioiTinh"]);
                row["GioiTinhHienThi"] = gioiTinh == 1 ? "Nam" : "Nữ";
            }

            // Gán dữ liệu cho DataGridView
            DgvBenhNhan.DataSource = dt;

            // Định dạng tiêu đề cột hiển thị tiếng Việt
            DgvBenhNhan.Columns["MaBenhNhan"].HeaderText = "Mã Bệnh Nhân";
            DgvBenhNhan.Columns["HoTen"].HeaderText = "Họ và Tên";
            DgvBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            DgvBenhNhan.Columns["GioiTinhHienThi"].HeaderText = "Giới Tính"; // Hiển thị chữ Nam/Nữ
            DgvBenhNhan.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            DgvBenhNhan.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            DgvBenhNhan.Columns["CanCuocCongDan"].HeaderText = "CMND/CCCD";
            DgvBenhNhan.Columns["GioiTinhHienThi"].DisplayIndex = DgvBenhNhan.Columns["HoTen"].DisplayIndex + 1;

            // Ẩn cột gốc GioiTinh (nếu không cần thiết)
            DgvBenhNhan.Columns["GioiTinh"].Visible = false;
        }



        private void NutThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin()) return;
            BenhNhanDTO bn = new BenhNhanDTO()
            {
                HoTen = TxtHoVaTen.Text,
                NgaySinh = DateSinh.Value,
                GioiTinh = RbNam.Checked ? 1 : 2,
                DiaChi = TxtDiaChi.Text,
                SoDienThoai = TxtSDT.Text,
                CanCuocCongDan = TxtCCCD.Text
            };

            if (BenhNhanBUS.ThemBenhNhan(bn))
            {
                MessageBox.Show("Thêm bệnh nhân thành công!");
                LoadDanhSachBenhNhan();
            }
            else
                MessageBox.Show("Thêm bệnh nhân thất bại!");
        }

        private void NutSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin()) return;
            if (DgvBenhNhan.SelectedRows.Count > 0)
            {
                int maBenhNhan = Convert.ToInt32(DgvBenhNhan.SelectedRows[0].Cells["MaBenhNhan"].Value);
                BenhNhanDTO bn = new BenhNhanDTO()
                {
                    MaBenhNhan = maBenhNhan,
                    HoTen = TxtHoVaTen.Text,
                    NgaySinh = DateSinh.Value,
                    GioiTinh = RbNam.Checked ? 1 : 2,
                    DiaChi = TxtDiaChi.Text,
                    SoDienThoai = TxtSDT.Text,
                    CanCuocCongDan = TxtCCCD.Text
                };

                if (BenhNhanBUS.SuaBenhNhan(bn))
                {
                    MessageBox.Show("Sửa bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachBenhNhan();
                }
                else
                    MessageBox.Show("Sửa bệnh nhân thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NutXoa_Click(object sender, EventArgs e)
        {
            if (DgvBenhNhan.SelectedRows.Count > 0)
            {
                int maBenhNhan = Convert.ToInt32(DgvBenhNhan.SelectedRows[0].Cells["MaBenhNhan"].Value);
                if (BenhNhanBUS.KiemTraTonTaiTrongPhieuKham(maBenhNhan))
                {
                    MessageBox.Show("Bệnh nhân đã có trong Phiếu Khám, không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (BenhNhanBUS.XoaBenhNhan(maBenhNhan))
                {
                    MessageBox.Show("Xóa bệnh nhân thành công!");
                    LoadDanhSachBenhNhan();
                }
                else
                    MessageBox.Show("Xóa bệnh nhân thất bại!");
            }
        }
        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DgvBenhNhan.DataSource = BenhNhanBUS.TimKiemBenhNhan(DgvBenhNhan.Text);
        }
        private void DgvBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBenhNhan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgvBenhNhan.SelectedRows[0];
                TxtHoVaTen.Text = row.Cells["HoTen"].Value?.ToString();
                DateSinh.Value = row.Cells["NgaySinh"].Value != DBNull.Value
                                    ? Convert.ToDateTime(row.Cells["NgaySinh"].Value)
                                    : DateTime.Now;

                string gioiTinh = row.Cells["GioiTinhHienThi"].Value?.ToString().Trim();
                if (!string.IsNullOrEmpty(gioiTinh))
                {
                    RbNam.Checked = gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase);
                    RbNu.Checked = gioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    RbNam.Checked = false;
                    RbNu.Checked = false;
                }

                TxtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                TxtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString();
                TxtCCCD.Text = row.Cells["CanCuocCongDan"].Value?.ToString();
            }
        }
        private void NutLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachBenhNhan();
        }

        private void NutThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

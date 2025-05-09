﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            LoadDanhSachBenhNhan();
        }
        private void QuanLiBenhNhan_Load(object sender, EventArgs e)
        {
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            DgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động co giãn theo độ rộng của DGV
            DgvBenhNhan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
            DgvBenhNhan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái cho nội dung
            DgvBenhNhan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Hàng tự động điều chỉnh kích thước theo nội dung
            DgvBenhNhan.AllowUserToResizeRows = false; // Không cho phép resize dòng
            DgvBenhNhan.AllowUserToResizeColumns = true; // Cho phép resize cột
            DgvBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn nguyên dòng
            DgvBenhNhan.MultiSelect = false; // Không cho phép chọn nhiều dòng
        }
        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(TxtHoVaTen.Text) || !Regex.IsMatch(TxtHoVaTen.Text, @"^[a-zA-ZÀ-Ỹà-ỹ\s]+$"))
            {
                MessageBox.Show("Họ và tên không hợp lệ! Không được chứa số hoặc ký tự đặc biệt.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtCCCD.Text) || !Regex.IsMatch(TxtCCCD.Text, @"^\d{9,12}$"))
            {
                MessageBox.Show("Số CMND/CCCD không hợp lệ! Vui lòng nhập đúng định dạng (9-12 số).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtSDT.Text) || !Regex.IsMatch(TxtSDT.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Phải bắt đầu bằng số 0 và có 10 chữ số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!RbNam.Checked && !RbNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DateSinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Phải nhỏ hơn ngày hiện tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || !Regex.IsMatch(TxtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập đúng định dạng.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadDanhSachBenhNhan()
        {
            // Ngắt sự kiện SelectionChanged tạm thời
            DgvBenhNhan.SelectionChanged -= DgvBenhNhan_SelectionChanged;

            DataTable dt = BenhNhanBUS.LayDanhSachBenhNhan();
            DgvBenhNhan.DataSource = dt;

            // Định dạng tiêu đề cột hiển thị tiếng Việt
            DgvBenhNhan.Columns["MaBenhNhan"].HeaderText = "Mã Bệnh Nhân";
            DgvBenhNhan.Columns["HoTen"].HeaderText = "Họ và Tên";
            DgvBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            DgvBenhNhan.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            DgvBenhNhan.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            DgvBenhNhan.Columns["CanCuocCongDan"].HeaderText = "CCCD";
            DgvBenhNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            DgvBenhNhan.Columns["Email"].HeaderText = "Email";

            // Bỏ chọn dòng đầu tiên
            DgvBenhNhan.ClearSelection();
            DgvBenhNhan.CurrentCell = null;

            // Kích hoạt lại sự kiện
            DgvBenhNhan.SelectionChanged += DgvBenhNhan_SelectionChanged;

            DateSinh.Format = DateTimePickerFormat.Custom;
            DateSinh.CustomFormat = "dd/MM/yyyy"; // Hiển thị dạng 01/04/2025
            DateSinh.CalendarForeColor = Color.Blue;   // Màu chữ  
            DateSinh.CalendarMonthBackground = Color.LightYellow; // Màu nền  
            DateSinh.ShowUpDown = false; // Ẩn phần giờ phút  
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
                CanCuocCongDan = TxtCCCD.Text,
                Email = TxtEmail.Text
            };

            if (BenhNhanBUS.KiemTraCCCDTonTai(bn.CanCuocCongDan))
            {
                MessageBox.Show("Số CCCD này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (BenhNhanBUS.KiemTraSDTTonTai(bn.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (BenhNhanBUS.ThemBenhNhan(bn))
            {
                MessageBox.Show("Thêm bệnh nhân thành công!");
                LoadDanhSachBenhNhan();
            }
            else
            {
                MessageBox.Show("Thêm bệnh nhân thất bại!");
            }
        }

        private void NutSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin()) return;

            if (DgvBenhNhan.SelectedRows.Count > 0)
            {
                int maBenhNhan = Convert.ToInt32(DgvBenhNhan.SelectedRows[0].Cells["MaBenhNhan"].Value);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin bệnh nhân này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    BenhNhanDTO bn = new BenhNhanDTO()
                    {
                        MaBenhNhan = maBenhNhan,
                        HoTen = TxtHoVaTen.Text,
                        NgaySinh = DateSinh.Value,
                        GioiTinh = RbNam.Checked ? 1 : 2,
                        DiaChi = TxtDiaChi.Text,
                        SoDienThoai = TxtSDT.Text,
                        CanCuocCongDan = TxtCCCD.Text,
                        Email = TxtEmail.Text
                    };


                    if (BenhNhanBUS.SuaBenhNhan(bn))
                    {
                        MessageBox.Show("Sửa bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachBenhNhan();
                    }
                    else
                        MessageBox.Show("Sửa bệnh nhân thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BenhNhanBUS.XoaBenhNhan(maBenhNhan))
                    {
                        MessageBox.Show("Xóa bệnh nhân thành công!");
                        LoadDanhSachBenhNhan();
                    }
                    else
                        MessageBox.Show("Xóa bệnh nhân thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DgvBenhNhan.DataSource = BenhNhanBUS.TimKiemBenhNhan(TxtTimKiem.Text);
        }
        private void DgvBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBenhNhan.SelectedRows.Count == 0 || DgvBenhNhan.CurrentRow == null)
                return; // Nếu không có dòng nào, thoát luôn

            DataGridViewRow row = DgvBenhNhan.SelectedRows[0];
            TxtHoVaTen.Text = row.Cells["HoTen"].Value?.ToString();
            DateSinh.Value = row.Cells["NgaySinh"].Value != DBNull.Value
                                ? Convert.ToDateTime(row.Cells["NgaySinh"].Value)
                                : DateTime.Now;

            string gioiTinh = row.Cells["GioiTinh"].Value?.ToString().Trim();
            if (!string.IsNullOrEmpty(gioiTinh))
            {
                RbNam.Checked = gioiTinh == "1";
                RbNu.Checked = gioiTinh == "2";
            }
            else
            {
                RbNam.Checked = false;
                RbNu.Checked = false;
            }

            TxtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            TxtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString();
            TxtCCCD.Text = row.Cells["CanCuocCongDan"].Value?.ToString();
            TxtEmail.Text = row.Cells["Email"].Value?.ToString();
        }

        private void NutLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachBenhNhan(); // Load lại danh sách bệnh nhân
            DgvBenhNhan.ClearSelection(); // Bỏ chọn tất cả dòng trong DataGridView

            // Xóa nội dung trong các ô nhập liệu
            TxtHoVaTen.Clear();
            TxtSDT.Clear();
            TxtDiaChi.Clear();
            TxtCCCD.Clear();
            TxtTimKiem.Clear();
            TxtEmail.Clear();

            // Đặt lại ngày sinh về ngày hiện tại
            DateSinh.Value = DateTime.Now;

            // Bỏ chọn radio button giới tính
            RbNam.Checked = false;
            RbNu.Checked = false;

            // Đưa focus về ô nhập tên bệnh nhân để tiện nhập mới
            TxtHoVaTen.Focus();
        }
        private void NutThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvBenhNhan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvBenhNhan.Columns[e.ColumnIndex].Name == "GioiTinh") // Kiểm tra cột Giới Tính
            {
                if (e.Value != null)
                {
                    int gioiTinh;
                    if (int.TryParse(e.Value.ToString(), out gioiTinh))
                    {
                        e.Value = (gioiTinh == 1) ? "Nam" : "Nữ";
                        e.FormattingApplied = true;
                    }
                }
            }
        }
    }
}

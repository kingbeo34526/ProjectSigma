using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nigga123
{
    public partial class QuanLiHoSoBN : Form
    {
        private int? maHoSo;
        public event Action HoSoDaCapNhat;
        public QuanLiHoSoBN(int? maHoSo = null)
        {
            InitializeComponent();
            this.maHoSo = maHoSo;
            LoadComboBoxData();

            if (maHoSo.HasValue)
            {
                LoadHoSo(maHoSo.Value);
            }
        }
        private void LoadComboBoxData()
        {
            // 🔹 Load danh sách Bệnh Nhân
            CmbBenhNhan.DataSource = BenhNhanBUS.GetAllBenhNhan();
            CmbBenhNhan.DisplayMember = "TenBenhNhan";
            CmbBenhNhan.ValueMember = "MaBenhNhan";

            // 🔹 Load danh sách Bác Sĩ (chỉ người có PhanQuyen = 2)
            CmbBacSi.DataSource = HoSoKhamBenhBUS.GetAllBacSi();
            CmbBacSi.DisplayMember = "Ten";
            CmbBacSi.ValueMember = "MaNV";

            // 🔹 Load danh sách Trạng Thái
            CmbTrangThai.Items.Add("Chờ khám");
            CmbTrangThai.Items.Add("Đã khám");
        }
        private void LoadHoSo(int maHoSo)
        {
            DataTable dt = HoSoKhamBenhBUS.GetHoSoById(maHoSo);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Lbl_mahoso.Text = row["MaHoSo"].ToString();
                CmbBenhNhan.SelectedValue = row["MaBenhNhan"];
                CmbBacSi.SelectedValue = row["MaBacSi"];
                TxtTrieuChung.Text = row["TrieuChung"].ToString();
                TxtKetQua.Text = row["KetQuaKham"].ToString();
                DateHen.Value = row["NgayHen"] != DBNull.Value ? Convert.ToDateTime(row["NgayHen"]) : DateTime.Now;
                CmbTrangThai.SelectedItem = row["TrangThai"].ToString();
            }
        }
        //private bool KiemTraChuoiHopLe(string input)
        //{
        //    return System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-zA-Z0-9\s,\.!?]+$");
        //}
        private void NutThem_Click(object sender, EventArgs e)
        {
            if (CmbBenhNhan.SelectedValue == null || CmbBacSi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Bệnh nhân và Bác sĩ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (string.IsNullOrWhiteSpace(TxtTrieuChung.Text) || !KiemTraChuoiHopLe(TxtTrieuChung.Text))
            //{
            //    MessageBox.Show("Triệu chứng không hợp lệ! Không được để trống hoặc chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(TxtKetQua.Text) || !KiemTraChuoiHopLe(TxtKetQua.Text))
            //{
            //    MessageBox.Show("Kết quả khám không hợp lệ! Không được để trống hoặc chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (DateHen.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày hẹn không hợp lệ! Không được nhỏ hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HoSoKhamBenhDTO hoSo = new HoSoKhamBenhDTO
            {
                MaHoSo = maHoSo ?? 0, // Nếu null thì để SQL tự tăng
                MaBenhNhan = Convert.ToInt32(CmbBenhNhan.SelectedValue),
                MaBacSi = Convert.ToInt32(CmbBacSi.SelectedValue),
                TrieuChung = TxtTrieuChung.Text,
                KetQuaKham = TxtKetQua.Text,
                NgayHen = DateHen.Value,
                TrangThai = CmbTrangThai.SelectedItem?.ToString()
            };

            bool result;
            if (maHoSo.HasValue)
            {
                result = HoSoKhamBenhBUS.UpdateHoSo(hoSo);
            }
            else
            {
                result = HoSoKhamBenhBUS.InsertHoSo(hoSo);
            }

            if (result)
            {
                MessageBox.Show("Lưu hồ sơ thành công!");
                HoSoDaCapNhat?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }
        private void NutThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBenhNhan.SelectedItem != null)
            {
                DataRowView row = CmbBenhNhan.SelectedItem as DataRowView;
                if (row != null)
                {
                    LblBN.Text = row["HoTen"].ToString();
                }
            }
        }
    }
}

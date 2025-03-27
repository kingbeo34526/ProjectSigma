namespace nigga123
{
    partial class QuanLiBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RbNu = new System.Windows.Forms.RadioButton();
            this.RbNam = new System.Windows.Forms.RadioButton();
            this.TxtTimKiem = new System.Windows.Forms.TextBox();
            this.NutThoat = new System.Windows.Forms.Button();
            this.NutXoa = new System.Windows.Forms.Button();
            this.NutSua = new System.Windows.Forms.Button();
            this.NutThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDiaChi = new System.Windows.Forms.TextBox();
            this.TxtCCCD = new System.Windows.Forms.TextBox();
            this.TxtHoVaTen = new System.Windows.Forms.TextBox();
            this.TxtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateSinh = new System.Windows.Forms.DateTimePicker();
            this.NutLamMoi = new System.Windows.Forms.Button();
            this.DgvBenhNhan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // RbNu
            // 
            this.RbNu.AutoSize = true;
            this.RbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNu.Location = new System.Drawing.Point(185, 137);
            this.RbNu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RbNu.Name = "RbNu";
            this.RbNu.Size = new System.Drawing.Size(58, 26);
            this.RbNu.TabIndex = 41;
            this.RbNu.TabStop = true;
            this.RbNu.Text = "Nữ";
            this.RbNu.UseVisualStyleBackColor = true;
            // 
            // RbNam
            // 
            this.RbNam.AutoSize = true;
            this.RbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNam.Location = new System.Drawing.Point(126, 137);
            this.RbNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RbNam.Name = "RbNam";
            this.RbNam.Size = new System.Drawing.Size(72, 26);
            this.RbNam.TabIndex = 40;
            this.RbNam.TabStop = true;
            this.RbNam.Text = "Nam";
            this.RbNam.UseVisualStyleBackColor = true;
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTimKiem.Location = new System.Drawing.Point(584, 404);
            this.TxtTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(117, 30);
            this.TxtTimKiem.TabIndex = 39;
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            // 
            // NutThoat
            // 
            this.NutThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThoat.Location = new System.Drawing.Point(353, 404);
            this.NutThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NutThoat.Name = "NutThoat";
            this.NutThoat.Size = new System.Drawing.Size(108, 40);
            this.NutThoat.TabIndex = 37;
            this.NutThoat.Text = "Thoát";
            this.NutThoat.UseVisualStyleBackColor = true;
            this.NutThoat.Click += new System.EventHandler(this.NutThoat_Click);
            // 
            // NutXoa
            // 
            this.NutXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutXoa.Location = new System.Drawing.Point(239, 404);
            this.NutXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NutXoa.Name = "NutXoa";
            this.NutXoa.Size = new System.Drawing.Size(108, 40);
            this.NutXoa.TabIndex = 36;
            this.NutXoa.Text = "Xóa";
            this.NutXoa.UseVisualStyleBackColor = true;
            this.NutXoa.Click += new System.EventHandler(this.NutXoa_Click);
            // 
            // NutSua
            // 
            this.NutSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutSua.Location = new System.Drawing.Point(125, 404);
            this.NutSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NutSua.Name = "NutSua";
            this.NutSua.Size = new System.Drawing.Size(108, 40);
            this.NutSua.TabIndex = 35;
            this.NutSua.Text = "Sửa ";
            this.NutSua.UseVisualStyleBackColor = true;
            this.NutSua.Click += new System.EventHandler(this.NutSua_Click);
            // 
            // NutThem
            // 
            this.NutThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThem.Location = new System.Drawing.Point(11, 404);
            this.NutThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NutThem.Name = "NutThem";
            this.NutThem.Size = new System.Drawing.Size(108, 40);
            this.NutThem.TabIndex = 34;
            this.NutThem.Text = "Thêm ";
            this.NutThem.UseVisualStyleBackColor = true;
            this.NutThem.Click += new System.EventHandler(this.NutThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Số CMND/CCCD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Họ và Tên:";
            // 
            // TxtDiaChi
            // 
            this.TxtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiaChi.Location = new System.Drawing.Point(384, 89);
            this.TxtDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDiaChi.Name = "TxtDiaChi";
            this.TxtDiaChi.Size = new System.Drawing.Size(199, 26);
            this.TxtDiaChi.TabIndex = 25;
            // 
            // TxtCCCD
            // 
            this.TxtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCCCD.Location = new System.Drawing.Point(126, 89);
            this.TxtCCCD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCCCD.Name = "TxtCCCD";
            this.TxtCCCD.Size = new System.Drawing.Size(148, 26);
            this.TxtCCCD.TabIndex = 23;
            // 
            // TxtHoVaTen
            // 
            this.TxtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoVaTen.Location = new System.Drawing.Point(126, 33);
            this.TxtHoVaTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtHoVaTen.Name = "TxtHoVaTen";
            this.TxtHoVaTen.Size = new System.Drawing.Size(148, 28);
            this.TxtHoVaTen.TabIndex = 22;
            // 
            // TxtSDT
            // 
            this.TxtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSDT.Location = new System.Drawing.Point(385, 137);
            this.TxtSDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.Size = new System.Drawing.Size(198, 26);
            this.TxtSDT.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ngày sinh:";
            // 
            // DateSinh
            // 
            this.DateSinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSinh.Location = new System.Drawing.Point(385, 33);
            this.DateSinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateSinh.Name = "DateSinh";
            this.DateSinh.Size = new System.Drawing.Size(198, 28);
            this.DateSinh.TabIndex = 43;
            // 
            // NutLamMoi
            // 
            this.NutLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutLamMoi.Location = new System.Drawing.Point(466, 404);
            this.NutLamMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NutLamMoi.Name = "NutLamMoi";
            this.NutLamMoi.Size = new System.Drawing.Size(108, 40);
            this.NutLamMoi.TabIndex = 44;
            this.NutLamMoi.Text = "Làm mới";
            this.NutLamMoi.UseVisualStyleBackColor = true;
            this.NutLamMoi.Click += new System.EventHandler(this.NutLamMoi_Click);
            // 
            // DgvBenhNhan
            // 
            this.DgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBenhNhan.Location = new System.Drawing.Point(11, 169);
            this.DgvBenhNhan.Name = "DgvBenhNhan";
            this.DgvBenhNhan.RowHeadersWidth = 62;
            this.DgvBenhNhan.RowTemplate.Height = 28;
            this.DgvBenhNhan.Size = new System.Drawing.Size(692, 229);
            this.DgvBenhNhan.TabIndex = 45;
            // 
            // QuanLiBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 454);
            this.Controls.Add(this.DgvBenhNhan);
            this.Controls.Add(this.NutLamMoi);
            this.Controls.Add(this.DateSinh);
            this.Controls.Add(this.TxtSDT);
            this.Controls.Add(this.RbNu);
            this.Controls.Add(this.RbNam);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.NutThoat);
            this.Controls.Add(this.NutXoa);
            this.Controls.Add(this.NutSua);
            this.Controls.Add(this.NutThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDiaChi);
            this.Controls.Add(this.TxtCCCD);
            this.Controls.Add(this.TxtHoVaTen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QuanLiBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bệnh nhân";
            this.Load += new System.EventHandler(this.QuanLiBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbNu;
        private System.Windows.Forms.RadioButton RbNam;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.Windows.Forms.Button NutThoat;
        private System.Windows.Forms.Button NutXoa;
        private System.Windows.Forms.Button NutSua;
        private System.Windows.Forms.Button NutThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDiaChi;
        private System.Windows.Forms.TextBox TxtCCCD;
        private System.Windows.Forms.TextBox TxtHoVaTen;
        private System.Windows.Forms.TextBox TxtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateSinh;
        private System.Windows.Forms.Button NutLamMoi;
        private System.Windows.Forms.DataGridView DgvBenhNhan;
    }
}
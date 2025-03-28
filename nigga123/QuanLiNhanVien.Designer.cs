using System;

namespace nigga123
{
    partial class QuanLiNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMatKhau = new System.Windows.Forms.TextBox();
            this.TxtHVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RQL = new System.Windows.Forms.RadioButton();
            this.RBS = new System.Windows.Forms.RadioButton();
            this.RLT = new System.Windows.Forms.RadioButton();
            this.DgvNV = new System.Windows.Forms.DataGridView();
            this.ButtonThem = new System.Windows.Forms.Button();
            this.ButtonSua = new System.Windows.Forms.Button();
            this.ButtonXoa = new System.Windows.Forms.Button();
            this.TxtTimKiem = new System.Windows.Forms.TextBox();
            this.ButtonThoat = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(147, 43);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.ReadOnly = true;
            this.TxtUsername.Size = new System.Drawing.Size(200, 20);
            this.TxtUsername.TabIndex = 1;
            // 
            // TxtMaNV
            // 
            this.TxtMaNV.Location = new System.Drawing.Point(543, 46);
            this.TxtMaNV.Name = "TxtMaNV";
            this.TxtMaNV.ReadOnly = true;
            this.TxtMaNV.Size = new System.Drawing.Size(218, 20);
            this.TxtMaNV.TabIndex = 3;
            this.TxtMaNV.Text = "Mã tự động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // TxtMatKhau
            // 
            this.TxtMatKhau.Location = new System.Drawing.Point(147, 91);
            this.TxtMatKhau.Name = "TxtMatKhau";
            this.TxtMatKhau.ReadOnly = true;
            this.TxtMatKhau.Size = new System.Drawing.Size(200, 20);
            this.TxtMatKhau.TabIndex = 3;
            this.TxtMatKhau.Text = "Mật khẩu đã được mã hóa";
            // 
            // TxtHVT
            // 
            this.TxtHVT.Location = new System.Drawing.Point(543, 92);
            this.TxtHVT.Name = "TxtHVT";
            this.TxtHVT.Size = new System.Drawing.Size(218, 20);
            this.TxtHVT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ và Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phân quyền:";
            // 
            // RQL
            // 
            this.RQL.AutoSize = true;
            this.RQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RQL.Location = new System.Drawing.Point(144, 137);
            this.RQL.Name = "RQL";
            this.RQL.Size = new System.Drawing.Size(88, 20);
            this.RQL.TabIndex = 7;
            this.RQL.TabStop = true;
            this.RQL.Text = "Quản lý (1)";
            this.RQL.UseVisualStyleBackColor = true;
            // 
            // RBS
            // 
            this.RBS.AutoSize = true;
            this.RBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBS.Location = new System.Drawing.Point(238, 138);
            this.RBS.Name = "RBS";
            this.RBS.Size = new System.Drawing.Size(82, 20);
            this.RBS.TabIndex = 8;
            this.RBS.TabStop = true;
            this.RBS.Text = "Bác sĩ (2)";
            this.RBS.UseVisualStyleBackColor = true;
            // 
            // RLT
            // 
            this.RLT.AutoSize = true;
            this.RLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLT.Location = new System.Drawing.Point(326, 138);
            this.RLT.Name = "RLT";
            this.RLT.Size = new System.Drawing.Size(79, 20);
            this.RLT.TabIndex = 9;
            this.RLT.TabStop = true;
            this.RLT.Text = "Lễ tân (3)";
            this.RLT.UseVisualStyleBackColor = true;
            // 
            // DgvNV
            // 
            this.DgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNV.Location = new System.Drawing.Point(12, 191);
            this.DgvNV.Name = "DgvNV";
            this.DgvNV.RowHeadersWidth = 62;
            this.DgvNV.Size = new System.Drawing.Size(776, 247);
            this.DgvNV.TabIndex = 10;
            this.DgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNV_CellClick);
            // 
            // ButtonThem
            // 
            this.ButtonThem.Location = new System.Drawing.Point(261, 445);
            this.ButtonThem.Name = "ButtonThem";
            this.ButtonThem.Size = new System.Drawing.Size(128, 24);
            this.ButtonThem.TabIndex = 12;
            this.ButtonThem.Text = "Thêm";
            this.ButtonThem.UseVisualStyleBackColor = true;
            this.ButtonThem.Click += new System.EventHandler(this.ButtonThem_Click);
            // 
            // ButtonSua
            // 
            this.ButtonSua.Location = new System.Drawing.Point(394, 445);
            this.ButtonSua.Name = "ButtonSua";
            this.ButtonSua.Size = new System.Drawing.Size(128, 24);
            this.ButtonSua.TabIndex = 13;
            this.ButtonSua.Text = "Sửa";
            this.ButtonSua.UseVisualStyleBackColor = true;
            this.ButtonSua.Click += new System.EventHandler(this.ButtonSua_Click);
            // 
            // ButtonXoa
            // 
            this.ButtonXoa.Location = new System.Drawing.Point(527, 445);
            this.ButtonXoa.Name = "ButtonXoa";
            this.ButtonXoa.Size = new System.Drawing.Size(128, 24);
            this.ButtonXoa.TabIndex = 14;
            this.ButtonXoa.Text = "Xóa";
            this.ButtonXoa.UseVisualStyleBackColor = true;
            this.ButtonXoa.Click += new System.EventHandler(this.ButtonXoa_Click);
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Location = new System.Drawing.Point(12, 445);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(235, 20);
            this.TxtTimKiem.TabIndex = 15;
            this.TxtTimKiem.Text = "Nhập tên";
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // ButtonThoat
            // 
            this.ButtonThoat.Location = new System.Drawing.Point(660, 443);
            this.ButtonThoat.Name = "ButtonThoat";
            this.ButtonThoat.Size = new System.Drawing.Size(128, 26);
            this.ButtonThoat.TabIndex = 16;
            this.ButtonThoat.Text = "Thoát";
            this.ButtonThoat.UseVisualStyleBackColor = true;
            this.ButtonThoat.Click += new System.EventHandler(this.ButtonThoat_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(543, 137);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(218, 20);
            this.TxtEmail.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email:";
            // 
            // QuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.ControlBox = false;
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonThoat);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.ButtonXoa);
            this.Controls.Add(this.ButtonSua);
            this.Controls.Add(this.ButtonThem);
            this.Controls.Add(this.DgvNV);
            this.Controls.Add(this.RLT);
            this.Controls.Add(this.RBS);
            this.Controls.Add(this.RQL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtHVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label1);
            this.Name = "QuanLiNhanVien";
            this.Text = "Quản lí nhân viên";
            this.Load += new System.EventHandler(this.QuanLiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMatKhau;
        private System.Windows.Forms.TextBox TxtHVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RQL;
        private System.Windows.Forms.RadioButton RBS;
        private System.Windows.Forms.RadioButton RLT;
        private System.Windows.Forms.DataGridView DgvNV;
        private System.Windows.Forms.Button ButtonThem;
        private System.Windows.Forms.Button ButtonSua;
        private System.Windows.Forms.Button ButtonXoa;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.Windows.Forms.Button ButtonThoat;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label6;
    }
}


namespace nigga123
{
    partial class QuanLiThuoc
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
            this.DgvThuoc = new System.Windows.Forms.DataGridView();
            this.TxtTimKiem = new System.Windows.Forms.TextBox();
            this.NutThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtMaThuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGia = new System.Windows.Forms.TextBox();
            this.CbThuoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTenThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvThuoc
            // 
            this.DgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvThuoc.Location = new System.Drawing.Point(13, 227);
            this.DgvThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvThuoc.Name = "DgvThuoc";
            this.DgvThuoc.RowHeadersWidth = 62;
            this.DgvThuoc.Size = new System.Drawing.Size(561, 274);
            this.DgvThuoc.TabIndex = 1;
            this.DgvThuoc.SelectionChanged += new System.EventHandler(this.DgvThuoc_SelectionChanged);
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTimKiem.Location = new System.Drawing.Point(368, 511);
            this.TxtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(206, 29);
            this.TxtTimKiem.TabIndex = 3;
            this.TxtTimKiem.Text = "Nhập tên thuốc";
            this.TxtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            // 
            // NutThoat
            // 
            this.NutThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThoat.Location = new System.Drawing.Point(131, 511);
            this.NutThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NutThoat.Name = "NutThoat";
            this.NutThoat.Size = new System.Drawing.Size(110, 46);
            this.NutThoat.TabIndex = 7;
            this.NutThoat.Text = "Thoát";
            this.NutThoat.UseVisualStyleBackColor = true;
            this.NutThoat.Click += new System.EventHandler(this.NutThoat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtMaThuoc
            // 
            this.TxtMaThuoc.Location = new System.Drawing.Point(152, 18);
            this.TxtMaThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMaThuoc.Name = "TxtMaThuoc";
            this.TxtMaThuoc.ReadOnly = true;
            this.TxtMaThuoc.Size = new System.Drawing.Size(258, 26);
            this.TxtMaThuoc.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã thuốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giá:";
            // 
            // TxtGia
            // 
            this.TxtGia.Location = new System.Drawing.Point(152, 178);
            this.TxtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGia.Name = "TxtGia";
            this.TxtGia.Size = new System.Drawing.Size(258, 26);
            this.TxtGia.TabIndex = 16;
            // 
            // CbThuoc
            // 
            this.CbThuoc.FormattingEnabled = true;
            this.CbThuoc.Location = new System.Drawing.Point(152, 98);
            this.CbThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbThuoc.Name = "CbThuoc";
            this.CbThuoc.Size = new System.Drawing.Size(256, 28);
            this.CbThuoc.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng:";
            // 
            // TxtSL
            // 
            this.TxtSL.Location = new System.Drawing.Point(152, 138);
            this.TxtSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSL.Name = "TxtSL";
            this.TxtSL.Size = new System.Drawing.Size(258, 26);
            this.TxtSL.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đơn vị:";
            // 
            // TxtTenThuoc
            // 
            this.TxtTenThuoc.Location = new System.Drawing.Point(150, 58);
            this.TxtTenThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTenThuoc.Name = "TxtTenThuoc";
            this.TxtTenThuoc.Size = new System.Drawing.Size(258, 26);
            this.TxtTenThuoc.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên thuốc:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(429, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NutThem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(429, 98);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NutSua_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(429, 156);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NutXoa_Click);
            // 
            // QuanLiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 560);
            this.ControlBox = false;
            this.Controls.Add(this.TxtMaThuoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtGia);
            this.Controls.Add(this.CbThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTenThuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NutThoat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.DgvThuoc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLiThuoc";
            this.Text = "Quản lí thuốc";
            this.Load += new System.EventHandler(this.QuanLiThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvThuoc;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.Windows.Forms.Button NutThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtMaThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGia;
        private System.Windows.Forms.ComboBox CbThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTenThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
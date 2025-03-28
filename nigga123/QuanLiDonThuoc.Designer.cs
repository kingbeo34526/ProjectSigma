namespace nigga123
{
    partial class QuanLiDonThuoc
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
            this.TxtHoSo = new System.Windows.Forms.TextBox();
            this.TxtMaBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.DgvChiTietDonThuoc = new System.Windows.Forms.DataGridView();
            this.NutSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDonThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvChiTietDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hồ sơ:";
            // 
            // TxtHoSo
            // 
            this.TxtHoSo.Location = new System.Drawing.Point(69, 6);
            this.TxtHoSo.Name = "TxtHoSo";
            this.TxtHoSo.ReadOnly = true;
            this.TxtHoSo.Size = new System.Drawing.Size(100, 20);
            this.TxtHoSo.TabIndex = 1;
            // 
            // TxtMaBN
            // 
            this.TxtMaBN.Location = new System.Drawing.Point(251, 6);
            this.TxtMaBN.Name = "TxtMaBN";
            this.TxtMaBN.ReadOnly = true;
            this.TxtMaBN.Size = new System.Drawing.Size(100, 20);
            this.TxtMaBN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bệnh nhân:";
            // 
            // DgvDonThuoc
            // 
            this.DgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDonThuoc.Location = new System.Drawing.Point(12, 34);
            this.DgvDonThuoc.Name = "DgvDonThuoc";
            this.DgvDonThuoc.RowHeadersWidth = 62;
            this.DgvDonThuoc.Size = new System.Drawing.Size(287, 253);
            this.DgvDonThuoc.TabIndex = 4;
            this.DgvDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDonThuoc_CellClick);
            // 
            // DgvChiTietDonThuoc
            // 
            this.DgvChiTietDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvChiTietDonThuoc.Location = new System.Drawing.Point(309, 34);
            this.DgvChiTietDonThuoc.Name = "DgvChiTietDonThuoc";
            this.DgvChiTietDonThuoc.RowHeadersWidth = 62;
            this.DgvChiTietDonThuoc.Size = new System.Drawing.Size(299, 282);
            this.DgvChiTietDonThuoc.TabIndex = 5;
            // 
            // NutSua
            // 
            this.NutSua.Location = new System.Drawing.Point(12, 293);
            this.NutSua.Name = "NutSua";
            this.NutSua.Size = new System.Drawing.Size(53, 23);
            this.NutSua.TabIndex = 6;
            this.NutSua.Text = "Sửa";
            this.NutSua.UseVisualStyleBackColor = true;
            this.NutSua.Click += new System.EventHandler(this.NutSua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QuanLiDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 325);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NutSua);
            this.Controls.Add(this.DgvChiTietDonThuoc);
            this.Controls.Add(this.DgvDonThuoc);
            this.Controls.Add(this.TxtMaBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtHoSo);
            this.Controls.Add(this.label1);
            this.Name = "QuanLiDonThuoc";
            this.Text = "Quản lí đơn thuốc";
            this.Load += new System.EventHandler(this.QuanLiDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDonThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvChiTietDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHoSo;
        private System.Windows.Forms.TextBox TxtMaBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvDonThuoc;
        private System.Windows.Forms.DataGridView DgvChiTietDonThuoc;
        private System.Windows.Forms.Button NutSua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
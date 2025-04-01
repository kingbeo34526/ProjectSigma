namespace nigga123
{
    partial class ThongKe
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
            this.tcthongke = new System.Windows.Forms.TabControl();
            this.tPBenhNhan = new System.Windows.Forms.TabPage();
            this.lbtbn = new System.Windows.Forms.Label();
            this.TxtTong = new System.Windows.Forms.TextBox();
            this.CbTT = new System.Windows.Forms.ComboBox();
            this.DgvBN = new System.Windows.Forms.DataGridView();
            this.tPThuoc = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTSLT = new System.Windows.Forms.TextBox();
            this.DgvThuoc = new System.Windows.Forms.DataGridView();
            this.CbXuat = new System.Windows.Forms.ComboBox();
            this.NutXuat = new System.Windows.Forms.Button();
            this.NutThoat = new System.Windows.Forms.Button();
            this.tcthongke.SuspendLayout();
            this.tPBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBN)).BeginInit();
            this.tPThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tcthongke
            // 
            this.tcthongke.Controls.Add(this.tPBenhNhan);
            this.tcthongke.Controls.Add(this.tPThuoc);
            this.tcthongke.Location = new System.Drawing.Point(18, 18);
            this.tcthongke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcthongke.Name = "tcthongke";
            this.tcthongke.SelectedIndex = 0;
            this.tcthongke.Size = new System.Drawing.Size(1164, 655);
            this.tcthongke.TabIndex = 0;
            // 
            // tPBenhNhan
            // 
            this.tPBenhNhan.Controls.Add(this.lbtbn);
            this.tPBenhNhan.Controls.Add(this.TxtTong);
            this.tPBenhNhan.Controls.Add(this.CbTT);
            this.tPBenhNhan.Controls.Add(this.DgvBN);
            this.tPBenhNhan.Location = new System.Drawing.Point(4, 29);
            this.tPBenhNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPBenhNhan.Name = "tPBenhNhan";
            this.tPBenhNhan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPBenhNhan.Size = new System.Drawing.Size(1156, 622);
            this.tPBenhNhan.TabIndex = 0;
            this.tPBenhNhan.Text = "Bệnh nhân";
            this.tPBenhNhan.UseVisualStyleBackColor = true;
            // 
            // lbtbn
            // 
            this.lbtbn.AutoSize = true;
            this.lbtbn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtbn.Location = new System.Drawing.Point(9, 18);
            this.lbtbn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtbn.Name = "lbtbn";
            this.lbtbn.Size = new System.Drawing.Size(141, 23);
            this.lbtbn.TabIndex = 5;
            this.lbtbn.Text = "Tổng bệnh nhân:";
            // 
            // TxtTong
            // 
            this.TxtTong.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTong.Location = new System.Drawing.Point(152, 14);
            this.TxtTong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTong.Name = "TxtTong";
            this.TxtTong.Size = new System.Drawing.Size(174, 29);
            this.TxtTong.TabIndex = 4;
            // 
            // CbTT
            // 
            this.CbTT.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTT.FormattingEnabled = true;
            this.CbTT.Items.AddRange(new object[] {
            "Đã Khám",
            "Chờ Khám"});
            this.CbTT.Location = new System.Drawing.Point(962, 12);
            this.CbTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbTT.Name = "CbTT";
            this.CbTT.Size = new System.Drawing.Size(180, 31);
            this.CbTT.TabIndex = 3;
            this.CbTT.Text = "Tình trạng";
            this.CbTT.SelectedIndexChanged += new System.EventHandler(this.CbTT_SelectedIndexChanged);
            // 
            // DgvBN
            // 
            this.DgvBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBN.Location = new System.Drawing.Point(9, 57);
            this.DgvBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvBN.Name = "DgvBN";
            this.DgvBN.RowHeadersWidth = 62;
            this.DgvBN.Size = new System.Drawing.Size(1134, 549);
            this.DgvBN.TabIndex = 2;
            this.DgvBN.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvBN_CellFormatting);
            // 
            // tPThuoc
            // 
            this.tPThuoc.Controls.Add(this.label1);
            this.tPThuoc.Controls.Add(this.TxtTSLT);
            this.tPThuoc.Controls.Add(this.DgvThuoc);
            this.tPThuoc.Location = new System.Drawing.Point(4, 29);
            this.tPThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPThuoc.Name = "tPThuoc";
            this.tPThuoc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPThuoc.Size = new System.Drawing.Size(1156, 622);
            this.tPThuoc.TabIndex = 1;
            this.tPThuoc.Text = "Thuốc";
            this.tPThuoc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số loại thuốc:";
            // 
            // TxtTSLT
            // 
            this.TxtTSLT.Location = new System.Drawing.Point(138, 17);
            this.TxtTSLT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTSLT.Name = "TxtTSLT";
            this.TxtTSLT.Size = new System.Drawing.Size(169, 26);
            this.TxtTSLT.TabIndex = 1;
            // 
            // DgvThuoc
            // 
            this.DgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvThuoc.Location = new System.Drawing.Point(9, 57);
            this.DgvThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvThuoc.Name = "DgvThuoc";
            this.DgvThuoc.RowHeadersWidth = 62;
            this.DgvThuoc.Size = new System.Drawing.Size(1134, 549);
            this.DgvThuoc.TabIndex = 1;
            this.DgvThuoc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvThuoc_CellFormatting);
            this.DgvThuoc.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvThuoc_DataError);
            // 
            // CbXuat
            // 
            this.CbXuat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbXuat.FormattingEnabled = true;
            this.CbXuat.Location = new System.Drawing.Point(24, 683);
            this.CbXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbXuat.Name = "CbXuat";
            this.CbXuat.Size = new System.Drawing.Size(180, 31);
            this.CbXuat.TabIndex = 1;
            // 
            // NutXuat
            // 
            this.NutXuat.Location = new System.Drawing.Point(214, 680);
            this.NutXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NutXuat.Name = "NutXuat";
            this.NutXuat.Size = new System.Drawing.Size(136, 35);
            this.NutXuat.TabIndex = 2;
            this.NutXuat.Text = "Xuất Excel";
            this.NutXuat.UseVisualStyleBackColor = true;
            this.NutXuat.Click += new System.EventHandler(this.NutXuat_Click);
            // 
            // NutThoat
            // 
            this.NutThoat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThoat.Location = new System.Drawing.Point(1040, 683);
            this.NutThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NutThoat.Name = "NutThoat";
            this.NutThoat.Size = new System.Drawing.Size(136, 35);
            this.NutThoat.TabIndex = 3;
            this.NutThoat.Text = "Thoát";
            this.NutThoat.UseVisualStyleBackColor = true;
            this.NutThoat.Click += new System.EventHandler(this.NutThoat_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 731);
            this.ControlBox = false;
            this.Controls.Add(this.NutThoat);
            this.Controls.Add(this.NutXuat);
            this.Controls.Add(this.CbXuat);
            this.Controls.Add(this.tcthongke);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.tcthongke.ResumeLayout(false);
            this.tPBenhNhan.ResumeLayout(false);
            this.tPBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBN)).EndInit();
            this.tPThuoc.ResumeLayout(false);
            this.tPThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcthongke;
        private System.Windows.Forms.TabPage tPBenhNhan;
        private System.Windows.Forms.TabPage tPThuoc;
        private System.Windows.Forms.DataGridView DgvThuoc;
        private System.Windows.Forms.ComboBox CbTT;
        private System.Windows.Forms.DataGridView DgvBN;
        private System.Windows.Forms.Label lbtbn;
        private System.Windows.Forms.TextBox TxtTong;
        private System.Windows.Forms.TextBox TxtTSLT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbXuat;
        private System.Windows.Forms.Button NutXuat;
        private System.Windows.Forms.Button NutThoat;
    }
}
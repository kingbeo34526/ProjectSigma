namespace nigga123
{
    partial class DangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_Password = new System.Windows.Forms.TextBox();
            this.GhiNhoMatKhau = new System.Windows.Forms.CheckBox();
            this.NutDangNhap = new System.Windows.Forms.Button();
            this.NutThoat = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // Txb_Username
            // 
            this.Txb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Username.Location = new System.Drawing.Point(52, 172);
            this.Txb_Username.Name = "Txb_Username";
            this.Txb_Username.Size = new System.Drawing.Size(422, 28);
            this.Txb_Username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // Txb_Password
            // 
            this.Txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Password.Location = new System.Drawing.Point(52, 270);
            this.Txb_Password.Name = "Txb_Password";
            this.Txb_Password.Size = new System.Drawing.Size(422, 26);
            this.Txb_Password.TabIndex = 5;
            this.Txb_Password.UseSystemPasswordChar = true;
            // 
            // GhiNhoMatKhau
            // 
            this.GhiNhoMatKhau.AutoSize = true;
            this.GhiNhoMatKhau.Location = new System.Drawing.Point(52, 324);
            this.GhiNhoMatKhau.Name = "GhiNhoMatKhau";
            this.GhiNhoMatKhau.Size = new System.Drawing.Size(171, 24);
            this.GhiNhoMatKhau.TabIndex = 6;
            this.GhiNhoMatKhau.Text = "Ghi nhớ đăng nhập";
            this.GhiNhoMatKhau.UseVisualStyleBackColor = true;
            // 
            // NutDangNhap
            // 
            this.NutDangNhap.Location = new System.Drawing.Point(187, 401);
            this.NutDangNhap.Name = "NutDangNhap";
            this.NutDangNhap.Size = new System.Drawing.Size(166, 42);
            this.NutDangNhap.TabIndex = 8;
            this.NutDangNhap.Text = "Đăng nhập";
            this.NutDangNhap.UseVisualStyleBackColor = true;
            this.NutDangNhap.Click += new System.EventHandler(this.NutDangNhap_Click);
            // 
            // NutThoat
            // 
            this.NutThoat.Location = new System.Drawing.Point(187, 449);
            this.NutThoat.Name = "NutThoat";
            this.NutThoat.Size = new System.Drawing.Size(166, 42);
            this.NutThoat.TabIndex = 9;
            this.NutThoat.Text = "Thoát";
            this.NutThoat.UseVisualStyleBackColor = true;
            this.NutThoat.Click += new System.EventHandler(this.NutThoat_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(347, 328);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 530);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.NutThoat);
            this.Controls.Add(this.NutDangNhap);
            this.Controls.Add(this.GhiNhoMatKhau);
            this.Controls.Add(this.Txb_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txb_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_Password;
        private System.Windows.Forms.CheckBox GhiNhoMatKhau;
        private System.Windows.Forms.Button NutDangNhap;
        private System.Windows.Forms.Button NutThoat;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
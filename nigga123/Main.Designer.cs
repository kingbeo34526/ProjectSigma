﻿using System.Drawing;
using System.Windows.Forms;

namespace nigga123
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hệThốngTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quyềnHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuKhámBệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblThongTin = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip2.ForeColor = System.Drawing.Color.Black;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngTàiKhoảnToolStripMenuItem,
            this.quảnToolStripMenuItem,
            this.quảnLýThuốcToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(1052, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // hệThốngTàiKhoảnToolStripMenuItem
            // 
            this.hệThốngTàiKhoảnToolStripMenuItem.Checked = true;
            this.hệThốngTàiKhoảnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hệThốngTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quyềnHạnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngTàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngTàiKhoảnToolStripMenuItem.Image")));
            this.hệThốngTàiKhoảnToolStripMenuItem.Name = "hệThốngTàiKhoảnToolStripMenuItem";
            this.hệThốngTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.hệThốngTàiKhoảnToolStripMenuItem.Text = "TAIKHOAN";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đổiMậtKhẩuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.đổiMậtKhẩuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image")));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem1.Text = "Đăng xuất";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // quyềnHạnToolStripMenuItem
            // 
            this.quyềnHạnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíTàiKhoảnToolStripMenuItem});
            this.quyềnHạnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quyềnHạnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quyềnHạnToolStripMenuItem.Image")));
            this.quyềnHạnToolStripMenuItem.Name = "quyềnHạnToolStripMenuItem";
            this.quyềnHạnToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.quyềnHạnToolStripMenuItem.Text = "Quyền hạn";
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            this.quảnLíTàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLíTàiKhoảnToolStripMenuItem.Image")));
            this.quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            this.quảnLíTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản lí tài khoản";
            this.quảnLíTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíTàiKhoảnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnToolStripMenuItem
            // 
            this.quảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bệnhNhânToolStripMenuItem,
            this.phiếuKhámBệnhToolStripMenuItem});
            this.quảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnToolStripMenuItem.Name = "quảnToolStripMenuItem";
            this.quảnToolStripMenuItem.Size = new System.Drawing.Size(125, 28);
            this.quảnToolStripMenuItem.Text = "Quản lý khám bệnh";
            // 
            // bệnhNhânToolStripMenuItem
            // 
            this.bệnhNhânToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bệnhNhânToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bệnhNhânToolStripMenuItem.Image")));
            this.bệnhNhânToolStripMenuItem.Name = "bệnhNhânToolStripMenuItem";
            this.bệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bệnhNhânToolStripMenuItem.Text = "Quản lý bệnh nhân";
            this.bệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.bệnhNhânToolStripMenuItem_Click);
            // 
            // phiếuKhámBệnhToolStripMenuItem
            // 
            this.phiếuKhámBệnhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phiếuKhámBệnhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phiếuKhámBệnhToolStripMenuItem.Image")));
            this.phiếuKhámBệnhToolStripMenuItem.Name = "phiếuKhámBệnhToolStripMenuItem";
            this.phiếuKhámBệnhToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.phiếuKhámBệnhToolStripMenuItem.Text = "Phiếu khám bệnh";
            this.phiếuKhámBệnhToolStripMenuItem.Click += new System.EventHandler(this.phiếuKhámBệnhToolStripMenuItem_Click);
            // 
            // quảnLýThuốcToolStripMenuItem
            // 
            this.quảnLýThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýThuốcToolStripMenuItem.Name = "quảnLýThuốcToolStripMenuItem";
            this.quảnLýThuốcToolStripMenuItem.Size = new System.Drawing.Size(95, 28);
            this.quảnLýThuốcToolStripMenuItem.Text = "Quản lý thuốc";
            this.quảnLýThuốcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThuốcToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(74, 28);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // LblThongTin
            // 
            this.LblThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblThongTin.AutoSize = true;
            this.LblThongTin.BackColor = System.Drawing.Color.Transparent;
            this.LblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThongTin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblThongTin.Location = new System.Drawing.Point(11, 604);
            this.LblThongTin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblThongTin.Name = "LblThongTin";
            this.LblThongTin.Size = new System.Drawing.Size(73, 17);
            this.LblThongTin.TabIndex = 3;
            this.LblThongTin.Text = "Đang tải...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1052, 630);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.LblThongTin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hệThốngTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuKhámBệnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyềnHạnToolStripMenuItem;
        private System.Windows.Forms.Label LblThongTin;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}


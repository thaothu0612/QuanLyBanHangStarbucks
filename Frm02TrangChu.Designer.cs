namespace QuanLyBanHangStarbucks
{
    partial class Frm02TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm02TrangChu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TSMHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMQLBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMMatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMKhuyenMai = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.STMQLHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.STMCTHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNhapXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCTPN = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBaoCaoHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBaoCaoKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMHeThong,
            this.TSMQLBanHang,
            this.TSMThongTin,
            this.STMQLHoaDon,
            this.TSMNhapXuat,
            this.TSMBaoCao,
            this.TSMTroGiup});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1440, 32);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // TSMHeThong
            // 
            this.TSMHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMDangXuat});
            this.TSMHeThong.ForeColor = System.Drawing.Color.White;
            this.TSMHeThong.Name = "TSMHeThong";
            this.TSMHeThong.Size = new System.Drawing.Size(106, 28);
            this.TSMHeThong.Text = "Hệ thống";
            // 
            // TSMDangXuat
            // 
            this.TSMDangXuat.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMDangXuat.Name = "TSMDangXuat";
            this.TSMDangXuat.Size = new System.Drawing.Size(186, 28);
            this.TSMDangXuat.Text = "Đăng xuất";
            this.TSMDangXuat.Click += new System.EventHandler(this.TSMDangXuat_Click);
            // 
            // TSMQLBanHang
            // 
            this.TSMQLBanHang.ForeColor = System.Drawing.Color.White;
            this.TSMQLBanHang.Name = "TSMQLBanHang";
            this.TSMQLBanHang.Size = new System.Drawing.Size(181, 28);
            this.TSMQLBanHang.Text = "Quản lý bán hàng";
            // 
            // TSMThongTin
            // 
            this.TSMThongTin.BackColor = System.Drawing.Color.SeaGreen;
            this.TSMThongTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMMatHang,
            this.TSMKhuyenMai,
            this.TSMKhachHang,
            this.TSMNhanVien,
            this.TSMTaiKhoan});
            this.TSMThongTin.ForeColor = System.Drawing.Color.White;
            this.TSMThongTin.Name = "TSMThongTin";
            this.TSMThongTin.Size = new System.Drawing.Size(109, 28);
            this.TSMThongTin.Text = "Thông tin";
            // 
            // TSMMatHang
            // 
            this.TSMMatHang.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMMatHang.Name = "TSMMatHang";
            this.TSMMatHang.Size = new System.Drawing.Size(288, 28);
            this.TSMMatHang.Text = "Thông tin mặt hàng";
            this.TSMMatHang.Click += new System.EventHandler(this.TSMMatHang_Click);
            // 
            // TSMKhuyenMai
            // 
            this.TSMKhuyenMai.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMKhuyenMai.Name = "TSMKhuyenMai";
            this.TSMKhuyenMai.Size = new System.Drawing.Size(288, 28);
            this.TSMKhuyenMai.Text = "Thông tin khuyến mãi";
            this.TSMKhuyenMai.Click += new System.EventHandler(this.TSMKhuyenMai_Click);
            // 
            // TSMKhachHang
            // 
            this.TSMKhachHang.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMKhachHang.Name = "TSMKhachHang";
            this.TSMKhachHang.Size = new System.Drawing.Size(288, 28);
            this.TSMKhachHang.Text = "Thông tin khách hàng";
            this.TSMKhachHang.Click += new System.EventHandler(this.TSMKhachHang_Click);
            // 
            // TSMNhanVien
            // 
            this.TSMNhanVien.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMNhanVien.Name = "TSMNhanVien";
            this.TSMNhanVien.Size = new System.Drawing.Size(288, 28);
            this.TSMNhanVien.Text = "Thông tin nhân viên";
            this.TSMNhanVien.Click += new System.EventHandler(this.TSMNhanVien_Click);
            // 
            // TSMTaiKhoan
            // 
            this.TSMTaiKhoan.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMTaiKhoan.Name = "TSMTaiKhoan";
            this.TSMTaiKhoan.Size = new System.Drawing.Size(288, 28);
            this.TSMTaiKhoan.Text = "Thông tin tài khoản";
            this.TSMTaiKhoan.Click += new System.EventHandler(this.TSMTaiKhoan_Click);
            // 
            // STMQLHoaDon
            // 
            this.STMQLHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMHoaDon,
            this.STMCTHoaDon});
            this.STMQLHoaDon.ForeColor = System.Drawing.Color.White;
            this.STMQLHoaDon.Name = "STMQLHoaDon";
            this.STMQLHoaDon.Size = new System.Drawing.Size(99, 28);
            this.STMQLHoaDon.Text = "Hóa đơn";
            // 
            // TSMHoaDon
            // 
            this.TSMHoaDon.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMHoaDon.Name = "TSMHoaDon";
            this.TSMHoaDon.Size = new System.Drawing.Size(257, 28);
            this.TSMHoaDon.Text = "Thông tin hóa đơn";
            this.TSMHoaDon.Click += new System.EventHandler(this.TSMHoaDon_Click);
            // 
            // STMCTHoaDon
            // 
            this.STMCTHoaDon.ForeColor = System.Drawing.Color.DarkGreen;
            this.STMCTHoaDon.Name = "STMCTHoaDon";
            this.STMCTHoaDon.Size = new System.Drawing.Size(257, 28);
            this.STMCTHoaDon.Text = "Chi tiết hóa đơn";
            this.STMCTHoaDon.Click += new System.EventHandler(this.STMCTHoaDon_Click);
            // 
            // TSMNhapXuat
            // 
            this.TSMNhapXuat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMPhieuNhap,
            this.TSMCTPN});
            this.TSMNhapXuat.ForeColor = System.Drawing.Color.White;
            this.TSMNhapXuat.Name = "TSMNhapXuat";
            this.TSMNhapXuat.Size = new System.Drawing.Size(108, 28);
            this.TSMNhapXuat.Text = "Nhập kho";
            // 
            // TSMPhieuNhap
            // 
            this.TSMPhieuNhap.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMPhieuNhap.Name = "TSMPhieuNhap";
            this.TSMPhieuNhap.Size = new System.Drawing.Size(301, 28);
            this.TSMPhieuNhap.Text = "Phiếu nhập kho";
            this.TSMPhieuNhap.Click += new System.EventHandler(this.TSMPhieuNhap_Click);
            // 
            // TSMCTPN
            // 
            this.TSMCTPN.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMCTPN.Name = "TSMCTPN";
            this.TSMCTPN.Size = new System.Drawing.Size(301, 28);
            this.TSMCTPN.Text = "Chi tiết phiếu nhập kho";
            this.TSMCTPN.Click += new System.EventHandler(this.TSMCTPN_Click);
            // 
            // TSMBaoCao
            // 
            this.TSMBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMBaoCaoHoaDon,
            this.TSMBaoCaoKhachHang});
            this.TSMBaoCao.ForeColor = System.Drawing.Color.White;
            this.TSMBaoCao.Name = "TSMBaoCao";
            this.TSMBaoCao.Size = new System.Drawing.Size(95, 28);
            this.TSMBaoCao.Text = "Báo cáo";
            // 
            // TSMBaoCaoHoaDon
            // 
            this.TSMBaoCaoHoaDon.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMBaoCaoHoaDon.Name = "TSMBaoCaoHoaDon";
            this.TSMBaoCaoHoaDon.Size = new System.Drawing.Size(273, 28);
            this.TSMBaoCaoHoaDon.Text = "Báo cáo hóa đơn";
            this.TSMBaoCaoHoaDon.Click += new System.EventHandler(this.TSMBaoCaoHoaDon_Click);
            // 
            // TSMBaoCaoKhachHang
            // 
            this.TSMBaoCaoKhachHang.ForeColor = System.Drawing.Color.DarkGreen;
            this.TSMBaoCaoKhachHang.Name = "TSMBaoCaoKhachHang";
            this.TSMBaoCaoKhachHang.Size = new System.Drawing.Size(273, 28);
            this.TSMBaoCaoKhachHang.Text = "Báo cáo khách hàng";
            this.TSMBaoCaoKhachHang.Click += new System.EventHandler(this.TSMBaoCaoKhachHang_Click);
            // 
            // TSMTroGiup
            // 
            this.TSMTroGiup.ForeColor = System.Drawing.Color.White;
            this.TSMTroGiup.Name = "TSMTroGiup";
            this.TSMTroGiup.Size = new System.Drawing.Size(98, 28);
            this.TSMTroGiup.Text = "Trợ giúp";
            // 
            // Frm02TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1440, 746);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Frm02TrangChu";
            this.Text = "TrangChu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TSMHeThong;
        private System.Windows.Forms.ToolStripMenuItem TSMDangXuat;
        private System.Windows.Forms.ToolStripMenuItem TSMQLBanHang;
        private System.Windows.Forms.ToolStripMenuItem TSMThongTin;
        private System.Windows.Forms.ToolStripMenuItem TSMMatHang;
        private System.Windows.Forms.ToolStripMenuItem TSMKhuyenMai;
        private System.Windows.Forms.ToolStripMenuItem TSMKhachHang;
        private System.Windows.Forms.ToolStripMenuItem TSMNhanVien;
        private System.Windows.Forms.ToolStripMenuItem TSMNhapXuat;
        private System.Windows.Forms.ToolStripMenuItem TSMPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem TSMCTPN;
        private System.Windows.Forms.ToolStripMenuItem TSMBaoCao;
        private System.Windows.Forms.ToolStripMenuItem TSMBaoCaoHoaDon;
        private System.Windows.Forms.ToolStripMenuItem TSMBaoCaoKhachHang;
        private System.Windows.Forms.ToolStripMenuItem TSMTroGiup;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private ToolStripMenuItem TSMTaiKhoan;
        private ToolStripMenuItem STMQLHoaDon;
        private ToolStripMenuItem TSMHoaDon;
        private ToolStripMenuItem STMCTHoaDon;
    }
}
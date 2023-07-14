using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanHangStarbucks
{
    public partial class Frm02TrangChu : Form
    {
        public Frm02TrangChu()
        {
            InitializeComponent();
        }

        private void TSMDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = (MessageBox.Show("Bạn có muốn đăng xuất?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (ThongBao == DialogResult.Yes)
            {
                this.Hide();
                Frm01Login lg = new Frm01Login();
                lg.ShowDialog();
            }
        }

        private void TSMMatHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm03QuanLyMatHang MH = new Frm03QuanLyMatHang();
            MH.Show();
        }

        private void TSMKhuyenMai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm04QuanLyKhuyenMai KM = new Frm04QuanLyKhuyenMai();
            KM.Show();
        }

        private void TSMTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm05QuanLyTaiKhoan TK = new Frm05QuanLyTaiKhoan();
            TK.Show();
        }

        private void TSMNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm06QuanLyNhanVien NV = new Frm06QuanLyNhanVien();
            NV.Show();
        }

        private void TSMKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm07QuanLyKhachHang KH = new Frm07QuanLyKhachHang();
            KH.Show();
        }
        private void TSMHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm08QuanLyHoaDon HD = new Frm08QuanLyHoaDon();
            HD.Show();
        }

        private void STMCTHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm09ChiTietHoaDon CTHD = new Frm09ChiTietHoaDon();
            CTHD.Show();
        }
        private void TSMPhieuNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm10QuanLyPhieuNhap PN = new Frm10QuanLyPhieuNhap();
            PN.Show();
        }

        private void TSMCTPN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm11ChiTietPhieuNhap CTPN = new Frm11ChiTietPhieuNhap();
            CTPN.Show();
        }

        private void TSMBaoCaoHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm12BaoCaoHoaDon BCHD = new Frm12BaoCaoHoaDon();
            BCHD.Show();
        }

        private void TSMBaoCaoKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm13BaoCaoKhachHang BCKH = new Frm13BaoCaoKhachHang();
            BCKH.Show();
        }
    }
}

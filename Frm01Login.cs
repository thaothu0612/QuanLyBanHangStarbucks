using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;

namespace QuanLyBanHangStarbucks
{
    public partial class Frm01Login : Form
    {
        public Frm01Login()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string TaiKhoan = txtDangNhap.Text;
            string MatKhau = txtMatKhau.Text;

            string select = @"select *from Account where Code='" + TaiKhoan + "' and Password ='" + MatKhau + "'";
            SqlCommand cmd = new SqlCommand(select, KN.GetConnect());
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read() == true)
                {
                    Frm02TrangChu main = new Frm02TrangChu();
                    this.Hide();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công! \nKiểm tra lại tên tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = (MessageBox.Show("Bạn có muốn thoát?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (ThongBao == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                if (ThongBao == DialogResult.No)
                {
                    Frm01Login lg = new Frm01Login();
                    lg.Visible = true;
                }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPassword.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else if(cbPassword.Checked == false)
            {
                txtMatKhau.UseSystemPasswordChar=false;
            }
        }
    }
}

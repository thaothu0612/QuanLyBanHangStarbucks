using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangStarbucks
{
    public partial class Frm05QuanLyTaiKhoan : Form
    {
        public Frm05QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();

        private void Frm05QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinTK();
            dgvTaiKhoan.DataSource = bdsource;
            txtCodeTK.Focus();
            dgvTaiKhoan.Columns[0].HeaderText = "Id";
            dgvTaiKhoan.Columns[1].HeaderText = "Mã tài khoản";
            dgvTaiKhoan.Columns[2].HeaderText = "Mật khẩu";
            dgvTaiKhoan.Columns[3].HeaderText = "Chức vụ";
            dgvTaiKhoan.Columns[4].HeaderText = "Mã nhân viên";

            DataGridView dgv = dgvTaiKhoan;
            dgv.Columns[0].Width = 180;
            dgv.Columns[1].Width = 200;
            dgv.Columns[2].Width = 200;
            dgv.Columns[3].Width = 300;
            dgv.Columns[4].Width = 200;
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }

            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            int ViTri = dgvTaiKhoan.CurrentCell.RowIndex;
            txtCodeTK.Text = dgvTaiKhoan.Rows[ViTri].Cells[1].Value.ToString();
            txtPassword.Text = dgvTaiKhoan.Rows[ViTri].Cells[2].Value.ToString();
            txtChucVu.Text = dgvTaiKhoan.Rows[ViTri].Cells[3].Value.ToString();
            txtStaffId.Text = dgvTaiKhoan.Rows[ViTri].Cells[4].Value.ToString();
        }

        private void rdCodeMH_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinTK();
            dgvTaiKhoan.DataSource = bdsource;
        }

        private void rdNameMH_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinTK();
            dgvTaiKhoan.DataSource = bdsource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from Account"));
            if (rdCodeMH.Checked == true)
            {
                dv.RowFilter = String.Format(" Code LIKE '%{0}%'", txtTimKiem.Text);
                dgvTaiKhoan.DataSource = dv;
            }
            else
            {
                dv.RowFilter = "StaffId = " + txtTimKiem.Text;
                dgvTaiKhoan.DataSource = dv;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = txtCodeTK.Text;
                string Password = txtPassword.Text;
                string Position = txtChucVu.Text;
                string StaffId = txtStaffId.Text;

                string insert = @"insert into Account (Code, Password, Position, StaffId) values
                        ('" + Code + "', '" + Password + " ', N'" + Position + " ', '" + StaffId + "'); ";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + Code, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm05QuanLyTaiKhoan_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = txtCodeTK.Text;
                string Password = txtPassword.Text;
                string Position = txtChucVu.Text;
                string StaffId = txtStaffId.Text;
                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn xóa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string delete = @"delete from Account 
                        where Code ='" + Code + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + Code + " " + Name, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm05QuanLyTaiKhoan_Load(sender, e);
                    txtCodeTK.Clear();
                    txtPassword.Clear();
                    txtChucVu.Clear();
                    txtStaffId.ResetText();
                    txtCodeTK.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = txtCodeTK.Text;
                string Password = txtPassword.Text;
                string Position = txtChucVu.Text;
                string StaffId = txtStaffId.Text;
                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn sửa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string update = @"update Account set Code = '" + Code + "',Password=N'" + Password + "',Position=N'" + Position + "',StaffId=N'" + StaffId + "' WHERE Code='" + Code + "';";
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm05QuanLyTaiKhoan_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm05QuanLyTaiKhoan_Load(sender, e);
            txtCodeTK.Clear();
            txtPassword.Clear();
            txtChucVu.Clear();
            txtStaffId.Clear();
            txtCodeTK.Focus();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dgvTaiKhoan_SelectionChanged(sender, e);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bdsource.Position -= 1;
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dgvTaiKhoan_SelectionChanged(sender, e);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            bdsource.Position += 1;
            if (bdsource.Position == bdsource.Count - 1)
            {
                btnSau.Enabled = false;
                btnCuoi.Enabled = false;
            }
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            dgvTaiKhoan_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            btnSau.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dgvTaiKhoan_SelectionChanged(sender, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = (MessageBox.Show("Bạn có muốn về trang chủ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (ThongBao == DialogResult.Yes)
            {
                this.Close();
                this.Hide();
                Frm02TrangChu main = new Frm02TrangChu();
                main.ShowDialog();
            }
        }
    }
}

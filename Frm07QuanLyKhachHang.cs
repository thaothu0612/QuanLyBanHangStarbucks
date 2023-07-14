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
    public partial class Frm07QuanLyKhachHang : Form
    {
        public Frm07QuanLyKhachHang()
        {
            InitializeComponent();
        }

        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();

        private void Frm07QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinKH();
            dgvKhachHang.DataSource = bdsource;
            txtCodeKH.Focus();
            dgvKhachHang.Columns[0].HeaderText = "Id";
            dgvKhachHang.Columns[1].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[3].HeaderText = "Giới tính";
            dgvKhachHang.Columns[4].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[5].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[6].HeaderText = "Email";

            DataGridView dgv = dgvKhachHang;
            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 255;
            dgv.Columns[3].Width = 120;
            dgv.Columns[4].Width = 175;
            dgv.Columns[5].Width = 120;
            dgv.Columns[6].Width = 220;
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }

            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            int ViTri = dgvKhachHang.CurrentCell.RowIndex;
            txtCodeKH.Text = dgvKhachHang.Rows[ViTri].Cells[1].Value.ToString();
            txtNameKH.Text = dgvKhachHang.Rows[ViTri].Cells[2].Value.ToString();
            txtSex.Text = dgvKhachHang.Rows[ViTri].Cells[3].Value.ToString();
            txtAddress.Text = dgvKhachHang.Rows[ViTri].Cells[4].Value.ToString();
            txtPhoneNumber.Text = dgvKhachHang.Rows[ViTri].Cells[5].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[ViTri].Cells[6].Value.ToString();
        }

        private void rdCodeKH_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinKH();
            dgvKhachHang.DataSource = bdsource;
        }

        private void rdPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinKH();
            dgvKhachHang.DataSource = bdsource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from Customer"));
            if (rdCodeKH.Checked == true)
            {
                dv.RowFilter = String.Format(" Code LIKE '%{0}%'", txtTimKiem.Text);
                dgvKhachHang.DataSource = dv;
            }
            else
            {
                dv.RowFilter = String.Format("PhoneNumber LIKE '%{0}%'", txtTimKiem.Text);
                dgvKhachHang.DataSource = dv;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = txtCodeKH.Text;
                string Name = txtNameKH.Text;
                string Sex = txtSex.Text;
                string Address = txtAddress.Text;
                string PhoneNumber = txtPhoneNumber.Text;
                string Email = txtEmail.Text;

                string insert = @"insert into Customer (Code, Name, Sex, Address, PhoneNumber, Email) values
                        ('" + Code + "', N'" + Name + " ', N'" + Sex + " ', N'" + Address + "', '" + PhoneNumber + " ', N'" + Email + "'); ";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + Code, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm07QuanLyKhachHang_Load(sender, e);
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
                string Code = txtCodeKH.Text;
                string Name = txtNameKH.Text;
                string Sex = txtSex.Text;
                string Address = txtAddress.Text;
                string PhoneNumber = txtPhoneNumber.Text;
                string Email = txtEmail.Text;

                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn xóa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string delete = @"delete from Customer 
                        where Code ='" + Code + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + Code + " " + Name, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm07QuanLyKhachHang_Load(sender, e);
                    txtCodeKH.Clear();
                    txtNameKH.Clear();
                    txtSex.Clear();
                    txtAddress.Clear();
                    txtPhoneNumber.Clear();
                    txtEmail.Clear();
                    txtCodeKH.Focus();
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
                string Code = txtCodeKH.Text;
                string Name = txtNameKH.Text;
                string Sex = txtSex.Text;
                string Address = txtAddress.Text;
                string PhoneNumber = txtPhoneNumber.Text;
                string Email = txtEmail.Text;

                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn sửa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string update = @"update Customer set 
                                    Code = '" + Code 
                                    + "',Name=N'" + Name 
                                    + "',Sex=N'" + Sex
                                    + "',Address=N'" + Address
                                    + "',PhoneNumber='" + PhoneNumber
                                    + "',Email='" + Email
                                    + "' WHERE Code='" + Code + "';";
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm07QuanLyKhachHang_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm07QuanLyKhachHang_Load(sender, e);
            txtCodeKH.Clear();
            txtNameKH.Clear();
            txtSex.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtCodeKH.Focus();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dgvKhachHang_SelectionChanged(sender, e);
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
            dgvKhachHang_SelectionChanged(sender, e);
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
            dgvKhachHang_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            btnSau.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dgvKhachHang_SelectionChanged(sender, e);
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

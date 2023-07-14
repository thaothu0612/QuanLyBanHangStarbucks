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
    public partial class Frm06QuanLyNhanVien : Form
    {
        public Frm06QuanLyNhanVien()
        {
            InitializeComponent();
        }

        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();

        private void Frm06QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinNV();
            dgvNhanVien.DataSource = bdsource;
            txtCodeNV.Focus();
            dgvNhanVien.Columns[0].HeaderText = "Id";
            dgvNhanVien.Columns[1].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[3].HeaderText = "Giới tính";
            dgvNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[5].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[6].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[7].HeaderText = "Email";
            dgvNhanVien.Columns[8].HeaderText = "Chức vụ";

            DataGridView dgv = dgvNhanVien;
            dgv.Columns[0].Width = 70;
            dgv.Columns[1].Width = 70;
            dgv.Columns[2].Width = 210;
            dgv.Columns[3].Width = 70;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 120;
            dgv.Columns[6].Width = 100;
            dgv.Columns[7].Width = 200;
            dgv.Columns[8].Width = 150;
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }

            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            int ViTri = dgvNhanVien.CurrentCell.RowIndex;
            txtCodeNV.Text = dgvNhanVien.Rows[ViTri].Cells[1].Value.ToString();
            txtNameNV.Text = dgvNhanVien.Rows[ViTri].Cells[2].Value.ToString();
            txtSex.Text = dgvNhanVien.Rows[ViTri].Cells[3].Value.ToString();
            DTPNgaySinh.Text = dgvNhanVien.Rows[ViTri].Cells[4].Value.ToString();
            txtAddress.Text = dgvNhanVien.Rows[ViTri].Cells[5].Value.ToString();
            txtPhoneNumber.Text = dgvNhanVien.Rows[ViTri].Cells[6].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[ViTri].Cells[7].Value.ToString();
            txtPosition.Text = dgvNhanVien.Rows[ViTri].Cells[8].Value.ToString();
        }

        private void rdCodeNV_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinNV();
            dgvNhanVien.DataSource = bdsource;
        }

        private void rdNameKM_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinNV();
            dgvNhanVien.DataSource = bdsource;
        }

        private void rdChucVu_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinNV();
            dgvNhanVien.DataSource = bdsource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from Staff"));
            if (rdCodeNV.Checked == true)
            {
                dv.RowFilter = String.Format(" Code LIKE '%{0}%'", txtTimKiem.Text);
                dgvNhanVien.DataSource = dv;
            }
            else
            {
                if (rdNameKM.Checked == true)
                {
                    dv.RowFilter = String.Format(" Name LIKE '%{0}%'", txtTimKiem.Text);
                    dgvNhanVien.DataSource = dv;
                }
                else
                {
                    if (rdChucVu.Checked == true)
                    {
                        dv.RowFilter = String.Format(" Position LIKE '%{0}%'", txtTimKiem.Text);
                        dgvNhanVien.DataSource = dv;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = txtCodeNV.Text;
                string Name = txtNameNV.Text;
                string Sex = txtSex.Text;
                DateTime DateOfBirth = DTPNgaySinh.Value;
                string Address = txtAddress.Text;
                string PhoneNumber = txtPhoneNumber.Text;
                string Email = txtEmail.Text;
                string Position = txtPosition.Text;

                string insert = @"insert into Staff (Code, Name, Sex, DateOfBirth, Address, PhoneNumber, Email, Position) values
                        ('" + Code + "', N'" + Name + " ', N'" + Sex + " ', '" + DateOfBirth + "', N'" + Address + " ', '" + PhoneNumber + "', '" + Email + " ', N'" + Position + "'); ";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + Code, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm06QuanLyNhanVien_Load(sender, e);
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
                string Code = txtCodeNV.Text;
                string Name = txtNameNV.Text;
                string Sex = txtSex.Text;
                DateTime DateOfBirth = DTPNgaySinh.Value;
                string Address = txtAddress.Text;
                string PhoneNumber = txtPhoneNumber.Text;
                string Email = txtEmail.Text;
                string Position = txtPosition.Text;

                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn xóa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string delete = @"delete from Staff 
                        where Code ='" + Code + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + Code + " " + Name, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm06QuanLyNhanVien_Load(sender, e);
                    txtCodeNV.Clear();
                    txtNameNV.Clear();
                    txtSex.Clear();
                    DTPNgaySinh.ResetText();
                    txtAddress.Focus();
                    txtPhoneNumber.Focus();
                    txtEmail.Focus();
                    txtPosition.Focus();
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
                string Code = txtCodeNV.Text;
                string Name = txtNameNV.Text;
                string Sex = txtSex.Text;
                DateTime DateOfBirth = DTPNgaySinh.Value;
                string Address = txtAddress.Text;
                string PhoneNumber = txtPhoneNumber.Text;
                string Email = txtEmail.Text;
                string Position = txtPosition.Text;

                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn sửa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string update = @"update Staff set Code = '" 
                                    + Code + "',Name=N'" 
                                    + Name + "',Sex=N'" 
                                    + Sex + "',DateOfBirth='" 
                                    + DateOfBirth  + "',Address=N'"
                                    + Address + "',PhoneNumber='"
                                    + PhoneNumber + "',Email='"
                                    + Email + "',Position=N'"
                                    + Position + "' WHERE Code='" + Code + "';";
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm06QuanLyNhanVien_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm06QuanLyNhanVien_Load(sender, e);
            txtCodeNV.Clear();
            txtNameNV.Clear();
            txtSex.Clear();
            DTPNgaySinh.ResetText();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtPosition.Clear();
            txtCodeNV.Focus();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dgvNhanVien_SelectionChanged(sender, e);
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
            dgvNhanVien_SelectionChanged(sender, e);
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
            dgvNhanVien_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            btnSau.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dgvNhanVien_SelectionChanged(sender, e);
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

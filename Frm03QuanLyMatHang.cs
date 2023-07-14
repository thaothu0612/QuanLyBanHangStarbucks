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

namespace QuanLyBanHangStarbucks
{
    public partial class Frm03QuanLyMatHang : Form
    {
        public Frm03QuanLyMatHang()
        {
            InitializeComponent();
        }

        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void Frm03QuanLyMatHang_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinMH();
            dgvMatHang.DataSource = bdsource;
            txtCodeMH.Focus();
            dgvMatHang.Columns[0].HeaderText = "Id";
            dgvMatHang.Columns[1].HeaderText = "Mã mặt hàng";
            dgvMatHang.Columns[2].HeaderText = "Tên mặt hàng";
            dgvMatHang.Columns[3].HeaderText = "Đơn vị tính";
            dgvMatHang.Columns[4].HeaderText = "Mã loại mặt hàng";
            dgvMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatHang.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvMatHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void dvgMatHang_SelectionChanged(object sender, EventArgs e)
        {
            int ViTri = dgvMatHang.CurrentCell.RowIndex;
            txtCodeMH.Text = dgvMatHang.Rows[ViTri].Cells[1].Value.ToString();
            txtNameMH.Text = dgvMatHang.Rows[ViTri].Cells[2].Value.ToString();
            txtUnitMH.Text = dgvMatHang.Rows[ViTri].Cells[3].Value.ToString();
            txtCategoryMH.Text = dgvMatHang.Rows[ViTri].Cells[4].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Code = txtCodeMH.Text;
                string Name = txtNameMH.Text;
                string Unit = txtUnitMH.Text;
                string CategoryId = txtCategoryMH.Text;
                string insert = @"insert into Product (Code, Name, Unit, CategoryId) values
                        ('" + Code + "',N'" + Name + " ',N'" + Unit + " ', N'" + CategoryId + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + Code, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm03QuanLyMatHang_Load(sender, e);
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
                int ViTri = dgvMatHang.CurrentCell.RowIndex;
                string Code = dgvMatHang.Rows[ViTri].Cells[1].Value.ToString();
                string Name = dgvMatHang.Rows[ViTri].Cells[2].Value.ToString();
                string Unit = dgvMatHang.Rows[ViTri].Cells[3].Value.ToString();
                string CategoryId = dgvMatHang.Rows[ViTri].Cells[4].Value.ToString();
                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn xóa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string delete = @"delete from Product 
                        where Code ='" + Code + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + Code + " " + Name, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm03QuanLyMatHang_Load(sender, e);
                    txtCodeMH.Clear();
                    txtNameMH.Clear();
                    txtCategoryMH.Clear();
                    txtUnitMH.Clear();
                    txtCodeMH.Focus();
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
                string Code = txtCodeMH.Text;
                string Name = txtNameMH.Text;
                string Unit = txtUnitMH.Text;
                string CategoryId = txtCategoryMH.Text;
                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn sửa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string update = @"update Product set Code = '" + Code +
                    "',Name=N'" + Name + "',Unit=N'" + Unit + "',CategoryId=N'" + CategoryId + "' WHERE Code='" + Code + "';";
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm03QuanLyMatHang_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm03QuanLyMatHang_Load(sender, e);
            txtCodeMH.Clear();
            txtNameMH.Clear();
            txtUnitMH.Clear();
            txtCategoryMH.Clear();
            txtTimKiem.Clear();
            txtCodeMH.Focus();
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

        private void rdCodeMH_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinMH();
            dgvMatHang.DataSource = bdsource;
        }

        private void rdNameMH_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinMH();
            dgvMatHang.DataSource = bdsource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from Product"));
            if (rdCodeMH.Checked == true)
            {
                dv.RowFilter = String.Format(" Code LIKE '%{0}%'", txtTimKiem.Text);
                dgvMatHang.DataSource = dv;
            }
            else
            {
                dv.RowFilter = String.Format(" Name LIKE '%{0}%'", txtTimKiem.Text);
                dgvMatHang.DataSource = dv;
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dvgMatHang_SelectionChanged(sender, e);
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
            dvgMatHang_SelectionChanged(sender, e);
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
            dvgMatHang_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            btnSau.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dvgMatHang_SelectionChanged(sender, e);
        }
    }
}

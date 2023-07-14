using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangStarbucks
{
    public partial class Frm04QuanLyKhuyenMai : Form
    {
        public Frm04QuanLyKhuyenMai()
        {
            InitializeComponent();
        }

        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();

        private void Frm04QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinKM();
            dgvKhuyenMai.DataSource = bdsource;
            txtCodeKM.Focus();
            dgvKhuyenMai.Columns[0].HeaderText = "Id";
            dgvKhuyenMai.Columns[1].HeaderText = "Mã khuyến mãi";
            dgvKhuyenMai.Columns[2].HeaderText = "Tên khuyến mãi";
            dgvKhuyenMai.Columns[3].HeaderText = "Id mặt hàng";
            dgvKhuyenMai.Columns[4].HeaderText = "Ngày bắt đầu";
            dgvKhuyenMai.Columns[5].HeaderText = "Ngày kết thúc";
            dgvKhuyenMai.Columns[6].HeaderText = "Điều kiện áp dụng";
            dgvKhuyenMai.Columns[7].HeaderText = "Hình thức";
            dgvKhuyenMai.Columns[8].HeaderText = "Tình trạng";

            DataGridView dgv = dgvKhuyenMai;
            dgv.Columns[0].Width = 70;
            dgv.Columns[1].Width = 70;
            dgv.Columns[2].Width = 210;
            dgv.Columns[3].Width = 70;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 100;
            dgv.Columns[6].Width = 250;
            dgv.Columns[7].Width = 120;
            dgv.Columns[8].Width = 100;
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }

            dgvKhuyenMai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhuyenMai.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvKhuyenMai.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }
        private void dgvKhuyenMai_SelectionChanged(object sender, EventArgs e)
        {
            int ViTri = dgvKhuyenMai.CurrentCell.RowIndex;
            txtCodeKM.Text = dgvKhuyenMai.Rows[ViTri].Cells[1].Value.ToString();
            txtNameKM.Text = dgvKhuyenMai.Rows[ViTri].Cells[2].Value.ToString();
            txtProductId.Text = dgvKhuyenMai.Rows[ViTri].Cells[3].Value.ToString();
            DTPStartDay.Text = dgvKhuyenMai.Rows[ViTri].Cells[4].Value.ToString();
            DTPEndDay.Text = dgvKhuyenMai.Rows[ViTri].Cells[5].Value.ToString();
            txtDieuKien.Text = dgvKhuyenMai.Rows[ViTri].Cells[6].Value.ToString();
            txtHinhThuc.Text = dgvKhuyenMai.Rows[ViTri].Cells[7].Value.ToString();
            bool isActive = Convert.ToBoolean(dgvKhuyenMai.Rows[ViTri].Cells["IsActive"].Value);
            // Gán giá trị IsActive vào RadioButton rbIsActive
            rbIsActive.Checked = isActive;
        }

        private void rdCodeKM_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinKM();
            dgvKhuyenMai.DataSource = bdsource;
        }

        private void rdNameKM_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinKM();
            dgvKhuyenMai.DataSource = bdsource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from Promotion"));
            if (rdCodeKM.Checked == true)
            {
                dv.RowFilter = String.Format(" Code LIKE '%{0}%'", txtTimKiem.Text);
                dgvKhuyenMai.DataSource = dv;
            }
            else
            {
                dv.RowFilter = String.Format(" Name LIKE '%{0}%'", txtTimKiem.Text);
                dgvKhuyenMai.DataSource = dv;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = txtCodeKM.Text;
                string Name = txtNameKM.Text;
                string ProductId = txtProductId.Text;
                string Condition = txtDieuKien.Text;
                string Method = txtHinhThuc.Text;
                DateTime StartDate = DTPStartDay.Value;
                DateTime EndDate = DTPEndDay.Value;
                bool isActive = rbIsActive.Checked ? true : false;

                string insert = @"insert into Promotion (Code, Name, ProductId, StartDate, EndDate, Condition, Method, IsActive) values
                        ('" + Code + "',N'" + Name + " ',N'" + ProductId + " ', N'" + StartDate + "',N'" + EndDate + " ',N'" + Condition + "',N'" + Method + " ', " + (isActive ? 1 : 0) + ");";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + Code, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm04QuanLyKhuyenMai_Load(sender, e);
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
                string Code = txtCodeKM.Text;
                string Name = txtNameKM.Text;
                string ProductId = txtProductId.Text;
                string Condition = txtDieuKien.Text;
                string Method = txtHinhThuc.Text;
                DateTime StartDate = DTPStartDay.Value;
                DateTime EndDate = DTPEndDay.Value;
                bool isActive = rbIsActive.Checked ? true : false;
                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn xóa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string delete = @"delete from Promotion 
                        where Code ='" + Code + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + Code + " " + Name, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm04QuanLyKhuyenMai_Load(sender, e);
                    txtCodeKM.Clear();
                    txtNameKM.Clear();
                    txtProductId.Clear();
                    DTPStartDay.ResetText();
                    DTPEndDay.ResetText();
                    txtDieuKien.Clear();
                    txtHinhThuc.Clear();
                    rbIsActive.Checked = false;
                    txtCodeKM.Focus();
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
                string Code = txtCodeKM.Text;
                string Name = txtNameKM.Text;
                string ProductId = txtProductId.Text;
                string Condition = txtDieuKien.Text;
                string Method = txtHinhThuc.Text;
                DateTime StartDate = DTPStartDay.Value;
                DateTime EndDate = DTPEndDay.Value;
                bool isActive = rbIsActive.Checked ? true : false;
                string update = @"update Promotion set
                   Code='" + Code + "',Name=N'" + Name + "',ProductId='" + ProductId + "' ,StartDate='" + StartDate + "'," +
                   "EndDate='" + EndDate + "',Condition=N'" + Condition + "',Method=N'" + Method + "'," + "IsActive='" + (rbIsActive.Checked ? "1" : "0") + "' WHERE Code='" + Code + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm04QuanLyKhuyenMai_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm04QuanLyKhuyenMai_Load(sender, e);
            txtCodeKM.Clear();
            txtNameKM.Clear();
            txtProductId.Clear();
            DTPStartDay.ResetText();
            DTPEndDay.ResetText();
            txtDieuKien.Clear();
            txtHinhThuc.Clear();
            rbIsActive.Checked = false;
            txtCodeKM.Focus();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dgvKhuyenMai_SelectionChanged(sender, e);
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
            dgvKhuyenMai_SelectionChanged(sender, e);
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
            dgvKhuyenMai_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            btnSau.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dgvKhuyenMai_SelectionChanged(sender, e);
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

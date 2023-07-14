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
    public partial class Frm08QuanLyHoaDon : Form
    {
        public Frm08QuanLyHoaDon()
        {
            InitializeComponent();
        }

        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();

        private void Frm08QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinHD();
            dgvHoaDon.DataSource = bdsource;
            txtBillNo.Focus();
            dgvHoaDon.Columns[0].HeaderText = "Id";
            dgvHoaDon.Columns[1].HeaderText = "Ngày lập";
            dgvHoaDon.Columns[2].HeaderText = "Số hiệu ";
            dgvHoaDon.Columns[3].HeaderText = "Id khách hàng";
            dgvHoaDon.Columns[4].HeaderText = "Id người dùng";
            dgvHoaDon.Columns[5].HeaderText = "Id khuyến mãi";
            dgvHoaDon.Columns[6].HeaderText = "Tình trạng";

            DataGridView dgv = dgvHoaDon;
            dgv.Columns[0].Width = 140;
            dgv.Columns[1].Width = 200;
            dgv.Columns[2].Width = 140;
            dgv.Columns[3].Width = 140;
            dgv.Columns[4].Width = 140;
            dgv.Columns[5].Width = 140;
            dgv.Columns[6].Width = 200;

            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }

            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            int ViTri = dgvHoaDon.CurrentCell.RowIndex;
            DTPBillDate.Text = dgvHoaDon.Rows[ViTri].Cells[1].Value.ToString();
            txtBillNo.Text = dgvHoaDon.Rows[ViTri].Cells[2].Value.ToString();
            txtCustomerId.Text = dgvHoaDon.Rows[ViTri].Cells[3].Value.ToString();
            txtAccountId.Text = dgvHoaDon.Rows[ViTri].Cells[4].Value.ToString();
            txtPromotionId.Text = dgvHoaDon.Rows[ViTri].Cells[5].Value.ToString();
            bool isActive = Convert.ToBoolean(dgvHoaDon.Rows[ViTri].Cells["IsActive"].Value);
            rbIsActive.Checked = isActive;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime BillDate = DTPBillDate.Value;
                string BillNo = txtBillNo.Text;
                string CustomerId = txtCustomerId.Text;
                string AccountId = txtAccountId.Text;
                string PromotionId = txtPromotionId.Text;
                bool isActive = rbIsActive.Checked ? true : false;

                string insert = @"insert into Bill (BillDate, BillNo, CustomerId, AccountId, PromotionId, IsActive) values
                        ('" + BillDate + "','" + BillNo + " ',N'" + CustomerId + " ', N'" + AccountId + "',N'" + PromotionId + " ', " + (isActive ? 1 : 0) + ");";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + BillNo, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm08QuanLyHoaDon_Load(sender, e);
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
                DateTime BillDate = DTPBillDate.Value;
                string BillNo = txtBillNo.Text;
                string CustomerId = txtCustomerId.Text;
                string AccountId = txtAccountId.Text;
                string PromotionId = txtPromotionId.Text;
                bool isActive = rbIsActive.Checked ? true : false;

                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn xóa " + BillNo, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string delete = @"delete from Bill 
                        where BillNo ='" + BillNo + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + BillNo, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm08QuanLyHoaDon_Load(sender, e);
                    DTPBillDate.ResetText();
                    txtBillNo.Clear();
                    txtCustomerId.Clear();
                    txtAccountId.Clear();
                    txtPromotionId.Clear();
                    rbIsActive.Checked = false;
                    txtBillNo.Focus();
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
                DateTime BillDate = DTPBillDate.Value;
                string BillNo = txtBillNo.Text;
                string CustomerId = txtCustomerId.Text;
                string AccountId = txtAccountId.Text;
                string PromotionId = txtPromotionId.Text;
                bool isActive = rbIsActive.Checked ? true : false;

                string update = @"update Bill set
                   BillDate='" + BillDate + "',BillNo= N'" + BillNo + "',CustomerId='" + CustomerId + "' ,AccountId='" + AccountId + "'," +
                   "PromotionId='" + PromotionId + "'," + "IsActive='" + (rbIsActive.Checked ? "1" : "0") + "' WHERE BillNo='" + BillNo + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + BillNo, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm08QuanLyHoaDon_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm08QuanLyHoaDon_Load(sender, e);
            Frm08QuanLyHoaDon_Load(sender, e);
            DTPBillDate.ResetText();
            txtBillNo.Clear();
            txtCustomerId.Clear();
            txtAccountId.Clear();
            txtPromotionId.Clear();
            rbIsActive.Checked = false;
            txtBillNo.Focus();
        }

        private void rdBillNo_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinHD();
            dgvHoaDon.DataSource = bdsource;
        }

        private void rdAccountId_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinHD();
            dgvHoaDon.DataSource = bdsource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from Bill"));
            if (rdBillNo.Checked == true)
            {
                dv.RowFilter = "BillNo = " + txtTimKiem.Text;
                dgvHoaDon.DataSource = dv;
            }
            else
            {
                dv.RowFilter = "AccountId = " + txtTimKiem.Text;
                dgvHoaDon.DataSource = dv;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            this.Close();
            this.Hide();
            Frm02TrangChu main = new Frm02TrangChu();
            main.ShowDialog();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dgvHoaDon_SelectionChanged(sender, e);
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
            dgvHoaDon_SelectionChanged(sender, e);
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
            dgvHoaDon_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            btnSau.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dgvHoaDon_SelectionChanged(sender, e);
        }
    }
}

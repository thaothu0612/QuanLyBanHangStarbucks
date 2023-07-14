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
    public partial class Frm09ChiTietHoaDon : Form
    {
        public Frm09ChiTietHoaDon()
        {
            InitializeComponent();
        }

        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();

        private void Frm09ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinCTHD();
            dgvCTHD.DataSource = bdsource;
            txtBillId.Focus();
            dgvCTHD.Columns[0].HeaderText = "Id";
            dgvCTHD.Columns[1].HeaderText = "Id hóa đơn";
            dgvCTHD.Columns[2].HeaderText = "Id mặt hàng";
            dgvCTHD.Columns[3].HeaderText = "Id size";
            dgvCTHD.Columns[4].HeaderText = "Số lượng";
            dgvCTHD.Columns[5].HeaderText = "Id đơn giá";
            dgvCTHD.Columns[6].HeaderText = "Tổng số tiền";

            DataGridView dgv = dgvCTHD;
            dgv.Columns[0].Width = 70;
            dgv.Columns[1].Width = 70;
            dgv.Columns[2].Width = 230;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 150;
            dgv.Columns[5].Width = 150;
            dgv.Columns[6].Width = 250;
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }

            dgvCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTHD.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvCTHD.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void dgvCTHD_SelectionChanged(object sender, EventArgs e)
        {
            int ViTri = dgvCTHD.CurrentCell.RowIndex;
            txtBillId.Text = dgvCTHD.Rows[ViTri].Cells[1].Value.ToString();
            txtProductId.Text = dgvCTHD.Rows[ViTri].Cells[2].Value.ToString();
            txtSizeId.Text = dgvCTHD.Rows[ViTri].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvCTHD.Rows[ViTri].Cells[4].Value.ToString();
            txtPriceId.Text = dgvCTHD.Rows[ViTri].Cells[5].Value.ToString();
            txtTongTien.Text = dgvCTHD.Rows[ViTri].Cells[6].Value.ToString();
        }

        private void rdBillId_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinCTHD();
            dgvCTHD.DataSource = bdsource;
        }

        private void rdProductId_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinCTHD();
            dgvCTHD.DataSource = bdsource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from BillDetail"));
            if (rdBillId.Checked == true)
            {
                dv.RowFilter = "BillId = " + txtTimKiem.Text;
                dgvCTHD.DataSource = dv;
            }
            else
            {
                dv.RowFilter = "ProductId = " + txtTimKiem.Text;
                dgvCTHD.DataSource = dv;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string BillId = txtBillId.Text;
                string ProductId = txtProductId.Text;
                string Quantity = txtSoLuong.Text;
                string PriceId = txtPriceId.Text;
                string TotalPrice = txtTongTien.Text;

                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn xóa " + BillId, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string delete = @"delete from BillDetail 
                        where BillId ='" + BillId + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + BillId, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm09ChiTietHoaDon_Load(sender, e);
                    txtBillId.Clear();
                    txtProductId.Clear();
                    txtSoLuong.Clear();
                    txtPriceId.Clear();
                    txtTongTien.Clear();
                    txtBillId.Focus();
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
                string BillId = txtBillId.Text;
                string ProductId = txtProductId.Text;
                string Quantity = txtSoLuong.Text;
                string PriceId = txtPriceId.Text;
                string SizeId = txtSizeId.Text;
                string TotalPrice = txtTongTien.Text;

                string update = @"update BillDetail set
                   BillId='" + BillId + "',ProductId=N'" + ProductId + "',Quantity='" + Quantity + "' ,PriceId='" + PriceId + "'," + "TotalPrice='" + TotalPrice + "PriceId='" + PriceId + "' WHERE BillId='" + BillId + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + BillId, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm09ChiTietHoaDon_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm09ChiTietHoaDon_Load(sender, e);
            txtBillId.Clear();
            txtProductId.Clear();
            txtSoLuong.Clear();
            txtPriceId.Clear();
            txtPriceId.Clear();
            txtTongTien.Clear();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dgvCTHD_SelectionChanged(sender, e);
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
            dgvCTHD_SelectionChanged(sender, e);
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
            dgvCTHD_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            btnSau.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dgvCTHD_SelectionChanged(sender, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;this.Close();
            this.Hide();
            Frm02TrangChu main = new Frm02TrangChu();
            main.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangStarbucks
{
    public partial class Frm10QuanLyPhieuNhap : Form
    {
        public Frm10QuanLyPhieuNhap()
        {
            InitializeComponent();
        }

        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();

        private void Frm10QuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinPN();
            dgvPhieuNhap.DataSource = bdsource;
            txtCodePN.Focus();
            dgvPhieuNhap.Columns[0].HeaderText = "Id";
            dgvPhieuNhap.Columns[1].HeaderText = "Mã phiếu nhập";
            dgvPhieuNhap.Columns[2].HeaderText = "Ngày nhập kho";
            dgvPhieuNhap.Columns[3].HeaderText = "Tổng số lượng";
            dgvPhieuNhap.Columns[4].HeaderText = "Id nhân viên";

            DataGridView dgv = dgvPhieuNhap;
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

            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvPhieuNhap.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            int ViTri = dgvPhieuNhap.CurrentCell.RowIndex;
            txtCodePN.Text = dgvPhieuNhap.Rows[ViTri].Cells[1].Value.ToString();
            DTPReceiptDate.Text = dgvPhieuNhap.Rows[ViTri].Cells[2].Value.ToString();
            txtToTalQuantity.Text = dgvPhieuNhap.Rows[ViTri].Cells[3].Value.ToString();
            txtStaffId.Text = dgvPhieuNhap.Rows[ViTri].Cells[4].Value.ToString();
        }

        private void rdCodePN_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinPN();
            dgvPhieuNhap.DataSource = bdsource;
        }

        private void rdReceiptDate_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
            bdsource.DataSource = KN.ThongtinPN();
            dgvPhieuNhap.DataSource = bdsource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from Warehouse_Receipt"));
            if (rdCodePN.Checked == true)
            {
                dv.RowFilter = String.Format(" Code LIKE '%{0}%'", txtTimKiem.Text);
                dgvPhieuNhap.DataSource = dv;
            }
            else
            {
                dv.RowFilter = "StaffId = " + txtTimKiem.Text;
                dgvPhieuNhap.DataSource = dv;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = txtCodePN.Text;
                string ReceiptDate = DTPReceiptDate.Text;
                string TotalQuantity = txtToTalQuantity.Text;
                string StaffId = txtStaffId.Text;

                string insert = @"insert into Warehouse_Receipt (Code, ReceiptDate, TotalQuantity, StaffId) values
                        ('" + Code + "', '" + ReceiptDate + " ', N'" + TotalQuantity + " ', '" + StaffId + "'); ";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + Code, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm10QuanLyPhieuNhap_Load(sender, e);
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
                string Code = txtCodePN.Text;
                string ReceiptDate = DTPReceiptDate.Text;
                string TotalQuantity = txtToTalQuantity.Text;
                string StaffId = txtStaffId.Text;

                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn xóa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string delete = @"delete from Warehouse_Receipt 
                        where Code ='" + Code + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + Code + " " + Name, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm10QuanLyPhieuNhap_Load(sender, e);
                    txtCodePN.Clear();
                    DTPReceiptDate.ResetText();
                    txtToTalQuantity.Clear();
                    txtStaffId.Clear();
                    txtCodePN.Focus();
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
                string Code = txtCodePN.Text;
                string ReceiptDate = DTPReceiptDate.Text;
                string TotalQuantity = txtToTalQuantity.Text;
                string StaffId = txtStaffId.Text;
                DialogResult ThongBao;
                ThongBao = (MessageBox.Show("Bạn có muốn sửa " + Code, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (ThongBao == DialogResult.Yes)
                {
                    string update = @"update Warehouse_Receipt set Code = '" + Code + "',ReceiptDate='" + ReceiptDate + "',TotalQuantity='" + TotalQuantity + "',StaffId=N'" + StaffId + "' WHERE Code='" + Code + "';";
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm10QuanLyPhieuNhap_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm10QuanLyPhieuNhap_Load(sender, e);
            txtCodePN.Clear();
            DTPReceiptDate.ResetText();
            txtToTalQuantity.Clear();
            txtStaffId.Clear();
            txtCodePN.Focus();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnSau.Enabled = true;
            btnCuoi.Enabled = true;
            dgvPhieuNhap_SelectionChanged(sender, e);
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
            dgvPhieuNhap_SelectionChanged(sender, e);
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
            dgvPhieuNhap_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            btnSau.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dgvPhieuNhap_SelectionChanged(sender, e);
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

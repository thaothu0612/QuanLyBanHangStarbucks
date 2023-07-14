using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangStarbucks
{
    public partial class Frm12BaoCaoHoaDon : Form
    {
        private DataSet md = new DataSet();
        public Frm12BaoCaoHoaDon()
        {
            InitializeComponent();
        }
        
        private void Frm12BaoCaoHoaDon_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;

            // Lấy bảng (DataTable) từ DataSet
            DataTable dtNhanVien = md.Tables["TBBill"]; // Thay "TenBangNhanVien" bằng tên bảng trong DataSet của bạn

            // Chuyển đổi DataTable thành danh sách DataRow
            List<DataRow> listNhanVien = dtNhanVien.AsEnumerable().ToList();

            // Đường dẫn tới tệp RDLC
            string reportPath = "./Frm12BaoCaoHoaDon.rdlc";

            // Gắn tên DataSet trong tệp RDLC và danh sách DataRow
            ReportDataSource reportDataSource = new ReportDataSource("Bill", listNhanVien);
            // Thay "DataSetName" bằng tên DataSet đã định nghĩa trong tệp RDLC

            // Xóa DataSources cũ và thêm DataSources mới
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            // Đặt đường dẫn tới tệp RDLC
            reportViewer1.LocalReport.ReportPath = reportPath;

            // Refresh báo cáo
            reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanHangStarbucks
{
    class KetNoi
    {
        private string strCon = "Data Source=LAPTOP-D2H52ORO\\THAO;Initial Catalog=QuanLyBanHangStarbucks;User ID=sa;Password=12345;";
        public SqlConnection GetConnect()
        {
            SqlConnection sqlCon = new SqlConnection (strCon);
            sqlCon.Open();
            return sqlCon;
        }

        public int EXECUTENONQUERY(string query)
        {
            int data = 0;
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                data = cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            return data;
        }

        public DataTable ThongtinMH()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Product", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable ThongtinKM()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Promotion", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable ThongtinTK()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Account", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable ThongtinNV()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Staff", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinKH()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Customer", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable ThongtinPN()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Warehouse_Receipt", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable ThongtinHD()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Bill", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable ThongtinCTHD()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from BillDetail", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable Executequery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter laydulieu = new SqlDataAdapter(cmd);
                laydulieu.Fill(data);
                sqlCon.Close();
            }
            return data;
        }
    }
}

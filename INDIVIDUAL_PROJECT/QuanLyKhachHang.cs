using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Load_DSKhachHang();
        }
        public void Load_DSKhachHang()
        {
            String chuoiketnoi = @"";
            SqlConnection connect = new SqlConnection(chuoiketnoi);
            connect.Open();
            string sqlLoad_DSKH = "select * form KHACHHANG";
            SqlCommand comm= new SqlCommand(sqlLoad_DSKH,connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable tb=new DataTable();
            adapter.Fill(tb);
            data_DanhSachKH.DataSource = tb;
            connect.Close();

        }
    }
}

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
        LopDungChung dungchung;
        public QuanLyKhachHang()
        {
            InitializeComponent();
            dungchung = new LopDungChung();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Load_DSKhachHang();
        }
        public void Load_DSKhachHang()
        {
            
            
            string sqlLoad_DSKH = "select * form KHACHHANG";
          
            data_DanhSachKH.DataSource = dungchung.LoadGrid(sqlLoad_DSKH);
            

        }
    }
}

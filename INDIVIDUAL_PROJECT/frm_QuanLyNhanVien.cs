using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT
{
    public partial class frm_QuanLyNhanVien : Form
    {
        LopDungChung lopDungChung;
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
            lopDungChung = new LopDungChung();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into NHANVIEN Values('" + txt_MaNhanVien.Text + "', '" + txt_HoTen.Text + "', '" + cbx_GioiTinh.Text + "', '" + dt_NgaySinh.Text + "', '" + txt_SoDT.Text + "', '" + txt_DiaChi.Text + "', '" + txt_Luong.Text + "', '"+ txt_HinhAnh.Text +"')";

        }
    }
}

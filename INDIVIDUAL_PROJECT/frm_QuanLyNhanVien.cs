using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Assets\\";
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into NHANVIEN Values('" + txt_MaNhanVien.Text + "', '" + txt_HoTen.Text + "', '" + cbx_GioiTinh.Text + "', '" + dt_NgaySinh.Text + "', '" + txt_SoDT.Text + "', '" + txt_DiaChi.Text + "', '" + txt_Luong.Text + "', '"+ txt_HinhAnh.Text +"')";
            pct_HinhAnh.Image.Save(duongdan + txt_HinhAnh.Text);
            lopDungChung.NonQuery(sqlThem);
            LoadData();
        }

        public void LoadData()
        {
            string sqlLoadData = "Select * from NHANVIEN";
            dataGridView1.DataSource = lopDungChung.LoadGrid(sqlLoadData);
        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void pct_HinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh";
            ofd.Filter = "Tất cả đuôi|*.*|Đuôi JPG|*.jpg|Đuôi JPEG|*.jpeg|Đuôi PNG|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
                pct_HinhAnh.Image = Image.FromFile(ofd.FileName);
        }
    }
}

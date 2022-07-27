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
            string sqlThem = "insert into NHANVIEN Values('" + txt_MaNhanVien.Text + "', N'" + txt_HoTen.Text + "', N'" + cbx_GioiTinh.Text + "', Convert(DateTime,'" + dt_NgaySinh.Text + "',103), '" + txt_SoDT.Text + "', N'" + txt_DiaChi.Text + "', '" + txt_Luong.Text + "', '"+ txt_HinhAnh.Text +"')";
            //pct_HinhAnh.Image.Save(duongdan + txt_HinhAnh.Text);
            try
            {
                if (txt_MaNhanVien.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên..");
                }
                else
                {
                    lopDungChung.NonQuery(sqlThem);
                    LoadData();
                }
                
            }
            catch
            {
                MessageBox.Show("Mã nhân viên bị trùng.");
            }
            
        }

        public void LoadData()
        {
            string sqlLoadData = "Select * from NHANVIEN";
            dataGridView1.DataSource = lopDungChung.LoadGrid(sqlLoadData);
        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pct_HinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh";
            ofd.Filter = "Tất cả đuôi|*.*|Đuôi JPG|*.jpg|Đuôi JPEG|*.jpeg|Đuôi PNG|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
                pct_HinhAnh.Image = Image.FromFile(ofd.FileName);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            string sqlSua = "Update NHANVIEN set HOTEN = N'" + txt_HoTen.Text + "', GIOITINH = N'" + cbx_GioiTinh.Text + "', NGAYSINH = Convert(DateTime,'" + dt_NgaySinh.Text + "',103), SDT = '" + txt_SoDT.Text + "', DIACHI = N'" + txt_DiaChi.Text + "', LUONG = '" + txt_Luong.Text + "', HINHANH = '" + txt_HinhAnh.Text + "' where MANV = '" + txt_MaNhanVien.Text + "'";
            pct_HinhAnh.Image.Save(duongdan + txt_HinhAnh.Text);
            lopDungChung.NonQuery(sqlSua);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNhanVien.Text = dataGridView1.CurrentRow.Cells["MANV"].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells["HOTEN"].Value.ToString();
            cbx_GioiTinh.Text = dataGridView1.CurrentRow.Cells["GIOITINH"].Value.ToString();
            dt_NgaySinh.Text = dataGridView1.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_SoDT.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_Luong.Text = dataGridView1.CurrentRow.Cells["LUONG"].Value.ToString();
            txt_HinhAnh.Text = dataGridView1.CurrentRow.Cells["HINHANH"].Value.ToString();
            pct_HinhAnh.ImageLocation = duongdan + txt_HinhAnh.Text;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            string sqlXoa = "Delete from NHANVIEN where MANV = '"+txt_MaNhanVien.Text+"'";
            try
            {
                lopDungChung.NonQuery(sqlXoa);
                File.Delete(duongdan + txt_HinhAnh.Text);
                LoadData();
            }
            catch
            {
                MessageBox.Show("Không có nhân viên trong danh sách.");
            }
            
        }


        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaNhanVien.Text = "";
            txt_HoTen.Text = "";
            cbx_GioiTinh.Text = "";
            dt_NgaySinh.Text = "";
            txt_SoDT.Text = "";
            txt_DiaChi.Text = "";
            txt_Luong.Text = "";
            txt_HinhAnh.Text = "";
            pct_HinhAnh.Image = null;
        }

        private void frm_QuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Visible = true;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if(txt_TimKiem.Text == "")
            {
                LoadData();
            }
            else
            {
                string sqlTimKiem = "select * from NHANVIEN where (MANV like '%" + txt_TimKiem.Text + "%') or (HOTEN like '%" + txt_TimKiem.Text + "%') or (GIOITINH like '%" + txt_TimKiem.Text + "%' )";
                dataGridView1.DataSource = lopDungChung.LoadGrid(sqlTimKiem);
            }
        }
    }
}

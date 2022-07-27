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
            
            Load_ComboKH();
            
            Load_DSKhachHang();
        }
        public void Load_DSKhachHang()
        {
            
            
            string sqlLoad_DSKH = "select * from KHACHHANG";
          
            data_DanhSachKH.DataSource = dungchung.LoadGrid(sqlLoad_DSKH);
            

        }
     
        private void Load_ComboKH()
        {
            string sqlLoad_Combo = "select * from LOAIKHACH";
            cb_LoaiKH.DataSource = dungchung.LoadCombobox(sqlLoad_Combo);
            cb_LoaiKH.DisplayMember = "TENLOAI";
            cb_LoaiKH.ValueMember = "MALOAI";

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
          

            String SqlThem = "Insert into KHACHHANG values('" + txt_IDKH.Text + "',N'" + txt_TenKH.Text + "',N'" + cb_GioiTinh.Text + "',convert(datetime,'" + dt_NgaySinh.Text+"',103),'" + txt_SoKH.Text + "' ,N'" + txt_DiaChi.Text + "',N'" + cb_LoaiKH.SelectedValue + "')";
            try
            {  
                if (txt_IDKH.Text == "") MessageBox.Show("Bạn không được để trống mã nhân viên");
                else {
                    dungchung.NonQuery(SqlThem);
                    Load_DSKhachHang();
                }
                
            }
            catch
            {
                MessageBox.Show("Mã Khách Hàng bị trùng");
            }

            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            String SqlXoa = "delete from KHACHHANG where MaKH ='" + txt_IDKH.Text+ "'";
            dungchung.NonQuery(SqlXoa);
            Load_DSKhachHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
           
            String SqlUpdate = "update KHACHHANG set HOTEN =N'" + txt_TenKH.Text + "',GIOITINH =N'" + cb_GioiTinh.Text + "',NGAYSINH=Convert(Datetime,'" + dt_NgaySinh.Text + "',103),SDT =N'" + txt_SoKH.Text + "',DIACHI =N'" + txt_DiaChi.Text + "',MALOAIKHACH =N'" + cb_LoaiKH.SelectedValue + "' where MAKH ='" + txt_IDKH.Text + "'";
            dungchung.NonQuery(SqlUpdate);
            Load_DSKhachHang();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Text = "";
            txt_IDKH.Text = " ";
            txt_SoKH.Text = " ";
            txt_TenKH.Text = " ";
            cb_GioiTinh.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
            {
               Load_DSKhachHang();
           }
           else
           {
                string sql_Tim = " select * from KHACHHANG where HOTEN like '%" + txt_TimKiem.Text + "%'";
                data_DanhSachKH.DataSource = dungchung.LoadGrid(sql_Tim);
           }
       }



        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
            {
               Load_DSKhachHang();
            }
           else
            {
                string sql_Tim = " select * from KHACHHANG where HOTEN like '%" + txt_TimKiem.Text+ "%'";
                data_DanhSachKH.DataSource = dungchung.LoadGrid(sql_Tim);
            }

        }

        private void data_DanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenKH.Text = data_DanhSachKH.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_IDKH.Text=data_DanhSachKH.CurrentRow.Cells["MAKH"].Value.ToString();
            txt_DiaChi.Text = data_DanhSachKH.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_SoKH.Text = data_DanhSachKH.CurrentRow.Cells["SDT"].Value.ToString();
            cb_GioiTinh.Text = data_DanhSachKH.CurrentRow.Cells["GIOITINH"].Value.ToString();
            cb_LoaiKH.Text = data_DanhSachKH.CurrentRow.Cells["MALOAIKHACH"].Value.ToString();
            cb_LoaiKH.Text = data_DanhSachKH.CurrentRow.Cells["MALOAIKHACH"].Value.ToString();
        }

        private void QuanLyKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Visible = true;
        }
    }
}

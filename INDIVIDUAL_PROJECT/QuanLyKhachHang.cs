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
            Load_ComboSearch();
            Load_ComboKH();
            //Load_ComboSearch();
            Load_DSKhachHang();
        }
        public void Load_DSKhachHang()
        {
            
            
            string sqlLoad_DSKH = "select * from KHACHHANG";
          
            data_DanhSachKH.DataSource = dungchung.LoadGrid(sqlLoad_DSKH);
            

        }
        private void Load_ComboSearch()
        {
            string sqlLoad_Combox = "select * from KHACHHANG";
            cb_Search.DataSource = dungchung.LoadCombobox(sqlLoad_Combox);
            cb_Search.DisplayMember = "MAKH";

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
                dungchung.NonQuery(SqlThem);
                Load_DSKhachHang();
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
    }
}

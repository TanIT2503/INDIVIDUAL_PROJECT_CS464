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
    public partial class HoaDon : Form
    {
        LopDungChung lopchung;
        public HoaDon()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }
        public void LoadData()
        {
            string sqlLoadDT = "select hd.MAHD, hd.NGAYLAPHD, hd.MANV,hd.MAKH,hd.MASP,hd.SOLUONG,sp.DONGIA, hd.GIAMGIA, ((sp.DONGIA*hd.SOLUONG)-(sp.DONGIA*hd.SOLUONG*hd.GIAMGIA*0.01)) as THANHTIEN from (((HOADON as hd left join SANPHAM as sp on hd.MASP=sp.MASP) left join NHANVIEN as nv on hd.MANV=nv.MANV) left join KHACHHANG as kh on hd.MAKH = kh.MAKH)";
            dataGridView1.DataSource = lopchung.LoadGrid(sqlLoadDT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sqlthem = "insert into HOADON values ('" + txt_macode.Text + "','" + dateTimePicker1.Value + "','" + cb_manv.Text + "','" + cb_makh.Text + "','" + cb_masp.Text + "','" + txt_soluong.Text + "','" + txt_giamgia.Text + "')";
            try
            {
                lopchung.NonQuery(sqlthem);
                LoadData();
            }catch
            {
                MessageBox.Show("Mã bị trùng!");
            }
        }

       public void LoadCombo()
        {
            string sqlLoadDT = "select * from NHANVIEN";
            cb_manv.DataSource = lopchung.LoadCombobox(sqlLoadDT);
            cb_manv.DisplayMember = "MANV";
            string sqlLoadMA = "select * from SANPHAM";
            cb_masp.DataSource = lopchung.LoadCombobox(sqlLoadMA);
            cb_masp.DisplayMember = "MASP";
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_macode.Text = dataGridView1.CurrentRow.Cells["MAHD"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NGAYLAPHD"].Value.ToString();
            cb_manv.Text = dataGridView1.CurrentRow.Cells["MANV"].Value.ToString();    
            cb_makh.Text = dataGridView1.CurrentRow.Cells["MAKH"].Value.ToString();
            cb_masp.Text = dataGridView1.CurrentRow.Cells["MASP"].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txt_giamgia.Text = dataGridView1.CurrentRow.Cells["GIAMGIA"].Value.ToString();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {

            string sqlSua = "update HOADON set MANV=N'" + cb_manv.Text + "', MAKH=N'" + cb_makh.Text + "', MASP=N'" + cb_masp.Text + "', SOLUONG=N'" + txt_soluong.Text + "', GIAMGIA=N'"+float.Parse(txt_giamgia.Text)+"' WHERE MAHD ='" + txt_macode.Text + "';";
            lopchung.NonQuery(sqlSua);
            LoadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete from HOADON where MAHD = '" + txt_macode.Text + "'";
            lopchung.NonQuery(sqlXoa);
            LoadData();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_tim.Text == "")
            {
                LoadData();
            }
            else
            {
                string sqltim = "select * from HOADON where MAHD like '%" + txt_tim.Text + "%'";
                dataGridView1.DataSource = lopchung.LoadGrid(sqltim);
            }
        }
    }
}

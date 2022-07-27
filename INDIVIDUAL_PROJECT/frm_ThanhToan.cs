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
    public partial class frm_ThanhToan : Form
    {
        LopDungChung lopChung;
        public frm_ThanhToan()
        {
            InitializeComponent();
            lopChung = new LopDungChung();           
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into THANHTOAN values('"+txt_MaTT.Text+"','"+cb_MaNV.Text+"','"+txt_GioLV.Text+"','"+txt_ThuongThem.Text+"')";
            try
            {
                if (txt_MaTT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên..");
                }
                else
                {
                    lopChung.NonQuery(sqlThem);
                    LoadGrid();
                }
            }
            catch
            {
                MessageBox.Show("Mã thanh toán bị trùng.");
            }
        }

        public void LoadGrid()
        {
            string sqlLoad = "select t.MATT,nv.MANV,nv.HOTEN,t.GIOLAMVIEC,t.THUONGTHEM,(nv.LUONG*t.GIOLAMVIEC)+t.THUONGTHEM as TONGLUONG from THANHTOAN as t join NHANVIEN as nv on t.MANV = nv.MANV";
            dataGridView1.DataSource = lopChung.LoadGrid(sqlLoad);
        }

        public void LoadComboboxMaNV()
        {
            string sqlLoad_combo = "select * from NHANVIEN";
            cb_MaNV.DataSource = lopChung.LoadCombobox(sqlLoad_combo);
            cb_MaNV.DisplayMember = "MANV";
            cb_MaNV.ValueMember = "MANV";
        }
        private void frm_ThanhToan_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadComboboxMaNV();
        }

        
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string SqlSua = "update THANHTOAN set MANV = '" + cb_MaNV.Text + "', GIOLAMVIEC = '" + txt_GioLV.Text + "', THUONGTHEM = '" + txt_ThuongThem.Text + "' where MATT = '" + txt_MaTT.Text + "'";
            lopChung.NonQuery(SqlSua);
            LoadGrid();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete from THANHTOAN where MATT = '" + txt_MaTT.Text + "'";
            lopChung.NonQuery(sqlXoa);
            LoadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaTT.Text = dataGridView1.CurrentRow.Cells["MATT"].Value.ToString();
            cb_MaNV.Text = dataGridView1.CurrentRow.Cells["MANV"].Value.ToString();
            txt_GioLV.Text = dataGridView1.CurrentRow.Cells["GIOLAMVIEC"].Value.ToString();
            txt_ThuongThem.Text = dataGridView1.CurrentRow.Cells["THUONGTHEM"].Value.ToString();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaTT.Text = "";
            cb_MaNV.Text = "";
            txt_GioLV.Text = "";
            txt_ThuongThem.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_Tim.Text == null)
            {
                LoadGrid();
            }
            else
            {
                string sqlTim = "select t.MATT,t.MANV,nv.HOTEN,t.GIOLAMVIEC,t.THUONGTHEM, (nv.LUONG*t.GIOLAMVIEC)+t.THUONGTHEM as TONGLUONG from THANHTOAN as t join NHANVIEN as nv on t.MANV=nv.MANV where t.MATT like ('%" + txt_Tim.Text + "%') or nv.HOTEN like ('%" + txt_Tim.Text + "%')";
                dataGridView1.DataSource = lopChung.LoadGrid(sqlTim);
            }
        }

        private void frm_ThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Visible = true;
        }
    }
}

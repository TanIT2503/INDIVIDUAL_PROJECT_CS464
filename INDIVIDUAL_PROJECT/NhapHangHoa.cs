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
    public partial class NhapHangHoa : Form
    { LopDungChung dungchung;

        public NhapHangHoa()
        {
            InitializeComponent();
            dungchung = new LopDungChung();
            Load_DSSanPham(); 
        }

        private void NhapHangHoa_Load(object sender, EventArgs e)
        {

        }
   
        public void Load_DSSanPham()
        {


            string sqlLoad_DSKH = "select * from SANPHAM";

            data_DSSanPham.DataSource= dungchung.LoadGrid(sqlLoad_DSKH);


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
          
                txt_GiaBan.Text = "";
                txt_IDSP.Text = " ";
                txt_SoLuong.Text = " ";
                txt_TenSP.Text = " ";
                cb_DungTich.Text = "";
                cb_MauSac.Text = " ";
                cb_ThuongHieu.Text = " ";
                txt_TimKiem.Text = "";
                txt_HinhAnh.Text = " ";

            
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Assets\\";

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String SqlThem = "Insert into SANPHAM values('" + txt_IDSP.Text + "',N'" + txt_TenSP.Text + "',N'" + cb_DungTich.Text + "',N'" + cb_MauSac.Text + "' ,N'" + cb_ThuongHieu.Text + "','" + int.Parse(txt_SoLuong.Text) + "','" + float.Parse(txt_GiaBan.Text) + "',N'" + txt_HinhAnh.Text  + "')";
            try
            {
                if (txt_IDSP.Text == "") MessageBox.Show("Bạn không được để trống mã sản phẩm");
                else 
                {
                    dungchung.NonQuery(SqlThem);
                    pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
                    Load_DSSanPham();
                }
               
            }
            catch
            {
                MessageBox.Show("Thêm sản phầm thất bại");
            }
              
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sql_Xoa= " delete from SANPHAM where MASP='" + txt_IDSP.Text + "'";
            
            dungchung.NonQuery(sql_Xoa);
            File.Delete(duongdan + txt_HinhAnh.Text);
            Load_DSSanPham();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String SqlUpdate = "update SANPHAM set TENSP =N'" + txt_TenSP.Text + "',SIZE ='" + cb_DungTich.Text + "',MAUSAC =N'" + cb_MauSac.Text + "',THUONGHIEU =N'" + cb_ThuongHieu.Text + "',SOLUONG ='" + int.Parse(txt_SoLuong.Text)+ "',DONGIA ='" + float.Parse(txt_GiaBan.Text) + "',HINHANH ='" + txt_HinhAnh.Text + "' where MASP ='" + txt_IDSP.Text + "'";
            dungchung.NonQuery(SqlUpdate);
            pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
            Load_DSSanPham();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn ảnh ";
            ofd.Filter = "Tất cả đuôi |*.*|đuôi jpg|*.jpg|đuôi jpeg|*.png ";
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
        }

        private void data_DSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDSP.Text =data_DSSanPham.CurrentRow.Cells["MASP"].Value.ToString();
            txt_GiaBan.Text = data_DSSanPham.CurrentRow.Cells["DONGIA"].Value.ToString();
            txt_HinhAnh.Text = data_DSSanPham.CurrentRow.Cells["HINHANH"].Value.ToString();
            txt_SoLuong.Text = data_DSSanPham.CurrentRow.Cells["SOLUONG"].Value.ToString();
            cb_DungTich.Text = data_DSSanPham.CurrentRow.Cells["SIZE"].Value.ToString();
            cb_MauSac.Text = data_DSSanPham.CurrentRow.Cells["MAUSAC"].Value.ToString();
            txt_TenSP.Text = data_DSSanPham.CurrentRow.Cells["TENSP"].Value.ToString();
            cb_ThuongHieu.Text = data_DSSanPham.CurrentRow.Cells["THUONGHIEU"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_HinhAnh.Text;
            



        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if(txt_TimKiem.Text == "")
            {
                Load_DSSanPham();
            }
            else
            {
                string sql_Tim = " select * from SANPHAM where TENSP like '%" + txt_TimKiem.Text + "%'";
                data_DSSanPham.DataSource = dungchung.LoadGrid(sql_Tim);
            }
            
            
        }

        private void NhapHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Visible = true;
        }
    }
}

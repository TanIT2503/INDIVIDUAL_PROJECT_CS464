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
                dungchung.NonQuery(SqlThem);
                Load_DSSanPham();
            }
            catch
            {
                MessageBox.Show("Mã Khách Hàng bị trùng");
            }
            pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sql_Xoa= " delete from SANPHAM where MASP='" + txt_IDSP.Text + "'";
            dungchung.NonQuery(sql_Xoa);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String SqlUpdate = "update SANPHAM set TENSP =N'" + txt_TenSP.Text + "', where MASP ='" + txt_IDSP.Text + "'";
            dungchung.NonQuery(SqlUpdate);
            Load_DSSanPham();
        }
    }
}

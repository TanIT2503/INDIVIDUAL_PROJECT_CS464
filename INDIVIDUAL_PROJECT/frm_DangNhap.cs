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
    public partial class frm_DangNhap : Form
    {
        LopDungChung lopDungChung;
        public frm_DangNhap()
        {
            InitializeComponent();
            lopDungChung = new LopDungChung();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhanVien frm = new frm_QuanLyNhanVien();
            string sqlDangNhap = "Select count (*) from DANGNHAP where UserName = '" + txt_TenDangNhap.Text + "' and Password = '" + txt_MatKhau.Text + "'";
            int ketqua = (int)lopDungChung.Scalar(sqlDangNhap);
            if (ketqua >= 1)
            {
                frm.Show();
                this.Visible = false;
            }
            else 
                lbl_ThongBao.Text = ("Vui lòng kiểm tra lại mật khẩu hoặc tài khoản.");
        }
    }
}

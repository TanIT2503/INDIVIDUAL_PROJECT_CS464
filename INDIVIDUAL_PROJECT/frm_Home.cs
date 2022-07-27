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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang frm = new QuanLyKhachHang();
            frm.Show();
            this.Visible = false; 
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhanVien frm = new frm_QuanLyNhanVien();
            frm.Show();
            this.Visible = false;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap(); 
            frm.Show();
            this.Visible = false;
        }

        private void thanhToánLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThanhToan frm = new frm_ThanhToan();
            frm.Show();
            this.Visible = false;
        }

        private void lậpHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon frm = new HoaDon();
            frm.Show();
            this.Visible=false;
        }

        

        private void quảnLýNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHangHoa frm = new NhapHangHoa();
            frm.Show();
            this.Visible = false;
        }

        private void frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

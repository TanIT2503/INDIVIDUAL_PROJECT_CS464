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
    }
}

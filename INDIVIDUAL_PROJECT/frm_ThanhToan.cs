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
            string sqlThem = "insert into THANHTOAN values('"+txt_MaTT.Text+"','"+txt_MaNV.Text;
        }
    }
}

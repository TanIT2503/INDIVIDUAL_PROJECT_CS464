using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT
{

    internal class LopDungChung
    {
        String chuoiKetNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|App_Data\BanHang.mdf;Integrated Security=True";
        SqlConnection conn;
        
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }
        public void NonQuery(string sql)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketqua >= 1)
                MessageBox.Show("Thành công.");
            else
                MessageBox.Show("Thất bại.");
        }

        public Object Scalar(string sql)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua; 
        }

        public DataTable LoadGrid(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
    }
}

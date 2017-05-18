using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNCKH
{
    public partial class fKhoa : Form
    {
        public fKhoa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            string makhoa = txtmakhoa.Text;
            string tenkhoa = txttenkhoa.Text;
            string truongkhoa = txttruongkhoa.Text;
            string sodtkhoa = txtsdtkhoa.Text;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Khoa_Insert";
                cmd.Parameters.Add("@makhoa", SqlDbType.VarChar).Value = makhoa;
                cmd.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = tenkhoa;
                cmd.Parameters.Add("@truongkhoa", SqlDbType.NVarChar).Value = truongkhoa;
                cmd.Parameters.Add("@sodtkhoa", SqlDbType.VarChar).Value = sodtkhoa;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm khoa thành công");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
            finally
            {
                conn.Close();
            }
        }

        private void fKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDTDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLDTDataSet.Khoa);
            
        }
    }
}

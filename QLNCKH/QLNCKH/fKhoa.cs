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
    public partial class FKhoa : Form
    {
        public FKhoa()
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
            // TODO: This line of code loads data into the 'qLNCKHDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter1.Fill(this.qLNCKHDataSet.Khoa);
            // TODO: This line of code loads data into the 'qLDTDataSet.Khoa' table. You can move, or remove it, as needed.
           
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string makhoa = txtmakhoa.Text;
            SqlConnection conn = DB.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Khoa_Delete";
                cmd.Parameters.Add("@makhoa", SqlDbType.VarChar).Value = makhoa;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thành công");
            }
            catch
            {
                MessageBox.Show("Xoá gặp lỗi");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SP_Khoa_Update";
                cmd.Parameters.Add("@makhoa", SqlDbType.VarChar).Value = makhoa;
                cmd.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = tenkhoa;
                cmd.Parameters.Add("@truongkhoa", SqlDbType.NVarChar).Value = truongkhoa;
                cmd.Parameters.Add("@sodtkhoa", SqlDbType.VarChar).Value = sodtkhoa;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thay đổi thành công");
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmakhoa.Text = "";
            txtsdtkhoa.Text = "";
            txttenkhoa.Text = "";
            txttruongkhoa.Text = "";
            this.ActiveControl = txtmakhoa;
        }
    }
}

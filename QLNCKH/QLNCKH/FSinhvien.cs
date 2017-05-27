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
    public partial class FSinhvien : Form
    {
        public FSinhvien()
        {
            InitializeComponent();
        }

        private void FSinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDTDataSet4.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter1.Fill(this.qLDTDataSet4.Lop);
            // TODO: This line of code loads data into the 'qLDTDataSet3.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qLDTDataSet3.Lop);
            // TODO: This line of code loads data into the 'qLDTDataSet2.Sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.qLDTDataSet2.Sinhvien);
            rbnam.Checked = true;
            txtngaysinh.Value = new DateTime(1990, 01, 01);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            string malop = cbmalop.Text;
            string masv = txtmasv.Text;
            string hoten = txthoten.Text;
            string ngaysinh = txtngaysinh.Text;
            Boolean gioitinh=false;
            if (rbnam.Checked == true) gioitinh = true;
            string dantoc = txtdantoc.Text;
            string sdt = txtsdt.Text;
            string tenuser = txtuser.Text;
            string diachi = txtdiachi.Text;
            string email = txtemail.Text;
          
            try
            {
                conn.Open();
                string sql = "insert into Sinhvien values('" + masv + "','" + hoten + "','" + malop + "','" + ngaysinh + "','" + dantoc + "','" + sdt + "','" + gioitinh + "','" + tenuser + "','" + diachi + "','" + email + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm Thông tin sinh viên thành công");
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            string masv = txtmasv.Text;
            try
            {
                conn.Open();
                string sql = "delete from Sinhvien where masv='"+masv+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa Thông tin sinh viên thành công");
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            string malop = cbmalop.Text;
            string masv = txtmasv.Text;
            string hoten = txthoten.Text;
            string ngaysinh = txtngaysinh.Text;
            Boolean gioitinh = false;
            if (rbnam.Checked == true) gioitinh = true;
            string dantoc = txtdantoc.Text;
            string sdt = txtsdt.Text;
            string tenuser = txtuser.Text;
            string diachi = txtdiachi.Text;
            string email = txtemail.Text;

            try
            {
                conn.Open();
                string sql = "update  Sinhvien set malop='"+malop+"',hoten='"+hoten+"',ngaysinh='"+ngaysinh+"',gioitinh='"+gioitinh+"',dantoc='"+dantoc+"',sdt='"+sdt+"',tenuser='"+tenuser+"',diachi='"+diachi+"',email='"+email+"' where masv='"+masv+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thay đổi Thông tin sinh viên thành công");
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
    }
}

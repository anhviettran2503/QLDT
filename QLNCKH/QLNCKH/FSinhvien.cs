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
            // TODO: This line of code loads data into the 'qLDTDataSet5.Sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter1.Fill(this.qLDTDataSet5.Sinhvien);
            // TODO: This line of code loads data into the 'qLDTDataSet4.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter1.Fill(this.qLDTDataSet4.Lop);
            // TODO: This line of code loads data into the 'qLDTDataSet3.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qLDTDataSet3.Lop);
            // TODO: This line of code loads data into the 'qLDTDataSet2.Sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.qLDTDataSet2.Sinhvien);
            rbnam.Checked = true;
            txtngaysinh.Value = new DateTime(1990, 01, 01);
            datatable.AutoResizeColumns();
            datatable.AutoResizeRows();
            datatable.Columns[1].Width = 200;
            datatable.Columns[0].Width = 70;
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
            int gioitinh=0;
            if (rbnam.Checked == true) gioitinh = 1;
            string dantoc = txtdantoc.Text;
            string sdt = txtsdt.Text;
            string tenuser = txtuser.Text;
            string diachi = txtdiachi.Text;
            string email = txtemail.Text;
          
            try
            {
                conn.Open();
                string sql = "insert into Sinhvien  values ('"+masv+"',N'"+hoten+"','"+malop+"','"+ngaysinh+"',N'"+dantoc+"','"+sdt+"',"+gioitinh+",'"+tenuser+"',N'"+diachi+"','"+email+"');";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                FSinhvien_Load(sender, e);
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
                FSinhvien_Load(sender, e);
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
            int gioitinh = 0;
            if (rbnam.Checked == true) gioitinh = 1;
            string dantoc = txtdantoc.Text;
            string sdt = txtsdt.Text;
            string tenuser = txtuser.Text;
            string diachi = txtdiachi.Text;
            string email = txtemail.Text;

            try
            {
                conn.Open();
                string sql = "update  Sinhvien set malop='"+malop+"',tensv=N'"+hoten+"',ngaysinh='"+ngaysinh+"',gioitinh="+gioitinh+",dantoc=N'"+dantoc+"',sodtsv='"+sdt+"',tentk='"+tenuser+"',diachi=N'"+diachi+"',email='"+email+"' where masv='"+masv+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                FSinhvien_Load(sender, e);
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


        int index;
        private void datatable_Click(object sender, EventArgs e)
        {
            index = datatable.CurrentRow.Index;
            txtmasv.Text = datatable.Rows[index].Cells[0].Value.ToString();
            txthoten.Text = datatable.Rows[index].Cells[1].Value.ToString();
            cbmalop.Text = datatable.Rows[index].Cells[2].Value.ToString();
            txtngaysinh.Text = datatable.Rows[index].Cells[3].Value.ToString();
            txtdantoc.Text = datatable.Rows[index].Cells[4].Value.ToString();
            txtsdt.Text = datatable.Rows[index].Cells[5].Value.ToString();
            string gioitinh = datatable.Rows[index].Cells[6].Value.ToString();
            if (gioitinh == "True")
                rbnam.Checked = true;
            else rbnu.Checked = true;
            txtuser.Text = datatable.Rows[index].Cells[7].Value.ToString();
            txtdiachi.Text = datatable.Rows[index].Cells[8].Value.ToString();
            txtemail.Text = datatable.Rows[index].Cells[9].Value.ToString();
        }
    }
}

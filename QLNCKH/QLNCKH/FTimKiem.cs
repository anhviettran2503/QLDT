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
    public partial class FTimKiem : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
       
        public FTimKiem()
        {
            InitializeComponent();
        }

        private void txttukhoa_TextChanged(object sender, EventArgs e)
        {
            //Tên Sinh Viên
            //Tên Giảng Viên
            //Tên Khoa
            //Tên Lớp
            //Tên Đề Tài
            conn = DB.GetDBConnection();
            try
            {
                conn.Open();
                string a = cbtruongtimkiem.Text;
                string truyvan = txttukhoa.Text;
                string timkiem="";
                string dk="";
                if (a == "Tên Sinh Viên")
                {   timkiem = "Sinhvien";
                    dk = "tensv";
                }
                else
                if (a == "Tên Giảng Viên")
                {
                    timkiem = "Giangvien";
                    dk = "tengv";
                }
                else
                if (a == "Tên Khoa")
                {
                    timkiem = "Khoa";
                    dk = "tenkhoa";
                }
                else
                if (a == "Tên Lớp")
                {
                    timkiem = "Lop";
                    dk = "tenlop";
                }
                else
                if (a == "Tên Đề Tài")
                {
                    timkiem = "Detai";
                    dk = "tendetai";
                };
                string sql = "select * from "+timkiem+" where "+dk+" like '%"+truyvan+"'";
                da = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

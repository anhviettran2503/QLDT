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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   //Tạo đối tượng conn
            SqlConnection conn = DB.GetDBConnection();
            string user = txtUser.Text;
            string pass = txtPass.Text;
            //Kiểm tra trường nhập vào rỗng
            if (user == "")
            {
                MessageBox.Show("Nhập lại user và password");
            }
            else
            { 
                try
                {   
                    conn.Open();
                    //Tạo đối tượng cmd kiểm tra điều kiện
                    string sql = "select COUNT(*) from Userr where username='"+user+"' and password='"+pass+"'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //x trả về giá trị , nếu lớn hơn hoặc bằng 1 thì điều kiện login đúng
                    int x = (int)cmd.ExecuteScalar();
                    sql = "select username from Userr where username='" + user + "' and password='" + pass + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //a chứa username
                    string a = (string)cmd.ExecuteScalar();
                    sql = "select quyen from Userr where username='" + user + "' and password='" + pass + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //quyen dùng để truyền tham số phân quyền xuống form login
                    string quyen = (string)cmd.ExecuteScalar();
                    //điều kiện login đúng khi x>=1
                    if (x >= 1)
                    {
                        MessageBox.Show("Đăng nhập thành công! Chào mừng " + a);
                        Fmain f = new Fmain(quyen,a);
                        this.Hide();
                        f.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!");
                        txtPass.Text = "";
                        txtUser.Text = "";
                        this.ActiveControl = txtUser;
                    }
                   
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //Link tới form đăng ký
            FRegister f = new FRegister();
            f.ShowDialog();
        }
    }
}

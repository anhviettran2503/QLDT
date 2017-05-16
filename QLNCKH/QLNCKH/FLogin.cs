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
        {
            SqlConnection conn = DB.GetDBConnection();
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (user == "")
            {
                MessageBox.Show("Nhập lại user và password");
            }
            else
            { 
                try
                {
                    conn.Open();
                    string sql = "select COUNT(*) from Userr where username='"+user+"' and password='"+pass+"'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    int x = (int)cmd.ExecuteScalar();
                    sql = "select username from Userr where username='" + user + "' and password='" + pass + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    string a = (string)cmd.ExecuteScalar();
                    sql = "select quyen from Userr where username='" + user + "' and password='" + pass + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    string quyen = (string)cmd.ExecuteScalar();
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
        {
            FRegister f = new FRegister();
            f.ShowDialog();
        }
    }
}

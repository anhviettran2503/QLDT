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
                    string sql = "select * from Userr where username='"+user+"' and password='"+pass+"'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter com = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    com.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        if (user == row["user"] || pass == row["pass"])
                        {
                            MessageBox.Show("Complete");
                            break;
                        }
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
    }
}

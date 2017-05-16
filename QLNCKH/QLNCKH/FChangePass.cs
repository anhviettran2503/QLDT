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
    public partial class FChangePass : Form
    { public string name;
        public FChangePass(string name)
        {
            this.name = name;
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            string pass = txt_pass.Text;
            string passnew = txt_passnew.Text;
            string repass = txt_repass.Text;
            if (pass=="" || passnew=="" || repass=="")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else 
                if (passnew!=repass)
            {
                MessageBox.Show("Password xác nhận sai, hãy nhập lại");
                txt_repass.Text = "";
                txt_passnew.Text = "";
            }
                else
                    try
                    {
                        conn.Open();
                        string sql = "Select password from Userr where username='"+this.name+"'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        string passsql = (string)cmd.ExecuteScalar();
                        if (passsql!=pass)
                        {
                            MessageBox.Show("Password nhập vào không đúng, xin hãy nhập lại");
                            txt_pass.Text = "";
                        }
                        else
                        {
                        sql = "update Userr set password='"+passnew+"' Where username='"+this.name+"'";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thay đổi Password thành công");
                        }
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

        private void FChangePass_Load(object sender, EventArgs e)
        {
            txt_user.Text = this.name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_passnew.Text = "";
            txt_repass.Text = "";
        }
    }
}

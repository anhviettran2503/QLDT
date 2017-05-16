﻿using System;
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
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            string mauser = txt_Mauser.Text;
            string user = txt_Tenuser.Text;
            string pass = txt_Password.Text;
            string quyen = cbt_quyen.Text;
            if (mauser == "" || user == "" || pass=="" || quyen=="")
            {
                MessageBox.Show("Hãy nhập đầy đủ các thông tin");
            }
            else
                try
                {
                    conn.Open();
                    string sql = "insert into Userr values('" + mauser + "','" + user + "','" + pass + "','" + quyen + "')";
                    SqlCommand cmd = new SqlCommand(sql,conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo mới người dùng thành công");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txt_Mauser.Text = "";
            txt_Password.Text = "";
            txt_Tenuser.Text = "";
            cbt_quyen.Text = "";
        }
    }
}

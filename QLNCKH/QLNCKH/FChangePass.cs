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
        {   //Tạo đối tượng conn   
            SqlConnection conn = DB.GetDBConnection();
            string pass = txt_pass.Text;
            string passnew = txt_passnew.Text;
            string repass = txt_repass.Text;
            //Kiểm tra các trường cần nhập đã được nhập đầy đủ chưa
            if (pass=="" || passnew=="" || repass=="")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                this.ActiveControl = txt_user;
            }
            else 
                //Kiểm tra pass mới và pass nhập lại có hợp lệ không
                if (passnew!=repass)
            {
                MessageBox.Show("Password xác nhận sai, hãy nhập lại");
                this.ActiveControl = txt_passnew;
                txt_repass.Text = "";
                txt_passnew.Text = "";
            }
                else
                    try
                    {   //Tạo đối tượng cmd , thực hiện việc lấy password cũ từ sql 
                        conn.Open();
                        string sql = "Select password from Userr where username='"+this.name+"'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        string passsql = (string)cmd.ExecuteScalar();
                        //So sánh password nhập vào với password lấy từ sql
                        if (passsql!=pass)
                        {
                            MessageBox.Show("Password nhập vào không đúng, xin hãy nhập lại");
                            txt_pass.Text = "";
                        }
                        else
                        {
                        //Nếu đúng, thực hiện việc update password trong sql
                        sql = "update Userr set password='"+passnew+"' Where username='"+this.name+"'";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thay đổi Password thành công");
                        }
                    }
                    catch
                    {   //Xảy ra lỗi thì quăng ra messsageBox
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
        {   //Set lại giá trị rỗng cho các trường cần nhập
            txt_pass.Text = "";
            txt_passnew.Text = "";
            txt_repass.Text = "";
        }
    }
}

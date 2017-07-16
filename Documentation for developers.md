# TÀI LIỆU DÀNH CHO NHÀ PHÁT TRIỂN

Muốn tìm hiểu về thiết kế hệ thống , xem tài liệu tại [đây](https://github.com/anhviettran2503/QLDT/blob/master/Design%20document.md)

Hiện tại , phần mềm đang ở ver 1.0. Các module chức năng vẫn chưa được hoàn thiện. Các module Danh mục đề tài, Quản lý đề tài,Thống kê vẫn chưa hoàn thiện.

## Bạn có thể tạo mới một module theo 2 cách: Cách xử lý trực tiếp ở GUI hoặc sử dụng mô hình 3 lớp

+Ở cả hai cách, bạn đều cần phải tạo trước các bảng mình muốn thao tác trong database của SQL Server

## Xử lý trực tiếp ở GUI: 


++Bước 1: Tạo một form thuộc layer GUI

<img src="http://i.imgur.com/JQXeftQ.png">

++Bước 2: Viết giao diện cho form 

Ví dụ: <img src="http://i.imgur.com/Ya3Qezv.png">

++Bước 3: Viết code cho form. Lưu ý: xử lý trực tiếp các thao tác tính toán cũng như thao tác với SQL Server trên form trong GUI

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
    public partial class FLop : Form
    {
        public FLop()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {   //Tạo đối tượng conn
            SqlConnection conn = DB.GetDBConnection();
            string malop = txtmalop.Text;
            string tenlop = txttenlop.Text;
            string makhoa = cbmakhoa.Text;
            try
            {   //Tạo đối tượng cmd thao tác với sql thông qua store procedure
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Lop_Insert";
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = tenlop;
                cmd.Parameters.Add("@makhoa", SqlDbType.VarChar).Value = makhoa;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công");
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

        private void FLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNCKHDataSet1.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLNCKHDataSet1.Khoa);
            // TODO: This line of code loads data into the 'qLDTDataSet1.Lop' table. You can move, or remove it, as needed.


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {   //Giống với button thêm
            string malop = txtmalop.Text;
            SqlConnection conn = DB.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Lop_Delete";
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
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
        {   //Giống với button thêm
            SqlConnection conn = DB.GetDBConnection();
            string malop = txtmalop.Text;
            string tenlop = txttenlop.Text;
            string makhoa = cbmakhoa.Text;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Lop_Update";
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = tenlop;
                cmd.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = makhoa;
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
        {   //Set giá trị rỗng cho các textfield và set vị trí cho con trỏ
            txtmalop.Text = "";
            txttenlop.Text = "";
            cbmakhoa.Text = "";
            this.ActiveControl = cbmakhoa;
        }
    }
}

## Xử lý theo mô hình 3 layer: 

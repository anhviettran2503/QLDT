using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace QLNCKH
{
    public partial class FormDetai : Form
    {   //Tạo BLL_detai để đưa dữ liệu xuống layer BLL
        BLL_Detai bll_detai = new BLL_Detai();
        public FormDetai()
        {
            InitializeComponent();

        }
        //Xử lý thêm đề tài
        private void btnThem_Click(object sender, EventArgs e)
        {   //Tạo detai để tạo DTO đóng gói dữ liệu
            Detai detai = new Detai(txtMadetai.Text,txtTendetai.Text,txtNguoihd.Text,txtThoigiandk.Text);
            if (bll_detai.Insert(detai))
            {
                MessageBox.Show("Đã thêm thành công");
                TableDetai.DataSource = bll_detai.GetDS();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }
        //Xử lý sửa đề tài
        private void btnSua_Click(object sender, EventArgs e)
        {//Tạo detai để tạo DTO đóng gói dữ liệu
            Detai detai = new Detai(txtMadetai.Text, txtTendetai.Text, txtNguoihd.Text, txtThoigiandk.Text);
            if (bll_detai.Update(detai))
            {
                MessageBox.Show("Đã sửa thành công");
                TableDetai.DataSource = bll_detai.GetDS();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }
        //Xử lý xóa đề tài
        private void btnXoa_Click(object sender, EventArgs e)
        {//Tạo detai để tạo DTO đóng gói dữ liệu
            Detai detai = new Detai(txtMadetai.Text, txtTendetai.Text, txtNguoihd.Text, txtThoigiandk.Text);
            if (bll_detai.Delete(detai))
            {
                MessageBox.Show("Đã xóa thành công");
                TableDetai.DataSource = bll_detai.GetDS();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }

        private void FormDetai_Load(object sender, EventArgs e)
        {   //Lấy danh sách đề tài đưa vào gridview
            TableDetai.DataSource = bll_detai.GetDS();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

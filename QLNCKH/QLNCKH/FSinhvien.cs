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
            // TODO: This line of code loads data into the 'qLDTDataSet2.Sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.qLDTDataSet2.Sinhvien);
            rbnam.Checked = true;
            txtngaysinh.Value = new DateTime(1990, 01, 01);
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

            }
        }
    }
}

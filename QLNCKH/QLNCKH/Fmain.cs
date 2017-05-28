using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNCKH
{
    public partial class Fmain : Form
    {
        public string quyen;
        public string name;
        public Fmain(string quyen,string name)
        {
            InitializeComponent();
            this.quyen = quyen;
            this.name = name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tạoUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRegister f = new FRegister();
            f.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChangePass f = new FChangePass(this.name);
            f.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drl = MessageBox.Show("Bạn muốn thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drl== DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void danhMụcKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhoa f = new fKhoa();
            f.ShowDialog();
        }

        private void danhMụcLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLop f = new FLop();
            f.ShowDialog();
        }

        private void danhMụcĐềTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSinhvien f = new FSinhvien();
            f.ShowDialog();
        }

        private void danhMụcGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fgiangvien f = new Fgiangvien();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f = new FLogin();
            f.ShowDialog();
        }

        private void Fmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drl = MessageBox.Show("Bạn muốn thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drl == DialogResult.No)
            {
                e.Cancel=true;
               
            }
            
        }

        private void danhMụcĐềTàiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

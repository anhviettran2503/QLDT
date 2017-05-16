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
    }
}

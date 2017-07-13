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
    public partial class RPNghiemthu : Form
    {
        public RPNghiemthu()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 f = new CrystalReport1();
            crystalReportViewer1.ReportSource = f;
        }
    }
}

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
    public partial class ReportNT : Form
    {
        public ReportNT()
        {
            InitializeComponent();
        }

        private void ReportNT_Load(object sender, EventArgs e)
        {
            CrystalReport1 rp = new CrystalReport1();
            crystalReportViewer1.ReportSource = rp;
        }
    }
}

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
    public partial class Fdetai : Form
    {
        SqlConnection conn = DB.GetDBConnection();
        SqlDataAdapter adap;
        DataTable tb;
        public Fdetai()
        {
            InitializeComponent();
        }

        private void Fdetai_Load(object sender, EventArgs e)
        {
            conn.Open();
            adap = new SqlDataAdapter("select * from detai", conn);
            tb = new DataTable();
            adap.Fill(tb);
            dataGridView1.DataSource = tb;
            conn.Close();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(adap);
            adap.Update(tb);
            Fdetai_Load(sender, e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

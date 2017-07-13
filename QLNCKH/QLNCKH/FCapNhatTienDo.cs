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
    public partial class FCapNhatTienDo : Form
    {
        SqlConnection conn = DB.GetDBConnection();
        SqlDataAdapter adap;
        DataTable tb;
        public FCapNhatTienDo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(adap);
            adap.Update(tb);
            FCapNhatTienDo_Load(sender, e);
        }

        private void FCapNhatTienDo_Load(object sender, EventArgs e)
        {
            conn.Open();
            adap = new SqlDataAdapter("select * from tiendo", conn);
            tb = new DataTable();
            adap.Fill(tb);
            dataGridView1.DataSource = tb;
            conn.Close();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{   //Dùng để tạo  kết nối
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BD23O87\SQLEXPRESS;Initial Catalog=QLNCKH; Integrated Security = True");
    }
}

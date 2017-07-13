using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAL
{   //Dùng để xử lí với sql 
    //Cần kế thừa DBConnect để có SQLConnection
    public class DAL_Detai : DBConnect 
    {   //Hàm lấy danh sách đề tài
        public DataTable GetDS()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Detai",conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        DataTable dt = new DataTable();
        public DAL_Detai()
        {
            dt = GetDS();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] }; 
        }
        //Hàm thêm đề tài
        public bool Insert(Detai pdetai)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Detai VALUES('"+pdetai.madetai+"','"+pdetai.tendetai+"','"+pdetai.nguoihd+"','"+pdetai.thoigiandk+"')", conn);
                cmd.ExecuteNonQuery();
              
            }
            catch
            {
                return false;
            }
            finally
            {
                
                conn.Close();
            }
            return true;
        }
        //Hàm xóa đề tài
        public bool Delete(Detai pdetai)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE Detai WHERE madetai='"+pdetai.madetai+"'", conn);
                cmd.ExecuteNonQuery();
                
            }
            catch
            {
                return false;
            }
            finally
            {
                
                conn.Close();
            }
            return true;
        }
        //Hàm sửa nội dungđề tài
        public bool Update(Detai pdetai)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Detai SET tendetai='" + pdetai.tendetai + "',nguoihd='" + pdetai.nguoihd + "',thoigiandk='" + pdetai.thoigiandk + "' WHERE madetai='" + pdetai.madetai + "'", conn);
                cmd.ExecuteNonQuery();
                
            }
            catch
            {
                return false;
            }
            finally
            {
                
                conn.Close();
            }
            return true;
        }
    }
}

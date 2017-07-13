using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{   
    public class BLL_Detai
    {   //Tạo đối tượng dal_detai để gọi xuống DAL_Detai
        DAL_Detai dal_detai = new DAL_Detai();
        public bool Insert(Detai pdetai)
        {   //Trả về giá trị true nếu thành công hoặc false nếu thất bại
            return dal_detai.Insert(pdetai);
        }
        public bool Delete(Detai pdetai)
        {//Trả về giá trị true nếu thành công hoặc false nếu thất bại
            return dal_detai.Delete(pdetai);
        }
        public bool Update(Detai pdetai)
        {//Trả về giá trị true nếu thành công hoặc false nếu thất bại
            return dal_detai.Update(pdetai);
        }
        public DataTable GetDS()
        {//Trả về bảng dữ liệu đề tài
            return dal_detai.GetDS();
        }
    }
}

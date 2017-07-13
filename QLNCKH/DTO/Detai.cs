using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{   //DTO dùng để đóng gói và chuyển dữ liệu
    public class Detai
    {   //Khai báo các biến và getter setter cho nó
        private string _madetai;

        public string madetai
        {
            get { return _madetai; }
            set { _madetai = value; }
        }
        private string _tendetai;

        public string tendetai
        {
            get { return _tendetai; }
            set { _tendetai = value; }
        }
        private string _nguoihd;

        public string nguoihd
        {
            get { return _nguoihd; }
            set { _nguoihd = value; }
        }
        private string _thoigiandk;

        public string thoigiandk
        {
            get { return _thoigiandk; }
            set { _thoigiandk = value; }
        }
        //Hàm khởi tạo cho class detai
        public Detai(string pMadetai, string pTendetai,string pNguoihd, string pThoigiandk)
        {
            this._madetai = pMadetai;
            this._tendetai = pTendetai;
            this._nguoihd = pNguoihd;
            this._thoigiandk = pThoigiandk;

        }
    }
}

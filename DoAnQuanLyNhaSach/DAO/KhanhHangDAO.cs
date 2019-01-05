using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DTO;
using DoAnQuanLyNhaSach.DAO;
using System.Data.SqlClient;

namespace DoAnQuanLyNhaSach.DAO
{
    
    class KhanhHangDAO
    {
        DataProvider kn = new DataProvider();
        public DataTable SelectKhachHang(KhachHangDTO kh)
        {
            string sql = "select * from KHACHHANG";
            
            return kn.Select(CommandType.Text,sql);
        }
    }

}

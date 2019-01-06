using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DTO;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQuanLyNhaSach.DAO
{
    class NguoiDungDAO
    {
        DataProvider kn = new DataProvider();
        public bool kiemTraNguoiDung(NguoiDungDTO user)
        {
            DataTable dt = new DataTable();
            string sql = "select * from NGUOIDUNG where Username='" + user.UID + "' and Password='" + user.Password + "' and PhanQuyen='" + user.PhanQuyen + "'";
            kn.Connect();
            dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "Username", Value = user.UID },
                new SqlParameter { ParameterName = "Password", Value = user.Password },
                new SqlParameter { ParameterName = "PhanQuyen", Value = user.PhanQuyen });
            if(dt.Rows.Count !=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetDanhSachNguoiDung()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from NGUOIDUNG";
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
    }
}

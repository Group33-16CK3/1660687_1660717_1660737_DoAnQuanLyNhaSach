using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DTO;
using System.Data.SqlClient;

namespace DoAnQuanLyNhaSach.DAO
{
    class ThamSoDAO
    {
        DataProvider kn = new DataProvider();
        public DataTable GetAllThamSo()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from THAMSO";
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
        public DataTable GetTienNoKH(string MaKH)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from KHACHHANG where MaKhachHang=" + MaKH + "";
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql,new SqlParameter { ParameterName="MaKhachHang",Value=MaKH});
            }
            catch(SqlException ex)
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

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
    class PhieuThuDAO
    {
        DataProvider kn = new DataProvider();
        public DataTable SelectAllPhieuThu()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from PHIEUTHU";
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
        public int Insert(PhieuThuDTO pt)
        {
            int flag = -1;
            try
            {
                string sql = "insert into PHIEUTHU(MaPhieuThu,NgayThu,SoTienThu,MaKhachHang) values('" + pt.MaPhieuThu + "'," + pt.NgayThu + "'," + pt.SoTienThu + "," + pt.MaKhachHang + ")";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaPhieuThu", Value = pt.MaPhieuThu },
                    new SqlParameter { ParameterName = "NgayThu", Value = pt.NgayThu },
                    new SqlParameter { ParameterName = "SoTienThu", Value = pt.SoTienThu },
                    new SqlParameter { ParameterName = "MaKhanhHang", Value = pt.MaKhachHang });
                if(nRow >0)
                {
                    flag = 1;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return flag;
        }
    }
}

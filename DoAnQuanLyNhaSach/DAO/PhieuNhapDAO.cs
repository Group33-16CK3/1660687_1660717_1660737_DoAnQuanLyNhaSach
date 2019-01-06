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
    class PhieuNhapDAO
    {
        DataProvider kn = new DataProvider();
        public DataTable SelectAllPhieuNhap()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select* from PHIEUNHAP";
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
        public DataTable SelectAllPhieuNhapCHITIET()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select* from CHITIETPHIEU";
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        public int InsertCHITIETPHIEU(PhieuNhapDTO pn)
        {
            int flag = -1;
            try
            {
                string sql = "insert into CHITIETPHIEU(MaPhieuNhap,MaSach,SoLuongNhap) values(" + pn.MaPhieuNhap + "," + pn.MaSach + "," + pn.SoLuong + ")";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaPhieuNhap", Value = pn.MaPhieuNhap },
                    new SqlParameter { ParameterName = "MaSach", Value = pn.MaSach },
                    new SqlParameter { ParameterName = "SoLuongNhap", Value = pn.SoLuong });
                   
                if (nRow > 0)
                {
                    flag = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return flag;
        }
        public int InsertPHIEUNHAP(PhieuNhapDTO pn)
        {
            int flag = -1;
            try
            {
                string sql = "insert into PHIEUNHAP(NgayNhap) values(" + pn.MaPhieuNhap + "," + pn.NgayNhap + ")";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaPhieuNhap", Value = pn.MaPhieuNhap },
                    new SqlParameter { ParameterName = "NgayNhap", Value = pn.NgayNhap });

                if (nRow > 0)
                {
                    flag = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return flag;
        }
        public PhieuNhapDTO GetPhieuNhapByName(string maphieunhap,string masach)
        {
            DataTable dt = new DataTable();
            string sql = "select * from CHITIETPHIEU where ((MaPhieuNhap=" + maphieunhap + ")AND(MaSach = " + masach + "))";
            kn.Connect();
            dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "MaPhieuNhap", Value = maphieunhap },
                new SqlParameter { ParameterName = "MaSach", Value = masach });
            if(dt.Rows.Count ==0)
            {
                return null;
            }
            else
            {
                PhieuNhapDTO pn = new PhieuNhapDTO();
                pn.MaPhieuNhap = dt.Rows[0].ItemArray[0].ToString();
                return pn;
            }
        }
    }
}

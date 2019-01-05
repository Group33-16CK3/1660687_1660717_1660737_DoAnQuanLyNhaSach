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
        public void Update(PhieuThuDTO pt)
        {
            try
            {
                string sql = "Update  PHIEUTHU set NgayThu =('" + pt.NgayThu + "'),SoTienThu=(" + pt.SoTienThu + ") where MaPhieuThu=" + pt.MaPhieuThu + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text,sql, new SqlParameter { ParameterName = "MaPhieuThu", Value = pt.MaPhieuThu },
                    new SqlParameter { ParameterName = "NgayThu", Value = pt.NgayThu },
                    new SqlParameter { ParameterName = "SoTienThu", Value = pt.SoTienThu });
            }
            catch(Exception ex)
            {
                throw ex;
            
            }
            finally
            {
                kn.Disconnect();
            }
        }
        public bool Delete(PhieuThuDTO pt)
        {
            try
            {
                string sql = "delete from PHIEUTHU where MaPhieuThu= " + pt.MaPhieuThu + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaPhieuThu", Value = pt.MaPhieuThu });


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                kn.Disconnect();
            }
        }
        public  PhieuThuDTO GetPhieuThuByMa(string Ma)
        {
            string sql = "select * from PHIEUTHU where MaPhieuThu=" + Ma + "";
            kn.Connect();
            DataTable dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "MaPhieuThu", Value = Ma });
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                PhieuThuDTO pt = new PhieuThuDTO();
                pt.MaPhieuThu = dt.Rows[0].ItemArray[0].ToString();
                               
                return pt;
            }

        }
        public  DataTable GetPhieuThuCondition(string MaPhieuThu)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from PHIEUTHU,KHACHHANG where MaPhieuThu = " + MaPhieuThu + "";
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "MaPhieuThu", Value = MaPhieuThu });
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

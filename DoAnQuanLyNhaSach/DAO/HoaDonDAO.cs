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
    class HoaDonDAO
    {
        DataProvider kn = new DataProvider();
        public HoaDonDTO SelectSachTheoMaSach(string mahoadon, string masach)
        {
            string sql = "select * from CHITIETHOADON where ((MaHoaDon = " + mahoadon + ")AND(MaSach like " + masach + ") )";
            kn.Connect();
            DataTable dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "MaHoaDon", Value = mahoadon },
                new SqlParameter { ParameterName = "MaSach", Value = masach }); 
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaSach = dt.Rows[0].ItemArray[0].ToString();
                return hd;
            }
        }
        public  DataTable SelectAllHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from HOADON";
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
        public  DataTable SelectallHoaDonChiTiet()
        {
           
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from CHITIETHOADON";
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
        public  int Insert(HoaDonDTO hd)
        {
            int flag = -1;
            try
            {
                string sql = "insert into HOADON(NgayLapHoaDon,MaKhachHang) values('" + hd.NgayLapHoaDon + "'," + hd.MaKhachHang + ")";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "NgayLapHoaDon", Value = hd.NgayLapHoaDon },
                    new SqlParameter { ParameterName = "MaKhachHang", Value = hd.MaKhachHang });
                if(nRow >0)
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
        public int InsertChitiet(HoaDonDTO hd)
        {
            int flag = -1;
            try
            {
                string sql = "insert into HOADON(NgayLapHoaDon,MaKhachHang) values('" + hd.NgayLapHoaDon + "'," + hd.MaKhachHang + ")";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "NgayLapHoaDon", Value = hd.NgayLapHoaDon },
                    new SqlParameter { ParameterName = "MaKhachHang", Value = hd.MaKhachHang });
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
        public  void Update(HoaDonDTO hd)
        {
            try
            {
                string sql = "Update  HOADON set NgayLapHoaDon =('" + hd.NgayLapHoaDon + "'),MaSach=(" + hd.MaSach + "), MaKhachHang=(" + hd.MaKhachHang + ") where MaHoaDon=" + hd.MaHoaDon + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "NgayLapHoaDon", Value = hd.NgayLapHoaDon },
                    new SqlParameter { ParameterName = "MaSach", Value = hd.MaSach },
                    new SqlParameter { ParameterName = "MaKhachHang", Value = hd.MaKhachHang },
                    new SqlParameter { ParameterName = "MaHoaDon", Value = hd.MaHoaDon });
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
        public  bool Delete(HoaDonDTO hd)
        {
            try
            {
                string sql = "delete from HOADON where MaHoaDon= " + hd.MaHoaDon + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaHoaDon", Value = hd.MaHoaDon });
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                kn.Disconnect();
            }
        }
    }
}

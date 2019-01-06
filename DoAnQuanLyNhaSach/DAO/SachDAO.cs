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
    class SachDAO
    {
        DataProvider kn = new DataProvider();
        public DataTable SelectSachTheoTen(SachDTO s)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from SACH where TenSach like '%" + s.TenSach + "%'";
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "TenSach", Value = s.TenSach });
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
        public DataTable SelectSachTheoMaTheLoai(SachDTO s)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from SACH where MaTheLoai like '%" + s.MaTheLoai + "%'";
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "MaTheLoai", Value = s.MaTheLoai });
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
        public DataTable SelectSachTheoTacGia(SachDTO s)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from SACH where TacGia like '%" + s.TacGia + "%'";
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "TacGia", Value = s.TacGia });
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
        public DataTable SelectAllSach(SachDTO s)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from SACH ";
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
        public int Insert(SachDTO s)
        {
            int flag = -1;
            try
            {
                string sql = "insert into SACH(MaSach,TenSach,TacGia,MaTheLoai,GiaBan,SoLuongTon) values('" + s.MaSach + "','" + s.TenSach + "','" + s.TacGia + "'," + s.MaTheLoai + "," + s.GiaBan + "," + s.SoLuongTon + ")";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaSach", Value = s.MaSach },
                    new SqlParameter { ParameterName = "TenSach", Value = s.TenSach },
                    new SqlParameter { ParameterName = "TacGia", Value = s.TacGia },
                    new SqlParameter { ParameterName = "MaTheLoai", Value = s.MaTheLoai },
                    new SqlParameter { ParameterName = "GiaBan", Value = s.GiaBan },
                    new SqlParameter { ParameterName = "SoLuongTon", Value = s.SoLuongTon });
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
        public bool Delete(SachDTO s)
        {
            try
            {
                string sql = "delete from SACH where MaSach= " + s.MaSach + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaSach", Value = s.MaSach });
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
        public void Update(SachDTO s)
        {
            try
            {
                string sql = "update  SACH set TenSach=('" + s.TenSach + "'),TacGia=('" + s.TacGia + "'),MaTheLoai=(" + s.MaTheLoai + "),GiaBan=(" + s.GiaBan + "),SoLuongTon=(" + s.SoLuongTon + ") where MaSach = " + s.MaSach + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text,sql, new SqlParameter { ParameterName = "MaSach", Value = s.MaSach },
                    new SqlParameter { ParameterName = "TenSach", Value = s.TenSach },
                    new SqlParameter { ParameterName = "TacGia", Value = s.TacGia },
                    new SqlParameter { ParameterName = "MaTheLoai", Value = s.MaTheLoai },
                    new SqlParameter { ParameterName = "GiaBan", Value = s.GiaBan },
                    new SqlParameter { ParameterName = "SoLuongTon", Value = s.SoLuongTon });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }

        }
        public void UpdateSoLuongTon(SachDTO s)
        {
            try
            {
                string sql = "update  SACH set SoLuongTon=(" + s.SoLuongTon + ") where MaSach = " + s.MaSach + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql,new SqlParameter { ParameterName = "SoLuongTon", Value = s.SoLuongTon });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }

        }
        public SachDTO SelectTLByName(string ten)
        {
            DataTable dt = new DataTable();
            string sql = "select * from SACH where TenSach='" + ten + "'";
            kn.Connect();


            dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "TenSach", Value = ten });
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                SachDTO s = new SachDTO();
                s.TenSach = dt.Rows[0].ItemArray[0].ToString();
                return s;
            }
        }
        public SachDTO SelectSachTheoMa(int ma)
        {
            DataTable dt = new DataTable();
            string sql = "select * from SACH where MaSach=" + ma + "";
            kn.Connect();
            dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "MaSach", Value = ma });
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                SachDTO s = new SachDTO();
                s.MaSach = dt.Rows[0].ItemArray[0].ToString();
                return s;
            }
        }
        public  DataTable GetSachCondition(int SoLuongTon)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from SACH where SoLuongTon < " + SoLuongTon;
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "SoLuongTon", Value = SoLuongTon });
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
        internal static object SelectPNByName(object p)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}

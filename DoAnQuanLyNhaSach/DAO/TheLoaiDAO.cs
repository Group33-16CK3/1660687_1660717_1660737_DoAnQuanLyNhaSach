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
    class TheLoaiDAO
    {
        DataProvider kn = new DataProvider();
        public int Insert(TheLoaiDTO tl)
        {
            int flag = -1;
            try
            {
                string sql = "insert into THELOAI(TenTheLoai) values('" + tl.TenTheLoai + "')";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "TenTheLoai", Value = tl.TenTheLoai });
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
        public  void Update(TheLoaiDTO tl)
        {
            try
            {
                string sql = "Update  THELOAI set TenTheLoai ='" + tl.TenTheLoai + "'where MaTheLoai=" + tl.MaTheLoai + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "TenTheLoai", Value = tl.TenTheLoai });

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
        public  bool Delete(TheLoaiDTO tl)
        {
            try
            {
                string sql = "delete from THELOAI where TenTheLoai= '" + tl.TenTheLoai + "'";

                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "TenTheLoai", Value = tl.TenTheLoai });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public  TheLoaiDTO GetTheLoaiByName(string Name)
        {
            string sql = "select * from THELOAI where TenTheLoai='" + Name + "'";
            kn.Connect();
            DataTable dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "TenTheLoai", Value = Name });
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                TheLoaiDTO tl = new TheLoaiDTO();
                tl.MaTheLoai = dt.Rows[0].ItemArray[0].ToString();
                tl.TenTheLoai = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public  TheLoaiDTO GetTheLoaiByMa(int Ma)
        {
            string sql = "select * from THELOAI where MaTheLoai=" + Ma + "";
            kn.Connect();
            DataTable dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "MaTheLoai", Value = Ma });
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                TheLoaiDTO tl = new TheLoaiDTO();
                tl.MaTheLoai = dt.Rows[0].ItemArray[0].ToString();
                tl.TenTheLoai = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public  DataTable GetTheLoaiAll()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from THELOAI";
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
    }
}

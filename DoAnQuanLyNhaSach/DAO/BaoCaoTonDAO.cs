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
    class BaoCaoTonDAO
    {
        DataProvider kn = new DataProvider();
        public  DataTable BaoCaoThang(int thang)
        {
            DataTable dt = new DataTable();
            try
            {

                string sql = "select * from BAOCAOTON where Month(NgayPhatSinh) like '%" + thang + "%' ";
                kn.Connect();
                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "Month(NgayPhatSinh)", Value = thang });
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
        public int Insert(BaoCaoTonDTO bc)
        {
            int flag = -1;
            try
            {
                string sql = "insert into BAOCAOTON(MaSach,NgayPhatSinh,TonDau,PhatSinh,TonCuoi) values(" + bc.MaSach + ",'" + bc.NgayPhatSinh + "'," + bc.TonDau + ",'" + bc.PhatSinh + "'," + bc.TonCuoi + ")";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaSach", Value = bc.MaSach },
                    new SqlParameter { ParameterName = "NgayPhatSinh", Value = bc.NgayPhatSinh },
                    new SqlParameter { ParameterName = "TonDau", Value = bc.TonDau },
                    new SqlParameter { ParameterName = "PhatSinh", Value = bc.PhatSinh },
                    new SqlParameter { ParameterName = "TonCuoi", Value = bc.TonCuoi });
                if(nRow>0)
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

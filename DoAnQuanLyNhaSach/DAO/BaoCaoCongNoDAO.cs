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
    class BaoCaoCongNoDAO
    {
        DataProvider kn = new DataProvider();
        public void Insert(BaoCaoCongNoDTO bc)
        {
            string sql = "insert into BAOCAOCONGNO(MaKhachHang,NgayPhatSinh,NoDau,PhatSinh,NoCuoi) values(" + bc.MaKhachHang + ",'" + bc.NgayPhatSinh + "'," + bc.NoDau + ",'" + bc.NoCuoi + "'," + bc.PhatSinh + ")";

            kn.ExecuteNonQuery(CommandType.Text,sql,new SqlParameter {ParameterName="MaKhachHang",Value=bc.MaKhachHang },
                new SqlParameter { ParameterName="NgayPhatSinh",Value=bc.NgayPhatSinh},
                new SqlParameter { ParameterName="NoDau",Value=bc.NoDau},
                new SqlParameter { ParameterName="PhatSinh",Value=bc.PhatSinh},
                new SqlParameter { ParameterName="NoCuoi",Value=bc.NoCuoi});
        }
    }
}

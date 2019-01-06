using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DTO;
using DoAnQuanLyNhaSach.DAO;
using System.Data.SqlClient;

namespace DoAnQuanLyNhaSach.DAO
{

    class KhanhHangDAO
    {
        DataProvider kn = new DataProvider();
        public DataTable SelectKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from KHACHHANG";
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
        public DataTable SelectKhachHangTheoDienThoai(KhachHangDTO kh)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from KHACHHANG where DienThoai like '%" + kh.DienThoai + "%'";
                kn.Connect();

                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "DienThoai", Value = kh.DienThoai });
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
        public DataTable SelectKhachHangTheoTen(KhachHangDTO kh)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from KHACHHANG where DienThoai like '%" + kh.HoTenKhachHang + "%'";
                kn.Connect();

                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "HoTenKhachHang", Value = kh.HoTenKhachHang });
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
        public DataTable SelectKhachHangTheoEmail(KhachHangDTO kh)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from KHACHHANG where DienThoai like '%" + kh.Email + "%'";
                kn.Connect();

                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "Email", Value = kh.Email });
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
        public DataTable SelectKhachHangTheoDiaChi(KhachHangDTO kh)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from KHACHHANG where DienThoai like '%" + kh.DiaChi + "%'";
                kn.Connect();

                dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "DiaChi", Value = kh.DiaChi });
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
        public int Insert(KhachHangDTO kh)
        {
            int flag = -1;
            try
            {
                string sql = "insert into KHACHHANG(MaKhachHang,HoTenKhachHang,DienThoai,DiaChi,Email,TienNo) values('" + kh.MaKhachHang + "'," + kh.HoTenKhachHang + "'," + kh.DienThoai + ",'" + kh.DiaChi + "','" + kh.Email + "'," + kh.HoTenKhachHang + "')";
                kn.Connect();
                int nRow = kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaKhachHang", Value = kh.MaKhachHang },
                    new SqlParameter { ParameterName = "HoTenKhachHang", Value = kh.HoTenKhachHang },
                    new SqlParameter { ParameterName = "DienThoai", Value = kh.DienThoai },
                    new SqlParameter { ParameterName = "DiaChi", Value = kh.DiaChi },
                    new SqlParameter { ParameterName = "Email", Value = kh.Email },
                    new SqlParameter { ParameterName = "TienNo", Value = kh.TienNo });
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
        public void Update(KhachHangDTO kh)
        {
            try
            {
                string sql = "Update  KHACHHANG set HoTenKhachHang =('" + kh.HoTenKhachHang + "'),DienThoai=(" + kh.DienThoai + "), DiaChi=('" + kh.DiaChi + "'),Email=('" + kh.Email + "'),TienNo=('" + kh.TienNo + "') where MaKhachHang=" + kh.MaKhachHang + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaKhachHang", Value = kh.MaKhachHang },
                    new SqlParameter { ParameterName = "HoTenKhachHang", Value = kh.HoTenKhachHang },
                    new SqlParameter { ParameterName = "DienThoai", Value = kh.DienThoai },
                    new SqlParameter { ParameterName = "DiaChi", Value = kh.DiaChi },
                    new SqlParameter { ParameterName = "Email", Value = kh.Email });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
        }
        public void UpdateTienNoKH(KhachHangDTO kh)
        {
            try
            {
                string sql = "Update  KHACHHANG set TienNo=('" + kh.TienNo + "') where MaKhachHang=" + kh.MaKhachHang + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaKhachHang", Value = kh.MaKhachHang },
                    new SqlParameter { ParameterName = "TienNo", Value = kh.TienNo });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
        }
        public bool Delete(KhachHangDTO kh)
        {
            try
            {
                string sql = "delete from KHACHHANG where MaKhachHang= " + kh.MaKhachHang + "";
                kn.Connect();
                kn.ExecuteNonQuery(CommandType.Text, sql, new SqlParameter { ParameterName = "MaKhachHang", Value = kh.MaKhachHang });
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
        public KhachHangDTO GetTheLoaiByMa(string Ma)
        {
            string sql = "select * from KHACHHANG where MaKhachHang=" + Ma + "";
            kn.Connect();
            DataTable dt = kn.Select(CommandType.Text, sql, new SqlParameter { ParameterName = "MaKhachHang", Value = Ma });
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = dt.Rows[0].ItemArray[0].ToString();
                kh.HoTenKhachHang = dt.Rows[0].ItemArray[1].ToString();
                kh.DienThoai = dt.Rows[0].ItemArray[2].ToString();
                kh.DiaChi = dt.Rows[0].ItemArray[3].ToString();
                kh.Email = dt.Rows[0].ItemArray[4].ToString();
                return kh;
            }
        }
    }
}

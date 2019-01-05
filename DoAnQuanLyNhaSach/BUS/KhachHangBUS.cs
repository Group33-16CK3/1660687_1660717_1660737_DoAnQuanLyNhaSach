using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DTO;
using DoAnQuanLyNhaSach.DAO;

namespace DoAnQuanLyNhaSach.BUS
{
    class KhachHangBUS
    {
        KhanhHangDAO khDAO = new KhanhHangDAO();
        public  bool ThemKhachHang(KhachHangDTO kh)
        {
            if (khDAO.GetTheLoaiByMa(kh.MaKhachHang) == null)
            {
                khDAO.Insert(kh);
                return true;
            }
            else
            {

                return false;
            }
        }
        public  bool XoaKhachHang(KhachHangDTO kh)
        {
            if (khDAO.GetTheLoaiByMa(kh.MaKhachHang) != null)
            {
                khDAO.Delete(kh);
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool SuaKhachHang(KhachHangDTO kh)
        {
            if (khDAO.GetTheLoaiByMa(kh.MaKhachHang) != null)
            {
                khDAO.Update(kh);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

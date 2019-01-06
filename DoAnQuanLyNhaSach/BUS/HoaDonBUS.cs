using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DTO;
using DoAnQuanLyNhaSach.DAO;

namespace DoAnQuanLyNhaSach.BUS
{
    class HoaDonBUS
    {
        HoaDonDAO hdDAO = new HoaDonDAO();
        public  bool ThemHoaDon(HoaDonDTO hd)
        {
            hdDAO.Insert(hd);
            return true;
        }
        public  bool ThemHoaDonChiTiet(HoaDonDTO hd)
        {
            if (hdDAO.SelectSachTheoMaSach(hd.MaHoaDon, hd.MaSach) == null)
            {
                hdDAO.InsertChitiet(hd);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

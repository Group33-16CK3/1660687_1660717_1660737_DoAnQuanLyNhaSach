using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DAO;
using DoAnQuanLyNhaSach.DTO;

namespace DoAnQuanLyNhaSach.BUS
{
    class SachBUS
    {
        SachDAO sDAO = new SachDAO();
        public  bool ThemSach(SachDTO s)
        {
            if (sDAO.SelectTLByName(s.TenSach) == null)
            {
                sDAO.Insert(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool CapNhatSach(SachDTO s)
        {
            if (sDAO.SelectSachTheoMa(s.MaSach) != null)
            {
                sDAO.Insert(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool XoaSach(SachDTO s)
        {
            if (sDAO.SelectSachTheoMa(s.MaSach) != null)
            {
                sDAO.Delete(s);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

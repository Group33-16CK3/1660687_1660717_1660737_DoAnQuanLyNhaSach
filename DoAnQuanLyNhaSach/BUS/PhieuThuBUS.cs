using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DAO;
using DoAnQuanLyNhaSach.DTO;

namespace DoAnQuanLyNhaSach.BUS
{
    class PhieuThuBUS
    {
        PhieuThuDAO ptDAO = new PhieuThuDAO();
        public  bool ThemPhieuThu(PhieuThuDTO pt)
        {
            if (ptDAO.GetPhieuThuByMa(pt.MaPhieuThu) == null)
            {
                ptDAO.Insert(pt);
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool XoaPhieuThu(PhieuThuDTO pt)
        {
            if (ptDAO.GetPhieuThuByMa(pt.MaPhieuThu) != null)
            {
                ptDAO.Delete(pt);
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool SuaPhieuThu(PhieuThuDTO pt)
        {
            if (ptDAO.GetPhieuThuByMa(pt.MaPhieuThu) != null)
            {
                ptDAO.Update(pt);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

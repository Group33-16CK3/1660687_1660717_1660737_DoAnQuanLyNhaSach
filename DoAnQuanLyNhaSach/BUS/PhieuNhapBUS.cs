using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DTO;
using DoAnQuanLyNhaSach.DAO;

namespace DoAnQuanLyNhaSach.BUS
{
    class PhieuNhapBUS
    {
        PhieuNhapDAO pnDAO = new PhieuNhapDAO();
        public  bool themphieunhap(PhieuNhapDTO p)
        {
            pnDAO.InsertPHIEUNHAP(p);
            return true;
        }
        public bool themchitietphieunhap(PhieuNhapDTO p)
        {
            if (pnDAO.GetPhieuNhapByName(p.MaPhieuNhap,p.MaSach) == null)
            {
                pnDAO.InsertCHITIETPHIEU(p);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

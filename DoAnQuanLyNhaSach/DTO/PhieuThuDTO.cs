using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class PhieuThuDTO
    {
        private string _MaPhieuThu;
        private DateTime _NgayThu;
        private int _SoTienThu;
        private string _MaKhachHang;

        public string MaPhieuThu
        {
            get
            {
                return _MaPhieuThu;
            }

            set
            {
                _MaPhieuThu = value;
            }
        }

        public DateTime NgayThu
        {
            get
            {
                return _NgayThu;
            }

            set
            {
                _NgayThu = value;
            }
        }

        public int SoTienThu
        {
            get
            {
                return _SoTienThu;
            }

            set
            {
                _SoTienThu = value;
            }
        }

        public string MaKhachHang
        {
            get
            {
                return _MaKhachHang;
            }

            set
            {
                _MaKhachHang = value;
            }
        }
    }
}

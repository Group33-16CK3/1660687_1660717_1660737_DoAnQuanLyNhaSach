using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class HoaDonDTO
    {
        private string _MaHoaDon;
        private DateTime _NgayLapHoaDon;
        private string _MaSach;
        private string _MaKhachHang;
        private int _SoLuongMua;


        public string MaHoaDon
        {
            get
            {
                return _MaHoaDon;
            }

            set
            {
                _MaHoaDon = value;
            }
        }

        public DateTime NgayLapHoaDon
        {
            get
            {
                return _NgayLapHoaDon;
            }

            set
            {
                _NgayLapHoaDon = value;
            }
        }

        public string MaSach
        {
            get
            {
                return _MaSach;
            }

            set
            {
                _MaSach = value;
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

        public int SoLuongMua
        {
            get
            {
                return _SoLuongMua;
            }

            set
            {
                _SoLuongMua = value;
            }
        }
    }
}

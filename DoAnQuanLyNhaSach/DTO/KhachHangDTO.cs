using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class KhachHangDTO
    {
        private string _MaKhachHang;
        private string _HoTenKhachHang;
        private int _DienThoai;
        private string _DiaChi;
        private string _Email;
        private string _MaHoaDon;
        private int _TienNo;

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

        public string HoTenKhachHang
        {
            get
            {
                return _HoTenKhachHang;
            }

            set
            {
                _HoTenKhachHang = value;
            }
        }

        public int DienThoai
        {
            get
            {
                return _DienThoai;
            }

            set
            {
                _DienThoai = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

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

        public int TienNo
        {
            get
            {
                return _TienNo;
            }

            set
            {
                _TienNo = value;
            }
        }
    }
}

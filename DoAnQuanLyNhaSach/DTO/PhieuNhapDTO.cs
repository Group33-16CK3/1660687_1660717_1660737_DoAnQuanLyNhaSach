using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class PhieuNhapDTO
    {
        private string _MaPhieuNhap;
        private DateTime _NgayNhap;
        private string _MaSach;
        private int _SoLuong;

        public string MaPhieuNhap
        {
            get
            {
                return _MaPhieuNhap;
            }

            set
            {
                _MaPhieuNhap = value;
            }
        }

        public DateTime NgayNhap
        {
            get
            {
                return _NgayNhap;
            }

            set
            {
                _NgayNhap = value;
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

        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }

            set
            {
                _SoLuong = value;
            }
        }
    }

}

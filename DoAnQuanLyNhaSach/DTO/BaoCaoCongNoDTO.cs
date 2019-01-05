using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class BaoCaoCongNoDTO
    {
        private string _MaKhachHang;
        private int _NoDau;
        private string _PhatSinh;
        private int _NoCuoi;
        private DateTime _NgayPhatSinh;

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

        public int NoDau
        {
            get
            {
                return _NoDau;
            }

            set
            {
                _NoDau = value;
            }
        }

        public string PhatSinh
        {
            get
            {
                return _PhatSinh;
            }

            set
            {
                _PhatSinh = value;
            }
        }

        public int NoCuoi
        {
            get
            {
                return _NoCuoi;
            }

            set
            {
                _NoCuoi = value;
            }
        }

        public DateTime NgayPhatSinh
        {
            get
            {
                return _NgayPhatSinh;
            }

            set
            {
                _NgayPhatSinh = value;
            }
        }
    }
}

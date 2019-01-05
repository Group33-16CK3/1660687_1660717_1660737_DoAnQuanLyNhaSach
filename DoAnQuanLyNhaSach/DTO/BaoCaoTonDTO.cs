using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class BaoCaoTonDTO
    {
        private string _MaSach;
        private DateTime _NgayPhatSinh;
        private int _TonDau;
        private int _TonCuoi;
        private string _PhatSinh;

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

        public int TonDau
        {
            get
            {
                return _TonDau;
            }

            set
            {
                _TonDau = value;
            }
        }

        public int TonCuoi
        {
            get
            {
                return _TonCuoi;
            }

            set
            {
                _TonCuoi = value;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class SachDTO
    {
        private string _MaSach;
        private string _TenSach;
        private int _SoLuongTon;
        private string _TacGia;
        private string _MaTheLoai;
        private int _GiaBan;

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

        public string TenSach
        {
            get
            {
                return _TenSach;
            }

            set
            {
                _TenSach = value;
            }
        }

        public int SoLuongTon
        {
            get
            {
                return _SoLuongTon;
            }

            set
            {
                _SoLuongTon = value;
            }
        }

        public string TacGia
        {
            get
            {
                return _TacGia;
            }

            set
            {
                _TacGia = value;
            }
        }

        public string MaTheLoai
        {
            get
            {
                return _MaTheLoai;
            }

            set
            {
                _MaTheLoai = value;
            }
        }

        public int GiaBan
        {
            get
            {
                return _GiaBan;
            }

            set
            {
                _GiaBan = value;
            }
        }
    }
}

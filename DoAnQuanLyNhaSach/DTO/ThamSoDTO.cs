using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class ThamSoDTO
    {
        private int _MaThamSo;
        private int _SoLuongNhapMin;
        private int _LuongTonMin;
        private int _NoMin;
        private int _TonSauKhiBan;
        private int _DieuKienThu;

        public int MaThamSo
        {
            get
            {
                return _MaThamSo;
            }

            set
            {
                _MaThamSo = value;
            }
        }

        public int SoLuongNhapMin
        {
            get
            {
                return _SoLuongNhapMin;
            }

            set
            {
                _SoLuongNhapMin = value;
            }
        }

        public int LuongTonMin
        {
            get
            {
                return _LuongTonMin;
            }

            set
            {
                _LuongTonMin = value;
            }
        }

        public int NoMin
        {
            get
            {
                return _NoMin;
            }

            set
            {
                _NoMin = value;
            }
        }

        public int TonSauKhiBan
        {
            get
            {
                return _TonSauKhiBan;
            }

            set
            {
                _TonSauKhiBan = value;
            }
        }

        public int DieuKienThu
        {
            get
            {
                return _DieuKienThu;
            }

            set
            {
                _DieuKienThu = value;
            }
        }
    }
}

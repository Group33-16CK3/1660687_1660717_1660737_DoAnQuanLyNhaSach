using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class TheLoaiDTO
    {
        private string _MaTheLoai;
        private string _TenTheLoai;

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

        public string TenTheLoai
        {
            get
            {
                return _TenTheLoai;
            }

            set
            {
                _TenTheLoai = value;
            }
        }
    }
}

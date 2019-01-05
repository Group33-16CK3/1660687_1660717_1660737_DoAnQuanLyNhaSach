using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DTO
{
    class NguoiDungDTO
    {
        private string _UID;
        private string _Password;

        public string UID
        {
            get
            {
                return _UID;
            }

            set
            {
                _UID = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }
    }
}

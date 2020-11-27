using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    class DTO_Luong
    {
        private string _Luong_MaCV;
        private string _Luong_TenCV;
        public string Luong_MaCV
        {
            get
            {
                return _Luong_MaCV;
            }
            set
            {
                _Luong_MaCV = value;
            }
        }
        public string Luong_TenCV
        {
            get
            {
                return _Luong_TenCV;
            }
            set
            {
                _Luong_TenCV = value;
            }
        }
    }
}

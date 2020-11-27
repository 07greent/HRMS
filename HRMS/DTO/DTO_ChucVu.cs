using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    public class DTO_ChucVu
    {
        private string _CtChucVu_MaCV;
        private string _CtChucVu_TenCV;

        public string CtChucVu_MaCV
        {
            get
            {
                return _CtChucVu_MaCV;
            }
            set
            {
                _CtChucVu_MaCV = value;
            }
        }
        public string CtChucVu_TenCV
        {
            get
            {
                return _CtChucVu_TenCV;
            }
            set
            {
                _CtChucVu_TenCV = value;
            }
        }

    }
}

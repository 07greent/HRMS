using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    class DTO_HopDong
    {
        private string _HopDong_MaHD;
        private DateTime _HopDong_NgayVaoLam;
        private int _HopDong_HeSoLuong;
        private string _HopDong_MaCV;
        private string _HopDong_MaPB;

        public string HopDong_MaHD
        {
            get
            {
                return _HopDong_MaHD;
            }
            set
            {
                _HopDong_MaHD = value;
            }
        }
        public DateTime ong_NgayVaoLam
        {
            get
            {
                return _HopDong_NgayVaoLam;
            }
            set
            {
                _HopDong_NgayVaoLam = value;
            }
        }
        public int HopDong_HeSoLuong
        {
            get
            {
                return _HopDong_HeSoLuong;
            }
            set
            {
                _HopDong_HeSoLuong = value;
            }
        }
        public string HopDong_MaCV
        {
            get
            {
                return _HopDong_MaCV;
            }
            set
            {
                _HopDong_MaCV = value;
            }
        }
        public string HopDong_MaPB
        {
            get
            {
                return _HopDong_MaPB;
            }
            set
            {
                _HopDong_MaPB = value;
            }
        }
    }
}

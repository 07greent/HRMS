using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    class DTO_ChamCong
    {
        private string _ChamCong_MaNhanVien;
        private DateTime _ChamCong_Ngay;
        private string _ChamCong_TinhTrang;

        public string ChamCong_MaNhanVien
        {
            get
            {
                return _ChamCong_MaNhanVien;
            }
            set
            {
                _ChamCong_MaNhanVien = value;
            }
        }
        public DateTime ChamCong_Ngay
        {
            get
            {
                return _ChamCong_Ngay;
            }
            set
            {
                _ChamCong_Ngay = value;
            }
        }
        public string ChamCong_TinhTrang
        {
            get
            {
                return _ChamCong_TinhTrang;
            }
            set
            {
                _ChamCong_TinhTrang = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    class DTO_PhuCap
    {
        private string _PhuCap_MaNhanVien;
        private string _PhuCap_LoaiPC;
        private int _PhuCap_Tien;
        private DateTime _PhuCap_TuNgay;
        private DateTime _PhuCap_DenNgay;
        public string PhuCap_MaNhanVien
        {
            get
            {
                return _PhuCap_MaNhanVien;
            }
            set
            {
                _PhuCap_MaNhanVien = value;
            }
        }
        public DateTime PhuCap_TuNgay
        {
            get
            {
                return _PhuCap_TuNgay;
            }
            set
            {
                _PhuCap_TuNgay = value;
            }
        }
        public DateTime PhuCap_DenNgay
        {
            get
            {
                return _PhuCap_DenNgay;
            }
            set
            {
                _PhuCap_DenNgay = value;
            }
        }
        public string PhuCap_LoaiPC
        {
            get
            {
                return _PhuCap_LoaiPC;
            }
            set
            {
                _PhuCap_LoaiPC = value;
            }
        }
        public int PhuCap_Tien
        {
            get
            {
                return _PhuCap_Tien;
            }
            set
            {
                _PhuCap_Tien = value;
            }
        }
    }
}

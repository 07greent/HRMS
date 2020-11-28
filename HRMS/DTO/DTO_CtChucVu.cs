using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    class DTO_CtChucVu
    {
        private string _ChucVu_MaNhanVien;
        private string _ChucVu_MaCV;
        private DateTime _ChucVu_NgayBatDau;
        private DateTime _ChucVu_NgayKetThuc;
        private string _ChucVu_LyDo;
        public string ChucVu_MaNhanVien
        {
            get
            {
                return _ChucVu_MaNhanVien;
            }
            set
            {
                _ChucVu_MaNhanVien = value;
            }
        }
        public DateTime ChucVu_NgayBatDau
        {
            get
            {
                return _ChucVu_NgayBatDau;
            }
            set
            {
                _ChucVu_NgayBatDau = value;
            }
        }
        public DateTime ChucVu_NgayKetThuc
        {
            get
            {
                return _ChucVu_NgayKetThuc;
            }
            set
            {
                _ChucVu_NgayKetThuc = value;
            }
        }
        public string ChucVu_MaCV
        {
            get
            {
                return _ChucVu_MaCV;
            }
            set
            {
                _ChucVu_MaCV = value;
            }
        }
        public string ChucVu_LyDo
        {
            get
            {
                return _ChucVu_LyDo;
            }
            set
            {
                _ChucVu_LyDo = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    class DTO_TaiKhoan
    {
        private string _TaiKhoan_MaNhanVien;
        private string _TaiKhoan_TenDangNhap;
        private string _TaiKhoan_MatKhau;
        private string _TaiKhoan_TenQuyenHan;

        public DTO_TaiKhoan(string tK, string mK)
        {
        }

        public DTO_TaiKhoan(string tK, string mK, string mK1, string quyenHan) : this(tK, mK)
        {
        }

        public string TaiKhoan_MaNhanVien
        {
            get
            {
                return _TaiKhoan_MaNhanVien;
            }
            set
            {
                _TaiKhoan_MaNhanVien = value;
            }
        }
        public string TaiKhoan_TenDangNhap
        {
            get
            {
                return _TaiKhoan_TenDangNhap;
            }
            set
            {
                _TaiKhoan_TenDangNhap = value;
            }
        }
        public string TaiKhoan_MatKhau
        {
            get
            {
                return _TaiKhoan_MatKhau;
            }
            set
            {
                _TaiKhoan_MatKhau = value;
            }
        }
        public string TaiKhoan_TenQuyenHan
        {
            get
            {
                return _TaiKhoan_TenQuyenHan;
            }
            set
            {
                _TaiKhoan_TenQuyenHan = value;
            }
        }
    }
}

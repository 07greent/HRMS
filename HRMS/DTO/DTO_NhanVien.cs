﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    class DTO_NhanVien
    {
        private string _NhanVien_MaNhanVien;
        private string _NhanVien_MaPB;
        private string _NhanVien_MaHD;
        private int _NhanVien_HeSoLuong;
        private string _NhanVien_TenNV;
        private string _NhanVien_GioiTinh;
        private DateTime _NhanVien_NgaySinh;
        private string _NhanVien_SoCM;
        private string _NhanVien_DienThoai;
        private string _NhanVien_TrinhDoHV;
        private string _NhanVien_DiaChi;
        private string _NhanVien_Email;
        private string _NhanVien_TTHonNhan;

        public DTO_NhanVien(string maNV, string maPB, string maHD, int hesoLuong, string hoTen, string gioiTinh, DateTime ngaySinh, string soCM, string sDT, string trinhdoHV, string diaChi, string email, string ttHonNhan)
        {
            this.NhanVien_MaNhanVien = maNV;
            this.NhanVien_MaPB = maPB;
            this.NhanVien_MaHD = maHD;
            this.NhanVien_HeSoLuong = hesoLuong;
            this.NhanVien_TenNV = hoTen;
            this.NhanVien_GioiTinh = gioiTinh;
            this.NhanVien_NgaySinh = ngaySinh;
            this.NhanVien_SoCM = soCM;
            this.NhanVien_DienThoai = sDT;
            this.NhanVien_TrinhDoHV = trinhdoHV;
            this.NhanVien_DiaChi = diaChi;
            this.NhanVien_Email = email;
            this.NhanVien_TTHonNhan = ttHonNhan;
        }

        public string NhanVien_MaNhanVien
        {
            get
            {
                return _NhanVien_MaNhanVien;
            }
            set
            {
                _NhanVien_MaNhanVien = value;
            }
        }
        public string NhanVien_MaPB
        {
            get
            {
                return _NhanVien_MaPB;
            }
            set
            {
                _NhanVien_MaPB = value;
            }
        }
        public string NhanVien_MaHD
        {
            get
            {
                return _NhanVien_MaHD;
            }
            set
            {
                _NhanVien_MaHD = value;
            }
        }
        public int NhanVien_HeSoLuong
        {
            get
            {
                return _NhanVien_HeSoLuong;
            }
            set
            {
                _NhanVien_HeSoLuong = value;
            }
        }
        public string NhanVien_TenNV
        {
            get
            {
                return _NhanVien_TenNV;
            }
            set
            {
                _NhanVien_TenNV = value;
            }
        }
        public string NhanVien_GioiTinh
        {
            get
            {
                return _NhanVien_GioiTinh;
            }
            set
            {
                _NhanVien_GioiTinh = value;
            }
        }
        public DateTime NhanVien_NgaySinh
        {
            get
            {
                return _NhanVien_NgaySinh;
            }
            set
            {
                _NhanVien_NgaySinh = value;
            }
        }
        public string NhanVien_SoCM
        {
            get
            {
                return _NhanVien_SoCM;
            }
            set
            {
                _NhanVien_SoCM = value;
            }
        }
        public string NhanVien_DienThoai
        {
            get
            {
                return _NhanVien_DienThoai;
            }
            set
            {
                _NhanVien_DienThoai = value;
            }
        }
        public string NhanVien_TrinhDoHV
        {
            get
            {
                return _NhanVien_TrinhDoHV;
            }
            set
            {
                _NhanVien_TrinhDoHV = value;
            }
        }
        public string NhanVien_DiaChi
        {
            get
            {
                return _NhanVien_DiaChi;
            }
            set
            {
                _NhanVien_DiaChi = value;
            }
        }
        public string NhanVien_Email
        {
            get
            {
                return _NhanVien_Email;
            }
            set
            {
                _NhanVien_Email = value;
            }
        }
        public string NhanVien_TTHonNhan
        {
            get
            {
                return _NhanVien_TTHonNhan;
            }
            set
            {
                _NhanVien_TTHonNhan = value;
            }
        }
    }
}

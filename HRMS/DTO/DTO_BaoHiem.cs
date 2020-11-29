using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    class DTO_BaoHiem
    {
        private string _BaoHiem_MaNhanVien;
        private string _BaoHiem_LoaiBaoHiem;
        private string _BaoHiem_SoThe;
        private DateTime _BaoHiem_NgayCap;
        private DateTime _BaoHiem_NgayHetHan;
        private string _BaoHiem_NoiCap;

        public DTO_BaoHiem(string maNV, string loaiBH, string soThe, DateTime ngayCap, DateTime ngayHetHan, string noiCap)
        {
            MaNV = maNV;
            LoaiBH = loaiBH;
            SoThe = soThe;
            NgayCap = ngayCap;
            NgayHetHan = ngayHetHan;
            NoiCap = noiCap;
        }

        public string BaoHiem_MaNhanVien
        {
            get
            {
                return _BaoHiem_MaNhanVien;
            }
            set
            {
                _BaoHiem_MaNhanVien = value;
            }
        }
        public DateTime BaoHiem_NgayCap
        {
            get
            {
                return _BaoHiem_NgayCap;
            }
            set
            {
                _BaoHiem_NgayCap = value;
            }
        }
        public DateTime BaoHiem_NgayHetHan
        {
            get
            {
                return _BaoHiem_NgayHetHan;
            }
            set
            {
                _BaoHiem_NgayHetHan = value;
            }
        }
        public string BaoHiem_LoaiBaoHiem
        {
            get
            {
                return _BaoHiem_LoaiBaoHiem;
            }
            set
            {
                _BaoHiem_LoaiBaoHiem = value;
            }
        }
        public string BaoHiem_SoThe
        {
            get
            {
                return _BaoHiem_SoThe;
            }
            set
            {
                _BaoHiem_SoThe = value;
            }
        }
        public string BaoHiem_NoiCap
        {
            get
            {
                return _BaoHiem_NoiCap;
            }
            set
            {
                _BaoHiem_NoiCap = value;
            }
        }

        public string MaNV { get; }
        public string LoaiBH { get; }
        public string SoThe { get; }
        public DateTime NgayCap { get; }
        public DateTime NgayHetHan { get; }
        public string NoiCap { get; }
    }
}

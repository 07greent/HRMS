using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HRMS.DTO;
using HRMS.DAO;

namespace HRMS.BUS
{
    class BUSNhanVien
    {
        DAONhanVien daoNhanVien = new DAONhanVien();

        public DataTable getNhanVien()
        {
            return daoNhanVien.Get();
        }

        public DataTable getNhanVien(string condition)
        {
            return daoNhanVien.Get(condition);
        }

        public DataTable getNhanVien(List<string> listProperties)
        {
            return daoNhanVien.Get(listProperties);
        }

        public DataTable getNhanVien(List<string> listProperties, string condition)
        {
            return daoNhanVien.Get(listProperties, condition);
        }

//<<<<<<< HEAD
//        public bool insertNhanVien(string maNV, string maPB,string maHD,int hesoLuong, string hoTen, string gioiTinh, DateTime ngaySinh,string soCM,string sDT,string trinhdoHV,string diaChi,string email,string ttHonNhan)
//        {
//            DTO_NhanVien dTO_DocGia = new DTO_NhanVien( maNV,  maPB,  maHD,  hesoLuong,  hoTen,  gioiTinh, ngaySinh,  soCM, sDT,  trinhdoHV,  diaChi,  email,  ttHonNhan);   
//            return daoNhanVien.Add(dTO_DocGia);
//=======
        public bool ThemNV(string maNV, string maPB,string maHD,int hesoLuong, string hoTen, string gioiTinh, DateTime ngaySinh,string soCM,string sDT,string trinhdoHV,string diaChi,string email,string ttHonNhan)
        {
            DTO_NhanVien dtoNhanVien = new DTO_NhanVien( maNV,  maPB,  maHD,  hesoLuong,  hoTen,  gioiTinh, ngaySinh,  soCM, sDT,  trinhdoHV,  diaChi,  email,  ttHonNhan);   
            return daoNhanVien.Add(dtoNhanVien);
        }
        public bool Sua(string maNV, string maPB, string maHD, int hesoLuong, string hoTen, string gioiTinh, DateTime ngaySinh, string soCM, string sDT, string trinhdoHV, string diaChi, string email, string ttHonNhan)
        {
            DTO_NhanVien dtoNhanVien = new DTO_NhanVien(maNV, maPB, maHD, hesoLuong, hoTen, gioiTinh, ngaySinh, soCM, sDT, trinhdoHV, diaChi, email, ttHonNhan);
            return daoNhanVien.SuaNV(dtoNhanVien);
        }
        public bool XoaNV(string MaNV)
        {
            return daoNhanVien.Delete(MaNV);
        }
        public DataTable TraCuu(string maNV,string maPB)
        {
            return daoNhanVien.TraCuuNV(maNV, maPB);

        }
    }
}

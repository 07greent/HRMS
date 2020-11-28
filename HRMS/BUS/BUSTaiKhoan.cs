using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.DTO;
using HRMS.DAO;
using System.Data;

namespace HRMS.BUS
{
    class BUSTaiKhoan
    {
        DAOTaiKhoan daoTaiKhoan = new DAOTaiKhoan();
        public DataTable Get()
        {
            return daoTaiKhoan.getTaiKhoan();
        }
        public bool ThemTK(string maNV, string TK,string MK,string QuyenHan)
        {
            DTO_TaiKhoan dtoTaiKhoan = new DTO_TaiKhoan(maNV,TK,MK,QuyenHan);
            return daoTaiKhoan.themTaiKhoan(dtoTaiKhoan);
        }
        public bool SuaTK(string maNV, string TK, string MK, string QuyenHan)
        {
            DTO_TaiKhoan dtoTaiKhoan = new DTO_TaiKhoan(maNV, TK, MK, QuyenHan);
            return daoTaiKhoan.themTaiKhoan(dtoTaiKhoan); 
        }
        public bool XoaTK(string maNV)
        {
            return daoTaiKhoan.xoaTaiKhoan(maNV);
        }
    }
}

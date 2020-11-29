using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HRMS.DTO;
using HRMS.DAO;
using System.Data;

namespace HRMS.BUS
{
    class BUSChucVu
    {
//<<<<<<< HEAD
        //DAOChucVu daoChucVu = new DAOChucVu();

        //public DataTable getChucVu()
        //{
        //    return daoChucVu.Get();
        //}

        //public DataTable getChucVu(string condition)
        //{
        //    return daoChucVu.Get(condition);
        //}

        //public DataTable getChucVu(List<string> listProperties)
        //{
        //    return daoChucVu.Get(listProperties);
        //}

        //public DataTable getChucVu(List<string> listProperties, string condition)
        //{
        //    return daoChucVu.Get(listProperties, condition);
        //}

        //public bool ThemCV(string maCV, string tenCV)
        //{
        //    DTO_ChucVu dtoChucVu = new DTO_ChucVu(maCV, tenCV);
        //    return daoChucVu.themChucVu(dtoChucVu);
        //}
        //public bool SuaCV(string maCV, string tenCV)
        //{
        //    DTO_ChucVu dtoChucVu = new DTO_ChucVu(maCV, tenCV);
        //    return daoChucVu.themChucVu(dtoChucVu);
        //}

        //public DataTable CTCV(string MaCV)
        //{
        //    return daoChucVu.CtChucVu(MaCV);
        //}
//=======
        DAOChucVu daoChucVu = new DAOChucVu();

        public DataTable getChucVu()
        {
            return daoChucVu.Get();
        }

        public DataTable getChucVu(string condition)
        {
            return daoChucVu.Get(condition);
        }

        public DataTable getChucVu(List<string> listProperties)
        {
            return daoChucVu.Get(listProperties);
        }

        public DataTable getChucVu(List<string> listProperties, string condition)
        {
            return daoChucVu.Get(listProperties, condition);
        }

        public bool ThemCV(string maCV, string tenCV)
        {
            DTO_ChucVu dtoChucVu = new DTO_ChucVu(maCV, tenCV);
            return daoChucVu.themChucVu(dtoChucVu);
        }
        public bool SuaCV(string maCV, string tenCV)
        {
            DTO_ChucVu dtoChucVu = new DTO_ChucVu(maCV, tenCV);
            return daoChucVu.themChucVu(dtoChucVu);
        }
        public bool XoaCV(string maCV)
        {
            return daoChucVu.xoaChucVu(maCV);
        }
        public DataTable CTCV(string MaCV)
        {
            return daoChucVu.CtChucVu(MaCV);
        }
//>>>>>>> 387e7c3c752ee2f441329f5a971169d9ab7f2e9f
    }
}


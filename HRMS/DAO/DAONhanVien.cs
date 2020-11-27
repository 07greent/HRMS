using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HRMS.DTO;
using System.Windows.Forms;

namespace HRMS.DAO
{
    class DAONhanVien : DBConnect
    {
        public DataTable Get()
        {
            try
            {
              //  MessageBox.Show("vao ham get");
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open(); 
                  //  MessageBox.Show("Vao duoc");                 
                }
                //else
                //    MessageBox.Show("kh duoc");
                SqlDataAdapter da = new SqlDataAdapter("select * from nhanvien", _conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get(string condition)
        {
            try
            {
                string sql = string.Format("Select * from nhanvien where {0}", condition);

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conn);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Get(List<string> listProperties)
        {
            try
            {
                //string SQL = string.Format("select {0} from nhanvien", listProperties);
                string sql = "select distinct " + listProperties[0];
                for (int i = 1; i < listProperties.Count; i++)
                {
                    sql += (", " + listProperties[i]);
                }
                sql += " from nhanvien";

                SqlDataAdapter da = new SqlDataAdapter(sql, _conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                return null;
            }
        }
       public DataTable Get(List<string> listProperties, string condition)
       {
            try
            {
                string sql = "select " + listProperties[0];
                for (int i = 1; i < listProperties.Count; i++)
                {
                    sql += (", " + listProperties[i]);
                }
                sql += " from nhanvien";

                sql += (" where " + condition);

                SqlDataAdapter da = new SqlDataAdapter(sql, _conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable TraCuuNV(string maNV, string maPB)
        {
            try
            {
                _conn.Open();
                SqlCommand comm = new SqlCommand("TraCuuNV", _conn);
                comm.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter("@MaNhanVien", maNV);
                comm.Parameters.Add(para);

                para = new SqlParameter("@MaPB", maPB);
                comm.Parameters.Add(para);

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = comm;
                DataTable datb = new DataTable();
                dataAdapter.Fill(datb);
                _conn.Close();
                return datb;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Add(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("Add", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaNhanVien", nv.NhanVien_MaNhanVien);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@MaPB", nv.NhanVien_MaPB);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@MaHD",nv.NhanVien_MaHD );
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@HeSoLuong",nv.NhanVien_HeSoLuong);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenNV",nv.NhanVien_TenNV);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@GioiTinh",nv.NhanVien_GioiTinh);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@NgaySinh", Convert.ToDateTime(nv.NhanVien_NgaySinh));
                cmd.Parameters.Add(parameter);
        
                parameter = new SqlParameter("@SoCM", nv.NhanVien_SoCM);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@DienThoai", nv.NhanVien_DienThoai);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TrinhDoHV", nv.NhanVien_TrinhDoHV);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@DiaChi", nv.NhanVien_Email);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@Email", nv.NhanVien_Email);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TTHonNhan", nv.NhanVien_TTHonNhan);
                cmd.Parameters.Add(parameter);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        public bool SuaNV(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("SuaNV", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaNV", nv.NhanVien_MaNhanVien);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@MaPB", nv.NhanVien_MaPB);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@MaHD", nv.NhanVien_MaHD);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@HeSoLuong", nv.NhanVien_HeSoLuong);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenNV", nv.NhanVien_TenNV);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@GioiTinh", nv.NhanVien_GioiTinh);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@NgaySinh", Convert.ToDateTime(nv.NhanVien_NgaySinh));
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@SoCM", nv.NhanVien_SoCM);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@DienThoai", nv.NhanVien_DienThoai);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TrinhDoHV", nv.NhanVien_TrinhDoHV);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@DiaChi", nv.NhanVien_Email);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@Email", nv.NhanVien_Email);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TTHonNhan", nv.NhanVien_TTHonNhan);
                cmd.Parameters.Add(parameter);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        public bool Delete(string MaNV)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Delete", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhanVien", MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}


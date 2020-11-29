using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.BUS;
using System.Data.SqlClient;
using HRMS.DAO;
using HRMS.DTO;
namespace HRMS.GUI
{
    public partial class NhanVien : Form
    {
        BUSNhanVien busNV = new BUSNhanVien();
        public NhanVien()
        {
            InitializeComponent();
        }

        public void NhanVien_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bunifuCustomDataGrid1.DataSource = busNV.getNhanVien();
        }
        
        public void iconButton1_Click(object sender, EventArgs e)
        {
            if(txtHoten.Text != "")
            {
                CheckboxNu.Enabled = false;
                string tthn = "";
                string gt = "";
                if (SwitchTTHonNhan.Value == true)
                    tthn = "Da ket hon";
                else
                    tthn = "Doc than";
                if (CheckboxNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nu";
                int HSLuong = int.Parse(CbBHSLuong.Text);
                DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, CbCMaPB.Text, "0", HSLuong, txtHoten.Text, gt, DatetimeNSinh.Value, txtCMND.Text, txtDienThoai.Text, CbBTDHVan.Text, txtDiachi.Text, txtEmail.Text, tthn);
                
                if (busNV.ThemNV(nv))
                {
                    MessageBox.Show("thêm thành công");
                    bunifuCustomDataGrid1.DataSource = busNV.getNhanVien();
                }

            }
            //string maNV, string maPB,string maHD,int hesoLuong, string hoTen, string gioiTinh, DateTime ngaySinh,string soCM,string sDT,string trinhdoHV,string diaChi,string email,string ttHonNhan
        }

        
    }
}

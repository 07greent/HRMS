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
using HRMS.GUI;
namespace HRMS
{
    public partial class Form2 : Form
    {
        BUSNhanVien busNV = new BUSNhanVien();
        public Form2()
        {
            InitializeComponent();
            TrangChu tc = new TrangChu();
            OpenFormInpanel(tc);
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void OpenFormInpanel(Form Formmini)
        {
            this.panel2.Controls.Clear();
            Form fm = Formmini as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fm);
            this.panel2.Tag = fm;
            fm.Show();
        }
     
        private void iconButton1_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            OpenFormInpanel(tc);
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();
            OpenFormInpanel(pb);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            CC cd = new CC();
            OpenFormInpanel(cd);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            OpenFormInpanel(nv);
            //nv.NhanVien_Load(sender, e);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            OpenFormInpanel(luong);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            PhuCap phucap = new PhuCap();
            OpenFormInpanel(phucap);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            BaoHiem baohiem = new BaoHiem();
            OpenFormInpanel(baohiem);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            OpenFormInpanel(au);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            OpenFormInpanel(tk);
        }
    }
}

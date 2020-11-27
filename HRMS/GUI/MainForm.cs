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
            while (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form fm = Formmini as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fm);
            this.panel2.Tag = fm;
            fm.Show();
        }
     
        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();
            OpenFormInpanel(pb);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            CaiDat cd = new CaiDat();
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
    }
}

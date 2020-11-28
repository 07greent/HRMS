using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.GUI.TK;

namespace HRMS.GUI
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        public void OpenFormInpanel(Form Formmini)
        {
            while (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form fm = Formmini as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DoiThongTin dtt = new DoiThongTin();
            OpenFormInpanel(dtt);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DoiMatKhau taikhoan = new DoiMatKhau();
            OpenFormInpanel(taikhoan);
        }
    }
}

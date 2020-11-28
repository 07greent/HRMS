using HRMS.GUI.ChamCong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.GUI
{
    public partial class CC : Form
    {
        public CC()
        {
            InitializeComponent();
        }
        public void OpenFormInpanel(Form Formmini)
        {
            while (this.pnLoad.Controls.Count > 0)
            {
                this.pnLoad.Controls.RemoveAt(0);
            }
            Form fm = Formmini as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.pnLoad.Controls.Add(fm);
            this.pnLoad.Tag = fm;
            fm.Show();
        }
        private void rdNTT_CheckedChanged(object sender, EventArgs e)
        {
            tkNVNghiTrongNgay tknvntn = new tkNVNghiTrongNgay();
            pnLoad.Controls.Clear();
            OpenFormInpanel(tknvntn);
            
        }

        private void rdNCP_CheckedChanged(object sender, EventArgs e)
        {
            tkNVNghiCoPhep tknvncp = new tkNVNghiCoPhep();
            pnLoad.Controls.Clear();
            OpenFormInpanel(tknvncp);
        }

        private void rdKN_CheckedChanged(object sender, EventArgs e)
        {
            tkSoNgayDiLam tksndl = new tkSoNgayDiLam();
            pnLoad.Controls.Clear();
            OpenFormInpanel(tksndl);
        }

        private void rdNNN_CheckedChanged(object sender, EventArgs e)
        {
            tkSoNgayNghiCoPhep tksnncp = new tkSoNgayNghiCoPhep();
            pnLoad.Controls.Clear();
            OpenFormInpanel(tksnncp);
        }

        private void rdNCPNN_CheckedChanged(object sender, EventArgs e)
        {
            tkSoNgayNghiKhongPhep tksnnkp = new tkSoNgayNghiKhongPhep();
            pnLoad.Controls.Clear();
            OpenFormInpanel(tksnnkp);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            tkXemccTheoTen tkxtt = new tkXemccTheoTen();
            pnLoad.Controls.Clear();
            OpenFormInpanel(tkxtt);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            tkXemccTheoPhong tkxtp = new tkXemccTheoPhong();
            pnLoad.Controls.Clear();
            OpenFormInpanel(tkxtp);
        }
    }
}

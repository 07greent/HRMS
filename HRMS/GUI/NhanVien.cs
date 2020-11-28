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

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

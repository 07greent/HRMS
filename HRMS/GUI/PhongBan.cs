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
    public partial class PhongBan : Form
    {

      //  BUSPhongBan busPB = new BUSPhongBan();
        public PhongBan()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            //bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //bunifuCustomDataGrid1.DataSource = busPB.getPhongBan();
        }
    }
}

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

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = busNV.getNhanVien();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}

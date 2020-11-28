namespace HRMS.GUI
{
    partial class Luong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btXem = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lbTB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLCB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHeSoLuong = new System.Windows.Forms.ComboBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLuong = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(1046, 583);
            this.btXem.Margin = new System.Windows.Forms.Padding(4);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(120, 28);
            this.btXem.TabIndex = 16;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(848, 580);
            this.txtThang.Margin = new System.Windows.Forms.Padding(4);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(45, 22);
            this.txtThang.TabIndex = 11;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(929, 581);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(91, 22);
            this.txtNam.TabIndex = 12;
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.ForeColor = System.Drawing.Color.Red;
            this.lbTB.Location = new System.Drawing.Point(583, 583);
            this.lbTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(12, 17);
            this.lbTB.TabIndex = 13;
            this.lbTB.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(688, 584);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bảng lương theo tháng";
            // 
            // TL
            // 
            this.TL.DataPropertyName = "TL";
            this.TL.HeaderText = "Tổng Lương";
            this.TL.MinimumWidth = 6;
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            this.TL.Width = 125;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "Tien";
            this.PhuCap.HeaderText = "Phụ Cấp";
            this.PhuCap.MinimumWidth = 6;
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.ReadOnly = true;
            this.PhuCap.Width = 125;
            // 
            // P
            // 
            this.P.DataPropertyName = "P";
            this.P.HeaderText = "Tiền Phạt";
            this.P.MinimumWidth = 6;
            this.P.Name = "P";
            this.P.ReadOnly = true;
            this.P.Width = 125;
            // 
            // T
            // 
            this.T.DataPropertyName = "T";
            this.T.HeaderText = "Tiền Thưởng";
            this.T.MinimumWidth = 6;
            this.T.Name = "T";
            this.T.ReadOnly = true;
            this.T.Width = 125;
            // 
            // SNL
            // 
            this.SNL.DataPropertyName = "NL";
            this.SNL.HeaderText = "Số Ngày Làm";
            this.SNL.MinimumWidth = 6;
            this.SNL.Name = "SNL";
            this.SNL.ReadOnly = true;
            this.SNL.Width = 125;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ Số Lương";
            this.HeSoLuong.MinimumWidth = 6;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.ReadOnly = true;
            this.HeSoLuong.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(901, 579);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "/";
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaNhanVien";
            this.Ma.HeaderText = "Mã Nhân Viên";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            this.Ma.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chức Vụ:";
            // 
            // txtLCB
            // 
            this.txtLCB.Location = new System.Drawing.Point(808, 94);
            this.txtLCB.Margin = new System.Windows.Forms.Padding(4);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Size = new System.Drawing.Size(123, 22);
            this.txtLCB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(940, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lương Cơ Bản";
            // 
            // cbHeSoLuong
            // 
            this.cbHeSoLuong.FormattingEnabled = true;
            this.cbHeSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbHeSoLuong.Location = new System.Drawing.Point(445, 94);
            this.cbHeSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.cbHeSoLuong.Name = "cbHeSoLuong";
            this.cbHeSoLuong.Size = new System.Drawing.Size(203, 24);
            this.cbHeSoLuong.TabIndex = 5;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(1011, 87);
            this.btCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(241, 34);
            this.btCapNhat.TabIndex = 4;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ số lương";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLuong);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLCB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbHeSoLuong);
            this.panel1.Controls.Add(this.btCapNhat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-31, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 530);
            this.panel1.TabIndex = 10;
            // 
            // txtLuong
            // 
            this.txtLuong.FormattingEnabled = true;
            this.txtLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtLuong.Location = new System.Drawing.Point(202, 137);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(170, 24);
            this.txtLuong.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Lương Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.TenNV,
            this.HeSoLuong,
            this.SNL,
            this.T,
            this.P,
            this.PhuCap,
            this.TL});
            this.dataGridView1.Location = new System.Drawing.Point(31, 173);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1209, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 645);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Luong";
            this.Text = "Luong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHeSoLuong;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtLuong;
    }
}
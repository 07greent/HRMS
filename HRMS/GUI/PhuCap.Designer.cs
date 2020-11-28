namespace HRMS.GUI
{
    partial class PhuCap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DenNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdTat = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 37);
            this.panel1.TabIndex = 15;
            // 
            // DenNgay
            // 
            this.DenNgay.DataPropertyName = "DenNgay";
            this.DenNgay.HeaderText = "Đến Ngày";
            this.DenNgay.MinimumWidth = 6;
            this.DenNgay.Name = "DenNgay";
            this.DenNgay.ReadOnly = true;
            this.DenNgay.Width = 150;
            // 
            // TuNgay
            // 
            this.TuNgay.DataPropertyName = "TuNgay";
            this.TuNgay.HeaderText = "Từ Ngày";
            this.TuNgay.MinimumWidth = 6;
            this.TuNgay.Name = "TuNgay";
            this.TuNgay.ReadOnly = true;
            this.TuNgay.Width = 150;
            // 
            // Tien
            // 
            this.Tien.DataPropertyName = "Tien";
            this.Tien.HeaderText = "Tiền";
            this.Tien.MinimumWidth = 6;
            this.Tien.Name = "Tien";
            this.Tien.ReadOnly = true;
            this.Tien.Width = 125;
            // 
            // rdTat
            // 
            this.rdTat.AutoSize = true;
            this.rdTat.Location = new System.Drawing.Point(333, 101);
            this.rdTat.Margin = new System.Windows.Forms.Padding(4);
            this.rdTat.Name = "rdTat";
            this.rdTat.Size = new System.Drawing.Size(135, 21);
            this.rdTat.TabIndex = 14;
            this.rdTat.Text = "Tất cả nhân viên";
            this.rdTat.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Checked = true;
            this.rdTen.Location = new System.Drawing.Point(90, 101);
            this.rdTen.Margin = new System.Windows.Forms.Padding(4);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(152, 21);
            this.rdTen.TabIndex = 13;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Theo tên nhân viên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(628, 145);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(224, 22);
            this.txtTen.TabIndex = 21;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(940, 146);
            this.txtTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(161, 22);
            this.txtTien.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Từ Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Đến Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên Phụ Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1109, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "vnd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "Phụ Cấp";
            // 
            // dtpTu
            // 
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Location = new System.Drawing.Point(628, 182);
            this.dtpTu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(224, 22);
            this.dtpTu.TabIndex = 24;
            // 
            // dtpDen
            // 
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.Location = new System.Drawing.Point(954, 182);
            this.dtpDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(203, 22);
            this.dtpDen.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNV,
            this.TenPC,
            this.Tien,
            this.TuNgay,
            this.DenNgay});
            this.dataGridView1.Location = new System.Drawing.Point(8, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1188, 314);
            this.dataGridView1.TabIndex = 30;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 150;
            // 
            // TenPC
            // 
            this.TenPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPC.DataPropertyName = "LoaiPC";
            this.TenPC.HeaderText = "Tên Phụ Cấp";
            this.TenPC.MinimumWidth = 6;
            this.TenPC.Name = "TenPC";
            this.TenPC.ReadOnly = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(368, 190);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(244, 190);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 28);
            this.btSua.TabIndex = 28;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(124, 190);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 28);
            this.btLuu.TabIndex = 27;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(8, 190);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 28);
            this.btThem.TabIndex = 26;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // PhuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdTat);
            this.Controls.Add(this.rdTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhuCap";
            this.Text = "PhuCap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.RadioButton rdTat;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPC;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThem;
    }
}
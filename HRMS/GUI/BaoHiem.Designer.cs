namespace HRMS.GUI
{
    partial class BaoHiem
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(870, 152);
            this.txtSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(267, 22);
            this.txtSo.TabIndex = 25;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(164, 152);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(201, 22);
            this.txtTen.TabIndex = 24;
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(618, 201);
            this.txtNoiCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(519, 22);
            this.txtNoiCap.TabIndex = 23;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Bảo Hiểm Thân Thể",
            "Bảo Hiểm Y Tế"});
            this.cbLoai.Location = new System.Drawing.Point(484, 152);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(211, 24);
            this.cbLoai.TabIndex = 22;
            // 
            // dtpNgayHH
            // 
            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHH.Location = new System.Drawing.Point(384, 201);
            this.dtpNgayHH.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayHH.Name = "dtpNgayHH";
            this.dtpNgayHH.Size = new System.Drawing.Size(129, 22);
            this.dtpNgayHH.TabIndex = 21;
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCap.Location = new System.Drawing.Point(131, 201);
            this.dtpNgayCap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(135, 22);
            this.dtpNgayCap.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nơi Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày Hết Hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngày Cấp";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.ForeColor = System.Drawing.Color.Red;
            this.lbTB.Location = new System.Drawing.Point(515, 254);
            this.lbTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(0, 20);
            this.lbTB.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Loại Bảo Hiểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(678, 250);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 28);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.MinimumWidth = 6;
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            this.NgayHetHan.Width = 150;
            // 
            // LoaiBaoHiem
            // 
            this.LoaiBaoHiem.DataPropertyName = "LoaiBaoHiem";
            this.LoaiBaoHiem.HeaderText = "Loại Bảo Hiểm";
            this.LoaiBaoHiem.MinimumWidth = 6;
            this.LoaiBaoHiem.Name = "LoaiBaoHiem";
            this.LoaiBaoHiem.ReadOnly = true;
            this.LoaiBaoHiem.Width = 250;
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
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã Số Thẻ Bảo Hiểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bảo Hiểm Nhân Viên";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(1038, 250);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(924, 250);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 28);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(802, 250);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 28);
            this.btLuu.TabIndex = 11;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNV,
            this.LoaiBaoHiem,
            this.NgayHetHan});
            this.dataGridView1.Location = new System.Drawing.Point(29, 325);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 282);
            this.dataGridView1.TabIndex = 7;
            // 
            // BaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 643);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtNoiCap);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.dtpNgayHH);
            this.Controls.Add(this.dtpNgayCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaoHiem";
            this.Text = "BaoHiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBaoHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
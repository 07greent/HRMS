﻿namespace HRMS.GUI
{
    partial class CC
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
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rdNCPNN = new System.Windows.Forms.RadioButton();
            this.rdNNN = new System.Windows.Forms.RadioButton();
            this.rdKN = new System.Windows.Forms.RadioButton();
            this.rdNCP = new System.Windows.Forms.RadioButton();
            this.rdNTT = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLoad = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.rdNCPNN);
            this.panel1.Controls.Add(this.rdNNN);
            this.panel1.Controls.Add(this.rdKN);
            this.panel1.Controls.Add(this.rdNCP);
            this.panel1.Controls.Add(this.rdNTT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 572);
            this.panel1.TabIndex = 2;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(47, 518);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(162, 21);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Xem theo Phòng ban";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(47, 443);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(181, 21);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Xem theo tên Nhân viên";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rdNCPNN
            // 
            this.rdNCPNN.AutoSize = true;
            this.rdNCPNN.Location = new System.Drawing.Point(47, 368);
            this.rdNCPNN.Margin = new System.Windows.Forms.Padding(4);
            this.rdNCPNN.Name = "rdNCPNN";
            this.rdNCPNN.Size = new System.Drawing.Size(316, 21);
            this.rdNCPNN.TabIndex = 1;
            this.rdNCPNN.TabStop = true;
            this.rdNCPNN.Text = "Xem số ngày nghỉ không phép của Nhân viên";
            this.rdNCPNN.UseVisualStyleBackColor = true;
            this.rdNCPNN.CheckedChanged += new System.EventHandler(this.rdNCPNN_CheckedChanged);
            // 
            // rdNNN
            // 
            this.rdNNN.AutoSize = true;
            this.rdNNN.Location = new System.Drawing.Point(47, 293);
            this.rdNNN.Margin = new System.Windows.Forms.Padding(4);
            this.rdNNN.Name = "rdNNN";
            this.rdNNN.Size = new System.Drawing.Size(292, 21);
            this.rdNNN.TabIndex = 1;
            this.rdNNN.TabStop = true;
            this.rdNNN.Text = "Xem số ngày nghỉ có phép của Nhân viên";
            this.rdNNN.UseVisualStyleBackColor = true;
            this.rdNNN.CheckedChanged += new System.EventHandler(this.rdNNN_CheckedChanged);
            // 
            // rdKN
            // 
            this.rdKN.AutoSize = true;
            this.rdKN.Location = new System.Drawing.Point(47, 218);
            this.rdKN.Margin = new System.Windows.Forms.Padding(4);
            this.rdKN.Name = "rdKN";
            this.rdKN.Size = new System.Drawing.Size(324, 21);
            this.rdKN.TabIndex = 1;
            this.rdKN.TabStop = true;
            this.rdKN.Text = "Xem số ngày đi làm của Nhân viên trong tháng";
            this.rdKN.UseVisualStyleBackColor = true;
            this.rdKN.CheckedChanged += new System.EventHandler(this.rdKN_CheckedChanged);
            // 
            // rdNCP
            // 
            this.rdNCP.AutoSize = true;
            this.rdNCP.Location = new System.Drawing.Point(47, 143);
            this.rdNCP.Margin = new System.Windows.Forms.Padding(4);
            this.rdNCP.Name = "rdNCP";
            this.rdNCP.Size = new System.Drawing.Size(283, 21);
            this.rdNCP.TabIndex = 1;
            this.rdNCP.TabStop = true;
            this.rdNCP.Text = "Xem Nhân viên nghỉ có phép trong ngày";
            this.rdNCP.UseVisualStyleBackColor = true;
            this.rdNCP.CheckedChanged += new System.EventHandler(this.rdNCP_CheckedChanged);
            // 
            // rdNTT
            // 
            this.rdNTT.AutoSize = true;
            this.rdNTT.Location = new System.Drawing.Point(47, 68);
            this.rdNTT.Margin = new System.Windows.Forms.Padding(4);
            this.rdNTT.Name = "rdNTT";
            this.rdNTT.Size = new System.Drawing.Size(254, 21);
            this.rdNTT.TabIndex = 1;
            this.rdNTT.TabStop = true;
            this.rdNTT.Text = "Xem Nhân viên nghỉ làm trong ngày";
            this.rdNTT.UseVisualStyleBackColor = true;
            this.rdNTT.CheckedChanged += new System.EventHandler(this.rdNTT_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách";
            // 
            // pnLoad
            // 
            this.pnLoad.BackColor = System.Drawing.Color.Lavender;
            this.pnLoad.Location = new System.Drawing.Point(552, 26);
            this.pnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.pnLoad.Name = "pnLoad";
            this.pnLoad.Size = new System.Drawing.Size(593, 794);
            this.pnLoad.TabIndex = 3;
            // 
            // CC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1177, 845);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLoad);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CC";
            this.Text = "CC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rdNCPNN;
        private System.Windows.Forms.RadioButton rdNNN;
        private System.Windows.Forms.RadioButton rdKN;
        private System.Windows.Forms.RadioButton rdNCP;
        private System.Windows.Forms.RadioButton rdNTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLoad;
    }
}
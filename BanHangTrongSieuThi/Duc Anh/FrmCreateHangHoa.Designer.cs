﻿namespace BanHangTrongSieuThi.Duc_Anh
{
    partial class FrmCreateHangHoa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.Windows.Forms.Label maHangLabel;
            System.Windows.Forms.Label maLoaiHangLabel;
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label tenHangLabel;
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.hangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaLH = new System.Windows.Forms.Button();
            this.btnMaNCC = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTenMaNCC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTenMaLH = new System.Windows.Forms.Label();
            this.lblMaLH = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.errMaHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaLH = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaNCC = new System.Windows.Forms.ErrorProvider(this.components);
            dVTLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            maHangLabel = new System.Windows.Forms.Label();
            maLoaiHangLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            tenHangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaLH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(18, 236);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(60, 13);
            dVTLabel.TabIndex = 0;
            dVTLabel.Text = "Đơn vị tính";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(18, 144);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(48, 13);
            ghiChuLabel.TabIndex = 2;
            ghiChuLabel.Text = "Ghi Chu:";
            // 
            // maHangLabel
            // 
            maHangLabel.AutoSize = true;
            maHangLabel.Location = new System.Drawing.Point(21, 38);
            maHangLabel.Name = "maHangLabel";
            maHangLabel.Size = new System.Drawing.Size(49, 13);
            maHangLabel.TabIndex = 4;
            maHangLabel.Text = "Mã hàng";
            // 
            // maLoaiHangLabel
            // 
            maLoaiHangLabel.AutoSize = true;
            maLoaiHangLabel.Location = new System.Drawing.Point(33, 27);
            maLoaiHangLabel.Name = "maLoaiHangLabel";
            maLoaiHangLabel.Size = new System.Drawing.Size(68, 13);
            maLoaiHangLabel.TabIndex = 6;
            maLoaiHangLabel.Text = "Mã loại hàng";
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(32, 32);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(91, 13);
            maNCCLabel.TabIndex = 8;
            maNCCLabel.Text = "Mã nhà cung cấp";
            // 
            // tenHangLabel
            // 
            tenHangLabel.AutoSize = true;
            tenHangLabel.Location = new System.Drawing.Point(18, 88);
            tenHangLabel.Name = "tenHangLabel";
            tenHangLabel.Size = new System.Drawing.Size(53, 13);
            tenHangLabel.TabIndex = 10;
            tenHangLabel.Text = "Tên hàng";
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(101, 233);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(140, 20);
            this.txtDVT.TabIndex = 1;
            // 
            // hangBindingSource
            // 
            this.hangBindingSource.DataSource = typeof(DAO.Hang);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "GhiChu", true));
            this.txtGhiChu.Location = new System.Drawing.Point(101, 141);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(140, 63);
            this.txtGhiChu.TabIndex = 3;
            // 
            // txtMaHang
            // 
            this.txtMaHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "MaHang", true));
            this.txtMaHang.Location = new System.Drawing.Point(101, 38);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(140, 20);
            this.txtMaHang.TabIndex = 5;
            // 
            // txtMaLH
            // 
            this.txtMaLH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "MaLoaiHang", true));
            this.txtMaLH.Enabled = false;
            this.txtMaLH.Location = new System.Drawing.Point(158, 21);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(100, 20);
            this.txtMaLH.TabIndex = 7;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "MaNCC", true));
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Location = new System.Drawing.Point(157, 29);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(100, 20);
            this.txtMaNCC.TabIndex = 9;
            // 
            // txtTenHang
            // 
            this.txtTenHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "TenHang", true));
            this.txtTenHang.Location = new System.Drawing.Point(101, 85);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(140, 20);
            this.txtTenHang.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tạo mới hàng hóa";
            // 
            // btnMaLH
            // 
            this.btnMaLH.Location = new System.Drawing.Point(264, 19);
            this.btnMaLH.Name = "btnMaLH";
            this.btnMaLH.Size = new System.Drawing.Size(29, 23);
            this.btnMaLH.TabIndex = 13;
            this.btnMaLH.Text = "...";
            this.btnMaLH.UseVisualStyleBackColor = true;
            this.btnMaLH.Click += new System.EventHandler(this.btnMaLH_Click);
            // 
            // btnMaNCC
            // 
            this.btnMaNCC.Location = new System.Drawing.Point(264, 27);
            this.btnMaNCC.Name = "btnMaNCC";
            this.btnMaNCC.Size = new System.Drawing.Size(29, 23);
            this.btnMaNCC.TabIndex = 14;
            this.btnMaNCC.Text = "...";
            this.btnMaNCC.UseVisualStyleBackColor = true;
            this.btnMaNCC.Click += new System.EventHandler(this.btnMaNCC_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(172, 348);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Hủy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblMaNCC);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(dVTLabel);
            this.groupBox1.Controls.Add(tenHangLabel);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(maHangLabel);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(ghiChuLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 290);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng hóa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTenMaNCC);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnMaNCC);
            this.groupBox3.Controls.Add(maNCCLabel);
            this.groupBox3.Controls.Add(this.txtMaNCC);
            this.groupBox3.Location = new System.Drawing.Point(262, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 88);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhà cung cấp";
            // 
            // lblTenMaNCC
            // 
            this.lblTenMaNCC.AutoSize = true;
            this.lblTenMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMaNCC.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTenMaNCC.Location = new System.Drawing.Point(155, 61);
            this.lblTenMaNCC.Name = "lblTenMaNCC";
            this.lblTenMaNCC.Size = new System.Drawing.Size(95, 13);
            this.lblTenMaNCC.TabIndex = 16;
            this.lblTenMaNCC.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTenMaLH);
            this.groupBox2.Controls.Add(this.btnMaLH);
            this.groupBox2.Controls.Add(this.txtMaLH);
            this.groupBox2.Controls.Add(this.lblMaLH);
            this.groupBox2.Controls.Add(maLoaiHangLabel);
            this.groupBox2.Location = new System.Drawing.Point(262, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 85);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhà cung cấp";
            // 
            // lblTenMaLH
            // 
            this.lblTenMaLH.AutoSize = true;
            this.lblTenMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMaLH.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTenMaLH.Location = new System.Drawing.Point(154, 54);
            this.lblTenMaLH.Name = "lblTenMaLH";
            this.lblTenMaLH.Size = new System.Drawing.Size(72, 13);
            this.lblTenMaLH.TabIndex = 16;
            this.lblTenMaLH.Text = "Tên loại hàng";
            // 
            // lblMaLH
            // 
            this.lblMaLH.AutoSize = true;
            this.lblMaLH.Location = new System.Drawing.Point(299, 24);
            this.lblMaLH.Name = "lblMaLH";
            this.lblMaLH.Size = new System.Drawing.Size(0, 13);
            this.lblMaLH.TabIndex = 15;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(561, 180);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(0, 13);
            this.lblMaNCC.TabIndex = 16;
            // 
            // errMaHang
            // 
            this.errMaHang.ContainerControl = this;
            // 
            // errTenHang
            // 
            this.errTenHang.ContainerControl = this;
            // 
            // errMaLH
            // 
            this.errMaLH.ContainerControl = this;
            // 
            // errMaNCC
            // 
            this.errMaNCC.ContainerControl = this;
            // 
            // FrmCreateHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreateHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaLH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource hangBindingSource;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaLH;
        private System.Windows.Forms.Button btnMaNCC;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errMaHang;
        private System.Windows.Forms.ErrorProvider errTenHang;
        private System.Windows.Forms.Label lblMaLH;
        private System.Windows.Forms.ErrorProvider errMaLH;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.ErrorProvider errMaNCC;
        public System.Windows.Forms.TextBox txtMaLH;
        public System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblTenMaNCC;
        public System.Windows.Forms.Label lblTenMaLH;
    }
}
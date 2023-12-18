namespace KiemTra_19_9
{
    partial class Form1
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
            this.btnThem = new System.Windows.Forms.Button();
            this.listBxDsCanHo = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labSoPhongNgu = new System.Windows.Forms.Label();
            this.txtSoPhongNgu = new System.Windows.Forms.TextBox();
            this.labSoNhaVeSinh = new System.Windows.Forms.Label();
            this.txtSoNhaVeSinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHuongBanCong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdConTrong = new System.Windows.Forms.RadioButton();
            this.rdbDaDatCoc = new System.Windows.Forms.RadioButton();
            this.rdbDaBan = new System.Windows.Forms.RadioButton();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbTimHuongBanCong = new System.Windows.Forms.ComboBox();
            this.txtTimGiaTien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHienDanhSach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(144, 438);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 35);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listBxDsCanHo
            // 
            this.listBxDsCanHo.FormattingEnabled = true;
            this.listBxDsCanHo.ItemHeight = 16;
            this.listBxDsCanHo.Location = new System.Drawing.Point(284, 12);
            this.listBxDsCanHo.Name = "listBxDsCanHo";
            this.listBxDsCanHo.Size = new System.Drawing.Size(629, 276);
            this.listBxDsCanHo.TabIndex = 2;
            this.listBxDsCanHo.SelectedIndexChanged += new System.EventHandler(this.listBxDsCanHo_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(329, 438);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(494, 438);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(87, 48);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(97, 22);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // labSoPhongNgu
            // 
            this.labSoPhongNgu.AutoSize = true;
            this.labSoPhongNgu.Location = new System.Drawing.Point(7, 92);
            this.labSoPhongNgu.Name = "labSoPhongNgu";
            this.labSoPhongNgu.Size = new System.Drawing.Size(90, 16);
            this.labSoPhongNgu.TabIndex = 4;
            this.labSoPhongNgu.Text = "Số phòng ngủ";
            // 
            // txtSoPhongNgu
            // 
            this.txtSoPhongNgu.Location = new System.Drawing.Point(119, 86);
            this.txtSoPhongNgu.Name = "txtSoPhongNgu";
            this.txtSoPhongNgu.Size = new System.Drawing.Size(44, 22);
            this.txtSoPhongNgu.TabIndex = 5;
            this.txtSoPhongNgu.TextChanged += new System.EventHandler(this.txtSoPhongNgu_TextChanged);
            // 
            // labSoNhaVeSinh
            // 
            this.labSoNhaVeSinh.AutoSize = true;
            this.labSoNhaVeSinh.Location = new System.Drawing.Point(7, 123);
            this.labSoNhaVeSinh.Name = "labSoNhaVeSinh";
            this.labSoNhaVeSinh.Size = new System.Drawing.Size(94, 16);
            this.labSoNhaVeSinh.TabIndex = 4;
            this.labSoNhaVeSinh.Text = "Số nhà vệ sinh";
            // 
            // txtSoNhaVeSinh
            // 
            this.txtSoNhaVeSinh.Location = new System.Drawing.Point(119, 117);
            this.txtSoNhaVeSinh.Name = "txtSoNhaVeSinh";
            this.txtSoNhaVeSinh.Size = new System.Drawing.Size(44, 22);
            this.txtSoNhaVeSinh.TabIndex = 5;
            this.txtSoNhaVeSinh.TextChanged += new System.EventHandler(this.txtSoNhaVeSinh_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hướng ban công";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbHuongBanCong
            // 
            this.cmbHuongBanCong.FormattingEnabled = true;
            this.cmbHuongBanCong.Items.AddRange(new object[] {
            "Bac",
            "Nam",
            "Tay ",
            "Dong",
            "TayBac",
            "TayNam",
            "DongBac",
            "DongNam"});
            this.cmbHuongBanCong.Location = new System.Drawing.Point(121, 153);
            this.cmbHuongBanCong.Name = "cmbHuongBanCong";
            this.cmbHuongBanCong.Size = new System.Drawing.Size(87, 24);
            this.cmbHuongBanCong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(121, 201);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(87, 22);
            this.txtGiaTien.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdConTrong);
            this.groupBox1.Controls.Add(this.rdbDaDatCoc);
            this.groupBox1.Controls.Add(this.rdbDaBan);
            this.groupBox1.Location = new System.Drawing.Point(40, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbdConTrong
            // 
            this.rbdConTrong.AutoSize = true;
            this.rbdConTrong.Location = new System.Drawing.Point(6, 97);
            this.rbdConTrong.Name = "rbdConTrong";
            this.rbdConTrong.Size = new System.Drawing.Size(85, 20);
            this.rbdConTrong.TabIndex = 0;
            this.rbdConTrong.TabStop = true;
            this.rbdConTrong.Text = "Còn trống";
            this.rbdConTrong.UseVisualStyleBackColor = true;
            // 
            // rdbDaDatCoc
            // 
            this.rdbDaDatCoc.AutoSize = true;
            this.rdbDaDatCoc.Location = new System.Drawing.Point(6, 21);
            this.rdbDaDatCoc.Name = "rdbDaDatCoc";
            this.rdbDaDatCoc.Size = new System.Drawing.Size(92, 20);
            this.rdbDaDatCoc.TabIndex = 0;
            this.rdbDaDatCoc.TabStop = true;
            this.rdbDaDatCoc.Text = "Đã đặt cọc";
            this.rdbDaDatCoc.UseVisualStyleBackColor = true;
            this.rdbDaDatCoc.CheckedChanged += new System.EventHandler(this.rdbDaDatCoc_CheckedChanged);
            // 
            // rdbDaBan
            // 
            this.rdbDaBan.AutoSize = true;
            this.rdbDaBan.Location = new System.Drawing.Point(6, 60);
            this.rdbDaBan.Name = "rdbDaBan";
            this.rdbDaBan.Size = new System.Drawing.Size(71, 20);
            this.rdbDaBan.TabIndex = 0;
            this.rdbDaBan.TabStop = true;
            this.rdbDaBan.Text = "Đã bán";
            this.rdbDaBan.UseVisualStyleBackColor = true;
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(12, 54);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(47, 16);
            this.labDiaChi.TabIndex = 4;
            this.labDiaChi.Text = "Địa chỉ";
            this.labDiaChi.Click += new System.EventHandler(this.labDiaChi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "(VND)";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(790, 438);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(293, 43);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 35);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbTimHuongBanCong
            // 
            this.cmbTimHuongBanCong.FormattingEnabled = true;
            this.cmbTimHuongBanCong.Items.AddRange(new object[] {
            "Bac",
            "Nam",
            "Tay ",
            "Dong",
            "TayBac",
            "TayNam",
            "DongBac",
            "DongNam"});
            this.cmbTimHuongBanCong.Location = new System.Drawing.Point(12, 21);
            this.cmbTimHuongBanCong.Name = "cmbTimHuongBanCong";
            this.cmbTimHuongBanCong.Size = new System.Drawing.Size(121, 24);
            this.cmbTimHuongBanCong.TabIndex = 9;
            // 
            // txtTimGiaTien
            // 
            this.txtTimGiaTien.Location = new System.Drawing.Point(12, 67);
            this.txtTimGiaTien.Name = "txtTimGiaTien";
            this.txtTimGiaTien.Size = new System.Drawing.Size(87, 22);
            this.txtTimGiaTien.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTimGiaTien);
            this.groupBox2.Controls.Add(this.cmbTimHuongBanCong);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(318, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 120);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tìm theo giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tìm theo hướng";
            // 
            // btnHienDanhSach
            // 
            this.btnHienDanhSach.Location = new System.Drawing.Point(780, 294);
            this.btnHienDanhSach.Name = "btnHienDanhSach";
            this.btnHienDanhSach.Size = new System.Drawing.Size(121, 23);
            this.btnHienDanhSach.TabIndex = 12;
            this.btnHienDanhSach.Text = "Hiện danh sách";
            this.btnHienDanhSach.UseVisualStyleBackColor = true;
            this.btnHienDanhSach.Click += new System.EventHandler(this.btnHienDanhSach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 494);
            this.Controls.Add(this.btnHienDanhSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbHuongBanCong);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtSoNhaVeSinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labSoNhaVeSinh);
            this.Controls.Add(this.txtSoPhongNgu);
            this.Controls.Add(this.labDiaChi);
            this.Controls.Add(this.labSoPhongNgu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.listBxDsCanHo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox listBxDsCanHo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labSoPhongNgu;
        private System.Windows.Forms.TextBox txtSoPhongNgu;
        private System.Windows.Forms.Label labSoNhaVeSinh;
        private System.Windows.Forms.TextBox txtSoNhaVeSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHuongBanCong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdConTrong;
        private System.Windows.Forms.RadioButton rdbDaDatCoc;
        private System.Windows.Forms.RadioButton rdbDaBan;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cmbTimHuongBanCong;
        private System.Windows.Forms.TextBox txtTimGiaTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHienDanhSach;
    }
}


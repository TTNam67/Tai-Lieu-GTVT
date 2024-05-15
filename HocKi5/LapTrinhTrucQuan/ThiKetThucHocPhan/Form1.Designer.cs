namespace ThiKetThucHocPhan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoThangNay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoThangTruoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtNgayChotSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoaKhoiDS = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXuatFileExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoThangNay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSoThangTruoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHoTenKhachHang);
            this.groupBox1.Controls.Add(this.txtNgayChotSo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng sử dụng điện";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSoThangNay
            // 
            this.txtSoThangNay.Location = new System.Drawing.Point(131, 193);
            this.txtSoThangNay.Name = "txtSoThangNay";
            this.txtSoThangNay.Size = new System.Drawing.Size(100, 22);
            this.txtSoThangNay.TabIndex = 1;
            this.txtSoThangNay.TextChanged += new System.EventHandler(this.txtSoThangNay_TextChanged);
            this.txtSoThangNay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThangNay_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số tháng này";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(131, 91);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtSoThangTruoc
            // 
            this.txtSoThangTruoc.Location = new System.Drawing.Point(131, 155);
            this.txtSoThangTruoc.Name = "txtSoThangTruoc";
            this.txtSoThangTruoc.Size = new System.Drawing.Size(100, 22);
            this.txtSoThangTruoc.TabIndex = 1;
            this.txtSoThangTruoc.TextChanged += new System.EventHandler(this.txtSoThangTruoc_TextChanged);
            this.txtSoThangTruoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThangTruoc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số tháng trước";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(131, 53);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(100, 22);
            this.txtHoTenKhachHang.TabIndex = 1;
            // 
            // txtNgayChotSo
            // 
            this.txtNgayChotSo.Location = new System.Drawing.Point(131, 127);
            this.txtNgayChotSo.Name = "txtNgayChotSo";
            this.txtNgayChotSo.Size = new System.Drawing.Size(100, 22);
            this.txtNgayChotSo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên KH";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(131, 25);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(100, 22);
            this.txtMaKhachHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày chốt sổ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKhachHang);
            this.groupBox2.Location = new System.Drawing.Point(318, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(47, 305);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(98, 34);
            this.btnThemVaoDS.TabIndex = 2;
            this.btnThemVaoDS.Text = "Thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(167, 305);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 34);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Làm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoaKhoiDS
            // 
            this.btnXoaKhoiDS.Location = new System.Drawing.Point(281, 305);
            this.btnXoaKhoiDS.Name = "btnXoaKhoiDS";
            this.btnXoaKhoiDS.Size = new System.Drawing.Size(96, 34);
            this.btnXoaKhoiDS.TabIndex = 2;
            this.btnXoaKhoiDS.Text = "Xóa khỏi DS";
            this.btnXoaKhoiDS.UseVisualStyleBackColor = true;
            this.btnXoaKhoiDS.Click += new System.EventHandler(this.btnXoaKhoiDS_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(416, 305);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(78, 34);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXuatFileExcel
            // 
            this.btnXuatFileExcel.Location = new System.Drawing.Point(539, 305);
            this.btnXuatFileExcel.Name = "btnXuatFileExcel";
            this.btnXuatFileExcel.Size = new System.Drawing.Size(100, 34);
            this.btnXuatFileExcel.TabIndex = 2;
            this.btnXuatFileExcel.Text = "Xuất file Excel";
            this.btnXuatFileExcel.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(666, 305);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(8, 19);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(460, 230);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            this.dgvKhachHang.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXuatFileExcel);
            this.Controls.Add(this.btnXoaKhoiDS);
            this.Controls.Add(this.btnThemVaoDS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoThangNay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoThangTruoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTenKhachHang;
        private System.Windows.Forms.TextBox txtNgayChotSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoaKhoiDS;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXuatFileExcel;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKhachHang;
    }
}


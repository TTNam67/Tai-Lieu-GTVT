namespace KiemTraGiuaKy
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
            this.LabTenTacGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.txtMaTacPham = new System.Windows.Forms.TextBox();
            this.txtTenTacPham = new System.Windows.Forms.TextBox();
            this.txtLoaiTacPham = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimTenTacPham = new System.Windows.Forms.Button();
            this.dgvTacPham = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacPham)).BeginInit();
            this.SuspendLayout();
            // 
            // LabTenTacGia
            // 
            this.LabTenTacGia.AutoSize = true;
            this.LabTenTacGia.Location = new System.Drawing.Point(30, 18);
            this.LabTenTacGia.Name = "LabTenTacGia";
            this.LabTenTacGia.Size = new System.Drawing.Size(74, 16);
            this.LabTenTacGia.TabIndex = 0;
            this.LabTenTacGia.Text = "Tên tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tác phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên tác phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại tác phẩm";
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(168, 18);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(215, 22);
            this.txtTenTacGia.TabIndex = 1;
            // 
            // txtMaTacPham
            // 
            this.txtMaTacPham.Location = new System.Drawing.Point(168, 46);
            this.txtMaTacPham.Name = "txtMaTacPham";
            this.txtMaTacPham.Size = new System.Drawing.Size(215, 22);
            this.txtMaTacPham.TabIndex = 1;
            // 
            // txtTenTacPham
            // 
            this.txtTenTacPham.Location = new System.Drawing.Point(168, 101);
            this.txtTenTacPham.Name = "txtTenTacPham";
            this.txtTenTacPham.Size = new System.Drawing.Size(215, 22);
            this.txtTenTacPham.TabIndex = 1;
            // 
            // txtLoaiTacPham
            // 
            this.txtLoaiTacPham.Location = new System.Drawing.Point(168, 145);
            this.txtLoaiTacPham.Name = "txtLoaiTacPham";
            this.txtLoaiTacPham.Size = new System.Drawing.Size(215, 22);
            this.txtLoaiTacPham.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(614, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 25);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(614, 48);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 25);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(614, 98);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 25);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.Location = new System.Drawing.Point(614, 142);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(156, 25);
            this.btnXuatRaExcel.TabIndex = 2;
            this.btnXuatRaExcel.Text = "Xuất ra Excel";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(614, 188);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(156, 25);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimTenTacPham
            // 
            this.btnTimTenTacPham.Location = new System.Drawing.Point(614, 234);
            this.btnTimTenTacPham.Name = "btnTimTenTacPham";
            this.btnTimTenTacPham.Size = new System.Drawing.Size(156, 25);
            this.btnTimTenTacPham.TabIndex = 2;
            this.btnTimTenTacPham.Text = "Tìm tên tác phẩm";
            this.btnTimTenTacPham.UseVisualStyleBackColor = true;
            this.btnTimTenTacPham.Click += new System.EventHandler(this.btnTimTenTacPham_Click);
            // 
            // dgvTacPham
            // 
            this.dgvTacPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacPham.Location = new System.Drawing.Point(17, 189);
            this.dgvTacPham.Name = "dgvTacPham";
            this.dgvTacPham.RowHeadersWidth = 51;
            this.dgvTacPham.RowTemplate.Height = 24;
            this.dgvTacPham.Size = new System.Drawing.Size(584, 267);
            this.dgvTacPham.TabIndex = 3;
            this.dgvTacPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacPham_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(614, 279);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 24);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 465);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvTacPham);
            this.Controls.Add(this.btnTimTenTacPham);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLoaiTacPham);
            this.Controls.Add(this.txtTenTacPham);
            this.Controls.Add(this.txtMaTacPham);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabTenTacGia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabTenTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacPham;
        private System.Windows.Forms.TextBox txtTenTacPham;
        private System.Windows.Forms.TextBox txtLoaiTacPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimTenTacPham;
        private System.Windows.Forms.DataGridView dgvTacPham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


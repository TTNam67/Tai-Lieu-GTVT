namespace FormBanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lstDanhSachMatHang = new System.Windows.Forms.ListBox();
            this.lstHangDatMua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTheTinDung = new System.Windows.Forms.RadioButton();
            this.rdbSec = new System.Windows.Forms.RadioButton();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbEmail = new System.Windows.Forms.CheckBox();
            this.chbFax = new System.Windows.Forms.CheckBox();
            this.chbDienThoai = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách các mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hàng đặt mua";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(121, 33);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(211, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(652, 26);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(187, 22);
            this.txtDienThoai.TabIndex = 1;
            // 
            // lstDanhSachMatHang
            // 
            this.lstDanhSachMatHang.FormattingEnabled = true;
            this.lstDanhSachMatHang.ItemHeight = 16;
            this.lstDanhSachMatHang.Location = new System.Drawing.Point(16, 143);
            this.lstDanhSachMatHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDanhSachMatHang.Name = "lstDanhSachMatHang";
            this.lstDanhSachMatHang.Size = new System.Drawing.Size(344, 164);
            this.lstDanhSachMatHang.TabIndex = 2;
            this.lstDanhSachMatHang.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDanhSachMatHang_MouseDoubleClick);
            // 
            // lstHangDatMua
            // 
            this.lstHangDatMua.FormattingEnabled = true;
            this.lstHangDatMua.ItemHeight = 16;
            this.lstHangDatMua.Location = new System.Drawing.Point(531, 143);
            this.lstHangDatMua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstHangDatMua.Name = "lstHangDatMua";
            this.lstHangDatMua.Size = new System.Drawing.Size(377, 164);
            this.lstHangDatMua.TabIndex = 2;
            this.lstHangDatMua.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstHangDatMua_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTheTinDung);
            this.groupBox1.Controls.Add(this.rdbSec);
            this.groupBox1.Controls.Add(this.rdbTienMat);
            this.groupBox1.Location = new System.Drawing.Point(16, 335);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(260, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // rdbTheTinDung
            // 
            this.rdbTheTinDung.AutoSize = true;
            this.rdbTheTinDung.Location = new System.Drawing.Point(44, 81);
            this.rdbTheTinDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTheTinDung.Name = "rdbTheTinDung";
            this.rdbTheTinDung.Size = new System.Drawing.Size(101, 20);
            this.rdbTheTinDung.TabIndex = 0;
            this.rdbTheTinDung.TabStop = true;
            this.rdbTheTinDung.Text = "Thẻ tín dụng";
            this.rdbTheTinDung.UseVisualStyleBackColor = true;
            // 
            // rdbSec
            // 
            this.rdbSec.AutoSize = true;
            this.rdbSec.Location = new System.Drawing.Point(44, 53);
            this.rdbSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSec.Name = "rdbSec";
            this.rdbSec.Size = new System.Drawing.Size(52, 20);
            this.rdbSec.TabIndex = 0;
            this.rdbSec.TabStop = true;
            this.rdbSec.Text = "Sec";
            this.rdbSec.UseVisualStyleBackColor = true;
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Location = new System.Drawing.Point(44, 25);
            this.rdbTienMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(80, 20);
            this.rdbTienMat.TabIndex = 0;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbEmail);
            this.groupBox2.Controls.Add(this.chbFax);
            this.groupBox2.Controls.Add(this.chbDienThoai);
            this.groupBox2.Location = new System.Drawing.Point(531, 335);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(232, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            // 
            // chbEmail
            // 
            this.chbEmail.AutoSize = true;
            this.chbEmail.Location = new System.Drawing.Point(43, 81);
            this.chbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Size = new System.Drawing.Size(63, 20);
            this.chbEmail.TabIndex = 0;
            this.chbEmail.Text = "Email";
            this.chbEmail.UseVisualStyleBackColor = true;
            // 
            // chbFax
            // 
            this.chbFax.AutoSize = true;
            this.chbFax.Location = new System.Drawing.Point(43, 53);
            this.chbFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbFax.Name = "chbFax";
            this.chbFax.Size = new System.Drawing.Size(51, 20);
            this.chbFax.TabIndex = 0;
            this.chbFax.Text = "Fax";
            this.chbFax.UseVisualStyleBackColor = true;
            // 
            // chbDienThoai
            // 
            this.chbDienThoai.AutoSize = true;
            this.chbDienThoai.Location = new System.Drawing.Point(43, 25);
            this.chbDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbDienThoai.Name = "chbDienThoai";
            this.chbDienThoai.Size = new System.Drawing.Size(88, 20);
            this.chbDienThoai.TabIndex = 0;
            this.chbDienThoai.Text = "Điện thoại";
            this.chbDienThoai.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 497);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(789, 497);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstHangDatMua);
            this.Controls.Add(this.lstDanhSachMatHang);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ListBox lstDanhSachMatHang;
        private System.Windows.Forms.ListBox lstHangDatMua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdbTheTinDung;
        private System.Windows.Forms.RadioButton rdbSec;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.CheckBox chbFax;
        private System.Windows.Forms.CheckBox chbDienThoai;
        private System.Windows.Forms.CheckBox chbEmail;
    }
}


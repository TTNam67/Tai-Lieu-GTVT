namespace QLPB
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Hà Nội",
            "10",
            "100",
            "Bắc",
            "100000",
            "10",
            "Đã bán"}, -1);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBan = new System.Windows.Forms.RadioButton();
            this.rdbEm = new System.Windows.Forms.RadioButton();
            this.rdbCoc = new System.Windows.Forms.RadioButton();
            this.cmbHuong = new System.Windows.Forms.ComboBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtCk = new System.Windows.Forms.TextBox();
            this.txtWc = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSe = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBan);
            this.groupBox1.Controls.Add(this.rdbEm);
            this.groupBox1.Controls.Add(this.rdbCoc);
            this.groupBox1.Controls.Add(this.cmbHuong);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtCk);
            this.groupBox1.Controls.Add(this.txtWc);
            this.groupBox1.Controls.Add(this.txtPN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin căn hộ";
            // 
            // rdbBan
            // 
            this.rdbBan.AutoSize = true;
            this.rdbBan.Location = new System.Drawing.Point(10, 423);
            this.rdbBan.Name = "rdbBan";
            this.rdbBan.Size = new System.Drawing.Size(89, 24);
            this.rdbBan.TabIndex = 3;
            this.rdbBan.Text = "Đã bán";
            this.rdbBan.UseVisualStyleBackColor = true;
            // 
            // rdbEm
            // 
            this.rdbEm.AutoSize = true;
            this.rdbEm.Location = new System.Drawing.Point(176, 423);
            this.rdbEm.Name = "rdbEm";
            this.rdbEm.Size = new System.Drawing.Size(112, 24);
            this.rdbEm.TabIndex = 3;
            this.rdbEm.Text = "Còn trống";
            this.rdbEm.UseVisualStyleBackColor = true;
            // 
            // rdbCoc
            // 
            this.rdbCoc.AutoSize = true;
            this.rdbCoc.Checked = true;
            this.rdbCoc.Location = new System.Drawing.Point(176, 376);
            this.rdbCoc.Name = "rdbCoc";
            this.rdbCoc.Size = new System.Drawing.Size(121, 24);
            this.rdbCoc.TabIndex = 3;
            this.rdbCoc.TabStop = true;
            this.rdbCoc.Text = "Đã đặt cọc";
            this.rdbCoc.UseVisualStyleBackColor = true;
            // 
            // cmbHuong
            // 
            this.cmbHuong.FormattingEnabled = true;
            this.cmbHuong.Items.AddRange(new object[] {
            "Đông ",
            "Tây",
            "Nam",
            "Bắc",
            "Đông Nam",
            "Đông Bắc",
            "Tây Bắc",
            "Tây Nam"});
            this.cmbHuong.Location = new System.Drawing.Point(187, 197);
            this.cmbHuong.Name = "cmbHuong";
            this.cmbHuong.Size = new System.Drawing.Size(140, 28);
            this.cmbHuong.TabIndex = 2;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(115, 45);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(198, 27);
            this.txtDC.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(115, 253);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(198, 27);
            this.txtGia.TabIndex = 1;
            // 
            // txtCk
            // 
            this.txtCk.Location = new System.Drawing.Point(176, 313);
            this.txtCk.Name = "txtCk";
            this.txtCk.Size = new System.Drawing.Size(75, 27);
            this.txtCk.TabIndex = 1;
            // 
            // txtWc
            // 
            this.txtWc.Location = new System.Drawing.Point(176, 145);
            this.txtWc.Name = "txtWc";
            this.txtWc.Size = new System.Drawing.Size(75, 27);
            this.txtWc.TabIndex = 1;
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(176, 95);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(75, 27);
            this.txtPN.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chiết Khấu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "%";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hướng Ban Công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà Vệ Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng Ngủ";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView.Location = new System.Drawing.Point(383, 37);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(583, 463);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Địa chỉ";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phòng ngủ";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nhà vệ sinh";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hướng ban công";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Triết Khấu";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tình Trạng";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(48, 535);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFix
            // 
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(259, 535);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 2;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(468, 535);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSe
            // 
            this.btnSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSe.Location = new System.Drawing.Point(682, 535);
            this.btnSe.Name = "btnSe";
            this.btnSe.Size = new System.Drawing.Size(75, 23);
            this.btnSe.TabIndex = 2;
            this.btnSe.Text = "Tìm kiếm";
            this.btnSe.UseVisualStyleBackColor = true;
            this.btnSe.Click += new System.EventHandler(this.btnSe_Click);
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(882, 535);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 607);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnSe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "QLPB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHuong;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtCk;
        private System.Windows.Forms.TextBox txtWc;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbBan;
        private System.Windows.Forms.RadioButton rdbEm;
        private System.Windows.Forms.RadioButton rdbCoc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSe;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}


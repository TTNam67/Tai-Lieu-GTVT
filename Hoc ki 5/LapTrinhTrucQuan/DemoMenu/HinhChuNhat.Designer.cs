namespace DemoMenu
{
    partial class HinhChuNhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labKetQua = new System.Windows.Forms.Label();
            this.TinhDienTich = new System.Windows.Forms.Button();
            this.LamMoi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chiều dài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập chiều rộng";
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(161, 50);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(78, 22);
            this.txtChieuDai.TabIndex = 2;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(161, 87);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(78, 22);
            this.txtChieuRong.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DemoMenu.Properties.Resources.Meme;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.labKetQua);
            this.groupBox1.Location = new System.Drawing.Point(34, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 247);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labKetQua
            // 
            this.labKetQua.AutoSize = true;
            this.labKetQua.Location = new System.Drawing.Point(32, 27);
            this.labKetQua.Name = "labKetQua";
            this.labKetQua.Size = new System.Drawing.Size(52, 16);
            this.labKetQua.TabIndex = 0;
            this.labKetQua.Text = "Kết quả";
            // 
            // TinhDienTich
            // 
            this.TinhDienTich.ContextMenuStrip = this.contextMenuStrip1;
            this.TinhDienTich.Location = new System.Drawing.Point(511, 52);
            this.TinhDienTich.Name = "TinhDienTich";
            this.TinhDienTich.Size = new System.Drawing.Size(160, 24);
            this.TinhDienTich.TabIndex = 4;
            this.TinhDienTich.Text = "Tính diện tích";
            this.TinhDienTich.UseVisualStyleBackColor = true;
            this.TinhDienTich.Click += new System.EventHandler(this.TinhDienTich_Click);
            // 
            // LamMoi
            // 
            this.LamMoi.Location = new System.Drawing.Point(511, 127);
            this.LamMoi.Name = "LamMoi";
            this.LamMoi.Size = new System.Drawing.Size(104, 24);
            this.LamMoi.TabIndex = 4;
            this.LamMoi.Text = "Làm mới";
            this.LamMoi.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoToolStripMenuItem,
            this.XanhToolStripMenuItem,
            this.VangToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 76);
            // 
            // DoToolStripMenuItem
            // 
            this.DoToolStripMenuItem.Name = "DoToolStripMenuItem";
            this.DoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.DoToolStripMenuItem.Text = "Đỏ";
            this.DoToolStripMenuItem.Click += new System.EventHandler(this.DoToolStripMenuItem_Click);
            // 
            // XanhToolStripMenuItem
            // 
            this.XanhToolStripMenuItem.Name = "XanhToolStripMenuItem";
            this.XanhToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.XanhToolStripMenuItem.Text = "Xanh";
            this.XanhToolStripMenuItem.Click += new System.EventHandler(this.XanhToolStripMenuItem_Click);
            // 
            // VangToolStripMenuItem
            // 
            this.VangToolStripMenuItem.Name = "VangToolStripMenuItem";
            this.VangToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.VangToolStripMenuItem.Text = "Vàng";
            this.VangToolStripMenuItem.Click += new System.EventHandler(this.VangToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // HinhChuNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 536);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LamMoi);
            this.Controls.Add(this.TinhDienTich);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HinhChuNhat";
            this.Text = "HinhChuNhat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labKetQua;
        private System.Windows.Forms.Button TinhDienTich;
        private System.Windows.Forms.Button LamMoi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VangToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
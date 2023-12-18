namespace DemoMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TinhDienTichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HinhChuNhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HinhTronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GiaiPhuongTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bac1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bac2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TinhDienTichToolStripMenuItem,
            this.GiaiPhuongTrinhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TinhDienTichToolStripMenuItem
            // 
            this.TinhDienTichToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HinhChuNhatToolStripMenuItem,
            this.HinhTronToolStripMenuItem});
            this.TinhDienTichToolStripMenuItem.Name = "TinhDienTichToolStripMenuItem";
            this.TinhDienTichToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.TinhDienTichToolStripMenuItem.Text = "Tính diện tích";
            this.TinhDienTichToolStripMenuItem.Click += new System.EventHandler(this.plToolStripMenuItem_Click);
            // 
            // HinhChuNhatToolStripMenuItem
            // 
            this.HinhChuNhatToolStripMenuItem.Name = "HinhChuNhatToolStripMenuItem";
            this.HinhChuNhatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.HinhChuNhatToolStripMenuItem.Text = "Hình chữ nhật";
            // 
            // HinhTronToolStripMenuItem
            // 
            this.HinhTronToolStripMenuItem.Name = "HinhTronToolStripMenuItem";
            this.HinhTronToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.HinhTronToolStripMenuItem.Text = "Hình tròn";
            // 
            // GiaiPhuongTrinhToolStripMenuItem
            // 
            this.GiaiPhuongTrinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bac1ToolStripMenuItem,
            this.Bac2ToolStripMenuItem});
            this.GiaiPhuongTrinhToolStripMenuItem.Name = "GiaiPhuongTrinhToolStripMenuItem";
            this.GiaiPhuongTrinhToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.GiaiPhuongTrinhToolStripMenuItem.Text = "Giải phương trình";
            // 
            // Bac1ToolStripMenuItem
            // 
            this.Bac1ToolStripMenuItem.Name = "Bac1ToolStripMenuItem";
            this.Bac1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Bac1ToolStripMenuItem.Text = "Bậc nhất";
            this.Bac1ToolStripMenuItem.Click += new System.EventHandler(this.Bac1ToolStripMenuItem_Click);
            // 
            // Bac2ToolStripMenuItem
            // 
            this.Bac2ToolStripMenuItem.Name = "Bac2ToolStripMenuItem";
            this.Bac2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Bac2ToolStripMenuItem.Text = "Bậc hai";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(292, 184);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(241, 132);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xanhToolStripMenuItem,
            this.DoToolStripMenuItem,
            this.VangToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // xanhToolStripMenuItem
            // 
            this.xanhToolStripMenuItem.Name = "xanhToolStripMenuItem";
            this.xanhToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xanhToolStripMenuItem.Text = "Xanh";
            this.xanhToolStripMenuItem.Click += new System.EventHandler(this.xanhToolStripMenuItem_Click);
            // 
            // DoToolStripMenuItem
            // 
            this.DoToolStripMenuItem.Name = "DoToolStripMenuItem";
            this.DoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.DoToolStripMenuItem.Text = "Đỏ";
            this.DoToolStripMenuItem.Click += new System.EventHandler(this.DoToolStripMenuItem_Click);
            // 
            // VangToolStripMenuItem
            // 
            this.VangToolStripMenuItem.Name = "VangToolStripMenuItem";
            this.VangToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.VangToolStripMenuItem.Text = "Vàng";
            this.VangToolStripMenuItem.Click += new System.EventHandler(this.VangToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TinhDienTichToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem HinhChuNhatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HinhTronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GiaiPhuongTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bac1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bac2ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VangToolStripMenuItem;
    }
}


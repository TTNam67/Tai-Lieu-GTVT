namespace GUI
{
    partial class BaoCao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.qLChoThueNhaBTLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLChoThueNha_BTLDataSet = new GUI.QLChoThueNha_BTLDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.qLChoThueNhaBTLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChoThueNha_BTLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // qLChoThueNhaBTLDataSetBindingSource
            // 
            this.qLChoThueNhaBTLDataSetBindingSource.DataSource = this.qLChoThueNha_BTLDataSet;
            this.qLChoThueNhaBTLDataSetBindingSource.Position = 0;
            // 
            // qLChoThueNha_BTLDataSet
            // 
            this.qLChoThueNha_BTLDataSet.DataSetName = "QLChoThueNha_BTLDataSet";
            this.qLChoThueNha_BTLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.qLChoThueNhaBTLDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLChoThueNhaBTLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChoThueNha_BTLDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLChoThueNhaBTLDataSetBindingSource;
        private QLChoThueNha_BTLDataSet qLChoThueNha_BTLDataSet;
    }
}
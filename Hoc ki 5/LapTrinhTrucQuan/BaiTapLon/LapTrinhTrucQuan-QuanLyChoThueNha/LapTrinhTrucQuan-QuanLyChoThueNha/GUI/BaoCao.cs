using GUI.QLChoThueNha_BTLDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            //this.reportViewer1.RefreshReport();




            QLChoThueNha_BTLDataSet qlbh = new QLChoThueNha_BTLDataSet();

            //BaoCao3TableAdapter bc3 = new BaoCao3TableAdapter();
            //bc3.Fill(qlbh.BaoCao3, mant);
//            reportViewer1.LocalReport.ReportPath = "D:\\Hoc ki 5\\LapTrinhTrucQuan\\BaiTapLon\\LapTrinhTrucQuan-QuanLyChoThueNha\\LapTrinhTrucQuan-QuanLyChoThueNha\\GUI\\Report1.rdlc";

            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", qlbh.Tables["BaoCao1"])); // "DataSetName" là tên của DataSet trong ReportViewer

            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }


    }
}

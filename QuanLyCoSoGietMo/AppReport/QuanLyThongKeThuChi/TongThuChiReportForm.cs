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

namespace QuanLyCoSoGietMo.AppReport.QuanLyThongKeThuChi
{
    public partial class TongThuChiReportForm : Form
    {
        DateTime _tuNgay;
        DateTime _denNgay;

        public TongThuChiReportForm(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            _tuNgay = tuNgay;
            _denNgay = denNgay;
        }

        private void TongThuChiReportForm_Load(object sender, EventArgs e)
        {
            v3_View_ChiTietNhatKyChiTableAdapter.Fill(appDataSet.V3_View_ChiTietNhatKyChi, _tuNgay.ToString("MM/dd/yyyy"), _tuNgay.ToString("MM/dd/yyyy"));
            v3_View_ChiTietNhatKyThuTableAdapter.Fill(appDataSet.V3_View_ChiTietNhatKyThu, _tuNgay.ToString("MM/dd/yyyy"), _tuNgay.ToString("MM/dd/yyyy"));
            ReportParameter[] rParameters = new ReportParameter[]{
                new ReportParameter("TuNgay", _tuNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("DenNgay", _tuNgay.ToString("dd/MM/yyyy")),
            };
            ReportDataSource rChiDataSource = new ReportDataSource("DsTongChi", appDataSet.Tables["V3_View_ChiTietNhatKyChi"]);
            ReportDataSource rThuDataSource = new ReportDataSource("DsTongThu", appDataSet.Tables["V3_View_ChiTietNhatKyThu"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rChiDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(rThuDataSource);
            this.reportViewer1.LocalReport.SetParameters(rParameters);
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.RefreshReport();
        }
    }
}

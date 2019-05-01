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
    public partial class TongVanChuyenReportForm : Form
    {
        DateTime _tuNgay;
        DateTime _denNgay;

        public TongVanChuyenReportForm(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            _tuNgay = tuNgay;
            _denNgay = denNgay;
        }

        private void TongVanChuyenReportForm_Load(object sender, EventArgs e)
        {
            v3_View_ChiTietNhatKyVanChuyenTableAdapter.Fill(appDataSet.V3_View_ChiTietNhatKyVanChuyen, _tuNgay.ToString("MM/dd/yyyy"), _tuNgay.ToString("MM/dd/yyyy"));
            v3_View_ChiTietNhatKyNhapHangTableAdapter.Fill(appDataSet.V3_View_ChiTietNhatKyNhapHang, _tuNgay.ToString("MM/dd/yyyy"), _tuNgay.ToString("MM/dd/yyyy"));
            ReportParameter[] rParameters = new ReportParameter[]{
                new ReportParameter("TuNgay", _tuNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("DenNgay", _tuNgay.ToString("dd/MM/yyyy")),
            };
            ReportDataSource rNhapHangDataSource = new ReportDataSource("DsNhapHang", appDataSet.Tables["V3_View_ChiTietNhatKyNhapHang"]);
            ReportDataSource rVanChuyenDataSource = new ReportDataSource("DsVanChuyen", appDataSet.Tables["V3_View_ChiTietNhatKyVanChuyen"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rNhapHangDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(rVanChuyenDataSource);
            this.reportViewer1.LocalReport.SetParameters(rParameters);
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.RefreshReport();
        }
    }
}

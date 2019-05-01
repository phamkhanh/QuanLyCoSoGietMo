using QuanLyCoSoGietMo.AppReport.QuanLyThongKeThuChi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoGietMo.AppReport
{
    public partial class QuanLyThuChiThongKe : Form
    {
        public QuanLyThuChiThongKe()
        {
            InitializeComponent();
        }

        private void QuanLyThuChiThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet.V3_View_ChiTietNhatKyThuChi' table. You can move, or remove it, as needed.
            //this.v3_View_ChiTietNhatKyThuChiTableAdapter.Fill(this.appDataSet.V3_View_ChiTietNhatKyThuChi);
            // TODO: This line of code loads data into the 'appDataSet.DoiTuong' table. You can move, or remove it, as needed.
            this.doiTuongTableAdapter.Fill(this.appDataSet.DoiTuong);

        }

        private void btnXuatTongThuChi_Click(object sender, EventArgs e)
        {
            new TongThuChiReportForm(dtpThuChiTuNgay.Value, dtpThuChiDenNgay.Value).ShowDialog();
        }

        private void btnXuatDoiTuong_Click(object sender, EventArgs e)
        {
            new TongVanChuyenReportForm(dtpThuChiTuNgay.Value, dtpThuChiDenNgay.Value).ShowDialog();
        }
    }
}

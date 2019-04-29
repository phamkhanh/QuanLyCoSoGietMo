using QuanLyCoSoGietMo.AppSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoGietMo.AppForm
{
    public partial class QuanLyDanhMucDoiTuongForm : Form
    {
        public QuanLyDanhMucDoiTuongForm()
        {
            InitializeComponent();
        }

        private void QuanLyDanhMucDoiTuongForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet.DoiTuong' table. You can move, or remove it, as needed.
            this.doiTuongTableAdapter.FillByTenDoiTuong(this.appDataSet.DoiTuong, txtTimHoTen.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.doiTuongTableAdapter.Update(appDataSet.DoiTuong);
            this.doiTuongTableAdapter.FillByTenDoiTuong(this.appDataSet.DoiTuong, "");
            AppMsg.Instance.Green(lbMsg, "Lưu dữ liệu thành công");
        }

        private void txtTimHoTen_TextChanged(object sender, EventArgs e)
        {
            this.doiTuongTableAdapter.FillByTenDoiTuong(this.appDataSet.DoiTuong, txtTimHoTen.Text);
        }
    }
}

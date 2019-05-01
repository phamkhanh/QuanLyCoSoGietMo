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
    public partial class QuanLyDanhMucNguoiVanChuyenForm : Form
    {
        public QuanLyDanhMucNguoiVanChuyenForm()
        {
            InitializeComponent();
        }

        private void QuanLyDanhMucNguoiVanChuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet.NguoiVanChuyen' table. You can move, or remove it, as needed.
            this.nguoiVanChuyenTableAdapter.Fill(this.appDataSet.NguoiVanChuyen, txtTimHoTen.Text);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.nguoiVanChuyenTableAdapter.Update(this.appDataSet.NguoiVanChuyen);
            AppMsg.Instance.Green(lbMsg, "Lưu dữ liệu thành công.");
        }

        private void txtTimHoTen_TextChanged(object sender, EventArgs e)
        {
            this.nguoiVanChuyenTableAdapter.Fill(this.appDataSet.NguoiVanChuyen, txtTimHoTen.Text);
        }
    }
}

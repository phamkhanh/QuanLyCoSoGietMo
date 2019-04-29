using QuanLyCoSoGietMo.AppSupport;
using System;
using System.Windows.Forms;

namespace QuanLyCoSoGietMo.AppForm
{
    public partial class QuanLyDanhMucSanPhamForm : Form
    {
        public QuanLyDanhMucSanPhamForm()
        {
            InitializeComponent();
        }

        private void QuanLyDanhMucSanPhamForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.FillByTenSanPham(this.appDataSet.SanPham, txtTimHoTen.Text);
        }

        private void txtTimHoTen_TextChanged(object sender, EventArgs e)
        {
            this.sanPhamTableAdapter.FillByTenSanPham(this.appDataSet.SanPham, txtTimHoTen.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.sanPhamTableAdapter.Update(this.appDataSet.SanPham);
            AppMsg.Instance.Green(lbMsg, "Lưu dữ liệu thành công.");
        }
    }
}
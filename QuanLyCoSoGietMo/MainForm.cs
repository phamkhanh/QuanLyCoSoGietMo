using QuanLyCoSoGietMo.AppForm;
using QuanLyCoSoGietMo.AppSupport;
using System;
using System.Windows.Forms;

namespace QuanLyCoSoGietMo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppCommon.AddFormToMdiParent(new QuanLyDanhMucDoiTuongForm(), this);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppCommon.AddFormToMdiParent(new QuanLyDanhMucSanPhamForm(), this);
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void nạpNhanhDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppCommon.AddFormToMdiParent(new NhapXuatDuLieuForm(), this);
        }

        private void thốngKêToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
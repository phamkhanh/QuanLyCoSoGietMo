using ClosedXML.Excel;
using QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters;
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
using static QuanLyCoSoGietMo.AppData.AppDataSet;

namespace QuanLyCoSoGietMo.AppForm
{
    public partial class NhapXuatDuLieuForm : Form
    {
        public DateTime NgayNhapDuLieu
        {
            get { return dtpNgayNhapDuLieu.Value; }
            set { dtpNgayNhapDuLieu.Value = value; }
        }

        private string ExcelFileName = "GGTech_Data_";
        private string ExcelTemplate = "GGTech_DataTemplate";
        private string ExcelDataFolder = "\\data\\";
        private string ExcelExt = ".xlsx";

        private string ExcelPath
        {
            get
            {
                return Application.StartupPath + ExcelDataFolder + NgayNhapDuLieu.Year + "\\" + NgayNhapDuLieu.Month + "\\" + ExcelFileName + " " + NgayNhapDuLieu.Day + " " + NgayNhapDuLieu.Month + " " + NgayNhapDuLieu.Year + ExcelExt;
            }
        }

        private string ExcelTemplatePath
        {
            get
            {
                return Application.StartupPath + ExcelDataFolder + ExcelTemplate + ExcelExt;
            }
        }

        public NhapXuatDuLieuForm()
        {
            InitializeComponent();
        }

        private void btnMoFileExcelMau_Click(object sender, EventArgs e)
        {
            AppCommon.FileOpen(ExcelTemplatePath);
        }

        private void btnMoExcelTheoNgay_Click(object sender, EventArgs e)
        {
            if (!AppCommon.FileExists(ExcelPath))
            {
                DialogResult dr = MessageBox.Show("File không tồn tại. Bạn có muốn tạo file mới không?",
                      "Cơ sở giết mổ", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        AppCommon.FolderCopyFile(ExcelTemplatePath, ExcelPath);
                        AppCommon.FileOpen(ExcelPath);
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                AppCommon.FileOpen(ExcelPath);
            }
        }

        private void btnNapDanhMucTheoNgay_Click(object sender, EventArgs e)
        {
            if (!AppCommon.FileExists(ExcelPath))
            {
                DialogResult dr = MessageBox.Show("File không tồn tại. Bạn có muốn tạo file mới không?",
                      "Cơ sở giết mổ", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        AppCommon.FolderCopyFile(ExcelTemplatePath, ExcelPath);
                        break;
                    case DialogResult.No:
                        break;
                }
            }

            DoiTuongDataTable doiTuongTable = new DoiTuongDataTable();
            doiTuongTableAdapter.ClearBeforeFill = true;
            doiTuongTableAdapter.Fill(doiTuongTable);

            SanPhamDataTable sanPhamTable = new SanPhamDataTable();
            sanPhamTableAdapter.ClearBeforeFill = true;
            sanPhamTableAdapter.Fill(sanPhamTable);

            using (var workbook = new XLWorkbook(ExcelTemplatePath))
            {
                var workSheetDoiTuong = workbook.Worksheet("DoiTuong");
                int indexRowStart = 2;

                foreach (DataRow row in doiTuongTable.Rows)
                {
                    workSheetDoiTuong.Cell(String.Format("A{0}", indexRowStart)).Value = row["TenDoiTuong"];
                    workSheetDoiTuong.Cell(String.Format("B{0}", indexRowStart)).Value = row["Id"];

                    indexRowStart++;
                }

                var workSheetSanPham = workbook.Worksheet("SanPham");
                indexRowStart = 2;

                foreach (DataRow row in sanPhamTable.Rows)
                {
                    workSheetSanPham.Cell(String.Format("A{0}", indexRowStart)).Value = row["TenSanPham"];
                    workSheetSanPham.Cell(String.Format("B{0}", indexRowStart)).Value = row["Id"];

                    indexRowStart++;
                }
                workbook.Save();
            }

            using (var workbook = new XLWorkbook(ExcelPath))
            {
                var workSheetDoiTuong = workbook.Worksheet("DoiTuong");
                int indexRowStart = 2;

                foreach (DataRow row in doiTuongTable.Rows)
                {
                    workSheetDoiTuong.Cell(String.Format("A{0}", indexRowStart)).Value = row["TenDoiTuong"];
                    workSheetDoiTuong.Cell(String.Format("B{0}", indexRowStart)).Value = row["Id"];
                    indexRowStart++;
                }

                var workSheetSanPham = workbook.Worksheet("SanPham");
                indexRowStart = 2;

                foreach (DataRow row in sanPhamTable.Rows)
                {
                    workSheetSanPham.Cell(String.Format("A{0}", indexRowStart)).Value = row["TenSanPham"];
                    workSheetSanPham.Cell(String.Format("B{0}", indexRowStart)).Value = row["Id"];
                    indexRowStart++;
                }

                workbook.Save();
                AppCommon.FileOpen(ExcelPath);
            }
        }

        private void btnNapDuLieuTheoNgay_Click(object sender, EventArgs e)
        {
            if (!AppCommon.FileExists(ExcelPath))
            {
                DialogResult dr = MessageBox.Show("File không tồn tại. Bạn có muốn tạo file mới không?",
                      "Cơ sở giết mổ", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        AppCommon.FolderCopyFile(ExcelTemplatePath, ExcelPath);
                        AppCommon.FileOpen(ExcelPath);
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                int countRow = 0; // đếm dòng bị lỗi trong excel
                int countError = 0; // đếm lỗi

                using (var workbook = new XLWorkbook(ExcelPath))
                {
                    SoDuTangTableAdapter soDuTangTableAdapter = new SoDuTangTableAdapter();
                    SoDuTangDataTable tableSoDuTang = new SoDuTangDataTable();
                    DataRow dr;
                    var workSheetSoTheoDoiGiaoDich = workbook.Worksheet("SoTheoDoiGiaoDich");
                    var rows = workSheetSoTheoDoiGiaoDich.RangeUsed().RowsUsed().Skip(1); // Skip header row

                    int _nguoiChiTienId;
                    int _nguoiNhanTienId;
                    string _ghiChu;
                    int _nguoiVanChuyenId;
                    float _soLuong;
                    int _sanPhamId;
                    string _diaChi;
                    int _thuongLaiId;
                    int _daThanhToan;
                    string _ngayNhapHang;
                    decimal _soTien;

                    foreach (var row in rows)
                    {
                        try
                        {
                            countRow++;
                            _nguoiChiTienId = row.Cell("A").ValueCached == "#N/A" ? 0 : AppCommon.AppIntergerParse(row.Cell("A").Value.ToString());
                            _nguoiNhanTienId = row.Cell("B").ValueCached == "#N/A" ? 0 : AppCommon.AppIntergerParse(row.Cell("B").Value.ToString());
                            _ghiChu = row.Cell("F").Value.ToString();
                            _nguoiVanChuyenId = row.Cell("G").ValueCached == "#N/A" ? 0 : AppCommon.AppIntergerParse(row.Cell("G").Value.ToString());
                            _soLuong = row.Cell("I").ValueCached == "#N/A" ? 0 : AppCommon.AppIntergerParse(row.Cell("I").Value.ToString());
                            _sanPhamId = row.Cell("J").ValueCached == "#N/A" ? 0 : AppCommon.AppIntergerParse(row.Cell("J").Value.ToString());
                            _diaChi = row.Cell("L").Value.ToString();
                            _thuongLaiId = row.Cell("M").ValueCached == "#N/A" ? 0 : AppCommon.AppIntergerParse(row.Cell("M").Value.ToString());
                            _daThanhToan = row.Cell("O").ValueCached == "#N/A" ? 0 : AppCommon.AppIntergerParse(row.Cell("O").Value.ToString());
                            _ngayNhapHang = row.Cell("P").Value.ToString();
                            _soTien = AppCommon.AppDecimalParse(row.Cell("Q").Value.ToString());

                            dr = tableSoDuTang.NewRow();
                            dr["DoiTuongId"] = _nguoiChiTienId;
                            dr["SoTienTang"] = _soTien;
                            dr["NgayTang"] = NgayNhapDuLieu;
                            dr["GhiChuTang"] = AppCommon.StringUpperTitle(_ghiChu);
                            dr["RefSoDuGiamId"] = _nguoiNhanTienId;
                            tableSoDuTang.Rows.Add(dr);
                        }
                        catch (Exception ex)
                        {
                            countError++; // lỗi tăng lên 1 đơn vị
                            AppMsg.Instance.Red(lbMsgExcelToCSDL, "Lỗi nạp dữ liệu đến CSDL.\n" + ex.ToString());
                            break;
                        }
                    }

                    if (countError > 0) return; // nếu có lỗi thì không chạy dòng code bên dưới
                    //thuChiTableAdapter.ThuChiDeleteByNgayChi(DateTime.Parse(NgayNhapDuLieu.ToShortDateString()), DateTime.Parse(NgayNhapDuLieu.ToShortDateString() + " 11:59:59 PM"));
                    //thuChiTableAdapter.Update(tableThuChi);
                    AppMsg.Instance.Green(lbMsgExcelToCSDL, "Cập nhật dữ liệu thành công");
                }
            }
        }
    }
}

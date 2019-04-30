using ClosedXML.Excel;
using QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters;
using QuanLyCoSoGietMo.AppSupport;
using QuanLyCoSoGietMo.AppSupport.Const;
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
            dtpNgayNhapDuLieu.Value = new DateTime(2019, 4, 28);
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
                    NhatKyThuChiTableAdapter thuChiTableAdapter = new NhatKyThuChiTableAdapter();
                    NhatKyThuChiDataTable thuChiTable = new NhatKyThuChiDataTable();

                    NhatKyVanChuyenTableAdapter vanChuyenTableAdapter = new NhatKyVanChuyenTableAdapter();
                    NhatKyVanChuyenDataTable vanChuyenTable = new NhatKyVanChuyenDataTable();

                    NhatKyNhapHangTableAdapter nhapHangTableAdapter = new NhatKyNhapHangTableAdapter();
                    NhatKyNhapHangDataTable nhapHangTable = new NhatKyNhapHangDataTable();

                    DataRow dataRow;

                    var wsSoThuChi = workbook.Worksheet("SoThuChi");
                    var wsChiPhiVanChuyen = workbook.Worksheet("ChiPhiVanChuyen");

                    var rowsSoThuChi = wsSoThuChi.RangeUsed().RowsUsed().Skip(10); // Skip header row
                    var rowsChiPhiVanChuyen = wsChiPhiVanChuyen.RangeUsed().RowsUsed().Skip(1); // Skip header row

                    int _nhatKyThuChiDoiTuongId;
                    DateTime _nhatKyThuChiNgay;
                    string _nhatKyThuChiNoiDung;
                    decimal _nhatKyThuChiNo;
                    decimal _nhatKyThuChiCo;

                    int _nhatKyNhapHangThuongLaiId;
                    int _nhatKyNhapHangNguoiVanChuyenId;
                    int _nhatKyNhapHangSanPhamId;
                    float _nhatKyNhapHangSoLuong;
                    string _nhatKyNhapHangDiaChi;
                    decimal _nhatKyNhapHangDonGia;
                    decimal _nhatKyNhapHangThanhTien;
                    int _nhatKyNhapHangDaThanhToan;

                    int _nhatKyVanChuyenNguoiVanChuyenId;
                    int _nhatKyVanChuyenSanPhamId;
                    float _nhatKyVanChuyenSoLuong;
                    decimal _nhatKyVanChuyenThanhTien;
                    int _nhatKyVanChuyenDaThanhToan;
                    string _nhatKyVanChuyenGhiChu;

                    //------------------------------
                    foreach (var row in rowsSoThuChi)
                    {
                        countRow++;
                        try
                        {
                            // validation
                            if (string.IsNullOrEmpty(row.Cell(SheetSoThuChiColumn.Ten).Value.ToString())) // kiểm tra giá trị cột TÊN
                            {
                                countError++; // lỗi tăng lên 1 đơn vị
                                AppMsg.Instance.Red(lbMsgExcelToCSDL, string.Format("Lỗi nạp dữ liệu đến CSDL.\n Cột {0}, dòng {1} không hợp lệ.", SheetSoThuChiColumn.Ten, countRow));
                                break;
                            }
                            else if (!string.IsNullOrEmpty(row.Cell(SheetSoThuChiColumn.ThuongLai).Value.ToString())) // kiểm tra giá trị cột THƯƠNG LÁI
                            {
                                if (string.IsNullOrEmpty(row.Cell(SheetSoThuChiColumn.NguoiVanChuyen).Value.ToString()))    // kiểm tra giá trị cột NGƯỜI VẬN CHUYỂN
                                {
                                    countError++; // lỗi tăng lên 1 đơn vị
                                    AppMsg.Instance.Red(lbMsgExcelToCSDL, string.Format("Lỗi nạp dữ liệu đến CSDL.\n Cột {0}, dòng {1} không hợp lệ.", SheetSoThuChiColumn.NguoiVanChuyen, countRow));
                                    break;
                                }
                                else if (AppCommon.AppFloatParse(row.Cell(SheetSoThuChiColumn.SoLuong).Value.ToString()) <= 0)
                                {
                                    countError++; // lỗi tăng lên 1 đơn vị
                                    AppMsg.Instance.Red(lbMsgExcelToCSDL, string.Format("Lỗi nạp dữ liệu đến CSDL.\n Cột {0}, dòng {1} không hợp lệ.", SheetSoThuChiColumn.SoLuong, countRow));
                                    break;
                                }
                                else if (string.IsNullOrEmpty(row.Cell(SheetSoThuChiColumn.SanPham).Value.ToString()))
                                {
                                    countError++; // lỗi tăng lên 1 đơn vị
                                    AppMsg.Instance.Red(lbMsgExcelToCSDL, string.Format("Lỗi nạp dữ liệu đến CSDL.\n Cột {0}, dòng {1} không hợp lệ.", SheetSoThuChiColumn.SanPham, countRow));
                                    break;
                                }
                                else if (AppCommon.AppIntergerParse(row.Cell(SheetSoThuChiColumn.DaThanhToan).Value.ToString()) < 0)
                                {
                                    countError++; // lỗi tăng lên 1 đơn vị
                                    AppMsg.Instance.Red(lbMsgExcelToCSDL, string.Format("Lỗi nạp dữ liệu đến CSDL.\n Cột {0}, dòng {1} không hợp lệ.", SheetSoThuChiColumn.DaThanhToan, countRow));
                                    break;
                                }
                                else
                                {
                                    _nhatKyNhapHangThuongLaiId = AppCommon.AppIntergerParse(row.Cell(SheetSoThuChiColumn.ThuongLaiId).Value.ToString());
                                    _nhatKyNhapHangNguoiVanChuyenId = AppCommon.AppIntergerParse(row.Cell(SheetSoThuChiColumn.NguoiVanChuyenId).Value.ToString());
                                    _nhatKyNhapHangSanPhamId = AppCommon.AppIntergerParse(row.Cell(SheetSoThuChiColumn.SanPhamId).Value.ToString());
                                    _nhatKyNhapHangSoLuong = AppCommon.AppFloatParse(row.Cell(SheetSoThuChiColumn.SoLuong).Value.ToString());
                                    _nhatKyNhapHangDiaChi = row.Cell(SheetSoThuChiColumn.DiaChi).Value.ToString();
                                    _nhatKyNhapHangDonGia = string.IsNullOrEmpty(row.Cell(SheetSoThuChiColumn.DonGia).Value.ToString()) ? 1 : AppCommon.AppDecimalParse(row.Cell(SheetSoThuChiColumn.DonGia).Value.ToString());
                                    _nhatKyNhapHangThanhTien = string.IsNullOrEmpty(row.Cell(SheetSoThuChiColumn.ThanhTien).Value.ToString()) ? 0 : AppCommon.AppDecimalParse(row.Cell(SheetSoThuChiColumn.ThanhTien).Value.ToString());
                                    _nhatKyNhapHangDaThanhToan = string.IsNullOrEmpty(row.Cell(SheetSoThuChiColumn.DaThanhToan).Value.ToString()) ? 1 : AppCommon.AppIntergerParse(row.Cell(SheetSoThuChiColumn.DaThanhToan).Value.ToString());

                                    dataRow = nhapHangTable.NewRow();
                                    dataRow[NhatKyNhapHangConst.ThuongLaiId] = _nhatKyNhapHangThuongLaiId;
                                    dataRow[NhatKyNhapHangConst.NguoiVanChuyenId] = _nhatKyNhapHangNguoiVanChuyenId;
                                    dataRow[NhatKyNhapHangConst.SanPhamId] = _nhatKyNhapHangSanPhamId;
                                    dataRow[NhatKyNhapHangConst.SoLuong] = _nhatKyNhapHangSoLuong;
                                    dataRow[NhatKyNhapHangConst.DiaChi] = _nhatKyNhapHangDiaChi;
                                    dataRow[NhatKyNhapHangConst.DonGia] = _nhatKyNhapHangDonGia;
                                    dataRow[NhatKyNhapHangConst.ThanhTien] = _nhatKyNhapHangThanhTien;
                                    dataRow[NhatKyNhapHangConst.DaThanhToan] = _nhatKyNhapHangDaThanhToan;
                                    dataRow[NhatKyNhapHangConst.NgayNhap] = dtpNgayNhapDuLieu.Value;
                                    nhapHangTable.Rows.Add(dataRow);
                                }
                            }
                            else
                            {
                                _nhatKyThuChiDoiTuongId = AppCommon.AppIntergerParse(row.Cell(SheetSoThuChiColumn.DoiTuongId).Value.ToString());
                                _nhatKyThuChiNgay = dtpNgayNhapDuLieu.Value;
                                _nhatKyThuChiNoiDung = row.Cell(SheetSoThuChiColumn.NoiDung).Value.ToString();
                                _nhatKyThuChiNo = AppCommon.AppDecimalParse( row.Cell(SheetSoThuChiColumn.No).Value.ToString());
                                _nhatKyThuChiCo = AppCommon.AppDecimalParse(row.Cell(SheetSoThuChiColumn.Co).Value.ToString());
                                dataRow = thuChiTable.NewRow();
                                dataRow[NhatKyThuChiConst.DoiTuongId] = _nhatKyThuChiDoiTuongId;
                                dataRow[NhatKyThuChiConst.Ngay] = _nhatKyThuChiNgay;
                                dataRow[NhatKyThuChiConst.NoiDung] = _nhatKyThuChiNoiDung;
                                dataRow[NhatKyThuChiConst.No] = _nhatKyThuChiNo;
                                dataRow[NhatKyThuChiConst.Co] = _nhatKyThuChiCo;
                                thuChiTable.Rows.Add(dataRow);
                            }
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

                    thuChiTableAdapter.v3_sp_delete_NhatKyThuChi_ByNgay(DateTime.Parse(NgayNhapDuLieu.ToShortDateString()));
                    nhapHangTableAdapter.v3_sp_delete_NhatKyNhapHang_ByNgayNhap(DateTime.Parse(NgayNhapDuLieu.ToShortDateString()));
                    nhapHangTableAdapter.Update(nhapHangTable);
                    thuChiTableAdapter.Update(thuChiTable);
                    AppMsg.Instance.Green(lbMsgExcelToCSDL, "Cập nhật dữ liệu thành công");
                    //------------------------------
                }
            }
        }
    }
}

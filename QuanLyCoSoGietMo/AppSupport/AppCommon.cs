using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyCoSoGietMo.AppSupport
{
    public class AppCommon
    {
        public static CultureInfo VNCulture = CultureInfo.GetCultureInfo("vi-VN");
        private static string[] ChuSo = new string[10] { " không", " một", " hai", " ba", " bốn", " năm", " sáu", " bảy", " tám", " chín" };
        private static string[] Tien = new string[6] { "", " nghìn", " triệu", " tỷ", " nghìn tỷ", " triệu tỷ" };
        // Hàm đọc số thành chữ

        private static string _AppSettingFileXml;
        public static string AppSettingFileXml
        {
            get { return _AppSettingFileXml; }
            set { _AppSettingFileXml = value; }
        }

        public static string StringUpperTitle(string input)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        public static void _FSaveSettingApp(string serverName, string database, string pagesize, string root = "<settings></settings>")
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(root);

            XmlElement newElem = doc.CreateElement("servername");
            newElem.InnerText = serverName;
            doc.DocumentElement.AppendChild(newElem);

            newElem = doc.CreateElement("database");
            newElem.InnerText = database;
            doc.DocumentElement.AppendChild(newElem);

            newElem = doc.CreateElement("pagesize");
            newElem.InnerText = pagesize;
            doc.DocumentElement.AppendChild(newElem);

            doc.Save(AppCommon.AppSettingFileXml);
        }

        public static string ReadNodeXml(string node, string fileName = null)
        {
            XmlDocument doc = new XmlDocument();
            string _value = "";
            string _fileName = "";
            if (fileName == null)
            {
                _fileName = AppSettingFileXml;
            }
            else
            {
                _fileName = fileName;
            }
            if (File.Exists(_fileName))
            {
                doc.Load(_fileName);
                _value = doc.SelectSingleNode(node).InnerText;
            }
            return _value;
        }

        public static void AddFormToMdiParent(Form frm, Form mdiParent)
        {
            bool _isExisted = false;

            if (mdiParent.MdiChildren.Count() == 0)
            {
                _isExisted = false;
            }
            else
            {
                foreach (Form tabItem in mdiParent.MdiChildren)
                {
                    //tabItem.WindowState = FormWindowState.Minimized;
                    tabItem.Close();
                }

                foreach (Form tabItem in mdiParent.MdiChildren)
                {
                    if (tabItem.Text == frm.Text)
                    {
                        tabItem.Activate();
                        tabItem.WindowState = FormWindowState.Maximized;
                        _isExisted = true;
                        break;
                    }
                }
            }

            if (!_isExisted)
            {
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.MdiParent = mdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.ControlBox = false;
                frm.Show();
            }
        }

        public static void FileOpen(string _path)
        {
            Process.Start(_path);
        }

        public static bool FileExists(string _path)
        {
            return File.Exists(_path);
        }

        public static void FolderCreate(string _path)
        {
            _path = Path.GetDirectoryName(_path);
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
        }

        public static void FolderCopyFile(string sourceFileName, string destinationFileName)
        {
            string directoryPath = Path.GetDirectoryName(destinationFileName);

            // If directory doesn't exist create one
            if (!Directory.Exists(directoryPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath);
            }
            File.Copy(sourceFileName, destinationFileName, true);
        }

        public static string ComboBoxGetStringValueMember(ComboBox comboBoxEx1)
        {
            object SelectedItem = comboBoxEx1.SelectedItem;
            return SelectedItem.ToString();
        }

        public static object ComboBoxGetValueMember(ComboBox comboBoxEx1)
        {
            if (comboBoxEx1.SelectedIndex >= 0)
            {
                DataRowView SelectedItem = (DataRowView)comboBoxEx1.SelectedItem;
                return SelectedItem.Row[comboBoxEx1.ValueMember];
            }
            else
            {
                return 0;
            }
        }

        public static string ComboBoxGetDisplayMember(ComboBox comboBoxEx1)
        {
            DataRowView SelectedItem = (DataRowView)comboBoxEx1.SelectedItem;
            return SelectedItem.Row[comboBoxEx1.DisplayMember].ToString();
        }

        public static void ComboBoxSetSelectedValue(ComboBox comboBoxEx1, int id)
        {
            int index = 0;
            for (index = 0; index < comboBoxEx1.Items.Count; index++)
                if (id == (int)((DataRowView)comboBoxEx1.Items[index])[comboBoxEx1.ValueMember]) break;
            comboBoxEx1.SelectedIndex = index;
        }

        public static void LogError(Exception ex)
        {
            //string path = Application.StartupPath + "\\Bug " + DateTime.Now.Year + " " + DateTime.Now.Month + " " + DateTime.Now.Day + " " + DateTime.Now.Hour + " " + DateTime.Now.Minute + " " + DateTime.Now.Second + ".txt";
            string path = Application.StartupPath + "\\Bug.txt";
            string content = string.Format("{0}/{1}/{2} {3}:{4}:{5} : ", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            content += ex.ToString() + Environment.NewLine + Environment.NewLine;
            System.IO.File.AppendAllText(@"" + path, content);
            Process.Start(Path.GetDirectoryName(path));
            Process.Start(path);
        }

        public static List<int> GetKeyGridView(DataGridView datagridview)
        {
            List<int> idKeys = new List<int>();
            idKeys.Clear();
            idKeys.Add(0);
            foreach (DataGridViewRow row in datagridview.SelectedRows)
            {
                idKeys.Add((int)row.Cells[0].Value);
            }
            return idKeys;
        }

        public static string GetCurrencyFormat(object value)
        {
            return String.Format("{0:#,###0}", value);
        }

        public static void ConvertDateTime(out DateTime dt, string _str1, string _strFormat1 = "dd/MM/yyyy")
        {
            dt = DateTime.ParseExact(_str1, _strFormat1, CultureInfo.InvariantCulture);
        }

        public static void DateTimeyyyyMMdd(out DateTime _dt, DateTime _datetime)
        {
            ConvertDateTime(out _dt, _datetime.ToString("yyyy/MM/dd"), "yyyy/MM/dd");
        }

        public static void FNumberToString(out string _str, object _baseStr)
        {
            _str = String.Format(VNCulture, "{0:0,0}", _baseStr);
        }

        public static string FNumberToString(object _baseStr)
        {
            return String.Format(AppCommon.VNCulture, "{0:0,0}", _baseStr);
        }

        public static void FStringToNumber(out string _str, object _baseStr)
        {
            _str = (string)String.Format(VNCulture, "{0:g}", _baseStr);
        }

        public static string FStringToNumber(object _baseStr)
        {
            return String.Format(VNCulture, "{0:g}", _baseStr);
        }

        public static int GetIdFromGridView(DataGridView gridview, int index)
        {
            return (int)gridview.Rows[index].Cells[0].Value;
        }

        public static int GetIdFromGridView(DataGridView gridview, int index, int cellIndex)
        {
            return (int)gridview.Rows[index].Cells[cellIndex].Value;
        }

        /// <summary>
        /// Sample:
        /// DataRowView drv = AppFunction.GetDataRowView(dgvSample);
        /// string original_hoten = drv.Row["HoTen"].ToString();
        /// </summary>
        /// <param name="gridview"></param>
        /// <returns></returns>
        public static DataRowView GetDataRowView(DataGridView gridview)
        {
            return (DataRowView)gridview.SelectedRows[0].DataBoundItem;
        }

        /// <summary>
        /// Lấy dữ liệu dòng đã chọn từ DataGridView dựa vào tên cột
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string GetDataRowViewByColumn(DataGridView gridview, string columnName)
        {
            return GetDataRowView(gridview).Row[columnName].ToString();
        }

        public static void SetAcceptButton(Form frm, Button buttonAccept)
        {
            if (frm.TopLevelControl is Form)
            {
                ((Form)frm.TopLevelControl).AcceptButton = buttonAccept;
            }
        }

        public static void SetAcceptButton(UserControl usercontrol, Button buttonAccept)
        {
            if (usercontrol.TopLevelControl is Form)
            {
                ((Form)usercontrol.TopLevelControl).AcceptButton = buttonAccept;
            }
        }

        public static string CreateFolder(string PathFolder)
        {
            if (!System.IO.Directory.Exists(PathFolder))
            {
                System.IO.Directory.CreateDirectory(PathFolder);
            }
            return PathFolder;
        }

        public static void SaveReport(ReportViewer reportViewer1, string ReportSaveFileName, bool deleted)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;
            byte[] bytes = reportViewer1.LocalReport.Render(
               "Word", null, out mimeType, out encoding,
                out extension,
               out streamids, out warnings);

            FileStream fs = new FileStream(@"" + ReportSaveFileName,
               FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
            if (MessageBox.Show("Đã lưu thành công. \n Bạn có muốn mở nó lên để chỉnh sửa không ?", "Hệ thống", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(ReportSaveFileName);
            }
        }

        public static void SaveReport(ReportViewer reportViewer1)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            string name = saveFileDialog1.FileName;
            name += ".doc";
            string mimeType;
            string encoding;
            string fileNameExtension = "doc";
            string[] streams;
            Microsoft.Reporting.WinForms.Warning[] warnings;

            Microsoft.Reporting.WinForms.Report report;
            if (reportViewer1.ProcessingMode == Microsoft.Reporting.WinForms.ProcessingMode.Local)
                report = reportViewer1.LocalReport;
            else
                report = reportViewer1.ServerReport;

            var bytes = report.Render("word", null,
                            Microsoft.Reporting.WinForms.PageCountMode.Actual, out mimeType,
                            out encoding, out fileNameExtension, out streams, out warnings);

            var path = string.Format(@"{0}", name);
            System.IO.File.WriteAllBytes(path, bytes);
            path = Path.GetDirectoryName(path);
            if (MessageBox.Show("Đã lưu thành công. \n Bạn có muốn mở thư mục chứa file đã lưu ?", "Hệ thống", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(path);
            }
        }

        public static void SaveReport(ReportViewer reportViewer1, string fileName)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = fileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;

                string mimeType;
                string encoding;
                string fileNameExtension = "doc";
                string[] streams;
                Microsoft.Reporting.WinForms.Warning[] warnings;

                Microsoft.Reporting.WinForms.Report report;
                if (reportViewer1.ProcessingMode == Microsoft.Reporting.WinForms.ProcessingMode.Local)
                    report = reportViewer1.LocalReport;
                else
                    report = reportViewer1.ServerReport;

                var bytes = report.Render("word", null,
                                Microsoft.Reporting.WinForms.PageCountMode.Actual, out mimeType,
                                out encoding, out fileNameExtension, out streams, out warnings);

                var path = string.Format(@"{0}", name);
                System.IO.File.WriteAllBytes(path, bytes);
                if (MessageBox.Show("Đã lưu thành công. \n Bạn có muốn mở thư mục chứa file đã lưu ?", "Hệ thống", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start(Path.GetDirectoryName(path));
                }
            }
        }

        public static void AppPanelMainClear(Panel PanelMain)
        {
            if (PanelMain.Controls.Count > 0)
            {
                PanelMain.Controls.RemoveAt(0);
            }
        }

        public static void AppShowChildForm(Panel PanelMain, Form ChildForm)
        {
            AppPanelMainClear(PanelMain);
            ChildForm.TopLevel = false;
            ChildForm.AutoScroll = true;
            PanelMain.Controls.Add(ChildForm);
            ChildForm.Show();
        }

        public static void AppRunFile(string FileName)
        {
            Process.Start(FileName);
        }

        public static DataTable ExcelToDataTable(string pathName, string sheetName)
        {
            DataTable tbContainer = new DataTable();
            string strConn = string.Empty;
            if (string.IsNullOrEmpty(sheetName)) { sheetName = "Sheet1"; }
            FileInfo file = new FileInfo(pathName);
            if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
            string extension = file.Extension;
            switch (extension)
            {
                case ".xls":
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;

                case ".xlsx":
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                    break;

                default:
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;
            }

            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";

            OleDbConnection cnnxls = new OleDbConnection(strConn);
            OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
            oda.Fill(tbContainer);
            return tbContainer;
        }

        public static void SetDataTable_To_Excel(DataTable dtTable, string PathFileName)
        {
            //Microsoft.Office.Interop.Excel.Application oXL = null;
            //Microsoft.Office.Interop.Excel._Workbook oWB = null;
            //Microsoft.Office.Interop.Excel._Worksheet oSheet = null;

            //try
            //{
            //    oXL = new Microsoft.Office.Interop.Excel.Application();
            //    oWB = oXL.Workbooks.Open(PathFileName);
            //    oSheet = String.IsNullOrEmpty(dtTable.TableName) ? (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet : (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets[dtTable.TableName];

            //    int indexColumnDataTable = 1;
            //    foreach (DataColumn column in dtTable.Columns)
            //    {
            //        oSheet.Cells[1, indexColumnDataTable] = column.ColumnName;
            //        indexColumnDataTable++;
            //    }
            //    oSheet.Cells[1, indexColumnDataTable] = "0:CHON" + dtTable.TableName;

            //    for (int i = 0; i < dtTable.Rows.Count; i++)
            //    {
            //        for (int x = 0; x < dtTable.Columns.Count; x++)
            //        {
            //            oSheet.Cells[i + 2, x + 1] = dtTable.Rows[i][x].ToString();
            //            if (x == dtTable.Columns.Count - 1)
            //            {
            //                //oSheet.Cells[i + 2, x + 2] = dtTable.Rows[i][0].ToString() + ":" + dtTable.Rows[i][1].ToString();//
            //                oSheet.Cells[i + 2, x + 2] = string.Format("=A{0}&\":\"&B{1}", i + 2, i + 2);
            //            }
            //        }
            //    }

            //    oWB.Save();
            //    Process.Start(Path.GetDirectoryName(PathFileName));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    if (oWB != null)
            //        oWB.Close();
            //    foreach (Process proc in Process.GetProcessesByName("EXCEL"))
            //    {
            //        proc.Kill();
            //    }
            //}
        }

        public static void SetDataTable_To_Excel2(DataTable dtTable, string PathFileName)
        {
            //Microsoft.Office.Interop.Excel.Application oXL = null;
            //Microsoft.Office.Interop.Excel._Workbook oWB = null;
            //Microsoft.Office.Interop.Excel._Worksheet oSheet = null;

            //try
            //{
            //    oXL = new Microsoft.Office.Interop.Excel.Application();
            //    oWB = oXL.Workbooks.Open(PathFileName);
            //    oSheet = String.IsNullOrEmpty(dtTable.TableName) ? (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet : (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets[dtTable.TableName];

            //    int indexColumnDataTable = 1;
            //    foreach (DataColumn column in dtTable.Columns)
            //    {
            //        oSheet.Cells[1, indexColumnDataTable] = column.ColumnName;
            //        indexColumnDataTable++;
            //    }
            //    oSheet.Cells[1, indexColumnDataTable] = "0:CHON" + dtTable.TableName;

            //    for (int i = 0; i < dtTable.Rows.Count; i++)
            //    {
            //        for (int x = 0; x < dtTable.Columns.Count; x++)
            //        {
            //            oSheet.Cells[i + 2, x + 1] = dtTable.Rows[i][x].ToString();
            //            if (x == dtTable.Columns.Count - 1)
            //            {
            //                //oSheet.Cells[i + 2, x + 2] = dtTable.Rows[i][0].ToString() + ":" + dtTable.Rows[i][1].ToString();//
            //                oSheet.Cells[i + 2, x + 2] = string.Format("=A{0}", i + 2);
            //            }
            //        }
            //    }

            //    oWB.Save();
            //    //Process.Start(Path.GetDirectoryName(PathFileName));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    if (oWB != null)
            //        oWB.Close();
            //    foreach (Process proc in Process.GetProcessesByName("EXCEL"))
            //    {
            //        proc.Kill();
            //    }
            //}
        }

        public static bool AppIsDatetime(String datetime)
        {
            try
            {
                DateTime.Parse(datetime);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }

        public static double AppDoubleParse(string doublenumber)
        {
            try
            {
                return Double.Parse(doublenumber);
            }
            catch (Exception exc)
            {
                return 0;
            }
        }

        public static int AppIntergerParse(string intNumber)
        {
            try
            {
                return Int32.Parse(intNumber);
            }
            catch (Exception exc)
            {
                return 0;
            }
        }

        public static float AppFloatParse(string floatNumber)
        {
            try
            {
                return float.Parse(floatNumber);
            }
            catch (Exception exc)
            {
                return 0;
            }
        }

        public static decimal AppDecimalParse(string DecimalNumber)
        {
            try
            {
                return Decimal.Parse(DecimalNumber);
            }
            catch (Exception exc)
            {
                return 0;
            }
        }

        public static string AppGetExecutePath()
        {
            return Application.StartupPath;
        }

        public static DateTime AppSqlDate(DateTime _stringdatetime)
        {
            try
            {
                return DateTime.Parse(_stringdatetime.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                return _stringdatetime;
            }
        }

        public static DateTime AppSqlDateTime(DateTime _stringdatetime)
        {
            try
            {
                return DateTime.Parse(_stringdatetime.ToString("yyyy-MM-dd HH:mm"));
            }
            catch (Exception ex)
            {
                return _stringdatetime;
            }
        }

        public static string DocTienBangChu(decimal SoTien, string strTail)
        {
            int lan, i;
            decimal so;
            string KetQua = "", tmp = "";
            bool FlagPositive = false;
            int[] ViTri = new int[6];
            //if (SoTien < 0) return "Số tiền âm !";
            if (SoTien < 0)
            {
                SoTien = SoTien * -1;
                FlagPositive = true;
            }
            Console.WriteLine(SoTien);
            if (SoTien == 0) return "Không đồng !";
            if (SoTien > 0)
            {
                so = SoTien;
            }
            else
            {
                so = -SoTien;
            }
            //Kiểm tra số quá lớn
            if (SoTien > 8999999999999999)
            {
                SoTien = 0;
                return "";
            }
            ViTri[5] = (int)(so / 1000000000000000);
            so = so - long.Parse(ViTri[5].ToString()) * 1000000000000000;
            ViTri[4] = (int)(so / 1000000000000);
            so = so - long.Parse(ViTri[4].ToString()) * +1000000000000;
            ViTri[3] = (int)(so / 1000000000);
            so = so - long.Parse(ViTri[3].ToString()) * 1000000000;
            ViTri[2] = (int)(so / 1000000);
            ViTri[1] = (int)((so % 1000000) / 1000);
            ViTri[0] = (int)(so % 1000);
            if (ViTri[5] > 0)
            {
                lan = 5;
            }
            else if (ViTri[4] > 0)
            {
                lan = 4;
            }
            else if (ViTri[3] > 0)
            {
                lan = 3;
            }
            else if (ViTri[2] > 0)
            {
                lan = 2;
            }
            else if (ViTri[1] > 0)
            {
                lan = 1;
            }
            else
            {
                lan = 0;
            }
            for (i = lan; i >= 0; i--)
            {
                tmp = DocSo3ChuSo(ViTri[i]);
                KetQua += tmp;
                if (ViTri[i] != 0) KetQua += Tien[i];
                if ((i > 0) && (!string.IsNullOrEmpty(tmp))) KetQua += ",";//&& (!string.IsNullOrEmpty(tmp))
            }
            if (KetQua.Substring(KetQua.Length - 1, 1) == ",") KetQua = KetQua.Substring(0, KetQua.Length - 1);
            KetQua = KetQua.Trim() + strTail;
            if (FlagPositive)
            {
                KetQua = "Âm " + KetQua;
            }
            return KetQua.Substring(0, 1).ToUpper() + KetQua.Substring(1);
        }

        // Hàm đọc số có 3 chữ số
        private static string DocSo3ChuSo(int baso)
        {
            int tram, chuc, donvi;
            string KetQua = "";
            tram = (int)(baso / 100);
            chuc = (int)((baso % 100) / 10);
            donvi = baso % 10;
            if ((tram == 0) && (chuc == 0) && (donvi == 0)) return "";
            if (tram != 0)
            {
                KetQua += ChuSo[tram] + " trăm";
                if ((chuc == 0) && (donvi != 0)) KetQua += " linh";
            }
            if ((chuc != 0) && (chuc != 1))
            {
                KetQua += ChuSo[chuc] + " mươi";
                if ((chuc == 0) && (donvi != 0)) KetQua = KetQua + " linh";
            }
            if (chuc == 1) KetQua += " mười";
            switch (donvi)
            {
                case 1:
                    if ((chuc != 0) && (chuc != 1))
                    {
                        KetQua += " mốt";
                    }
                    else
                    {
                        KetQua += ChuSo[donvi];
                    }
                    break;

                case 5:
                    if (chuc == 0)
                    {
                        KetQua += ChuSo[donvi];
                    }
                    else
                    {
                        KetQua += " lăm";
                    }
                    break;

                default:
                    if (donvi != 0)
                    {
                        KetQua += ChuSo[donvi];
                    }
                    break;
            }
            return KetQua;
        }

        public static void Log(params object[] args)
        {
            foreach (object arg in args)
            {
                if (arg.GetType().IsArray)
                {
                    Array arg2 = (Array)arg;
                    for (int i = 0; i < arg2.Length; i++)
                    {
                        Console.WriteLine(arg2.GetValue(i));
                    }
                }
                else
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}

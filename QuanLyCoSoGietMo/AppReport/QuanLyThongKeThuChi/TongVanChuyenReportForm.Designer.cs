namespace QuanLyCoSoGietMo.AppReport.QuanLyThongKeThuChi
{
    partial class TongVanChuyenReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.appDataSet = new QuanLyCoSoGietMo.AppData.AppDataSet();
            this.v3_View_ChiTietNhatKyNhapHangTableAdapter = new QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters.V3_View_ChiTietNhatKyNhapHangTableAdapter();
            this.v3_View_ChiTietNhatKyVanChuyenTableAdapter = new QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters.V3_View_ChiTietNhatKyVanChuyenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCoSoGietMo.AppReport.QuanLyThongKeThuChi.TongVanChuyenReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(884, 1011);
            this.reportViewer1.TabIndex = 0;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v3_View_ChiTietNhatKyNhapHangTableAdapter
            // 
            this.v3_View_ChiTietNhatKyNhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // v3_View_ChiTietNhatKyVanChuyenTableAdapter
            // 
            this.v3_View_ChiTietNhatKyVanChuyenTableAdapter.ClearBeforeFill = true;
            // 
            // TongVanChuyenReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 1011);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TongVanChuyenReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê vận chuyển";
            this.Load += new System.EventHandler(this.TongVanChuyenReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AppData.AppDataSet appDataSet;
        private AppData.AppDataSetTableAdapters.V3_View_ChiTietNhatKyNhapHangTableAdapter v3_View_ChiTietNhatKyNhapHangTableAdapter;
        private AppData.AppDataSetTableAdapters.V3_View_ChiTietNhatKyVanChuyenTableAdapter v3_View_ChiTietNhatKyVanChuyenTableAdapter;
    }
}
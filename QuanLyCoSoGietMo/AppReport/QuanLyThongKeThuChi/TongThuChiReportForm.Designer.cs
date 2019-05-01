namespace QuanLyCoSoGietMo.AppReport.QuanLyThongKeThuChi
{
    partial class TongThuChiReportForm
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
            this.v3_View_ChiTietNhatKyChiTableAdapter = new QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters.V3_View_ChiTietNhatKyChiTableAdapter();
            this.v3_View_ChiTietNhatKyThuTableAdapter = new QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters.V3_View_ChiTietNhatKyThuTableAdapter();
            this.appDataSet = new QuanLyCoSoGietMo.AppData.AppDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // v3_View_ChiTietNhatKyChiTableAdapter
            // 
            this.v3_View_ChiTietNhatKyChiTableAdapter.ClearBeforeFill = true;
            // 
            // v3_View_ChiTietNhatKyThuTableAdapter
            // 
            this.v3_View_ChiTietNhatKyThuTableAdapter.ClearBeforeFill = true;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCoSoGietMo.AppReport.QuanLyThongKeThuChi.TongThuChiReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(884, 1011);
            this.reportViewer1.TabIndex = 0;
            // 
            // TongThuChiReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 1011);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TongThuChiReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng thu - chi ";
            this.Load += new System.EventHandler(this.TongThuChiReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AppData.AppDataSetTableAdapters.V3_View_ChiTietNhatKyChiTableAdapter v3_View_ChiTietNhatKyChiTableAdapter;
        private AppData.AppDataSetTableAdapters.V3_View_ChiTietNhatKyThuTableAdapter v3_View_ChiTietNhatKyThuTableAdapter;
        private AppData.AppDataSet appDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
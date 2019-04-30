namespace QuanLyCoSoGietMo.AppForm
{
    partial class NhapXuatDuLieuForm
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayNhapDuLieu = new System.Windows.Forms.DateTimePicker();
            this.btnNapDanhMucTheoNgay = new System.Windows.Forms.Button();
            this.btnNapDuLieuTheoNgay = new System.Windows.Forms.Button();
            this.btnMoExcelTheoNgay = new System.Windows.Forms.Button();
            this.btnMoFileExcelMau = new System.Windows.Forms.Button();
            this.lbMsgExcelToCSDL = new System.Windows.Forms.Label();
            this.doiTuongTableAdapter = new QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters.DoiTuongTableAdapter();
            this.sanPhamTableAdapter = new QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters.SanPhamTableAdapter();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(523, 38);
            this.panelTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP - XUẤT DỮ LIỆU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày";
            // 
            // dtpNgayNhapDuLieu
            // 
            this.dtpNgayNhapDuLieu.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpNgayNhapDuLieu.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpNgayNhapDuLieu.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpNgayNhapDuLieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhapDuLieu.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpNgayNhapDuLieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhapDuLieu.Location = new System.Drawing.Point(69, 44);
            this.dtpNgayNhapDuLieu.Name = "dtpNgayNhapDuLieu";
            this.dtpNgayNhapDuLieu.Size = new System.Drawing.Size(148, 33);
            this.dtpNgayNhapDuLieu.TabIndex = 14;
            this.dtpNgayNhapDuLieu.TabStop = false;
            // 
            // btnNapDanhMucTheoNgay
            // 
            this.btnNapDanhMucTheoNgay.BackColor = System.Drawing.Color.Green;
            this.btnNapDanhMucTheoNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapDanhMucTheoNgay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNapDanhMucTheoNgay.Location = new System.Drawing.Point(48, 169);
            this.btnNapDanhMucTheoNgay.Name = "btnNapDanhMucTheoNgay";
            this.btnNapDanhMucTheoNgay.Size = new System.Drawing.Size(211, 70);
            this.btnNapDanhMucTheoNgay.TabIndex = 10;
            this.btnNapDanhMucTheoNgay.Text = "Đồng bộ Danh mục\r\nTừ CSDL --> Excel";
            this.btnNapDanhMucTheoNgay.UseVisualStyleBackColor = false;
            this.btnNapDanhMucTheoNgay.Click += new System.EventHandler(this.btnNapDanhMucTheoNgay_Click);
            // 
            // btnNapDuLieuTheoNgay
            // 
            this.btnNapDuLieuTheoNgay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNapDuLieuTheoNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapDuLieuTheoNgay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNapDuLieuTheoNgay.Location = new System.Drawing.Point(265, 169);
            this.btnNapDuLieuTheoNgay.Name = "btnNapDuLieuTheoNgay";
            this.btnNapDuLieuTheoNgay.Size = new System.Drawing.Size(211, 70);
            this.btnNapDuLieuTheoNgay.TabIndex = 11;
            this.btnNapDuLieuTheoNgay.Text = "Đồng bộ Dữ liệu\r\nTừ Excel --> CSDL";
            this.btnNapDuLieuTheoNgay.UseVisualStyleBackColor = false;
            this.btnNapDuLieuTheoNgay.Click += new System.EventHandler(this.btnNapDuLieuTheoNgay_Click);
            // 
            // btnMoExcelTheoNgay
            // 
            this.btnMoExcelTheoNgay.BackColor = System.Drawing.Color.Gold;
            this.btnMoExcelTheoNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoExcelTheoNgay.ForeColor = System.Drawing.Color.Red;
            this.btnMoExcelTheoNgay.Location = new System.Drawing.Point(265, 93);
            this.btnMoExcelTheoNgay.Name = "btnMoExcelTheoNgay";
            this.btnMoExcelTheoNgay.Size = new System.Drawing.Size(211, 70);
            this.btnMoExcelTheoNgay.TabIndex = 12;
            this.btnMoExcelTheoNgay.Text = "Mở Excel theo ngày";
            this.btnMoExcelTheoNgay.UseVisualStyleBackColor = false;
            this.btnMoExcelTheoNgay.Click += new System.EventHandler(this.btnMoExcelTheoNgay_Click);
            // 
            // btnMoFileExcelMau
            // 
            this.btnMoFileExcelMau.BackColor = System.Drawing.Color.Red;
            this.btnMoFileExcelMau.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFileExcelMau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoFileExcelMau.Location = new System.Drawing.Point(48, 93);
            this.btnMoFileExcelMau.Name = "btnMoFileExcelMau";
            this.btnMoFileExcelMau.Size = new System.Drawing.Size(211, 70);
            this.btnMoFileExcelMau.TabIndex = 13;
            this.btnMoFileExcelMau.Text = "Mở Excel Mẫu";
            this.btnMoFileExcelMau.UseVisualStyleBackColor = false;
            this.btnMoFileExcelMau.Click += new System.EventHandler(this.btnMoFileExcelMau_Click);
            // 
            // lbMsgExcelToCSDL
            // 
            this.lbMsgExcelToCSDL.AutoSize = true;
            this.lbMsgExcelToCSDL.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsgExcelToCSDL.Location = new System.Drawing.Point(223, 50);
            this.lbMsgExcelToCSDL.Name = "lbMsgExcelToCSDL";
            this.lbMsgExcelToCSDL.Size = new System.Drawing.Size(0, 25);
            this.lbMsgExcelToCSDL.TabIndex = 16;
            this.lbMsgExcelToCSDL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doiTuongTableAdapter
            // 
            this.doiTuongTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // NhapXuatDuLieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 248);
            this.Controls.Add(this.lbMsgExcelToCSDL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayNhapDuLieu);
            this.Controls.Add(this.btnNapDanhMucTheoNgay);
            this.Controls.Add(this.btnNapDuLieuTheoNgay);
            this.Controls.Add(this.btnMoExcelTheoNgay);
            this.Controls.Add(this.btnMoFileExcelMau);
            this.Controls.Add(this.panelTitle);
            this.Name = "NhapXuatDuLieuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập - Xuất dữ liệu";
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapDuLieu;
        private System.Windows.Forms.Button btnNapDanhMucTheoNgay;
        private System.Windows.Forms.Button btnNapDuLieuTheoNgay;
        private System.Windows.Forms.Button btnMoExcelTheoNgay;
        private System.Windows.Forms.Button btnMoFileExcelMau;
        private System.Windows.Forms.Label lbMsgExcelToCSDL;
        private AppData.AppDataSetTableAdapters.DoiTuongTableAdapter doiTuongTableAdapter;
        private AppData.AppDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
    }
}
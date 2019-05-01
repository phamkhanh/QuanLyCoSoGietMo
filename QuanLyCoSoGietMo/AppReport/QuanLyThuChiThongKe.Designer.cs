namespace QuanLyCoSoGietMo.AppReport
{
    partial class QuanLyThuChiThongKe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtonFunction = new System.Windows.Forms.Panel();
            this.cbbDoiTuong = new System.Windows.Forms.ComboBox();
            this.doiTuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSet = new QuanLyCoSoGietMo.AppData.AppDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpThuChiTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpThuChiDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXuatNguoiVanChuyen = new System.Windows.Forms.Button();
            this.btnXuatTongThuChi = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.dgvThongKeThuChi = new System.Windows.Forms.DataGridView();
            this.doiTuongTableAdapter = new QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters.DoiTuongTableAdapter();
            this.panelTitle.SuspendLayout();
            this.panelButtonFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeThuChi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1305, 38);
            this.panelTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1305, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ THU - CHI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonFunction
            // 
            this.panelButtonFunction.BackColor = System.Drawing.SystemColors.Info;
            this.panelButtonFunction.Controls.Add(this.cbbDoiTuong);
            this.panelButtonFunction.Controls.Add(this.label2);
            this.panelButtonFunction.Controls.Add(this.label4);
            this.panelButtonFunction.Controls.Add(this.label3);
            this.panelButtonFunction.Controls.Add(this.dtpThuChiTuNgay);
            this.panelButtonFunction.Controls.Add(this.dtpThuChiDenNgay);
            this.panelButtonFunction.Controls.Add(this.btnXuatNguoiVanChuyen);
            this.panelButtonFunction.Controls.Add(this.btnXuatTongThuChi);
            this.panelButtonFunction.Controls.Add(this.btnXem);
            this.panelButtonFunction.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonFunction.Location = new System.Drawing.Point(0, 38);
            this.panelButtonFunction.Name = "panelButtonFunction";
            this.panelButtonFunction.Size = new System.Drawing.Size(352, 619);
            this.panelButtonFunction.TabIndex = 8;
            // 
            // cbbDoiTuong
            // 
            this.cbbDoiTuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDoiTuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDoiTuong.DataSource = this.doiTuongBindingSource;
            this.cbbDoiTuong.DisplayMember = "TenDoiTuong";
            this.cbbDoiTuong.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbbDoiTuong.FormattingEnabled = true;
            this.cbbDoiTuong.Location = new System.Drawing.Point(139, 11);
            this.cbbDoiTuong.Name = "cbbDoiTuong";
            this.cbbDoiTuong.Size = new System.Drawing.Size(193, 33);
            this.cbbDoiTuong.TabIndex = 10;
            this.cbbDoiTuong.ValueMember = "Id";
            // 
            // doiTuongBindingSource
            // 
            this.doiTuongBindingSource.DataMember = "DoiTuong";
            this.doiTuongBindingSource.DataSource = this.appDataSet;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đối tượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày";
            // 
            // dtpThuChiTuNgay
            // 
            this.dtpThuChiTuNgay.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpThuChiTuNgay.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpThuChiTuNgay.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpThuChiTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpThuChiTuNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpThuChiTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThuChiTuNgay.Location = new System.Drawing.Point(139, 50);
            this.dtpThuChiTuNgay.Name = "dtpThuChiTuNgay";
            this.dtpThuChiTuNgay.Size = new System.Drawing.Size(193, 33);
            this.dtpThuChiTuNgay.TabIndex = 8;
            this.dtpThuChiTuNgay.TabStop = false;
            // 
            // dtpThuChiDenNgay
            // 
            this.dtpThuChiDenNgay.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpThuChiDenNgay.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpThuChiDenNgay.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpThuChiDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpThuChiDenNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpThuChiDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThuChiDenNgay.Location = new System.Drawing.Point(139, 89);
            this.dtpThuChiDenNgay.Name = "dtpThuChiDenNgay";
            this.dtpThuChiDenNgay.Size = new System.Drawing.Size(193, 33);
            this.dtpThuChiDenNgay.TabIndex = 8;
            this.dtpThuChiDenNgay.TabStop = false;
            // 
            // btnXuatNguoiVanChuyen
            // 
            this.btnXuatNguoiVanChuyen.BackColor = System.Drawing.Color.Salmon;
            this.btnXuatNguoiVanChuyen.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatNguoiVanChuyen.ForeColor = System.Drawing.Color.White;
            this.btnXuatNguoiVanChuyen.Location = new System.Drawing.Point(17, 206);
            this.btnXuatNguoiVanChuyen.Name = "btnXuatNguoiVanChuyen";
            this.btnXuatNguoiVanChuyen.Size = new System.Drawing.Size(315, 33);
            this.btnXuatNguoiVanChuyen.TabIndex = 1;
            this.btnXuatNguoiVanChuyen.Text = "Xuất phiếu theo tài xế";
            this.btnXuatNguoiVanChuyen.UseVisualStyleBackColor = false;
            this.btnXuatNguoiVanChuyen.Click += new System.EventHandler(this.btnXuatDoiTuong_Click);
            // 
            // btnXuatTongThuChi
            // 
            this.btnXuatTongThuChi.BackColor = System.Drawing.Color.Blue;
            this.btnXuatTongThuChi.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatTongThuChi.ForeColor = System.Drawing.Color.Transparent;
            this.btnXuatTongThuChi.Location = new System.Drawing.Point(17, 167);
            this.btnXuatTongThuChi.Name = "btnXuatTongThuChi";
            this.btnXuatTongThuChi.Size = new System.Drawing.Size(315, 33);
            this.btnXuatTongThuChi.TabIndex = 1;
            this.btnXuatTongThuChi.Text = "Xuất phiếu Tổng thu chi";
            this.btnXuatTongThuChi.UseVisualStyleBackColor = false;
            this.btnXuatTongThuChi.Click += new System.EventHandler(this.btnXuatTongThuChi_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(139, 128);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(193, 33);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // dgvThongKeThuChi
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKeThuChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongKeThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeThuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeThuChi.Location = new System.Drawing.Point(352, 38);
            this.dgvThongKeThuChi.Name = "dgvThongKeThuChi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKeThuChi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongKeThuChi.Size = new System.Drawing.Size(953, 619);
            this.dgvThongKeThuChi.TabIndex = 9;
            // 
            // doiTuongTableAdapter
            // 
            this.doiTuongTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyThuChiThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 657);
            this.Controls.Add(this.dgvThongKeThuChi);
            this.Controls.Add(this.panelButtonFunction);
            this.Controls.Add(this.panelTitle);
            this.Name = "QuanLyThuChiThongKe";
            this.Text = "THỐNG KÊ THU - CHI";
            this.Load += new System.EventHandler(this.QuanLyThuChiThongKe_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelButtonFunction.ResumeLayout(false);
            this.panelButtonFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeThuChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtonFunction;
        private System.Windows.Forms.ComboBox cbbDoiTuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpThuChiTuNgay;
        private System.Windows.Forms.DateTimePicker dtpThuChiDenNgay;
        private System.Windows.Forms.Button btnXuatNguoiVanChuyen;
        private System.Windows.Forms.Button btnXuatTongThuChi;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgvThongKeThuChi;
        private AppData.AppDataSet appDataSet;
        private System.Windows.Forms.BindingSource doiTuongBindingSource;
        private AppData.AppDataSetTableAdapters.DoiTuongTableAdapter doiTuongTableAdapter;
    }
}
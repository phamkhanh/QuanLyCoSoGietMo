namespace QuanLyCoSoGietMo.AppForm
{
    partial class QuanLyDanhMucNguoiVanChuyenForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtonFunction = new System.Windows.Forms.Panel();
            this.lbMsg = new System.Windows.Forms.Label();
            this.txtTimHoTen = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvNguoiVanChuyen = new System.Windows.Forms.DataGridView();
            this.appDataSet = new QuanLyCoSoGietMo.AppData.AppDataSet();
            this.nguoiVanChuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiVanChuyenTableAdapter = new QuanLyCoSoGietMo.AppData.AppDataSetTableAdapters.NguoiVanChuyenTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiVanChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitle.SuspendLayout();
            this.panelButtonFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiVanChuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiVanChuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 38);
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
            this.label1.Size = new System.Drawing.Size(800, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH MỤC NGƯỜI VẬN CHUYỂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonFunction
            // 
            this.panelButtonFunction.BackColor = System.Drawing.SystemColors.Info;
            this.panelButtonFunction.Controls.Add(this.lbMsg);
            this.panelButtonFunction.Controls.Add(this.txtTimHoTen);
            this.panelButtonFunction.Controls.Add(this.btnLuu);
            this.panelButtonFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonFunction.Location = new System.Drawing.Point(0, 38);
            this.panelButtonFunction.Name = "panelButtonFunction";
            this.panelButtonFunction.Size = new System.Drawing.Size(800, 47);
            this.panelButtonFunction.TabIndex = 7;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.Location = new System.Drawing.Point(371, 10);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 25);
            this.lbMsg.TabIndex = 7;
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimHoTen
            // 
            this.txtTimHoTen.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimHoTen.Location = new System.Drawing.Point(34, 7);
            this.txtTimHoTen.Name = "txtTimHoTen";
            this.txtTimHoTen.Size = new System.Drawing.Size(217, 33);
            this.txtTimHoTen.TabIndex = 5;
            this.txtTimHoTen.TextChanged += new System.EventHandler(this.txtTimHoTen_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(257, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 34);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu bảng";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvNguoiVanChuyen
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Yellow;
            this.dgvNguoiVanChuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNguoiVanChuyen.AutoGenerateColumns = false;
            this.dgvNguoiVanChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNguoiVanChuyen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvNguoiVanChuyen.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguoiVanChuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNguoiVanChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiVanChuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenNguoiVanChuyenDataGridViewTextBoxColumn});
            this.dgvNguoiVanChuyen.DataSource = this.nguoiVanChuyenBindingSource;
            this.dgvNguoiVanChuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguoiVanChuyen.Location = new System.Drawing.Point(0, 85);
            this.dgvNguoiVanChuyen.Name = "dgvNguoiVanChuyen";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguoiVanChuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNguoiVanChuyen.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNguoiVanChuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguoiVanChuyen.Size = new System.Drawing.Size(800, 365);
            this.dgvNguoiVanChuyen.TabIndex = 10;
            this.dgvNguoiVanChuyen.TabStop = false;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiVanChuyenBindingSource
            // 
            this.nguoiVanChuyenBindingSource.DataMember = "NguoiVanChuyen";
            this.nguoiVanChuyenBindingSource.DataSource = this.appDataSet;
            // 
            // nguoiVanChuyenTableAdapter
            // 
            this.nguoiVanChuyenTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 52;
            // 
            // tenNguoiVanChuyenDataGridViewTextBoxColumn
            // 
            this.tenNguoiVanChuyenDataGridViewTextBoxColumn.DataPropertyName = "TenNguoiVanChuyen";
            this.tenNguoiVanChuyenDataGridViewTextBoxColumn.HeaderText = "TenNguoiVanChuyen";
            this.tenNguoiVanChuyenDataGridViewTextBoxColumn.Name = "tenNguoiVanChuyenDataGridViewTextBoxColumn";
            this.tenNguoiVanChuyenDataGridViewTextBoxColumn.Width = 237;
            // 
            // QuanLyDanhMucNguoiVanChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvNguoiVanChuyen);
            this.Controls.Add(this.panelButtonFunction);
            this.Controls.Add(this.panelTitle);
            this.Name = "QuanLyDanhMucNguoiVanChuyen";
            this.Text = "QuanLyDanhMucNguoiVanChuyen";
            this.Load += new System.EventHandler(this.QuanLyDanhMucNguoiVanChuyen_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelButtonFunction.ResumeLayout(false);
            this.panelButtonFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiVanChuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiVanChuyenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtonFunction;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.TextBox txtTimHoTen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvNguoiVanChuyen;
        private AppData.AppDataSet appDataSet;
        private System.Windows.Forms.BindingSource nguoiVanChuyenBindingSource;
        private AppData.AppDataSetTableAdapters.NguoiVanChuyenTableAdapter nguoiVanChuyenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiVanChuyenDataGridViewTextBoxColumn;
    }
}
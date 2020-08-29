namespace GUI.UserControls
{
    partial class ReportUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvReportCar = new System.Windows.Forms.DataGridView();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbbTypeReport = new System.Windows.Forms.ComboBox();
            this.gbRepot = new System.Windows.Forms.GroupBox();
            this.cbCar = new System.Windows.Forms.CheckBox();
            this.cbbCar = new System.Windows.Forms.ComboBox();
            this.cbReportRevenue = new System.Windows.Forms.CheckBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportRevenue = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportCar)).BeginInit();
            this.gbRepot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportCar
            // 
            this.dgvReportCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvReportCar.Location = new System.Drawing.Point(4, 313);
            this.dgvReportCar.Name = "dgvReportCar";
            this.dgvReportCar.Size = new System.Drawing.Size(1227, 381);
            this.dgvReportCar.TabIndex = 1;
            this.dgvReportCar.Visible = false;
            // 
            // btnReview
            // 
            this.btnReview.Image = global::GUI.Properties.Resources.Actions_file_open_icon;
            this.btnReview.Location = new System.Drawing.Point(314, 243);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(163, 49);
            this.btnReview.TabIndex = 3;
            this.btnReview.Text = "Xem báo cáo";
            this.btnReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::GUI.Properties.Resources.Microsoft_Excel_2013_icon;
            this.btnExport.Location = new System.Drawing.Point(711, 243);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(163, 49);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbbTypeReport
            // 
            this.cbbTypeReport.Enabled = false;
            this.cbbTypeReport.FormattingEnabled = true;
            this.cbbTypeReport.Items.AddRange(new object[] {
            "Báo cáo theo ngày",
            "Báo cáo theo tuần",
            "Báo cáo theo tháng"});
            this.cbbTypeReport.Location = new System.Drawing.Point(183, 29);
            this.cbbTypeReport.Name = "cbbTypeReport";
            this.cbbTypeReport.Size = new System.Drawing.Size(190, 29);
            this.cbbTypeReport.TabIndex = 1;
            this.cbbTypeReport.Text = "---Chọn loại báo cáo---";
            // 
            // gbRepot
            // 
            this.gbRepot.Controls.Add(this.cbbCar);
            this.gbRepot.Controls.Add(this.cbCar);
            this.gbRepot.Controls.Add(this.cbReportRevenue);
            this.gbRepot.Controls.Add(this.cbbTypeReport);
            this.gbRepot.Location = new System.Drawing.Point(79, 59);
            this.gbRepot.Name = "gbRepot";
            this.gbRepot.Size = new System.Drawing.Size(531, 178);
            this.gbRepot.TabIndex = 5;
            this.gbRepot.TabStop = false;
            this.gbRepot.Text = "Báo cáo";
            // 
            // cbCar
            // 
            this.cbCar.Location = new System.Drawing.Point(7, 75);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(170, 29);
            this.cbCar.TabIndex = 3;
            this.cbCar.Text = "Báo cáo xe";
            this.cbCar.UseVisualStyleBackColor = true;
            this.cbCar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbbCar
            // 
            this.cbbCar.Enabled = false;
            this.cbbCar.FormattingEnabled = true;
            this.cbbCar.Items.AddRange(new object[] {
            "Số xe có trong kho",
            "Số xe đã cho thuê"});
            this.cbbCar.Location = new System.Drawing.Point(183, 75);
            this.cbbCar.Name = "cbbCar";
            this.cbbCar.Size = new System.Drawing.Size(190, 29);
            this.cbbCar.TabIndex = 4;
            this.cbbCar.Text = "---Chọn loại báo cáo---";
            // 
            // cbReportRevenue
            // 
            this.cbReportRevenue.Location = new System.Drawing.Point(7, 29);
            this.cbReportRevenue.Name = "cbReportRevenue";
            this.cbReportRevenue.Size = new System.Drawing.Size(170, 29);
            this.cbReportRevenue.TabIndex = 0;
            this.cbReportRevenue.Text = "Báo cáo doanh thu";
            this.cbReportRevenue.UseVisualStyleBackColor = true;
            this.cbReportRevenue.CheckedChanged += new System.EventHandler(this.cbReportRevenue_CheckedChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên xe";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "NumCar";
            this.Column2.HeaderText = "Biển số xe";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Status";
            this.Column3.HeaderText = "Tình trạng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NumberOfCar";
            this.Column4.HeaderText = "Số lượng còn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DateAddCar";
            this.Column5.HeaderText = "Ngày nhập";
            this.Column5.Name = "Column5";
            // 
            // dgvReportRevenue
            // 
            this.dgvReportRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column7,
            this.dataGridViewTextBoxColumn4,
            this.Column6,
            this.dataGridViewTextBoxColumn5});
            this.dgvReportRevenue.Location = new System.Drawing.Point(4, 313);
            this.dgvReportRevenue.Name = "dgvReportRevenue";
            this.dgvReportRevenue.Size = new System.Drawing.Size(1227, 381);
            this.dgvReportRevenue.TabIndex = 6;
            this.dgvReportRevenue.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hoá đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nhân viên ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CreateDay";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày tạo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "CusName";
            this.Column7.HeaderText = "Tên khách hàng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NameCar";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên xe";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "NumCar";
            this.Column6.HeaderText = "Biển số xe";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvReportRevenue);
            this.Controls.Add(this.gbRepot);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.dgvReportCar);
            this.Controls.Add(this.btnExport);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReportUC";
            this.Size = new System.Drawing.Size(1234, 697);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportCar)).EndInit();
            this.gbRepot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvReportCar;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.ComboBox cbbTypeReport;
        private System.Windows.Forms.GroupBox gbRepot;
        private System.Windows.Forms.ComboBox cbbCar;
        private System.Windows.Forms.CheckBox cbCar;
        private System.Windows.Forms.CheckBox cbReportRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dgvReportRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

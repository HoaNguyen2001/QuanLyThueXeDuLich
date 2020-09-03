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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportUC));
            this.dgvReportCar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbbTypeReport = new System.Windows.Forms.ComboBox();
            this.gbRepot = new System.Windows.Forms.GroupBox();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.cbbCar = new System.Windows.Forms.ComboBox();
            this.cbCar = new System.Windows.Forms.CheckBox();
            this.cbReportRevenue = new System.Windows.Forms.CheckBox();
            this.dgvReportRevenue = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUocTinh = new System.Windows.Forms.GroupBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportCar)).BeginInit();
            this.gbRepot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportRevenue)).BeginInit();
            this.gbUocTinh.SuspendLayout();
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
            resources.ApplyResources(this.dgvReportCar, "dgvReportCar");
            this.dgvReportCar.Name = "dgvReportCar";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "NumCar";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Status";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NumberOfCar";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DateAddCar";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // btnReview
            // 
            this.btnReview.Image = global::GUI.Properties.Resources.Actions_file_open_icon;
            resources.ApplyResources(this.btnReview, "btnReview");
            this.btnReview.Name = "btnReview";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Image = global::GUI.Properties.Resources.Microsoft_Excel_2013_icon;
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbbTypeReport
            // 
            resources.ApplyResources(this.cbbTypeReport, "cbbTypeReport");
            this.cbbTypeReport.FormattingEnabled = true;
            this.cbbTypeReport.Items.AddRange(new object[] {
            resources.GetString("cbbTypeReport.Items"),
            resources.GetString("cbbTypeReport.Items1"),
            resources.GetString("cbbTypeReport.Items2"),
            resources.GetString("cbbTypeReport.Items3")});
            this.cbbTypeReport.Name = "cbbTypeReport";
            this.cbbTypeReport.SelectedIndexChanged += new System.EventHandler(this.cbbTypeReport_SelectedIndexChanged);
            // 
            // gbRepot
            // 
            this.gbRepot.Controls.Add(this.dtpEndDay);
            this.gbRepot.Controls.Add(this.dtpStartDay);
            this.gbRepot.Controls.Add(this.cbbCar);
            this.gbRepot.Controls.Add(this.cbCar);
            this.gbRepot.Controls.Add(this.cbReportRevenue);
            this.gbRepot.Controls.Add(this.cbbTypeReport);
            resources.ApplyResources(this.gbRepot, "gbRepot");
            this.gbRepot.Name = "gbRepot";
            this.gbRepot.TabStop = false;
            // 
            // dtpEndDay
            // 
            resources.ApplyResources(this.dtpEndDay, "dtpEndDay");
            this.dtpEndDay.Name = "dtpEndDay";
            // 
            // dtpStartDay
            // 
            resources.ApplyResources(this.dtpStartDay, "dtpStartDay");
            this.dtpStartDay.Name = "dtpStartDay";
            // 
            // cbbCar
            // 
            resources.ApplyResources(this.cbbCar, "cbbCar");
            this.cbbCar.FormattingEnabled = true;
            this.cbbCar.Items.AddRange(new object[] {
            resources.GetString("cbbCar.Items"),
            resources.GetString("cbbCar.Items1")});
            this.cbbCar.Name = "cbbCar";
            // 
            // cbCar
            // 
            resources.ApplyResources(this.cbCar, "cbCar");
            this.cbCar.Name = "cbCar";
            this.cbCar.UseVisualStyleBackColor = true;
            this.cbCar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbReportRevenue
            // 
            resources.ApplyResources(this.cbReportRevenue, "cbReportRevenue");
            this.cbReportRevenue.Name = "cbReportRevenue";
            this.cbReportRevenue.UseVisualStyleBackColor = true;
            this.cbReportRevenue.CheckedChanged += new System.EventHandler(this.cbReportRevenue_CheckedChanged);
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
            resources.ApplyResources(this.dgvReportRevenue, "dgvReportRevenue");
            this.dgvReportRevenue.Name = "dgvReportRevenue";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CreateDay";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "CusName";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NameCar";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "NumCar";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalPrice";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // gbUocTinh
            // 
            this.gbUocTinh.Controls.Add(this.txtTotalAmount);
            this.gbUocTinh.Controls.Add(this.label2);
            this.gbUocTinh.Controls.Add(this.txtTotalBill);
            this.gbUocTinh.Controls.Add(this.label1);
            resources.ApplyResources(this.gbUocTinh, "gbUocTinh");
            this.gbUocTinh.Name = "gbUocTinh";
            this.gbUocTinh.TabStop = false;
            // 
            // txtTotalAmount
            // 
            resources.ApplyResources(this.txtTotalAmount, "txtTotalAmount");
            this.txtTotalAmount.Name = "txtTotalAmount";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtTotalBill
            // 
            resources.ApplyResources(this.txtTotalBill, "txtTotalBill");
            this.txtTotalBill.Name = "txtTotalBill";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ReportUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUocTinh);
            this.Controls.Add(this.dgvReportRevenue);
            this.Controls.Add(this.gbRepot);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.dgvReportCar);
            this.Controls.Add(this.btnExport);
            this.Name = "ReportUC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportCar)).EndInit();
            this.gbRepot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportRevenue)).EndInit();
            this.gbUocTinh.ResumeLayout(false);
            this.gbUocTinh.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbUocTinh;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
    }
}

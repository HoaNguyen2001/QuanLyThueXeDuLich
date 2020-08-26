namespace GUI.UserControls
{
    partial class EmployeeUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListEmp = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbTypeSearch = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListEmp
            // 
            this.dgvListEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvListEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListEmp.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvListEmp.Location = new System.Drawing.Point(5, 370);
            this.dgvListEmp.Margin = new System.Windows.Forms.Padding(5);
            this.dgvListEmp.Name = "dgvListEmp";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvListEmp.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListEmp.Size = new System.Drawing.Size(1224, 322);
            this.dgvListEmp.TabIndex = 0;
            this.dgvListEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListEmp_CellClick);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "ID";
            this.Column5.HeaderText = "Mã nhân viên";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên nhân viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Birthday";
            this.Column2.HeaderText = "Sinh nhật";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Address";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Phone";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(121, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(297, 114);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 28);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(667, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sinh nhật";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(298, 179);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(261, 28);
            this.txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(842, 116);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(261, 28);
            this.txtPhone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(667, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(842, 59);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(261, 29);
            this.dtpBirthday.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::GUI.Properties.Resources.Actions_document_edit_icon;
            this.btnEdit.Location = new System.Drawing.Point(393, 276);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 44);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::GUI.Properties.Resources.Actions_edit_delete_icon;
            this.btnDelete.Location = new System.Drawing.Point(564, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 44);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::GUI.Properties.Resources.Windows_Restart_icon;
            this.btnReset.Location = new System.Drawing.Point(735, 276);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 44);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::GUI.Properties.Resources.red_search_icon;
            this.btnSearch.Location = new System.Drawing.Point(906, 276);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 44);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbTypeSearch
            // 
            this.cbbTypeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeSearch.FormattingEnabled = true;
            this.cbbTypeSearch.Items.AddRange(new object[] {
            "Họ tên",
            "Địa chỉ"});
            this.cbbTypeSearch.Location = new System.Drawing.Point(842, 181);
            this.cbbTypeSearch.Name = "cbbTypeSearch";
            this.cbbTypeSearch.Size = new System.Drawing.Size(262, 29);
            this.cbbTypeSearch.TabIndex = 20;
            this.cbbTypeSearch.Text = "---Tìm kiếm theo---";
            this.cbbTypeSearch.SelectedIndexChanged += new System.EventHandler(this.cbbTypeSearch_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(297, 58);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(261, 28);
            this.txtID.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(121, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã nhân viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(667, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tìm kiếm theo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(122, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::GUI.Properties.Resources.Actions_list_add_user_icon;
            this.btnAdd.Location = new System.Drawing.Point(221, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 44);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.lamborghini_centenario_2017_1600_01_1514410005837;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbTypeSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListEmp);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(1234, 697);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbTypeSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

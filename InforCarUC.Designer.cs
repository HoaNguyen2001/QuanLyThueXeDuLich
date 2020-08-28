namespace GUI.UserControls
{
    partial class InforCarUC
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
            this.dtpNamSanXuat = new System.Windows.Forms.DateTimePicker();
            this.grTinhTrang = new System.Windows.Forms.GroupBox();
            this.rdbCu = new System.Windows.Forms.RadioButton();
            this.rdbMoi = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMauSon = new System.Windows.Forms.TextBox();
            this.txtGiaMoiNgay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.dtpNgayDangKi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHangXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDangKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMoiNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grTinhTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNamSanXuat
            // 
            this.dtpNamSanXuat.CustomFormat = "dd-MM-yyyy";
            this.dtpNamSanXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNamSanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamSanXuat.Location = new System.Drawing.Point(953, 158);
            this.dtpNamSanXuat.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNamSanXuat.Name = "dtpNamSanXuat";
            this.dtpNamSanXuat.Size = new System.Drawing.Size(231, 29);
            this.dtpNamSanXuat.TabIndex = 150;
            // 
            // grTinhTrang
            // 
            this.grTinhTrang.Controls.Add(this.rdbCu);
            this.grTinhTrang.Controls.Add(this.rdbMoi);
            this.grTinhTrang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grTinhTrang.Location = new System.Drawing.Point(392, 152);
            this.grTinhTrang.Margin = new System.Windows.Forms.Padding(5);
            this.grTinhTrang.Name = "grTinhTrang";
            this.grTinhTrang.Padding = new System.Windows.Forms.Padding(5);
            this.grTinhTrang.Size = new System.Drawing.Size(355, 110);
            this.grTinhTrang.TabIndex = 148;
            this.grTinhTrang.TabStop = false;
            this.grTinhTrang.Text = "Tình trạng";
            // 
            // rdbCu
            // 
            this.rdbCu.AutoSize = true;
            this.rdbCu.Location = new System.Drawing.Point(230, 47);
            this.rdbCu.Margin = new System.Windows.Forms.Padding(5);
            this.rdbCu.Name = "rdbCu";
            this.rdbCu.Size = new System.Drawing.Size(52, 26);
            this.rdbCu.TabIndex = 1;
            this.rdbCu.TabStop = true;
            this.rdbCu.Text = "Cũ";
            this.rdbCu.UseVisualStyleBackColor = true;
            // 
            // rdbMoi
            // 
            this.rdbMoi.AutoSize = true;
            this.rdbMoi.Location = new System.Drawing.Point(50, 47);
            this.rdbMoi.Margin = new System.Windows.Forms.Padding(5);
            this.rdbMoi.Name = "rdbMoi";
            this.rdbMoi.Size = new System.Drawing.Size(62, 26);
            this.rdbMoi.TabIndex = 0;
            this.rdbMoi.TabStop = true;
            this.rdbMoi.Text = "Mới";
            this.rdbMoi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(813, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 144;
            this.label8.Text = "Biển số xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(392, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 142;
            this.label1.Text = "Ngày đăng kí";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.Image = global::GUI.Properties.Resources.Windows_Restart_icon;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(577, 318);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(125, 42);
            this.btnLamMoi.TabIndex = 141;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbbTimKiemTheo
            // 
            this.cbbTimKiemTheo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTimKiemTheo.FormattingEnabled = true;
            this.cbbTimKiemTheo.Items.AddRange(new object[] {
            "Tên xe",
            "Hãng xe",
            "Biển số xe"});
            this.cbbTimKiemTheo.Location = new System.Drawing.Point(944, 329);
            this.cbbTimKiemTheo.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTimKiemTheo.Name = "cbbTimKiemTheo";
            this.cbbTimKiemTheo.Size = new System.Drawing.Size(186, 29);
            this.cbbTimKiemTheo.TabIndex = 140;
            this.cbbTimKiemTheo.Text = "---Tìm kiếm theo---";
            this.cbbTimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.cbbTimKiemTheo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(946, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 139;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(109, 93);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(251, 29);
            this.txtTenXe.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 137;
            this.label6.Text = "Tên xe";
            // 
            // txtMauSon
            // 
            this.txtMauSon.Location = new System.Drawing.Point(523, 36);
            this.txtMauSon.Margin = new System.Windows.Forms.Padding(5);
            this.txtMauSon.Name = "txtMauSon";
            this.txtMauSon.Size = new System.Drawing.Size(224, 29);
            this.txtMauSon.TabIndex = 129;
            // 
            // txtGiaMoiNgay
            // 
            this.txtGiaMoiNgay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaMoiNgay.Location = new System.Drawing.Point(953, 95);
            this.txtGiaMoiNgay.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiaMoiNgay.Name = "txtGiaMoiNgay";
            this.txtGiaMoiNgay.Size = new System.Drawing.Size(231, 29);
            this.txtGiaMoiNgay.TabIndex = 147;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(813, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 22);
            this.label9.TabIndex = 146;
            this.label9.Text = "Giá mỗi ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(813, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 149;
            this.label5.Text = "Năm sản xuất";
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBienSoXe.Location = new System.Drawing.Point(953, 36);
            this.txtBienSoXe.Margin = new System.Windows.Forms.Padding(5);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(231, 29);
            this.txtBienSoXe.TabIndex = 145;
            // 
            // dtpNgayDangKi
            // 
            this.dtpNgayDangKi.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayDangKi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayDangKi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDangKi.Location = new System.Drawing.Point(523, 95);
            this.dtpNgayDangKi.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNgayDangKi.Name = "dtpNgayDangKi";
            this.dtpNgayDangKi.Size = new System.Drawing.Size(226, 29);
            this.dtpNgayDangKi.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(392, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 127;
            this.label4.Text = "Màu sơn";
            // 
            // txtHangXe
            // 
            this.txtHangXe.Location = new System.Drawing.Point(109, 158);
            this.txtHangXe.Margin = new System.Windows.Forms.Padding(5);
            this.txtHangXe.Name = "txtHangXe";
            this.txtHangXe.Size = new System.Drawing.Size(251, 29);
            this.txtHangXe.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 128;
            this.label3.Text = "Hãng xe";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Enabled = false;
            this.txtMaXe.Location = new System.Drawing.Point(109, 36);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(251, 29);
            this.txtMaXe.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 126;
            this.label2.Text = "Mã xe";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::GUI.Properties.Resources.Actions_document_edit_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(258, 318);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 40);
            this.btnSua.TabIndex = 134;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::GUI.Properties.Resources.vw_beetle_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(64, 318);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 40);
            this.btnThem.TabIndex = 133;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.red_search_icon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(755, 318);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(131, 40);
            this.btnTimKiem.TabIndex = 136;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenXe,
            this.HangXe,
            this.MauSon,
            this.NgayDangKi,
            this.TinhTrang,
            this.BienSoXe,
            this.GiaMoiNgay,
            this.NamSX,
            this.SoLuong,
            this.NgayNhap});
            this.dgvXe.Location = new System.Drawing.Point(7, 386);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(5);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.Size = new System.Drawing.Size(1224, 353);
            this.dgvXe.TabIndex = 132;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::GUI.Properties.Resources.Actions_edit_delete_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(418, 318);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 40);
            this.btnXoa.TabIndex = 135;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(109, 221);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(251, 29);
            this.txtSoLuong.TabIndex = 152;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(14, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 151;
            this.label10.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(814, 221);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 22);
            this.label11.TabIndex = 153;
            this.label11.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(953, 215);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(231, 29);
            this.dtpNgayNhap.TabIndex = 154;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Mã Xe";
            this.ID.Name = "ID";
            // 
            // TenXe
            // 
            this.TenXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenXe.HeaderText = "Tên Xe";
            this.TenXe.Name = "TenXe";
            // 
            // HangXe
            // 
            this.HangXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HangXe.HeaderText = "Hãng Xe";
            this.HangXe.Name = "HangXe";
            // 
            // MauSon
            // 
            this.MauSon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MauSon.HeaderText = "Màu Sơn";
            this.MauSon.Name = "MauSon";
            // 
            // NgayDangKi
            // 
            this.NgayDangKi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDangKi.HeaderText = "Ngày Đăng Kí";
            this.NgayDangKi.Name = "NgayDangKi";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // BienSoXe
            // 
            this.BienSoXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BienSoXe.HeaderText = "Biển Số Xe";
            this.BienSoXe.Name = "BienSoXe";
            // 
            // GiaMoiNgay
            // 
            this.GiaMoiNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaMoiNgay.HeaderText = "Giá Mỗi Ngày";
            this.GiaMoiNgay.Name = "GiaMoiNgay";
            // 
            // NamSX
            // 
            this.NamSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamSX.HeaderText = "Năm SX";
            this.NamSX.Name = "NamSX";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 80;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // InforCarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources._818372dc919f7b2e5246c443579bcd11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpNamSanXuat);
            this.Controls.Add(this.grTinhTrang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cbbTimKiemTheo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMauSon);
            this.Controls.Add(this.txtGiaMoiNgay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.dtpNgayDangKi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHangXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.btnXoa);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InforCarUC";
            this.Size = new System.Drawing.Size(1234, 697);
            this.grTinhTrang.ResumeLayout(false);
            this.grTinhTrang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNamSanXuat;
        private System.Windows.Forms.GroupBox grTinhTrang;
        private System.Windows.Forms.RadioButton rdbCu;
        private System.Windows.Forms.RadioButton rdbMoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cbbTimKiemTheo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMauSon;
        private System.Windows.Forms.TextBox txtGiaMoiNgay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBienSoXe;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHangXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMoiNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
    }
}

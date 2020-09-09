using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI.UserControls
{
    public partial class InforCarUC : UserControl
    {
        String connstring = @"Data Source = HOANGUYEN; Initial Catalog = QLXeDuLich; Integrated Security = True";
        SqlConnection conn = new SqlConnection();
        public InforCarUC()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(connstring);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from InforCar", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int index = 0;
            dgvXe.ColumnCount = 11;
            dgvXe.Rows.Clear();
            while (dr.Read())
            {
                dgvXe.Rows.Add();
                dgvXe.Rows[index].Cells[0].Value = dr["ID"];
                dgvXe.Rows[index].Cells[1].Value = dr["Name"];
                dgvXe.Rows[index].Cells[2].Value = dr["ManufacturerCar"];
                dgvXe.Rows[index].Cells[3].Value = dr["Color"];
                dgvXe.Rows[index].Cells[4].Value = dr["RegistrationDate"];
                if (dr["Status"].Equals(rdbMoi.Text))
                {
                    dgvXe.Rows[index].Cells[5].Value = rdbMoi.Text;
                }
                else
                {
                    dgvXe.Rows[index].Cells[5].Value = rdbCu.Text;
                }
                dgvXe.Rows[index].Cells[6].Value = dr["NumCar"];
                dgvXe.Rows[index].Cells[7].Value = dr["PricePerDay"];
                dgvXe.Rows[index].Cells[8].Value = dr["ManufactureYear"];
                dgvXe.Rows[index].Cells[9].Value = dr["NumberOfCar"];
                dgvXe.Rows[index].Cells[10].Value = dr["DateAddCar"];
                index++;
            }
        }

        private void SetNull()
        {
            txtMaXe.Text = "";
            txtTenXe.Text = "";
            txtHangXe.Text = "";
            txtMauSon.Text = "";
            dtpNgayDangKi.Value = DateTime.Now;
            rdbMoi.Checked = false;
            rdbCu.Checked = false;
            cbbTimKiemTheo.SelectedIndex = -1;
            cbbTimKiemTheo.Text = "---Tìm kiếm theo---";
            txtBienSoXe.Text = "";
            txtGiaMoiNgay.Text = "";
            dtpNamSanXuat.Value = DateTime.Now;
            dtpNgayNhap.Value = DateTime.Now;
            txtSoLuong.Text = "";
        }
        int row;
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtMaXe.Text = dgvXe.Rows[row].Cells[0].Value.ToString();
                txtTenXe.Text = dgvXe.Rows[row].Cells[1].Value.ToString();
                txtHangXe.Text = dgvXe.Rows[row].Cells[2].Value.ToString();
                txtMauSon.Text = dgvXe.Rows[row].Cells[3].Value.ToString();
                dtpNgayDangKi.Text = dgvXe.Rows[row].Cells[4].Value.ToString();
                if (dgvXe.Rows[row].Cells[5].Value.Equals(rdbMoi.Text))
                {
                    rdbMoi.Checked = true;
                }
                else
                {
                    rdbCu.Checked = true;
                }
                txtBienSoXe.Text = dgvXe.Rows[row].Cells[6].Value.ToString();
                txtGiaMoiNgay.Text = dgvXe.Rows[row].Cells[7].Value.ToString();
                dtpNamSanXuat.Text = dgvXe.Rows[row].Cells[8].Value.ToString();
                txtSoLuong.Text= dgvXe.Rows[row].Cells[9].Value.ToString();
                dtpNgayNhap.Text = dgvXe.Rows[row].Cells[10].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Bạn có muốn thêm {txtTenXe.Text} ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string sql = "Insert into InforCar values (@Name, @ManufacturerCar, @Color, @RegistrationDate, @Status, @NumCar, @PricePerDay, @ManufactureYear, @NumberOfCar, @DateAddCar)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.Parameters.AddWithValue("@ID", txtMaXe.Text);
                    cmd.Parameters.AddWithValue("@Name", txtTenXe.Text);
                    cmd.Parameters.AddWithValue("@ManufacturerCar", txtHangXe.Text);
                    cmd.Parameters.AddWithValue("@Color", txtMauSon.Text);
                    cmd.Parameters.AddWithValue("@RegistrationDate", dtpNgayDangKi.Value);
                    if (rdbMoi.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Status", rdbMoi.Text);
                    }
                    else
                    {

                        cmd.Parameters.AddWithValue("@Status", rdbCu.Text);
                    }
                    cmd.Parameters.AddWithValue("@NumCar", Int32.Parse(txtBienSoXe.Text));
                    cmd.Parameters.AddWithValue("@PricePerDay", Int32.Parse(txtGiaMoiNgay.Text));
                    cmd.Parameters.AddWithValue("@ManufactureYear", dtpNamSanXuat.Value);
                    cmd.Parameters.AddWithValue("@NumberOfCar", Int32.Parse(txtSoLuong.Text));
                    cmd.Parameters.AddWithValue("@DateAddCar", dtpNgayNhap.Value);
                    cmd.ExecuteNonQuery();

                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    LoadData();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Bạn muốn sửa xe {txtTenXe.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string sql = "Update InforCar set Name=@Name, ManufacturerCar=@ManufacturerCar, Color=@Color, RegistrationDate=@RegistrationDate, Status=@Status, NumCar=@NumCar, PricePerDay=@PricePerDay, ManufactureYear=@ManufactureYear, NumberOfCar=@NumberOfCar, DateAddCar=@DateAddCar Where ID='" + txtMaXe.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Name", txtTenXe.Text);
                    cmd.Parameters.AddWithValue("@ManufacturerCar", txtHangXe.Text);
                    cmd.Parameters.AddWithValue("@Color", txtMauSon.Text);
                    cmd.Parameters.AddWithValue("@RegistrationDate", dtpNgayDangKi.Value);
                    if (rdbMoi.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Status", rdbMoi.Text);
                    }
                    else
                    {

                        cmd.Parameters.AddWithValue("@Status", rdbCu.Text);
                    }
                    cmd.Parameters.AddWithValue("@NumCar", Int32.Parse(txtBienSoXe.Text));
                    cmd.Parameters.AddWithValue("@PricePerDay", Int32.Parse(txtGiaMoiNgay.Text));
                    cmd.Parameters.AddWithValue("@ManufactureYear", dtpNamSanXuat.Value);
                    cmd.Parameters.AddWithValue("@NumberOfCar", Int32.Parse(txtSoLuong.Text));
                    cmd.Parameters.AddWithValue("@DateAddCar", dtpNgayNhap.Value);
                    cmd.ExecuteNonQuery();

                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    LoadData();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Bạn muốn xoá xe {txtTenXe.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete from InforCar Where ID='" + txtMaXe.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            SetNull();
            LoadData();
        }

        private void cbbTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbbTimKiemTheo.SelectedIndex;

            switch (index)
            {
                case 0://tìm kiếm theo tên xe
                    txtTenXe.Enabled = true;
                    txtBienSoXe.Enabled = false;
                    txtHangXe.Enabled = false;
                    txtGiaMoiNgay.Enabled = false;
                    rdbMoi.Enabled = false;
                    rdbCu.Enabled = false;
                    txtMauSon.Enabled = false;
                    dtpNgayDangKi.Enabled = false;
                    dtpNamSanXuat.Enabled = false;
                    txtMaXe.Enabled = false;
                    txtSoLuong.Enabled = false;
                    dtpNgayNhap.Enabled = false;
                    break;

                case 1://tìm kiếm theo hãng xe
                    txtTenXe.Enabled = false;
                    txtBienSoXe.Enabled = false;
                    txtHangXe.Enabled = true;
                    txtGiaMoiNgay.Enabled = false;
                    rdbMoi.Enabled = false;
                    rdbCu.Enabled = false;
                    txtMauSon.Enabled = false;
                    dtpNgayDangKi.Enabled = false;
                    dtpNamSanXuat.Enabled = false;
                    txtMaXe.Enabled = false;
                    txtSoLuong.Enabled = false;
                    dtpNgayNhap.Enabled = false;
                    break;

                case 2://tìm kiếm theo biển số xe
                    txtTenXe.Enabled = false;
                    txtBienSoXe.Enabled = true;
                    txtHangXe.Enabled = false;
                    txtGiaMoiNgay.Enabled = false;
                    rdbMoi.Enabled = false;
                    rdbCu.Enabled = false;
                    txtMauSon.Enabled = false;
                    dtpNgayDangKi.Enabled = false;
                    dtpNamSanXuat.Enabled = false;
                    txtMaXe.Enabled = false;
                    txtSoLuong.Enabled = false;
                    dtpNgayNhap.Enabled = false;
                    break;

                default:
                    txtTenXe.Enabled = true;
                    txtBienSoXe.Enabled = true;
                    txtHangXe.Enabled = true;
                    txtGiaMoiNgay.Enabled = true;
                    rdbMoi.Enabled = true;
                    rdbCu.Enabled = true;
                    txtMauSon.Enabled = true;
                    dtpNgayDangKi.Enabled = true;
                    dtpNamSanXuat.Enabled = true;
                    txtMaXe.Enabled = true;
                    txtSoLuong.Enabled = true;
                    dtpNgayNhap.Enabled = true;
                    break;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var index = cbbTimKiemTheo.SelectedIndex;

                switch (index)
                {
                    case 0://tìm kiếm theo tên xe
                        String sql0 = "Select * from InforCar Where Name=N'" + txtTenXe.Text + "'";
                        SqlCommand cmd0 = new SqlCommand(sql0, conn);
                        cmd0.ExecuteNonQuery();
                        SqlDataReader dr0 = cmd0.ExecuteReader();
                        int i0 = 0;
                        dgvXe.ColumnCount = 11;
                        dgvXe.Rows.Clear();
                        while (dr0.Read())
                        {
                            dgvXe.Rows.Add();
                            dgvXe.Rows[i0].Cells[0].Value = dr0["ID"];
                            dgvXe.Rows[i0].Cells[1].Value = dr0["Name"];
                            dgvXe.Rows[i0].Cells[2].Value = dr0["ManufacturerCar"];
                            dgvXe.Rows[i0].Cells[3].Value = dr0["Color"];
                            dgvXe.Rows[i0].Cells[4].Value = dr0["RegistrationDate"];
                            if (dr0["Status"].Equals(rdbMoi.Text))
                            {
                                dgvXe.Rows[i0].Cells[5].Value = rdbMoi.Text;
                            }
                            else
                            {
                                dgvXe.Rows[i0].Cells[5].Value = rdbCu.Text;
                            }
                            dgvXe.Rows[i0].Cells[6].Value = dr0["NumCar"];
                            dgvXe.Rows[i0].Cells[7].Value = dr0["PricePerDay"];
                            dgvXe.Rows[i0].Cells[8].Value = dr0["ManufactureYear"];
                            dgvXe.Rows[i0].Cells[9].Value = dr0["NumberOfCar"];
                            dgvXe.Rows[i0].Cells[10].Value = dr0["DateAddCar"];
                            i0++;
                        }

                        break;


                    case 1://tìm kiếm theo hãng xe
                        String sql1 = "Select * from InforCar Where ManufacturerCar=N'" + txtHangXe.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(sql1, conn);
                        cmd1.ExecuteNonQuery();
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        int i1 = 0;
                        dgvXe.ColumnCount = 11;
                        dgvXe.Rows.Clear();
                        while (dr1.Read())
                        {
                            dgvXe.Rows.Add();
                            dgvXe.Rows[i1].Cells[0].Value = dr1["ID"];
                            dgvXe.Rows[i1].Cells[1].Value = dr1["Name"];
                            dgvXe.Rows[i1].Cells[2].Value = dr1["ManufacturerCar"];
                            dgvXe.Rows[i1].Cells[3].Value = dr1["Color"];
                            dgvXe.Rows[i1].Cells[4].Value = dr1["RegistrationDate"];
                            if (dr1["Status"].Equals(rdbMoi.Text))
                            {
                                dgvXe.Rows[i1].Cells[5].Value = rdbMoi.Text;
                            }
                            else
                            {
                                dgvXe.Rows[i1].Cells[5].Value = rdbCu.Text;
                            }
                            dgvXe.Rows[i1].Cells[6].Value = dr1["NumCar"];
                            dgvXe.Rows[i1].Cells[7].Value = dr1["PricePerDay"];
                            dgvXe.Rows[i1].Cells[8].Value = dr1["ManufactureYear"];
                            dgvXe.Rows[i1].Cells[9].Value = dr1["NumberOfCar"];
                            dgvXe.Rows[i1].Cells[10].Value = dr1["DateAddCar"];
                            i1++;
                        }

                        break;



                    case 2://tìm kiếm theo biển số xe
                        String sql2 = "Select * from InforCar Where NumCar='" + txtBienSoXe.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        cmd2.ExecuteNonQuery();
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        int i2 = 0;
                        dgvXe.ColumnCount = 11;
                        dgvXe.Rows.Clear();
                        while (dr2.Read())
                        {
                            dgvXe.Rows.Add();
                            dgvXe.Rows[i2].Cells[0].Value = dr2["ID"];
                            dgvXe.Rows[i2].Cells[1].Value = dr2["Name"];
                            dgvXe.Rows[i2].Cells[2].Value = dr2["ManufacturerCar"];
                            dgvXe.Rows[i2].Cells[3].Value = dr2["Color"];
                            dgvXe.Rows[i2].Cells[4].Value = dr2["RegistrationDate"];
                            if (dr2["Status"].Equals(rdbMoi.Text))
                            {
                                dgvXe.Rows[i2].Cells[5].Value = rdbMoi.Text;
                            }
                            else
                            {
                                dgvXe.Rows[i2].Cells[5].Value = rdbCu.Text;
                            }
                            dgvXe.Rows[i2].Cells[6].Value = dr2["NumCar"];
                            dgvXe.Rows[i2].Cells[7].Value = dr2["PricePerDay"];
                            dgvXe.Rows[i2].Cells[8].Value = dr2["ManufactureYear"];
                            dgvXe.Rows[i2].Cells[9].Value = dr2["NumberOfCar"];
                            dgvXe.Rows[i2].Cells[10].Value = dr2["DateAddCar"];
                            i2++;
                        }

                        break;

                    default:
                        txtTenXe.Enabled = true;
                        txtBienSoXe.Enabled = true;
                        txtHangXe.Enabled = true;
                        txtGiaMoiNgay.Enabled = true;
                        rdbMoi.Enabled = true;
                        rdbCu.Enabled = true;
                        txtMauSon.Enabled = true;
                        dtpNgayDangKi.Enabled = true;
                        dtpNamSanXuat.Enabled = true;
                        txtMaXe.Enabled = true;
                        txtSoLuong.Enabled = true;
                        dtpNgayNhap.Enabled = true;
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;

namespace GUI.UserControls
{
    public partial class ManagePunish : UserControl
    {
        String connstring = @"Data Source=HOANGUYEN;Initial Catalog=QLXeDuLich;Integrated Security=True";
        SqlConnection conn = new SqlConnection();

        private void LoadData()
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Select *,Customers.[Name] as CusName,Employee.[Name] as EmpName from Punish inner join Employee on Punish.EmpID=Employee.ID inner join Customers on Customers.ID=Punish.CustomerID", conn);

                //SqlDataAdapter ad1 = new SqlDataAdapter("Select * From Customers", conn);
                //DataTable cmbKH = new DataTable();
                //ad1.Fill(cmbKH);
                //cmbmakh.DataSource = cmbKH;
                //cmbmakh.DisplayMember = "ID";
                //cmbmakh.ValueMember = "ID";

                //SqlDataAdapter ad2 = new SqlDataAdapter("Select ID From Employee", conn);
                //DataTable cmbNV = new DataTable();
                //ad2.Fill(cmbNV);
                //cmbmanv.DataSource = cmbNV;
                //cmbmanv.DisplayMember = "ID";
                //cmbmanv.ValueMember = "ID";


                SqlDataReader dr = cmd.ExecuteReader();
                int index = 0;
                dgvphat.ColumnCount = 8;
                dgvphat.Rows.Clear();
                while (dr.Read())
                {
                    dgvphat.Rows.Add();
                    dgvphat.Rows[index].Cells[0].Value = index + 1;
                    dgvphat.Rows[index].Cells[1].Value = dr["ID"];
                    dgvphat.Rows[index].Cells[2].Value = dr["BillsID"];
                    dgvphat.Rows[index].Cells[4].Value = dr["CusName"];
                    dgvphat.Rows[index].Cells[3].Value = dr["EmpName"];
                    dgvphat.Rows[index].Cells[5].Value = dr["Description"];
                    dgvphat.Rows[index].Cells[7].Value =dr["Date"];
                    dgvphat.Rows[index].Cells[6].Value = dr["Price"];

                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void LoadCustomers()
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select Customers.ID,Customers.[Name] From Customers", conn);
                DataTable cmbKH = new DataTable();
                da.Fill(cmbKH);
                cmbmakh.DataSource = cmbKH;
                cmbmakh.DisplayMember = "Name";
                cmbmakh.ValueMember = "ID";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public ManagePunish()
        {
            InitializeComponent();
            LoadData();
            LoadCustomers();
            cmbmanv.Text = LoginInfo.Name;
        }

        private void SetNull()
        {
            txtmahd.Text = null;
            txtmaphieu.Text = null;
            txttienphat.Text = null;
            txtmota.Text = null;
            cmbmakh.Text = null;
            cmbmanv.Text = null;
            txttimkiemphieu.Text = null;
            datephieuphat.Text = null;

            txtmaphieu.Focus();

        }
        private void ManagePunish_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            LoadData();
            SetNull();
        }

        private void btnxoaphieu_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Bạn muốn xoá phiếu phạt {txtmaphieu.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Punish Where ID='" + txtmaphieu.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    SetNull();
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvphat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvphat.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvphat.Rows[index];

            if(index>=0 && index<=dgvphat.Rows.Count-2)
            {
                txtmaphieu.Text = Convert.ToString(row.Cells[1].Value);
                txtmahd.Text = Convert.ToString(row.Cells[2].Value);
                cmbmanv.Text = Convert.ToString(row.Cells[3].Value);
                cmbmakh.Text = Convert.ToString(row.Cells[4].Value);
                txtmota.Text = Convert.ToString(row.Cells[5].Value);
                txttienphat.Text = Convert.ToString(row.Cells[6].Value);
                datephieuphat.Value = DateTime.Parse(row.Cells[7].Value.ToString());
            }
        }

        private void btnthemphieu_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql = "Insert into Punish values (@IDHD,@IDNV, @IDKH , @DES,@MON,@DATE)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IDHD", int.Parse(txtmahd.Text));
                cmd.Parameters.AddWithValue("@IDKH", cmbmakh.SelectedValue);
                cmd.Parameters.AddWithValue("@IDNV", LoginInfo.ID);
                cmd.Parameters.AddWithValue("@DES", txtmota.Text);
                cmd.Parameters.AddWithValue("@DATE", datephieuphat.Value);
                cmd.Parameters.AddWithValue("@MON", Int32.Parse(txttienphat.Text));

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();

                LoadData();
                SetNull();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsuaphieu_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Bạn muốn sửa thông tin phiếu phạt {txtmaphieu.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string sql = "Update Punish set BillsID=@IDHD,CustomerID=@IDKH, EmpID=@IDNV,Price=@MON,Description=@DES,Date=@DATE Where ID='" + txtmaphieu.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@IDKH", cmbmakh.SelectedValue);
                    cmd.Parameters.AddWithValue("@IDNV", LoginInfo.ID);
                    cmd.Parameters.AddWithValue("@IDHD", int.Parse(txtmahd.Text));
                    cmd.Parameters.AddWithValue("@DATE", datephieuphat.Value);
                    cmd.Parameters.AddWithValue("@MON", Int32.Parse(txttienphat.Text));
                    cmd.Parameters.AddWithValue("@DES", txtmota.Text);

                    cmd.ExecuteNonQuery();

                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    LoadData();
                    SetNull();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btntimphieu_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Select *,Customers.[Name] as CusName,Employee.[Name] as EmpName from Punish inner join Employee on Punish.EmpID=Employee.ID inner join Customers on Customers.ID=Punish.CustomerID where Punish.ID='"+txttimkiemphieu.Text+"'", conn);

                //SqlDataAdapter ad1 = new SqlDataAdapter("Select * From Customers", conn);
                //DataTable cmbKH = new DataTable();
                //ad1.Fill(cmbKH);
                //cmbmakh.DataSource = cmbKH;
                //cmbmakh.DisplayMember = "ID";
                //cmbmakh.ValueMember = "ID";

                //SqlDataAdapter ad2 = new SqlDataAdapter("Select ID From Employee", conn);
                //DataTable cmbNV = new DataTable();
                //ad2.Fill(cmbNV);
                //cmbmanv.DataSource = cmbNV;
                //cmbmanv.DisplayMember = "ID";
                //cmbmanv.ValueMember = "ID";


                SqlDataReader dr = cmd.ExecuteReader();
                int index = 0;
                dgvphat.ColumnCount = 8;
                dgvphat.Rows.Clear();
                while (dr.Read())
                {
                    dgvphat.Rows.Add();
                    dgvphat.Rows[index].Cells[0].Value = index + 1;
                    dgvphat.Rows[index].Cells[1].Value = dr["ID"];
                    dgvphat.Rows[index].Cells[2].Value = dr["BillsID"];
                    dgvphat.Rows[index].Cells[4].Value = dr["CusName"];
                    dgvphat.Rows[index].Cells[3].Value = dr["EmpName"];
                    dgvphat.Rows[index].Cells[5].Value = dr["Description"];
                    dgvphat.Rows[index].Cells[7].Value = dr["Date"];
                    dgvphat.Rows[index].Cells[6].Value = dr["Price"];

                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            LoadData();
            SetNull();
        }
    }
}

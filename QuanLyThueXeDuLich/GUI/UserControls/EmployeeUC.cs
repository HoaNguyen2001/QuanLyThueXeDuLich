using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.Process;
using DTO.Entities;
using NUnit.Framework;

namespace GUI.UserControls
{
    public partial class EmployeeUC : UserControl
    {
        EmployeeProcess EmpPro = new EmployeeProcess();
        public EmployeeUC()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(List<EmployeeEntities> Emp=null)
        {
            dgvListEmp.Rows.Clear();

            var items = Emp==null? EmpPro.GetAllData() as List<EmployeeEntities>:Emp;
            int index = 0;
            dgvListEmp.ColumnCount = 5;
            foreach (var item in items)
            {
                dgvListEmp.Rows.Add();
                dgvListEmp.Rows[index].Cells[0].Value = item.ID;
                dgvListEmp.Rows[index].Cells[1].Value = item.Name;
                dgvListEmp.Rows[index].Cells[2].Value = item.Birthday.ToString("dd/MM/yyyy");
                dgvListEmp.Rows[index].Cells[3].Value = item.Address;
                dgvListEmp.Rows[index].Cells[4].Value = item.Phone;
                index++;
            }
        }

        private void SetNull()
        {
            txtName.Text = "";
            dtpBirthday.Value = DateTime.Now;
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeEntities Emp = new EmployeeEntities();

                Emp.Name = txtName.Text;
                Emp.Birthday = dtpBirthday.Value;
                Emp.Address = txtAddress.Text;
                Emp.Phone = txtPhone.Text;

                EmpPro.CreateOrUpdate(Emp);
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvListEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvListEmp.CurrentCell.RowIndex;

            var row = dgvListEmp.Rows[index];
            txtID.Text= $"NV{row.Cells[0].Value.ToString()}";
            txtName.Text = row.Cells[1].Value.ToString();
            dtpBirthday.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            txtPhone.Text = row.Cells[4].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetNull();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var Emp = new EmployeeEntities();
                Emp.ID = int.Parse(txtID.Text.Substring(2));
                Emp.Name = txtName.Text;
                Emp.Birthday = dtpBirthday.Value;
                Emp.Address = txtAddress.Text;
                Emp.Phone = txtPhone.Text;

                EmpPro.CreateOrUpdate(Emp);
                LoadData();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Emp = new EmployeeEntities();
                Emp.ID = int.Parse(txtID.Text);
                Emp.Name = txtName.Text;

                var result= MessageBox.Show($"Bạn muốn xoá nhân viên {Emp.Name} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    EmpPro.Delete(Emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbbTypeSearch.SelectedIndex;

            switch (index)
            {
                case 0://tìm kiếm theo tên
                    dtpBirthday.Enabled = false;
                    txtAddress.Enabled = false;
                    txtPhone.Enabled = false;
                    break;

                case 1://tìm kiếm theo địa chỉ
                    dtpBirthday.Enabled = false;
                    txtName.Enabled = false;
                    txtPhone.Enabled = false;
                    break;
                default:
                    dtpBirthday.Enabled = true;
                    txtName.Enabled = true;
                    txtPhone.Enabled = true;
                    txtAddress.Enabled = true;
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var index = cbbTypeSearch.SelectedIndex;
                var Emp = new EmployeeEntities();

                switch (index)
                {
                    case 0://tìm kiếm theo tên
                        Emp.Name = txtName.Text;
                        LoadData(EmpPro.Search(Emp, index));
                        break;

                    case 1://tìm kiếm theo địa chỉ
                        Emp.Address = txtAddress.Text;
                        LoadData(EmpPro.Search(Emp, index));
                        break;
                    default:
                        dtpBirthday.Enabled = true;
                        txtName.Enabled = true;
                        txtPhone.Enabled = true;
                        txtAddress.Enabled = true;
                        break;
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Employee : Form
    {
        EmployeeProcess EmpPro = new EmployeeProcess();

        public void LoadData()
        {
            dgvListEmployee.Rows.Clear();

            var items = EmpPro.GetAllData() as List<DTO.Employee>;
            int index = 0;
            dgvListEmployee.ColumnCount = 5;
            foreach (var item in items)
            {
                dgvListEmployee.Rows.Add();
                dgvListEmployee.Rows[index].Cells[0].Value = item.ID;
                dgvListEmployee.Rows[index].Cells[1].Value = item.Name;
                dgvListEmployee.Rows[index].Cells[2].Value = item.Birthday.ToString("dd/MM/yyyy");
                dgvListEmployee.Rows[index].Cells[3].Value = item.Address;
                dgvListEmployee.Rows[index].Cells[4].Value = item.Account;
                index++;
            }
            //dgvListEmployee.DataSource = items;
        }

        public Employee()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO.Employee Emp = new DTO.Employee();

            Emp.Name = txtName.Text;
            Emp.Birthday = dtpBirthday.Value;
            Emp.Address = txtAddress.Text;
            Emp.Account = txtAccount.Text;
            Emp.Password = txtPassword.Text;

            EmpPro.CreateOrUpdate(Emp);
            LoadData();
        }
    }
}

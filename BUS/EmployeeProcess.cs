using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class EmployeeProcess
    {
        DataContext db = new DataContext();

        public List<Employee> GetAllData()
        {
            var Emps = db.Employees.OrderByDescending(o => o.ID);
            return Emps.ToList();
        }

        public void CreateOrUpdate(Employee Emp)
        {
            if (Emp.ID == 0)
            {
                var emp =new Employee();

                emp.Name = Emp.Name;
                emp.Birthday = Emp.Birthday;
                emp.Address = Emp.Address;
                emp.Account = Emp.Account.ToLower();
                emp.Password = BUS.Globals.Security.Encrypt(Emp.Password); //ma hoa mat khau

                db.Employees.Add(emp);
                db.SaveChanges();
            }
            else
            {
                var emp = db.Employees.Where(o => o.ID == Emp.ID).FirstOrDefault();
                emp.Name = Emp.Name;
                emp.Birthday = Emp.Birthday;
                emp.Address = Emp.Address;
                emp.Account = Emp.Account;
                emp.Password = Emp.Password;

                db.Employees.Update(emp);
                db.SaveChanges();
            }
        }

        public void Delete(Employee Emp)
        {
            try
            {
                var emp = db.Employees.Where(o => o.ID == Emp.ID).FirstOrDefault();
                if (emp != null)
                {
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên tương ứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

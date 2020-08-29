using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace BUS.Process
{
    public class EmployeeProcess
    {
        DataContext db = new DataContext();

        public List<EmployeeEntities> GetAllData()
        {
            var Emps = db.Employees.OrderByDescending(o => o.ID);
            return Emps.ToList();
        }

        public void CreateOrUpdate(EmployeeEntities Emp)
        {
            if (Emp.ID == 0)
            {
                //var emp = new EmployeeEntities();

                //emp.Name = Emp.Name;
                //emp.Birthday = Emp.Birthday;
                //emp.Address = Emp.Address;
                //emp.Phone = Emp.Phone;
                //emp.Account = Emp.Account.ToLower();
                //emp.Password = BUS.Globals.Security.Encrypt(Emp.Password); //ma hoa mat khau

                db.Employees.Add(Emp);
                db.SaveChanges();
            }
            else
            {
                var emp = db.Employees.Where(o => o.ID == Emp.ID).FirstOrDefault();
                emp.Name = Emp.Name;
                emp.Birthday = Emp.Birthday;
                emp.Address = Emp.Address;
                emp.Phone = Emp.Phone;
                //emp.Account = Emp.Account;
                //emp.Password = Emp.Password;

                db.Employees.Update(emp);
                db.SaveChanges();
            }
        }

        public void Delete(EmployeeEntities Emp)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<EmployeeEntities> Search(EmployeeEntities Emp,int type)
        {
            try
            {
                if (type == 0) //tìm theo tên
                {
                    var List = db.Employees.Where(x => x.Name.Contains(Emp.Name));
                    return List.ToList();
                }
                else if (type == 1) //tìm theo địa chỉ
                {
                    var List = db.Employees.Where(x => x.Address.Contains(Emp.Address));
                    return List.ToList();
                }
                else return null;
            }
            catch(Exception Ex)
            {
                return null;
            }
        }

        public EmployeeEntities GetByID(int ID)
        {
            var Emps = db.Employees.Where(x=>x.ID==ID).FirstOrDefault();
            return Emps;
        }
    }
}

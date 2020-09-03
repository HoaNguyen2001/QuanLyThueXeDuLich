using DAL;
using DTO.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS.Process
{
    public class BillsProcess
    {
        DataContext db = new DataContext();
        public List<BillsVM> GetByDay()
        {
            var items = from i in db.Bills.Where(x => x.CreateDay.Day == DateTime.Now.Day).ToList()
                       select new
                       {
                           ID = i.ID,
                           EmpName = i.EmpID != 0 ? db.Employees.Where(x => x.ID == i.EmpID).FirstOrDefault().Name : "",
                           CreateDay = i.CreateDay,
                           CusName = i.CustomerID != 0 ? db.Customers.Where(x => x.ID == i.CustomerID).FirstOrDefault().Name : "",
                           NumCar = i.InforCarID != 0 ? db.inforCars.Where(x => x.ID == i.InforCarID).FirstOrDefault().NumCar : 0,
                           CarName = i.InforCarID != 0 ? db.inforCars.Where(x => x.ID == i.InforCarID).FirstOrDefault().Name : "",
                           TotalPrice = i.DateOfPayment.Subtract(i.DateOfHire).Days == 0 ? i.PricePerDay : i.DateOfPayment.Subtract(i.DateOfHire).Days * i.PricePerDay
                       };
            var list = new List<BillsVM>();
            foreach (var item in items)
            {
                var b = new BillsVM();
                b.ID = item.ID;
                b.EmpName = item.EmpName;
                b.CreateDay = item.CreateDay;
                b.CusName = item.CusName;
                b.NumCar = item.NumCar;
                b.CarName = item.CarName;
                b.TotalPrice = item.TotalPrice;
                list.Add(b);
            }
            return list;
        }

        public List<BillsVM> GetByWeek()
        {
            var items = from i in db.Bills.ToList()
                       where DateTime.Now.Subtract(i.CreateDay).Days <= 7 && DateTime.Now.Subtract(i.CreateDay).Days >=0
                        select new
                       {
                           ID = i.ID,
                           EmpName = i.EmpID != 0 ? db.Employees.Where(x => x.ID == i.EmpID).FirstOrDefault().Name : "",
                           CreateDay = i.CreateDay,
                           CusName = i.CustomerID != 0 ? db.Customers.Where(x => x.ID == i.CustomerID).FirstOrDefault().Name : "",
                           NumCar = i.InforCarID != 0 ? db.inforCars.Where(x => x.ID == i.InforCarID).FirstOrDefault().NumCar : 0,
                           CarName = i.InforCarID != 0 ? db.inforCars.Where(x => x.ID == i.InforCarID).FirstOrDefault().Name : "",
                           TotalPrice = i.DateOfPayment.Subtract(i.DateOfHire).Days ==0?i.PricePerDay: i.DateOfPayment.Subtract(i.DateOfHire).Days * i.PricePerDay
                       };
            var list = new List<BillsVM>();
            foreach(var item in items)
            {
                var b = new BillsVM();
                b.ID = item.ID;
                b.EmpName = item.EmpName;
                b.CreateDay = item.CreateDay;
                b.CusName = item.CusName;
                b.NumCar = item.NumCar;
                b.CarName = item.CarName;
                b.TotalPrice = item.TotalPrice;
                list.Add(b);
            }
            return list;
        }

        public List<BillsVM> GetByMonth()
        {
            var items = from i in db.Bills.Where(x => x.CreateDay.Month == DateTime.Now.Month).ToList()
                       select new
                       {
                           ID = i.ID,
                           EmpName = i.EmpID != 0 ? db.Employees.Where(x => x.ID == i.EmpID).FirstOrDefault().Name : "",
                           CreateDay = i.CreateDay,
                           CusName = i.CustomerID != 0 ? db.Customers.Where(x => x.ID == i.CustomerID).FirstOrDefault().Name : "",
                           NumCar = i.InforCarID != 0 ? db.inforCars.Where(x => x.ID == i.InforCarID).FirstOrDefault().NumCar : 0,
                           CarName = i.InforCarID != 0 ? db.inforCars.Where(x => x.ID == i.InforCarID).FirstOrDefault().Name : "",
                           TotalPrice = i.DateOfPayment.Subtract(i.DateOfHire).Days == 0 ? i.PricePerDay : i.DateOfPayment.Subtract(i.DateOfHire).Days * i.PricePerDay
                       };
            var list = new List<BillsVM>();
            foreach (var item in items)
            {
                var b = new BillsVM();
                b.ID = item.ID;
                b.EmpName = item.EmpName;
                b.CreateDay = item.CreateDay;
                b.CusName = item.CusName;
                b.NumCar = item.NumCar;
                b.CarName = item.CarName;
                b.TotalPrice = item.TotalPrice;
                list.Add(b);
            }
            return list;
        }

        public List<BillsVM> GetByOrtherTime(DateTime Start,DateTime End)
        {
            var items = from i in db.Bills.Where(x => x.CreateDay >=Start && x.CreateDay<=End).ToList()
                        select new
                        {
                            ID = i.ID,
                            EmpName = i.EmpID != 0 ? db.Employees.Where(x => x.ID == i.EmpID).FirstOrDefault().Name : "",
                            CreateDay = i.CreateDay,
                            CusName = i.CustomerID != 0 ? db.Customers.Where(x => x.ID == i.CustomerID).FirstOrDefault().Name : "",
                            NumCar = i.InforCarID != 0 ? db.inforCars.Where(x => x.ID == i.InforCarID).FirstOrDefault().NumCar : 0,
                            CarName = i.InforCarID != 0 ? db.inforCars.Where(x => x.ID == i.InforCarID).FirstOrDefault().Name : "",
                            TotalPrice = i.DateOfPayment.Subtract(i.DateOfHire).Days == 0 ? i.PricePerDay : i.DateOfPayment.Subtract(i.DateOfHire).Days * i.PricePerDay
                        };
            var list = new List<BillsVM>();
            foreach (var item in items)
            {
                var b = new BillsVM();
                b.ID = item.ID;
                b.EmpName = item.EmpName;
                b.CreateDay = item.CreateDay;
                b.CusName = item.CusName;
                b.NumCar = item.NumCar;
                b.CarName = item.CarName;
                b.TotalPrice = item.TotalPrice;
                list.Add(b);
            }
            return list;
        }
    }

}

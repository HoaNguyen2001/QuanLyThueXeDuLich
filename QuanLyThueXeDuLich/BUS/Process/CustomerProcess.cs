using DAL;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Process
{
    public class CustomerProcess
    {
        DataContext db = new DataContext();

        public void Create(CustomerEntities Cus)
        {
            db.Customers.Add(Cus);
            db.SaveChangesAsync();
        }
    }
}

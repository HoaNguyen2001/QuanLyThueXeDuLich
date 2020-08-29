using DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;UID=sa;Password=Ta0lacuamay1;");
                //optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;trusted_user=true");
            }
            catch(Exception Ex)
            {

            }
        }

        //khai bao su dung class o day
        public DbSet<EmployeeEntities> Employees { get; set; }
        public DbSet<InforCarEntities> inforCars { get; set; }
    }
}

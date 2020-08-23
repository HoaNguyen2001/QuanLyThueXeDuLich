using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DTO
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json");
            //var configuration = builder.Build();
            //optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
            optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;UID=sa;Password=Ta0lacuamay1;");
        }

        //khai bao su dung class o day
        public DbSet<Employee> Employees { get; set; }
    }
}

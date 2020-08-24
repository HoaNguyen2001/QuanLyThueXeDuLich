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
<<<<<<< HEAD
<<<<<<< HEAD
            // var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json");
            //var configuration = builder.Build();
            //optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
            optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;UID=sa;Password=Ta0lacuamay1;");
            //optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;trusted_user=true");
=======
            optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;trusted_user=true");//Đổi tên server,database thì điền tên database vừa tạo
            //optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;UID=sa;Password=Ta0lacuamay1;");
>>>>>>> b1c07953366e899bd5298fefe2ac4a6858cd3142
=======
            optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;trusted_user=true");//Đổi tên server,database thì điền tên database vừa tạo
            //optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;UID=sa;Password=Ta0lacuamay1;");
>>>>>>> b1c07953366e899bd5298fefe2ac4a6858cd3142
        }

        //khai bao su dung class o day
        public DbSet<Employee> Employees { get; set; }
    }
}

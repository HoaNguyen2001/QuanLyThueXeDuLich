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
            optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;trusted_user=true");//Đổi tên server,database thì điền tên database vừa tạo
            //optionsBuilder.UseSqlServer(@"Server=HOANGUYEN;Database=QLXeDuLich;UID=sa;Password=Ta0lacuamay1;");
        }

        //khai bao su dung class o day
        public DbSet<Employee> Employees { get; set; }
    }
}

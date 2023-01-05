using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database=BookStore;uid=sa;pwd=123");
        //    base.OnConfiguring(optionsBuilder);
        //}

        // Veritabanı tabloları configuraiton larının yapıldığı yer
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().Ignore("ID"); // base entity deki ID alanını ignore ettik çıkardık.
            modelBuilder.Entity<OrderDetail>().HasKey("OrderID","ProductID"); //primary key yapıldı
        }

        public DbSet<AppUser> Tbl_Users { get; set; }
        public DbSet<AppUserDetail> Tbl_UserDetails { get; set; }
        public DbSet<Category> Tbl_Categories { get; set; }
        public DbSet<Order> Tbl_Orders { get; set; }
        public DbSet<OrderDetail> Tbl_OrderDetails { get; set; }
        public DbSet<Product> Tbl_Products { get; set; }
    }
}

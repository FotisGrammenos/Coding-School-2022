using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLibrary;
using App.EF.Configs;

namespace App.EF.Context
{
    internal class CarServiceContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<ServiceTask> ServiceTasks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new EngineerConfig());
            modelBuilder.ApplyConfiguration(new ManagerConfig());
            modelBuilder.ApplyConfiguration(new ServiceTaskConfig());
            modelBuilder.ApplyConfiguration(new TransactionConfig());
            modelBuilder.ApplyConfiguration(new TransactionLInesConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            base.OnConfiguring(optionBuilder);
            var conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Session-14;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionBuilder.UseSqlServer(conString);

        }
    }
}

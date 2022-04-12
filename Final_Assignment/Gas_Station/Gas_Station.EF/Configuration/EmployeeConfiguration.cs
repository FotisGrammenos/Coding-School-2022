﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Gas_Station.EF.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.Name).HasMaxLength(50);
            builder.Property(employee=>employee.Surname).HasMaxLength(50);
            builder.Property(employee=> employee.SallaryPerMonth).HasPrecision(10, 3);
            builder.Property(employee => employee.Role).HasConversion(employeeType => employeeType.ToString(),
                            employeeType => (EmployeeType)Enum.Parse(typeof(EmployeeType), employeeType)).HasMaxLength(20);

            builder.HasMany(employee => employee.Transactions)
                .WithOne(transaction => transaction.Employee)
                .HasForeignKey(transaction => transaction.EmployeeID);
        }
    }
}

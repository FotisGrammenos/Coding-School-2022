﻿// <auto-generated />
using System;
using App.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.EF.Migrations
{
    [DbContext(typeof(CarServiceContext))]
    partial class CarServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataLibrary.Car", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CarRegNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DataLibrary.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TIN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DataLibrary.Engineer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ManagerID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("SallaryPerMonth")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Status")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("ManagerID");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("DataLibrary.Manager", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("SallaryPerMonth")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("DataLibrary.ServiceTask", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Hours")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("ServiceTasks");
                });

            modelBuilder.Entity("DataLibrary.Transaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ManagerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ManagerID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("DataLibrary.TransactionLine", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EngineerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Hours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ServiceTaskID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TransactionID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("EngineerID");

                    b.HasIndex("ServiceTaskID");

                    b.HasIndex("TransactionID");

                    b.ToTable("TransactionLines");
                });

            modelBuilder.Entity("DataLibrary.Engineer", b =>
                {
                    b.HasOne("DataLibrary.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("DataLibrary.Transaction", b =>
                {
                    b.HasOne("DataLibrary.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLibrary.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLibrary.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("DataLibrary.TransactionLine", b =>
                {
                    b.HasOne("DataLibrary.Engineer", "Engineer")
                        .WithMany()
                        .HasForeignKey("EngineerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLibrary.ServiceTask", "ServiceTask")
                        .WithMany()
                        .HasForeignKey("ServiceTaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLibrary.Transaction", null)
                        .WithMany("TransactionLines")
                        .HasForeignKey("TransactionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("ServiceTask");
                });

            modelBuilder.Entity("DataLibrary.Transaction", b =>
                {
                    b.Navigation("TransactionLines");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using CarRent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRent.Migrations
{
    [DbContext(typeof(MyAppDataContext))]
    [Migration("20191122222155_sixth")]
    partial class sixth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("CarRent.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CarRent.Models.Car", b =>
                {
                    b.Property<int>("carID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandID");

                    b.Property<string>("CarImage")
                        .IsRequired();

                    b.Property<string>("Model")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<double>("Run");

                    b.Property<int>("Year");

                    b.Property<double>("price");

                    b.HasKey("carID");

                    b.HasIndex("BrandID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarRent.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("passportID");

                    b.HasKey("EmployeeID");

                    b.HasIndex("passportID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CarRent.Models.EmployeeDetails", b =>
                {
                    b.Property<int>("EmployeeID");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int?>("Age");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.HasKey("EmployeeID");

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("CarRent.Models.Passport", b =>
                {
                    b.Property<int>("passportID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Level");

                    b.Property<int>("No");

                    b.Property<DateTime>("RegistationDate");

                    b.HasKey("passportID");

                    b.ToTable("Passports");
                });

            modelBuilder.Entity("CarRent.Models.RentedCars", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarId");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("EndTime");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("ID");

                    b.HasIndex("CarId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("RentedCars");
                });

            modelBuilder.Entity("CarRent.Models.Car", b =>
                {
                    b.HasOne("CarRent.Models.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarRent.Models.Employee", b =>
                {
                    b.HasOne("CarRent.Models.Passport", "Passport")
                        .WithMany()
                        .HasForeignKey("passportID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarRent.Models.EmployeeDetails", b =>
                {
                    b.HasOne("CarRent.Models.Employee", "Employee")
                        .WithOne("EmployeeDetails")
                        .HasForeignKey("CarRent.Models.EmployeeDetails", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarRent.Models.RentedCars", b =>
                {
                    b.HasOne("CarRent.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarRent.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

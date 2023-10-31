﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoApp.Data;

#nullable disable

namespace ToDoApp.Migrations
{
    [DbContext(typeof(ToDoAppDbContext))]
    [Migration("20231027121132_NamingFix")]
    partial class NamingFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.24");

            modelBuilder.Entity("ToDoApp.Data.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpiryDate = new DateTime(2024, 1, 25, 14, 11, 32, 713, DateTimeKind.Local).AddTicks(9980),
                            Name = "Get AWS Certified"
                        },
                        new
                        {
                            Id = 2,
                            ExpiryDate = new DateTime(2023, 11, 8, 14, 11, 32, 714, DateTimeKind.Local).AddTicks(20),
                            Name = "Book off days"
                        },
                        new
                        {
                            Id = 3,
                            ExpiryDate = new DateTime(2023, 11, 7, 14, 11, 32, 714, DateTimeKind.Local).AddTicks(30),
                            Name = "Read a book"
                        },
                        new
                        {
                            Id = 4,
                            ExpiryDate = new DateTime(2023, 11, 17, 14, 11, 32, 714, DateTimeKind.Local).AddTicks(30),
                            Name = "Pay Electricity bill"
                        },
                        new
                        {
                            Id = 5,
                            ExpiryDate = new DateTime(2023, 10, 28, 14, 11, 32, 714, DateTimeKind.Local).AddTicks(30),
                            Name = "Get Groceries"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
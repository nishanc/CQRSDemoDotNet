﻿// <auto-generated />
using CQRSDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CQRSDemo.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("CQRSDemo.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Demo Product Description 1",
                            ProductName = "Demo Product 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Demo Product Description 2",
                            ProductName = "Demo Product 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Demo Product Description 3",
                            ProductName = "Demo Product 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

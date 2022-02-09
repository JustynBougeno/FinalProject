﻿// <auto-generated />
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20220202162428_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FinalProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    //b.Property<string>("productId")
                      //  .HasColumnType("longtext CHARACTER SET utf8mb4");

                    //b.Property<string>("productManufacture")
                        //.HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("productName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("productPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    //b.Property<string>("productSeller")
                        //.HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("productType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("productUnitAmount")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

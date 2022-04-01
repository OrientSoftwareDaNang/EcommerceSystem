﻿// <auto-generated />
using System;
using EcommerceSystem.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceSystem.DAL.Migrations
{
    [DbContext(typeof(EcommerceSystemContext))]
    partial class EcommerceSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EcommerceSystem.Domain.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("Discription")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Origin")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int>("ProductNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductSubcategoryID")
                        .HasColumnType("int");

                    b.Property<string>("TradeMark")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductSubcategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("EcommerceSystem.Domain.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryID"), 1L, 1);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ProductCategoryID");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("EcommerceSystem.Domain.ProductSubcategory", b =>
                {
                    b.Property<int>("ProductSubcategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductSubcategoryID"), 1L, 1);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductCategoryID")
                        .HasColumnType("int");

                    b.HasKey("ProductSubcategoryID");

                    b.HasIndex("ProductCategoryID");

                    b.ToTable("ProductSubcategory");
                });

            modelBuilder.Entity("EcommerceSystem.Domain.Product", b =>
                {
                    b.HasOne("EcommerceSystem.Domain.ProductSubcategory", "ProductSubcategory")
                        .WithMany()
                        .HasForeignKey("ProductSubcategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductSubcategory");
                });

            modelBuilder.Entity("EcommerceSystem.Domain.ProductSubcategory", b =>
                {
                    b.HasOne("EcommerceSystem.Domain.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}

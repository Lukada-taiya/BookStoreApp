﻿// <auto-generated />
using System;
using Bookstore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookstore.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231115075432_Initital-Migration")]
    partial class InititalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookstore.Application.DTOs.BookDto", b =>
                {
                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookIdpk")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("BookDto");
                });

            modelBuilder.Entity("Bookstore.Application.DTOs.CreateBookDto", b =>
                {
                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("CreateBookDto");
                });

            modelBuilder.Entity("Bookstore.Domain.Models.Book", b =>
                {
                    b.Property<int>("BookIdpk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookIdpk"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookIdpk");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Bookstore.Domain.Models.Order", b =>
                {
                    b.Property<int>("OrderIdpk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderIdpk"));

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderIdpk");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Bookstore.Domain.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemIdpk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemIdpk"));

                    b.Property<int>("BookIdpk")
                        .HasColumnType("int");

                    b.Property<int>("OrderIdfk")
                        .HasColumnType("int");

                    b.Property<int?>("OrderIdpk")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemIdpk");

                    b.HasIndex("BookIdpk");

                    b.HasIndex("OrderIdpk");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Bookstore.Domain.Models.OrderItem", b =>
                {
                    b.HasOne("Bookstore.Domain.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookIdpk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore.Domain.Models.Order", null)
                        .WithMany("Books")
                        .HasForeignKey("OrderIdpk");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Bookstore.Domain.Models.Order", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

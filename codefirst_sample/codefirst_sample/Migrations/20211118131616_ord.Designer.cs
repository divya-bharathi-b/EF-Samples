﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using codefirst_sample.Models;

#nullable disable

namespace codefirst_sample.Migrations
{
    [DbContext(typeof(TrainingContext))]
    [Migration("20211118131616_ord")]
    partial class ord
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("codefirst_sample.Models.author", b =>
                {
                    b.Property<int>("authorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("authorId"), 1L, 1);

                    b.Property<string>("authorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("BookName");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("phoneno")
                        .HasColumnType("int");

                    b.HasKey("authorId");

                    b.ToTable("Author_Details");
                });

            modelBuilder.Entity("codefirst_sample.Models.book", b =>
                {
                    b.Property<int>("book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("book_id"), 1L, 1);

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bookage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2)
                        .HasColumnName("Book_Age");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("book_id");

                    b.ToTable("books");
                });

            modelBuilder.Entity("codefirst_sample.Models.buyer", b =>
                {
                    b.Property<int>("buyer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("buyer_Id"), 1L, 1);

                    b.Property<string>("buyer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("buyer_Id");

                    b.ToTable("buyers");
                });

            modelBuilder.Entity("codefirst_sample.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("codefirst_sample.Models.Order", b =>
                {
                    b.Property<int>("Order_ID")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("OrderAmt");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("custID")
                        .HasColumnType("int");

                    b.HasKey("Order_ID");

                    b.HasIndex("custID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("codefirst_sample.Models.Order", b =>
                {
                    b.HasOne("codefirst_sample.Models.Customer", "cust")
                        .WithMany("Orders")
                        .HasForeignKey("custID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cust");
                });

            modelBuilder.Entity("codefirst_sample.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
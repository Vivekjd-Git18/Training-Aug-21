﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToyProject1.Models;

namespace ToyProject1.Migrations
{
    [DbContext(typeof(ToysDbContext))]
    [Migration("20211120123404_sixth")]
    partial class sixth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("OrderToy", b =>
                {
                    b.Property<int>("OrdersOrderId")
                        .HasColumnType("int");

                    b.Property<int>("ToysToyId")
                        .HasColumnType("int");

                    b.HasKey("OrdersOrderId", "ToysToyId");

                    b.HasIndex("ToysToyId");

                    b.ToTable("OrderToy");
                });

            modelBuilder.Entity("PlantToy", b =>
                {
                    b.Property<int>("PlantsPlantId")
                        .HasColumnType("int");

                    b.Property<int>("ToysToyId")
                        .HasColumnType("int");

                    b.HasKey("PlantsPlantId", "ToysToyId");

                    b.HasIndex("ToysToyId");

                    b.ToTable("PlantToy");
                });

            modelBuilder.Entity("ToyProject1.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddressLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Pincode")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ToyProject1.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ToyProject1.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("NetAmount")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("CustomerId");

                    b.HasIndex("PurchaseId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ToyProject1.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PlantAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantPincode")
                        .HasColumnType("int");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("ToyProject1.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ToysId")
                        .HasColumnType("int");

                    b.HasKey("PurchaseId");

                    b.HasIndex("ToysId")
                        .IsUnique();

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("ToyProject1.Models.Toy", b =>
                {
                    b.Property<int>("ToyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ToyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToyPrice")
                        .HasColumnType("int");

                    b.Property<string>("ToyType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToyId");

                    b.ToTable("Toys");
                });

            modelBuilder.Entity("OrderToy", b =>
                {
                    b.HasOne("ToyProject1.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToyProject1.Models.Toy", null)
                        .WithMany()
                        .HasForeignKey("ToysToyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlantToy", b =>
                {
                    b.HasOne("ToyProject1.Models.Plant", null)
                        .WithMany()
                        .HasForeignKey("PlantsPlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToyProject1.Models.Toy", null)
                        .WithMany()
                        .HasForeignKey("ToysToyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToyProject1.Models.Address", b =>
                {
                    b.HasOne("ToyProject1.Models.Customer", null)
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("ToyProject1.Models.Order", b =>
                {
                    b.HasOne("ToyProject1.Models.Address", "Address")
                        .WithOne("Order")
                        .HasForeignKey("ToyProject1.Models.Order", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToyProject1.Models.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ToyProject1.Models.Purchase", "Purchase")
                        .WithOne("Order")
                        .HasForeignKey("ToyProject1.Models.Order", "PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("ToyProject1.Models.Purchase", b =>
                {
                    b.HasOne("ToyProject1.Models.Toy", "Toy")
                        .WithOne("Purchase")
                        .HasForeignKey("ToyProject1.Models.Purchase", "ToysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Toy");
                });

            modelBuilder.Entity("ToyProject1.Models.Address", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("ToyProject1.Models.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ToyProject1.Models.Purchase", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("ToyProject1.Models.Toy", b =>
                {
                    b.Navigation("Purchase");
                });
#pragma warning restore 612, 618
        }
    }
}

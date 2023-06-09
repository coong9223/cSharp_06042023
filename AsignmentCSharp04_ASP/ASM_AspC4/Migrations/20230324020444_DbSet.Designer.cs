﻿// <auto-generated />
using System;
using ASM_AspC4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASM_AspC4.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20230324020444_DbSet")]
    partial class DbSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASM_AspC4.Models.Bill", b =>
                {
                    b.Property<Guid>("idBill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("idUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("statusBill")
                        .HasColumnType("int");

                    b.HasKey("idBill");

                    b.HasIndex("idUser");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("ASM_AspC4.Models.BillDetail", b =>
                {
                    b.Property<Guid>("idBDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idBill")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("statusBDetail")
                        .HasColumnType("int");

                    b.HasKey("idBDetail");

                    b.HasIndex("idProduct");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Cart", b =>
                {
                    b.Property<Guid>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersidUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("statusCart")
                        .HasColumnType("int");

                    b.HasKey("idUser");

                    b.HasIndex("UsersidUser");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ASM_AspC4.Models.CartDetail", b =>
                {
                    b.Property<Guid>("idCDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idCart")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("statusCDetail")
                        .HasColumnType("int");

                    b.HasKey("idCDetail");

                    b.HasIndex("idCart");

                    b.HasIndex("idProduct");

                    b.ToTable("CasrtDetail");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Color", b =>
                {
                    b.Property<Guid>("idColor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nameColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("statusMetarial")
                        .HasColumnType("int");

                    b.HasKey("idColor");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Metarial", b =>
                {
                    b.Property<Guid>("idMetarial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nameMetarial")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("statusMetarial")
                        .HasColumnType("int");

                    b.HasKey("idMetarial");

                    b.ToTable("Metarial");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Product", b =>
                {
                    b.Property<Guid>("idProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("availableQuantity")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("idColor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idMetarial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nameColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nameMetarial")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nameProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("priceProduct")
                        .HasColumnType("int");

                    b.Property<int>("statusProduct")
                        .HasColumnType("int");

                    b.Property<string>("supplier")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength();

                    b.HasKey("idProduct");

                    b.HasIndex("idColor");

                    b.HasIndex("idMetarial");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Role", b =>
                {
                    b.Property<Guid>("idRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nameRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("statusRole")
                        .HasColumnType("int");

                    b.HasKey("idRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ASM_AspC4.Models.User", b =>
                {
                    b.Property<Guid>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("emailUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("idRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nameRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("nameUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("passwordUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("statusUser")
                        .HasColumnType("int");

                    b.HasKey("idUser");

                    b.HasIndex("idRole");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Bill", b =>
                {
                    b.HasOne("ASM_AspC4.Models.User", "Users")
                        .WithMany("Bills")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ASM_AspC4.Models.BillDetail", b =>
                {
                    b.HasOne("ASM_AspC4.Models.Bill", "Bills")
                        .WithMany("BillDetails")
                        .HasForeignKey("idBDetail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_AspC4.Models.Product", "Products")
                        .WithMany("BillDetails")
                        .HasForeignKey("idProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bills");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Cart", b =>
                {
                    b.HasOne("ASM_AspC4.Models.User", "Users")
                        .WithMany("Carts")
                        .HasForeignKey("UsersidUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ASM_AspC4.Models.CartDetail", b =>
                {
                    b.HasOne("ASM_AspC4.Models.Cart", "Carts")
                        .WithMany("CartDetails")
                        .HasForeignKey("idCart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_AspC4.Models.Product", "Products")
                        .WithMany("CartDetails")
                        .HasForeignKey("idProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carts");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Product", b =>
                {
                    b.HasOne("ASM_AspC4.Models.Color", "Colors")
                        .WithMany("Products")
                        .HasForeignKey("idColor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_AspC4.Models.Metarial", "Metarials")
                        .WithMany("Products")
                        .HasForeignKey("idMetarial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colors");

                    b.Navigation("Metarials");
                });

            modelBuilder.Entity("ASM_AspC4.Models.User", b =>
                {
                    b.HasOne("ASM_AspC4.Models.Role", "Roles")
                        .WithMany("Users")
                        .HasForeignKey("idRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Color", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Metarial", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Product", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("ASM_AspC4.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ASM_AspC4.Models.User", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}

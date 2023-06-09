﻿// <auto-generated />
using System;
using BAI_1_6_EFCORE_CODEFIRST.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BAI_1_6_EFCORE_CODEFIRST.Migrations
{
    [DbContext(typeof(FpolyDBContext))]
    [Migration("20220727034630_CreateDB2707221044")]
    partial class CreateDB2707221044
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BAI_1_5_EFCORE_CODEFIRST.DomainClass.Point", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSv")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IdSv");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("BAI_1_5_EFCORE_CODEFIRST.DomainClass.SinhVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSV")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SinhVien");
                });

            modelBuilder.Entity("BAI_1_5_EFCORE_CODEFIRST.DomainClass.Point", b =>
                {
                    b.HasOne("BAI_1_5_EFCORE_CODEFIRST.DomainClass.SinhVien", "SinhVien")
                        .WithMany()
                        .HasForeignKey("IdSv");

                    b.Navigation("SinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}

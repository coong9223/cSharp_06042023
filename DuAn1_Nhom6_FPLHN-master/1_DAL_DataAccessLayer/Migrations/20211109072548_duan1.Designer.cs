﻿// <auto-generated />
using System;
using _1_DAL_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace _1_DAL_DataAccessLayer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211109072548_duan1")]
    partial class duan1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Anh", b =>
                {
                    b.Property<int>("Idanh")
                        .HasColumnType("int")
                        .HasColumnName("IDAnh");

                    b.Property<string>("DuongDan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaAnh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenAnh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Idanh");

                    b.ToTable("Anh");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChatLieu", b =>
                {
                    b.Property<int>("IdchatLieu")
                        .HasColumnType("int")
                        .HasColumnName("IDChatLieu");

                    b.Property<string>("MaChatLieu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenChatLieu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdchatLieu");

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChiTietHangHoa", b =>
                {
                    b.Property<int>("IdthongTinHangHoa")
                        .HasColumnType("int")
                        .HasColumnName("IDThongTinHangHoa");

                    b.Property<double?>("DonGiaBan")
                        .HasColumnType("float");

                    b.Property<double?>("DonGiaNhap")
                        .HasColumnType("float");

                    b.Property<DateTime?>("HanSuDung")
                        .HasColumnType("datetime");

                    b.Property<int?>("Idanh")
                        .HasColumnType("int")
                        .HasColumnName("IDAnh");

                    b.Property<int?>("IdchatLieu")
                        .HasColumnType("int")
                        .HasColumnName("IDChatLieu");

                    b.Property<int?>("IddungTich")
                        .HasColumnType("int")
                        .HasColumnName("IDDungTich");

                    b.Property<int?>("IdhangHoa")
                        .HasColumnType("int")
                        .HasColumnName("IDHangHoa");

                    b.Property<int?>("IdnhomHuong")
                        .HasColumnType("int")
                        .HasColumnName("IDNhomHuong");

                    b.Property<int?>("IdquocGia")
                        .HasColumnType("int")
                        .HasColumnName("IDQuocGia");

                    b.Property<int?>("IdvatChua")
                        .HasColumnType("int")
                        .HasColumnName("IDVatChua");

                    b.Property<string>("Mavach")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("NgayNhapKho")
                        .HasColumnType("datetime");

                    b.Property<string>("SoLuong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdthongTinHangHoa");

                    b.HasIndex("Idanh");

                    b.HasIndex("IdchatLieu");

                    b.HasIndex("IddungTich");

                    b.HasIndex("IdhangHoa");

                    b.HasIndex("IdnhomHuong");

                    b.HasIndex("IdquocGia");

                    b.HasIndex("IdvatChua");

                    b.ToTable("ChiTietHangHoa");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DanhMuc", b =>
                {
                    b.Property<int>("IddanhMuc")
                        .HasColumnType("int")
                        .HasColumnName("IDDanhMuc");

                    b.Property<string>("MaDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IddanhMuc");

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DiemTieuDung", b =>
                {
                    b.Property<int>("IddiemTieuDung")
                        .HasColumnType("int")
                        .HasColumnName("IDDiemTieuDung");

                    b.Property<string>("MaDiem")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("SoDiem")
                        .HasColumnType("float");

                    b.Property<string>("TenDiem")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IddiemTieuDung");

                    b.ToTable("DiemTieuDung");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DungTich", b =>
                {
                    b.Property<int>("IddungTich")
                        .HasColumnType("int")
                        .HasColumnName("IDDungTich");

                    b.Property<string>("MaDungTich")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("SoDungTich")
                        .HasColumnType("float");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IddungTich");

                    b.ToTable("DungTich");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HangHoa", b =>
                {
                    b.Property<int>("IdhangHoa")
                        .HasColumnType("int")
                        .HasColumnName("IDHangHoa");

                    b.Property<int?>("IddanhMuc")
                        .HasColumnType("int")
                        .HasColumnName("IDDanhMuc");

                    b.Property<int?>("IdnhaSanXuat")
                        .HasColumnType("int")
                        .HasColumnName("IDNhaSanXuat");

                    b.Property<string>("MaHangHoa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenHangHoa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdhangHoa");

                    b.HasIndex("IddanhMuc");

                    b.HasIndex("IdnhaSanXuat");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HoaDonBan", b =>
                {
                    b.Property<int>("IdhoaDon")
                        .HasColumnType("int")
                        .HasColumnName("IDHoaDon");

                    b.Property<int?>("IdkhachHang")
                        .HasColumnType("int")
                        .HasColumnName("IDKhachHang");

                    b.Property<int?>("Iduser")
                        .HasColumnType("int")
                        .HasColumnName("IDUser");

                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("NgayLap")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayNhanHang")
                        .HasColumnType("datetime");

                    b.Property<double?>("Thue")
                        .HasColumnType("float");

                    b.Property<double?>("Tien")
                        .HasColumnType("float");

                    b.Property<double?>("TongSoTien")
                        .HasColumnType("float");

                    b.HasKey("IdhoaDon");

                    b.HasIndex("IdkhachHang");

                    b.HasIndex("Iduser");

                    b.ToTable("HoaDonBan");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HoaDonChiTiet", b =>
                {
                    b.Property<int>("IdhoaDonChiTiet")
                        .HasColumnType("int")
                        .HasColumnName("IDHoaDonChiTiet");

                    b.Property<double?>("DonGia")
                        .HasColumnType("float");

                    b.Property<double?>("GiamGia")
                        .HasColumnType("float");

                    b.Property<int?>("IdhangHoa")
                        .HasColumnType("int")
                        .HasColumnName("IDHangHoa");

                    b.Property<int?>("IdhoaDon")
                        .HasColumnType("int")
                        .HasColumnName("IDHoaDon");

                    b.Property<int?>("IdthongTinHangHoa")
                        .HasColumnType("int")
                        .HasColumnName("IDThongTinHangHoa");

                    b.Property<string>("MaHoaDonChiTiet")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<double?>("ThanhTien")
                        .HasColumnType("float");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdhoaDonChiTiet");

                    b.HasIndex("IdhoaDon");

                    b.HasIndex("IdthongTinHangHoa");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.KhachHang", b =>
                {
                    b.Property<int>("IdkhachHang")
                        .HasColumnType("int")
                        .HasColumnName("IDKhachHang");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<int?>("IddiemTieuDung")
                        .HasColumnType("int")
                        .HasColumnName("IDDiemTieuDung");

                    b.Property<string>("MaKhachHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NamSinh")
                        .HasColumnType("int");

                    b.Property<string>("SoCmnd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SoCMND");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenKhachHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdkhachHang");

                    b.HasIndex("IddiemTieuDung");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhaSanXuat", b =>
                {
                    b.Property<int>("IdnhaSanXuat")
                        .HasColumnType("int")
                        .HasColumnName("IDNhaSanXuat");

                    b.Property<string>("MaNhaSanXuat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenNhaSanXuat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdnhaSanXuat");

                    b.ToTable("NhaSanXuat");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhanVien", b =>
                {
                    b.Property<int>("Iduser")
                        .HasColumnType("int")
                        .HasColumnName("IDUser");

                    b.Property<string>("Anh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Flag")
                        .HasColumnType("bit");

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<int?>("Idrole")
                        .HasColumnType("int")
                        .HasColumnName("IDRole");

                    b.Property<string>("MaNhanVien")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NamSinh")
                        .HasColumnType("int");

                    b.Property<string>("PassWord")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QueQuan")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SoCmnd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SoCMND");

                    b.Property<string>("TenNhanVien")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Iduser")
                        .HasName("PK_Users");

                    b.HasIndex("Idrole");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhomHuong", b =>
                {
                    b.Property<int>("IdnhomHuong")
                        .HasColumnType("int")
                        .HasColumnName("IDNhomHuong");

                    b.Property<string>("MaNhomHuong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenNhomHuong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdnhomHuong");

                    b.ToTable("NhomHuong");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Role", b =>
                {
                    b.Property<int>("Idrole")
                        .HasColumnType("int")
                        .HasColumnName("IDRole");

                    b.Property<string>("MaRole")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Idrole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.VatChua", b =>
                {
                    b.Property<int>("IdvatChua")
                        .HasColumnType("int")
                        .HasColumnName("IDVatChua");

                    b.Property<string>("MaVatChua")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenVatChua")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdvatChua");

                    b.ToTable("VatChua");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.XuatXu", b =>
                {
                    b.Property<int>("IdquocGia")
                        .HasColumnType("int")
                        .HasColumnName("IDQuocGia");

                    b.Property<string>("MaQuocGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenQuocGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdquocGia");

                    b.ToTable("XuatXu");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChiTietHangHoa", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.Anh", "IdanhNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("Idanh")
                        .HasConstraintName("FK_ChiTietHangHoa_Anh");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.ChatLieu", "IdchatLieuNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IdchatLieu")
                        .HasConstraintName("FK_ChiTietHangHoa_ChatLieu");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.DungTich", "IddungTichNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IddungTich")
                        .HasConstraintName("FK_ChiTietHangHoa_DungTich");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.HangHoa", "IdhangHoaNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IdhangHoa")
                        .HasConstraintName("FK_ChiTietHangHoa_HangHoa");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.NhomHuong", "IdnhomHuongNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IdnhomHuong")
                        .HasConstraintName("FK_ChiTietHangHoa_NhomHuong");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.XuatXu", "IdquocGiaNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IdquocGia")
                        .HasConstraintName("FK_ChiTietHangHoa_XuatXu");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.VatChua", "IdvatChuaNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IdvatChua")
                        .HasConstraintName("FK_ChiTietHangHoa_VatChua");

                    b.Navigation("IdanhNavigation");

                    b.Navigation("IdchatLieuNavigation");

                    b.Navigation("IddungTichNavigation");

                    b.Navigation("IdhangHoaNavigation");

                    b.Navigation("IdnhomHuongNavigation");

                    b.Navigation("IdquocGiaNavigation");

                    b.Navigation("IdvatChuaNavigation");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HangHoa", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.DanhMuc", "IddanhMucNavigation")
                        .WithMany("HangHoas")
                        .HasForeignKey("IddanhMuc")
                        .HasConstraintName("FK_HangHoa_DanhMuc");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.NhaSanXuat", "IdnhaSanXuatNavigation")
                        .WithMany("HangHoas")
                        .HasForeignKey("IdnhaSanXuat")
                        .HasConstraintName("FK_HangHoa_NhaSanXuat");

                    b.Navigation("IddanhMucNavigation");

                    b.Navigation("IdnhaSanXuatNavigation");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HoaDonBan", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.KhachHang", "IdkhachHangNavigation")
                        .WithMany("HoaDonBans")
                        .HasForeignKey("IdkhachHang")
                        .HasConstraintName("FK_HoaDonBan_KhachHang");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.NhanVien", "IduserNavigation")
                        .WithMany("HoaDonBans")
                        .HasForeignKey("Iduser")
                        .HasConstraintName("FK_HoaDonBan_Users");

                    b.Navigation("IdkhachHangNavigation");

                    b.Navigation("IduserNavigation");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.HoaDonBan", "IdhoaDonNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdhoaDon")
                        .HasConstraintName("FK_HoaDonChiTiet_HoaDonBan");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.ChiTietHangHoa", "IdthongTinHangHoaNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdthongTinHangHoa")
                        .HasConstraintName("FK_HoaDonChiTiet_ChiTietHangHoa");

                    b.Navigation("IdhoaDonNavigation");

                    b.Navigation("IdthongTinHangHoaNavigation");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.KhachHang", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.DiemTieuDung", "IddiemTieuDungNavigation")
                        .WithMany("KhachHangs")
                        .HasForeignKey("IddiemTieuDung")
                        .HasConstraintName("FK_KhachHang_DiemTieuDung");

                    b.Navigation("IddiemTieuDungNavigation");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhanVien", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.Role", "IdroleNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("Idrole")
                        .HasConstraintName("FK_Users_Roles");

                    b.Navigation("IdroleNavigation");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Anh", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChatLieu", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChiTietHangHoa", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DanhMuc", b =>
                {
                    b.Navigation("HangHoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DiemTieuDung", b =>
                {
                    b.Navigation("KhachHangs");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DungTich", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HangHoa", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HoaDonBan", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDonBans");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhaSanXuat", b =>
                {
                    b.Navigation("HangHoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDonBans");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhomHuong", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Role", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.VatChua", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.XuatXu", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });
#pragma warning restore 612, 618
        }
    }
}

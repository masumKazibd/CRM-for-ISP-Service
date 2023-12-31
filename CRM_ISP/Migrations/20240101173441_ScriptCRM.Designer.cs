﻿// <auto-generated />
using System;
using CRM_ISP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRM_ISP.Migrations
{
    [DbContext(typeof(CrmDbContext))]
    [Migration("20240101173441_ScriptCRM")]
    partial class ScriptCRM
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRM_ISP.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<DateTime>("AdminCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdminImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("date");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("RoleId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("CRM_ISP.Models.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AreaId"));

                    b.Property<string>("AreaName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.HasKey("AreaId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("CRM_ISP.Models.Billing", b =>
                {
                    b.Property<int>("BillingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillingId"));

                    b.Property<DateTime>("BillingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("BillingStatus")
                        .HasColumnType("bit");

                    b.Property<int?>("PackageId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BillingId");

                    b.HasIndex("PackageId");

                    b.HasIndex("UserId");

                    b.ToTable("Billings");
                });

            modelBuilder.Entity("CRM_ISP.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CRM_ISP.Models.Complain", b =>
                {
                    b.Property<int>("ComplainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComplainId"));

                    b.Property<string>("ComplainDetails")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ComplainType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ComplaintDate")
                        .HasColumnType("date");

                    b.HasKey("ComplainId");

                    b.ToTable("Complaines");
                });

            modelBuilder.Entity("CRM_ISP.Models.ComplainStatus", b =>
                {
                    b.Property<int>("ComplainStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComplainStatusId"));

                    b.Property<int?>("ComplainId")
                        .HasColumnType("int");

                    b.Property<bool>("ComplainStatusType")
                        .HasColumnType("bit");

                    b.HasKey("ComplainStatusId");

                    b.HasIndex("ComplainId");

                    b.ToTable("ComplainesStatuses");
                });

            modelBuilder.Entity("CRM_ISP.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CRM_ISP.Models.Feedback", b =>
                {
                    b.Property<int>("FeedBackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedBackId"));

                    b.Property<int?>("ComplainId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FeedbackDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RatingMessage")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FeedBackId");

                    b.HasIndex("ComplainId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("CRM_ISP.Models.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PackageId"));

                    b.Property<int>("PackageDuration")
                        .HasColumnType("int");

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("PackagePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PackageType")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("PackageId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("CRM_ISP.Models.RegistrationMessage", b =>
                {
                    b.Property<int>("RegistrationMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegistrationMessageId"));

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("RegistrationMessageId");

                    b.ToTable("RegistrationMessages");
                });

            modelBuilder.Entity("CRM_ISP.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CRM_ISP.Models.SupportEngineer", b =>
                {
                    b.Property<int>("SupportEngineerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupportEngineerId"));

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("EngineerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EngineerGender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EngineerJoinDate")
                        .HasColumnType("date");

                    b.Property<string>("EngineerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EngineerPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EngineerPhone")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SupportEngineerCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupportEngineerImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupportEngineerId");

                    b.HasIndex("AreaId");

                    b.HasIndex("RoleId");

                    b.ToTable("SupportEngineers");
                });

            modelBuilder.Entity("CRM_ISP.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("PackageId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UserCreateDate")
                        .HasColumnType("date");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("AreaId");

                    b.HasIndex("CityId");

                    b.HasIndex("PackageId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CRM_ISP.Models.UserComplain", b =>
                {
                    b.Property<int>("UserComplainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserComplainId"));

                    b.Property<int?>("ComplainId")
                        .HasColumnType("int");

                    b.Property<int?>("PackageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UserComplainDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserComplainId");

                    b.HasIndex("ComplainId");

                    b.HasIndex("PackageId");

                    b.HasIndex("UserId");

                    b.ToTable("UserComplain");
                });

            modelBuilder.Entity("CRM_ISP.Models.UserPackage", b =>
                {
                    b.Property<int>("UserPackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPackageId"));

                    b.Property<int?>("PackageId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PackageStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserPackageId");

                    b.HasIndex("PackageId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersPackages");
                });

            modelBuilder.Entity("CRM_ISP.Models.UserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserEmail")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CRM_ISP.Models.Admin", b =>
                {
                    b.HasOne("CRM_ISP.Models.Role", "Role")
                        .WithMany("Admins")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CRM_ISP.Models.Billing", b =>
                {
                    b.HasOne("CRM_ISP.Models.Package", "Package")
                        .WithMany("Billings")
                        .HasForeignKey("PackageId");

                    b.HasOne("CRM_ISP.Models.User", "User")
                        .WithMany("Billings")
                        .HasForeignKey("UserId");

                    b.Navigation("Package");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRM_ISP.Models.ComplainStatus", b =>
                {
                    b.HasOne("CRM_ISP.Models.Complain", "Complain")
                        .WithMany("ComplainStatuses")
                        .HasForeignKey("ComplainId");

                    b.Navigation("Complain");
                });

            modelBuilder.Entity("CRM_ISP.Models.Feedback", b =>
                {
                    b.HasOne("CRM_ISP.Models.Complain", "Complain")
                        .WithMany("FeedBacks")
                        .HasForeignKey("ComplainId");

                    b.HasOne("CRM_ISP.Models.User", "User")
                        .WithMany("FeedBacks")
                        .HasForeignKey("UserId");

                    b.Navigation("Complain");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRM_ISP.Models.SupportEngineer", b =>
                {
                    b.HasOne("CRM_ISP.Models.Area", "Area")
                        .WithMany("SupportEngineers")
                        .HasForeignKey("AreaId");

                    b.HasOne("CRM_ISP.Models.Role", "Role")
                        .WithMany("SupportEngineers")
                        .HasForeignKey("RoleId");

                    b.Navigation("Area");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CRM_ISP.Models.User", b =>
                {
                    b.HasOne("CRM_ISP.Models.Area", "Area")
                        .WithMany("Users")
                        .HasForeignKey("AreaId");

                    b.HasOne("CRM_ISP.Models.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId");

                    b.HasOne("CRM_ISP.Models.Package", "Package")
                        .WithMany("Users")
                        .HasForeignKey("PackageId");

                    b.HasOne("CRM_ISP.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Area");

                    b.Navigation("City");

                    b.Navigation("Package");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CRM_ISP.Models.UserComplain", b =>
                {
                    b.HasOne("CRM_ISP.Models.Complain", "Complain")
                        .WithMany("UserComplains")
                        .HasForeignKey("ComplainId");

                    b.HasOne("CRM_ISP.Models.Package", "Package")
                        .WithMany("UserComplains")
                        .HasForeignKey("PackageId");

                    b.HasOne("CRM_ISP.Models.User", "User")
                        .WithMany("UserComplains")
                        .HasForeignKey("UserId");

                    b.Navigation("Complain");

                    b.Navigation("Package");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRM_ISP.Models.UserPackage", b =>
                {
                    b.HasOne("CRM_ISP.Models.Package", "Package")
                        .WithMany()
                        .HasForeignKey("PackageId");

                    b.HasOne("CRM_ISP.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Package");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRM_ISP.Models.Area", b =>
                {
                    b.Navigation("SupportEngineers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("CRM_ISP.Models.City", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("CRM_ISP.Models.Complain", b =>
                {
                    b.Navigation("ComplainStatuses");

                    b.Navigation("FeedBacks");

                    b.Navigation("UserComplains");
                });

            modelBuilder.Entity("CRM_ISP.Models.Package", b =>
                {
                    b.Navigation("Billings");

                    b.Navigation("UserComplains");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("CRM_ISP.Models.Role", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("SupportEngineers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("CRM_ISP.Models.User", b =>
                {
                    b.Navigation("Billings");

                    b.Navigation("FeedBacks");

                    b.Navigation("UserComplains");
                });
#pragma warning restore 612, 618
        }
    }
}

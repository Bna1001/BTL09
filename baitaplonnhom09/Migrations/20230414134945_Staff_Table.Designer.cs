﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace baitaplonnhom09.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230414134945_Staff_Table")]
    partial class StaffTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("baitaplonnhom09.Models.Account", b =>
                {
                    b.Property<string>("AccountID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountBank")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountEarn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountEnd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountPosition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountSex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountStart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("baitaplonnhom09.Models.Ceo", b =>
                {
                    b.Property<string>("CeoID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoBank")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoEarn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoEnd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoPosition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoSex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CeoStart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CeoID");

                    b.ToTable("Ceo");
                });

            modelBuilder.Entity("baitaplonnhom09.Models.Sale", b =>
                {
                    b.Property<string>("SaleID")
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleBank")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleEarn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleEnd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SalePhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SalePosition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleSex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleStart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SaleID");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("baitaplonnhom09.Models.Staff", b =>
                {
                    b.Property<string>("StaffID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffBank")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffEarn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffEnd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffPosition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffSex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffStart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StaffID");

                    b.ToTable("Staff");
                });
#pragma warning restore 612, 618
        }
    }
}

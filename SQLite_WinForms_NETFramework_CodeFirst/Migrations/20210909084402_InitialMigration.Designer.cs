using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SQLite_WinForms_NETFramework_CodeFirst.Entities;

namespace SQLite_WinForms_NETFramework_CodeFirst.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20210909084402_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6");

            modelBuilder.Entity("SQLite_WinForms_NETFramework_CodeFirst.Entities.CashVoucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Number");

                    b.Property<int?>("ShiftId");

                    b.HasKey("Id");

                    b.HasIndex("ShiftId");

                    b.ToTable("CashVouchers");
                });

            modelBuilder.Entity("SQLite_WinForms_NETFramework_CodeFirst.Entities.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("SQLite_WinForms_NETFramework_CodeFirst.Entities.CashVoucher", b =>
                {
                    b.HasOne("SQLite_WinForms_NETFramework_CodeFirst.Entities.Shift", "Shift")
                        .WithMany("CashVouchers")
                        .HasForeignKey("ShiftId");
                });
        }
    }
}

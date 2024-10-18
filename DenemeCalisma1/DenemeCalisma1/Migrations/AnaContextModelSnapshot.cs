﻿// <auto-generated />
using DenemeCalisma1.Models.VeriTabani1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DenemeCalisma1.Migrations
{
    [DbContext(typeof(AnaContext))]
    partial class AnaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DenemeCalisma1.Models.VeriTabani1.Acente", b =>
                {
                    b.Property<int>("AcenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcenteID"));

                    b.Property<string>("AcenteAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeriTabaniLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeriTabaniServerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeriTabaniSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcenteID");

                    b.ToTable("Acents");
                });
#pragma warning restore 612, 618
        }
    }
}
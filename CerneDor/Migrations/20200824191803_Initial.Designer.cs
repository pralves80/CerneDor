﻿// <auto-generated />
using CerneDor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CerneDor.Migrations
{
    [DbContext(typeof(CerneDorContext))]
    [Migration("20200824191803_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CerneDor.Models.Convenio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoAns");

                    b.Property<string>("Descricao");

                    b.HasKey("ID");

                    b.ToTable("Convenio");
                });
#pragma warning restore 612, 618
        }
    }
}

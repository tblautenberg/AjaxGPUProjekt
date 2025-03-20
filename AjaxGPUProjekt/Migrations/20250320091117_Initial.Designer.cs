﻿// <auto-generated />
using AjaxGPUProjekt.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AjaxGPUProjekt.Migrations
{
    [DbContext(typeof(GpuContext))]
    [Migration("20250320091117_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AjaxGPUProjekt.Models.Gpu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Pris")
                        .HasColumnType("int");

                    b.Property<string>("Producent")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VRam")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Gpus");
                });
#pragma warning restore 612, 618
        }
    }
}

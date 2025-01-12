﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCRUDSample;

#nullable disable

namespace WebCRUDSample.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebCRUDSample.Models.ItemCategory", b =>
                {
                    b.Property<int>("pk_typeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pk_typeId"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsConsumable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsMedicine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reamrk")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pk_typeId");

                    b.ToTable("SAP_ItemType_Mst");
                });
#pragma warning restore 612, 618
        }
    }
}

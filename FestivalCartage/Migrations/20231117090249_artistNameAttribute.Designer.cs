﻿// <auto-generated />
using System;
using FestivalCartage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FestivalCartage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231117090249_artistNameAttribute")]
    partial class artistNameAttribute
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FestivalCartage.Models.Concert", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("artistName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("concertDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("concertName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Concert");
                });
#pragma warning restore 612, 618
        }
    }
}
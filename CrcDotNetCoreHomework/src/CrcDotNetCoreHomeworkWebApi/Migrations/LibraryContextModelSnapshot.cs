﻿// <auto-generated />
using System;
using CrcDotNetCoreHomeworkWebApi.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrcDotNetCoreHomeworkWebApi.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("CrcDotNetCoreHomeworkWebApi.Model.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("Year");

                    b.HasKey("Id");

                    b.ToTable("Libraries");
                });
#pragma warning restore 612, 618
        }
    }
}

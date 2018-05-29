﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using API.DB;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180517202220_addingPrimaryKey")]
    partial class addingPrimaryKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeIt.Models.Electricity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TimeStamp");

                    b.Property<decimal>("Used");

                    b.Property<Guid>("UserGuid");

                    b.Property<int>("UtilityType");

                    b.HasKey("Id");

                    b.ToTable("Electricity");
                });

            modelBuilder.Entity("HomeIt.Models.Errors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<string>("StackTrace");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("HomeIt.Models.Gas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TimeStamp");

                    b.Property<decimal>("Used");

                    b.Property<Guid>("UserGuid");

                    b.Property<int>("UtilityType");

                    b.HasKey("Id");

                    b.ToTable("Gas");
                });

            modelBuilder.Entity("HomeIt.Models.Water", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TimeStamp");

                    b.Property<decimal>("Used");

                    b.Property<Guid>("UserGuid");

                    b.Property<int>("UtilityType");

                    b.HasKey("Id");

                    b.ToTable("Water");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    [Migration("20210208004355_StatesTestSeven")]
    partial class StatesTestSeven
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StateOrNational")
                        .IsRequired();

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Mount Rainier",
                            State = "Washington",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "North Cascades",
                            State = "Washington",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "Olympic",
                            State = "Washington",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 4,
                            Name = "Crater Lake",
                            State = "Oregon",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 5,
                            Name = "test2",
                            State = "Oregon",
                            StateOrNational = "State"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

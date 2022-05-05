﻿// <auto-generated />
using System;
using F1_FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace F1_FinalProject.Migrations
{
    [DbContext(typeof(TeamContext))]
    [Migration("20220426023052_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24");

            modelBuilder.Entity("F1_FinalProject.Models.Circuit", b =>
                {
                    b.Property<int>("CircuitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CircuitName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<int>("DriverID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FirstGP")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GPName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("LapRecord")
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<double>("Length")
                        .HasColumnType("REAL");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.HasKey("CircuitID");

                    b.HasIndex("DriverID");

                    b.ToTable("Circuits");
                });

            modelBuilder.Entity("F1_FinalProject.Models.Driver", b =>
                {
                    b.Property<int>("DriverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Championships")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<int>("GPEntered")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Podiums")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Points")
                        .HasColumnType("REAL");

                    b.Property<int>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("DriverID");

                    b.HasIndex("TeamID");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("F1_FinalProject.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Base")
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<int>("Championships")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Chasis")
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("Chief")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<int>("FirstEntry")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PolePositions")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PowerUnit")
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("F1_FinalProject.Models.Circuit", b =>
                {
                    b.HasOne("F1_FinalProject.Models.Driver", "Driver")
                        .WithMany("Circuits")
                        .HasForeignKey("DriverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("F1_FinalProject.Models.Driver", b =>
                {
                    b.HasOne("F1_FinalProject.Models.Team", "Team")
                        .WithMany("Drivers")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wellness_USC.Models;

namespace Wellness_USC.Migrations.HorarioDb
{
    [DbContext(typeof(HorarioDbContext))]
    partial class HorarioDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Wellness_USC.Models.Clase", b =>
                {
                    b.Property<int>("Id_Clase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CoursesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HorarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfesoresId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int>("cantidad")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Clase");

                    b.HasIndex("CoursesId");

                    b.HasIndex("HorarioId");

                    b.HasIndex("ProfesoresId");

                    b.ToTable("Clase");
                });

            modelBuilder.Entity("Wellness_USC.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Wellness_USC.Models.Horario", b =>
                {
                    b.Property<int>("Id_Horario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("release_date")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Horario");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("Wellness_USC.Models.Profesores", b =>
                {
                    b.Property<int>("Id_Profesores")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apell")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageNameP")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Profesores");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("Wellness_USC.Models.Clase", b =>
                {
                    b.HasOne("Wellness_USC.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Wellness_USC.Models.Horario", "Horario")
                        .WithMany("Clases")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Wellness_USC.Models.Profesores", "Profesores")
                        .WithMany("Clase")
                        .HasForeignKey("ProfesoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

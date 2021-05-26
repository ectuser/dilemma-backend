﻿// <auto-generated />
using System;
using Dilemma.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Dilemma.DAL.Migrations
{
    [DbContext(typeof(DilemmaDbContext))]
    [Migration("20210526124123_AddData")]
    partial class AddData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Dilemma.DAL.Models.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("SolutionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SolutionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Dilemma.DAL.Models.Dilemma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Dilemmas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"),
                            Text = "Dilemma 1"
                        },
                        new
                        {
                            Id = new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"),
                            Text = "Dilemma 2"
                        },
                        new
                        {
                            Id = new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"),
                            Text = "Dilemma 3"
                        });
                });

            modelBuilder.Entity("Dilemma.DAL.Models.Solution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DilemmaId")
                        .HasColumnType("uuid");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DilemmaId");

                    b.ToTable("Solutions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("66a360e7-2ee4-4dba-82b6-5efd83402081"),
                            DilemmaId = new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"),
                            Image = "dilemma_1_solution_1.jpeg",
                            Rate = 0.69999999999999996,
                            Text = "Dilemma 1 Solution 1"
                        },
                        new
                        {
                            Id = new Guid("717e11a7-2fe7-43eb-a2ce-699eeaf3d9d7"),
                            DilemmaId = new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"),
                            Image = "dilemma_1_solution_2.jpeg",
                            Rate = -0.40000000000000002,
                            Text = "Dilemma 1 Solution 2"
                        },
                        new
                        {
                            Id = new Guid("1dd7f1aa-7ecf-4804-9bff-1862e01a5b0a"),
                            DilemmaId = new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"),
                            Image = "dilemma_1_solution_1.jpeg",
                            Rate = 0.40000000000000002,
                            Text = "Dilemma 2 Solution 1"
                        },
                        new
                        {
                            Id = new Guid("25f1de4e-5dbd-4b12-b4fd-53cc9194f672"),
                            DilemmaId = new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"),
                            Image = "dilemma_1_solution_2.jpeg",
                            Rate = -0.5,
                            Text = "Dilemma 2 Solution 2"
                        },
                        new
                        {
                            Id = new Guid("aa39be35-41c5-411e-923d-a1139cef286b"),
                            DilemmaId = new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"),
                            Image = "dilemma_1_solution_1.jpeg",
                            Rate = 0.59999999999999998,
                            Text = "Dilemma 3 Solution 1"
                        },
                        new
                        {
                            Id = new Guid("fd7d0f5d-738c-46e4-957c-4abfec5b8c1a"),
                            DilemmaId = new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"),
                            Image = "dilemma_1_solution_2.jpeg",
                            Rate = -0.20000000000000001,
                            Text = "Dilemma 3 Solution 2"
                        });
                });

            modelBuilder.Entity("Dilemma.DAL.Models.Statistics", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("Dilemma.DAL.Models.Answer", b =>
                {
                    b.HasOne("Dilemma.DAL.Models.Solution", "Solution")
                        .WithMany("Answers")
                        .HasForeignKey("SolutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solution");
                });

            modelBuilder.Entity("Dilemma.DAL.Models.Solution", b =>
                {
                    b.HasOne("Dilemma.DAL.Models.Dilemma", "Dilemma")
                        .WithMany("Solutions")
                        .HasForeignKey("DilemmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dilemma");
                });

            modelBuilder.Entity("Dilemma.DAL.Models.Dilemma", b =>
                {
                    b.Navigation("Solutions");
                });

            modelBuilder.Entity("Dilemma.DAL.Models.Solution", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
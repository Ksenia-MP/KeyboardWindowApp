﻿// <auto-generated />
using System;
using KeyboardWIndowApp.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace KeyboardWIndowApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221126164001_madeDB2")]
    partial class madeDB2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.Difficulty", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ErrorPct")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("MaxLen")
                        .HasColumnType("integer");

                    b.Property<int>("MinLen")
                        .HasColumnType("integer");

                    b.Property<int>("TypeSpeed")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Difficulty");
                });

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.Exercise", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("DifficultyId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsRandom")
                        .HasColumnType("boolean");

                    b.Property<int>("Len")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.HasIndex("DifficultyId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.Keyboard", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Char")
                        .HasColumnType("text");

                    b.Property<int>("ZoneN")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Keyboard");
                });

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.Statistics", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ErrorPct")
                        .HasColumnType("integer");

                    b.Property<long>("ExerciseId")
                        .HasColumnType("bigint");

                    b.Property<int>("TipeSpeed")
                        .HasColumnType("integer");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("UserId");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.TypeZone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("DifficultyId")
                        .HasColumnType("bigint");

                    b.Property<int>("ZoneN")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.ToTable("TypeZone");
                });

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Admin")
                        .HasColumnType("boolean");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasAlternateKey("Login");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.Exercise", b =>
                {
                    b.HasOne("KeyboardWIndowApp.DataBase.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.Statistics", b =>
                {
                    b.HasOne("KeyboardWIndowApp.DataBase.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyboardWIndowApp.DataBase.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KeyboardWIndowApp.DataBase.TypeZone", b =>
                {
                    b.HasOne("KeyboardWIndowApp.DataBase.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

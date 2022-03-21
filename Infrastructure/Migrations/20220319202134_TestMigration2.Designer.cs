﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PreviaturasFing.Infrastructure.Context;

#nullable disable

namespace PreviaturasFing.Infrastructure.Migrations
{
    [DbContext(typeof(SubjectDbContext))]
    [Migration("20220319202134_TestMigration2")]
    partial class TestMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PreviaturasFing.Domain.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<bool>("EvenSemester")
                        .HasColumnType("bit");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OddSemester")
                        .HasColumnType("bit");

                    b.Property<int>("SubGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("GroupId")
                        .IsUnique();

                    b.HasIndex("SubGroupId")
                        .IsUnique();

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("PreviaturasFing.Domain.Models.SubjectGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("SubjectGroup");
                });

            modelBuilder.Entity("PreviaturasFing.Domain.Models.SubjectSubGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("SubjectSubGroup");
                });

            modelBuilder.Entity("PreviaturasFing.Domain.Models.Subject", b =>
                {
                    b.HasOne("PreviaturasFing.Domain.Models.SubjectGroup", "Group")
                        .WithOne("Subject")
                        .HasForeignKey("PreviaturasFing.Domain.Models.Subject", "GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PreviaturasFing.Domain.Models.SubjectSubGroup", "SubGroup")
                        .WithOne("Subject")
                        .HasForeignKey("PreviaturasFing.Domain.Models.Subject", "SubGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("SubGroup");
                });

            modelBuilder.Entity("PreviaturasFing.Domain.Models.SubjectGroup", b =>
                {
                    b.Navigation("Subject")
                        .IsRequired();
                });

            modelBuilder.Entity("PreviaturasFing.Domain.Models.SubjectSubGroup", b =>
                {
                    b.Navigation("Subject")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

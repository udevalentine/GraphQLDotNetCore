﻿// <auto-generated />
using System;
using GraphQLDotNetCore.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphQLDotNetCore.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20200901234640_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraphQLDotNetCore.Domain.Model.Gender", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GENDER");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = true,
                            Name = "Male"
                        },
                        new
                        {
                            Id = 2L,
                            Active = true,
                            Name = "Female"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Domain.Model.GeoPoliticalZone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("USER");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = true,
                            Name = "North Central"
                        },
                        new
                        {
                            Id = 2L,
                            Active = true,
                            Name = "North East"
                        },
                        new
                        {
                            Id = 3L,
                            Active = true,
                            Name = "North West"
                        },
                        new
                        {
                            Id = 4L,
                            Active = true,
                            Name = "South East"
                        },
                        new
                        {
                            Id = 5L,
                            Active = true,
                            Name = "South South"
                        },
                        new
                        {
                            Id = 6L,
                            Active = true,
                            Name = "South West"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Domain.Model.Lga", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StateId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("LGA");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = true,
                            Name = "Udi",
                            StateId = 14L
                        },
                        new
                        {
                            Id = 2L,
                            Active = true,
                            Name = "Oji-River",
                            StateId = 14L
                        },
                        new
                        {
                            Id = 3L,
                            Active = true,
                            Name = "Nsukka",
                            StateId = 14L
                        },
                        new
                        {
                            Id = 4L,
                            Active = true,
                            Name = "Ogwu",
                            StateId = 14L
                        },
                        new
                        {
                            Id = 5L,
                            Active = true,
                            Name = "Enugu",
                            StateId = 14L
                        },
                        new
                        {
                            Id = 6L,
                            Active = true,
                            Name = "Eziagu",
                            StateId = 14L
                        },
                        new
                        {
                            Id = 7L,
                            Active = true,
                            Name = "Ilaro",
                            StateId = 28L
                        },
                        new
                        {
                            Id = 8L,
                            Active = true,
                            Name = "Obiakpo",
                            StateId = 33L
                        },
                        new
                        {
                            Id = 9L,
                            Active = true,
                            Name = "Port-Harcourt",
                            StateId = 33L
                        },
                        new
                        {
                            Id = 10L,
                            Active = true,
                            Name = "Degema",
                            StateId = 33L
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Domain.Model.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PERSON");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = true,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2L,
                            Active = true,
                            Name = "SuperAdmin"
                        },
                        new
                        {
                            Id = 3L,
                            Active = true,
                            Name = "Student"
                        },
                        new
                        {
                            Id = 4L,
                            Active = true,
                            Name = "Agent"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Domain.Model.State", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("GeoPoliticalZoneId")
                        .HasColumnType("int");

                    b.Property<long?>("GeoPoliticalZoneId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeoPoliticalZoneId1");

                    b.ToTable("STATE");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = true,
                            GeoPoliticalZoneId = 4,
                            Name = "Abia"
                        },
                        new
                        {
                            Id = 2L,
                            Active = true,
                            GeoPoliticalZoneId = 2,
                            Name = "Adamawa"
                        },
                        new
                        {
                            Id = 3L,
                            Active = true,
                            GeoPoliticalZoneId = 5,
                            Name = "Akwa-Ibom"
                        },
                        new
                        {
                            Id = 4L,
                            Active = true,
                            GeoPoliticalZoneId = 4,
                            Name = "Anambra"
                        },
                        new
                        {
                            Id = 5L,
                            Active = true,
                            GeoPoliticalZoneId = 2,
                            Name = "Bauchi"
                        },
                        new
                        {
                            Id = 6L,
                            Active = true,
                            GeoPoliticalZoneId = 5,
                            Name = "Bayelsa"
                        },
                        new
                        {
                            Id = 7L,
                            Active = true,
                            GeoPoliticalZoneId = 1,
                            Name = "Benue"
                        },
                        new
                        {
                            Id = 8L,
                            Active = true,
                            GeoPoliticalZoneId = 2,
                            Name = "Borno"
                        },
                        new
                        {
                            Id = 9L,
                            Active = true,
                            GeoPoliticalZoneId = 5,
                            Name = "Cross-Rivers"
                        },
                        new
                        {
                            Id = 10L,
                            Active = true,
                            GeoPoliticalZoneId = 5,
                            Name = "Delta"
                        },
                        new
                        {
                            Id = 11L,
                            Active = true,
                            GeoPoliticalZoneId = 4,
                            Name = "Ebonyi"
                        },
                        new
                        {
                            Id = 12L,
                            Active = true,
                            GeoPoliticalZoneId = 5,
                            Name = "Edo"
                        },
                        new
                        {
                            Id = 13L,
                            Active = true,
                            GeoPoliticalZoneId = 6,
                            Name = "Ekiti"
                        },
                        new
                        {
                            Id = 14L,
                            Active = true,
                            GeoPoliticalZoneId = 4,
                            Name = "Enugu"
                        },
                        new
                        {
                            Id = 15L,
                            Active = true,
                            GeoPoliticalZoneId = 1,
                            Name = "FCT Abuja"
                        },
                        new
                        {
                            Id = 16L,
                            Active = true,
                            GeoPoliticalZoneId = 2,
                            Name = "Gombe"
                        },
                        new
                        {
                            Id = 17L,
                            Active = true,
                            GeoPoliticalZoneId = 5,
                            Name = "Imo"
                        },
                        new
                        {
                            Id = 18L,
                            Active = true,
                            GeoPoliticalZoneId = 3,
                            Name = "Jigawa"
                        },
                        new
                        {
                            Id = 19L,
                            Active = true,
                            GeoPoliticalZoneId = 3,
                            Name = "Kaduna"
                        },
                        new
                        {
                            Id = 20L,
                            Active = true,
                            GeoPoliticalZoneId = 3,
                            Name = "Kano"
                        },
                        new
                        {
                            Id = 21L,
                            Active = true,
                            GeoPoliticalZoneId = 3,
                            Name = "Katsina"
                        },
                        new
                        {
                            Id = 22L,
                            Active = true,
                            GeoPoliticalZoneId = 3,
                            Name = "Kebbi"
                        },
                        new
                        {
                            Id = 23L,
                            Active = true,
                            GeoPoliticalZoneId = 1,
                            Name = "Kogi"
                        },
                        new
                        {
                            Id = 24L,
                            Active = true,
                            GeoPoliticalZoneId = 1,
                            Name = "Kwara"
                        },
                        new
                        {
                            Id = 25L,
                            Active = true,
                            GeoPoliticalZoneId = 6,
                            Name = "Lagos"
                        },
                        new
                        {
                            Id = 26L,
                            Active = true,
                            GeoPoliticalZoneId = 1,
                            Name = "Nassarawa"
                        },
                        new
                        {
                            Id = 27L,
                            Active = true,
                            GeoPoliticalZoneId = 1,
                            Name = "Niger"
                        },
                        new
                        {
                            Id = 28L,
                            Active = true,
                            GeoPoliticalZoneId = 6,
                            Name = "Ogun"
                        },
                        new
                        {
                            Id = 29L,
                            Active = true,
                            GeoPoliticalZoneId = 6,
                            Name = "Ondo"
                        },
                        new
                        {
                            Id = 30L,
                            Active = true,
                            GeoPoliticalZoneId = 6,
                            Name = "Osun"
                        },
                        new
                        {
                            Id = 31L,
                            Active = true,
                            GeoPoliticalZoneId = 6,
                            Name = "Oyo"
                        },
                        new
                        {
                            Id = 32L,
                            Active = true,
                            GeoPoliticalZoneId = 1,
                            Name = "Plateau"
                        },
                        new
                        {
                            Id = 33L,
                            Active = true,
                            GeoPoliticalZoneId = 5,
                            Name = "Rivers"
                        },
                        new
                        {
                            Id = 34L,
                            Active = true,
                            GeoPoliticalZoneId = 3,
                            Name = "Sokoto"
                        },
                        new
                        {
                            Id = 35L,
                            Active = true,
                            GeoPoliticalZoneId = 2,
                            Name = "Taraba"
                        },
                        new
                        {
                            Id = 36L,
                            Active = true,
                            GeoPoliticalZoneId = 2,
                            Name = "Yobe"
                        },
                        new
                        {
                            Id = 37L,
                            Active = true,
                            GeoPoliticalZoneId = 3,
                            Name = "Zamfara"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Domain.Model.Lga", b =>
                {
                    b.HasOne("GraphQLDotNetCore.Domain.Model.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("GraphQLDotNetCore.Domain.Model.State", b =>
                {
                    b.HasOne("GraphQLDotNetCore.Domain.Model.GeoPoliticalZone", "GeoPoliticalZone")
                        .WithMany()
                        .HasForeignKey("GeoPoliticalZoneId1")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyHotelDb))]
    [Migration("20240522091805_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.HotelRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Bath")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageWay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Internet")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBedsId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeatsId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double?>("RatingNumber")
                        .HasColumnType("float");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<int>("TypeRoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NumberOfBedsId");

                    b.HasIndex("NumberOfSeatsId");

                    b.HasIndex("TypeRoomId");

                    b.ToTable("HotelRooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bath = false,
                            Description = "Ok",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/square240/248195922.webp?k=6b877e663516a32f2bc8ea0650bd8f99c82410492c14970ef50d4d03efd98d3e&o=",
                            Internet = false,
                            Name = "room 1",
                            NumberOfBedsId = 1,
                            NumberOfSeatsId = 1,
                            Price = 600m,
                            RatingNumber = 1.0,
                            State = true,
                            TypeRoomId = 5
                        },
                        new
                        {
                            Id = 2,
                            Bath = true,
                            Description = "Nice",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/square240/20587801.webp?k=f2bf851dde89ce807cfaee75bfaf553141dc8ded4522a4499622b1d8515ed135&o=",
                            Internet = true,
                            Name = "room 2",
                            NumberOfBedsId = 2,
                            NumberOfSeatsId = 2,
                            Price = 800m,
                            RatingNumber = 2.0,
                            State = true,
                            TypeRoomId = 4
                        },
                        new
                        {
                            Id = 3,
                            Bath = true,
                            Description = "Very OK VeryVeryVeryVery Very",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/square240/438603683.webp?k=7c9e443957dc86d5b06967d1e1f42ad04c22bbfac1fdb6df3cfc9a607873f716&o=",
                            Internet = true,
                            Name = "room 3",
                            NumberOfBedsId = 3,
                            NumberOfSeatsId = 3,
                            Price = 1000m,
                            RatingNumber = 3.5,
                            State = true,
                            TypeRoomId = 3
                        },
                        new
                        {
                            Id = 4,
                            Bath = true,
                            Description = "Very OK",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/square240/174892954.webp?k=c4c4a19bc0f48dbcb5eb746836c198d8aefccd940c5977dc3d3a7824851820fd&o=",
                            Internet = true,
                            Name = "room 4",
                            NumberOfBedsId = 4,
                            NumberOfSeatsId = 4,
                            Price = 1200m,
                            RatingNumber = 4.0,
                            State = true,
                            TypeRoomId = 2
                        },
                        new
                        {
                            Id = 5,
                            Bath = true,
                            Description = "Very OK",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/square240/479602453.webp?k=607d43a927a0bfb7021e70a93ee55b6be457a8e976f19d34ff3a9091b5b6e4bb&o=",
                            Internet = true,
                            Name = "room 5",
                            NumberOfBedsId = 5,
                            NumberOfSeatsId = 5,
                            Price = 2000m,
                            RatingNumber = 5.0,
                            State = true,
                            TypeRoomId = 1
                        });
                });

            modelBuilder.Entity("Data.Entities.NumberOfBeds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NumberOfBeds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            Number = 4
                        },
                        new
                        {
                            Id = 5,
                            Number = 6
                        },
                        new
                        {
                            Id = 6,
                            Number = 8
                        });
                });

            modelBuilder.Entity("Data.Entities.NumberOfSeats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NumberOfSeats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            Number = 4
                        },
                        new
                        {
                            Id = 5,
                            Number = 6
                        },
                        new
                        {
                            Id = 6,
                            Number = 8
                        });
                });

            modelBuilder.Entity("Data.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            Number = 4
                        },
                        new
                        {
                            Id = 5,
                            Number = 5
                        });
                });

            modelBuilder.Entity("Data.Entities.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelRoomId")
                        .HasColumnType("int");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelRoomId");

                    b.HasIndex("RatingId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Good",
                            HotelRoomId = 1,
                            RatingId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "not Good",
                            HotelRoomId = 2,
                            RatingId = 2
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bad",
                            HotelRoomId = 3,
                            RatingId = 3
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Good",
                            HotelRoomId = 4,
                            RatingId = 4
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Good",
                            HotelRoomId = 5,
                            RatingId = 5
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Very Good",
                            HotelRoomId = 1,
                            RatingId = 4
                        });
                });

            modelBuilder.Entity("Data.Entities.TypeRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeRooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "penthouse"
                        },
                        new
                        {
                            Id = 2,
                            Name = "luxury"
                        },
                        new
                        {
                            Id = 3,
                            Name = "premium"
                        },
                        new
                        {
                            Id = 4,
                            Name = "normal"
                        },
                        new
                        {
                            Id = 5,
                            Name = "economy"
                        });
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entities.HotelRoom", b =>
                {
                    b.HasOne("Data.Entities.NumberOfBeds", "NumberOfBeds")
                        .WithMany("HotelRooms")
                        .HasForeignKey("NumberOfBedsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.NumberOfSeats", "NumberOfSeats")
                        .WithMany("HotelRooms")
                        .HasForeignKey("NumberOfSeatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.TypeRoom", "TypeRoom")
                        .WithMany("HotelRooms")
                        .HasForeignKey("TypeRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NumberOfBeds");

                    b.Navigation("NumberOfSeats");

                    b.Navigation("TypeRoom");
                });

            modelBuilder.Entity("Data.Entities.Response", b =>
                {
                    b.HasOne("Data.Entities.HotelRoom", "HotelRooms")
                        .WithMany("Responses")
                        .HasForeignKey("HotelRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Rating", "Rating")
                        .WithMany("Responses")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelRooms");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.HotelRoom", b =>
                {
                    b.Navigation("Responses");
                });

            modelBuilder.Entity("Data.Entities.NumberOfBeds", b =>
                {
                    b.Navigation("HotelRooms");
                });

            modelBuilder.Entity("Data.Entities.NumberOfSeats", b =>
                {
                    b.Navigation("HotelRooms");
                });

            modelBuilder.Entity("Data.Entities.Rating", b =>
                {
                    b.Navigation("Responses");
                });

            modelBuilder.Entity("Data.Entities.TypeRoom", b =>
                {
                    b.Navigation("HotelRooms");
                });
#pragma warning restore 612, 618
        }
    }
}

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
    [DbContext(typeof(AuctionDBContext))]
    [Migration("20241024163048_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityNow")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentPrice")
                        .HasColumnType("int");

                    b.Property<bool>("IsSold")
                        .HasColumnType("bit");

                    b.Property<string>("MinDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("StartPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VenichleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("Data.Entities.Bid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuctionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BidTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.HasIndex("UserId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuctionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CommentTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSeller")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

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

            modelBuilder.Entity("Data.Entities.VenichleInfo.BodyStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BodyStyles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Style = "Sedan"
                        },
                        new
                        {
                            Id = 2,
                            Style = "Coupe"
                        },
                        new
                        {
                            Id = 3,
                            Style = "Hatchback"
                        },
                        new
                        {
                            Id = 4,
                            Style = "SUV"
                        },
                        new
                        {
                            Id = 5,
                            Style = "Crossover"
                        },
                        new
                        {
                            Id = 6,
                            Style = "Convertible"
                        },
                        new
                        {
                            Id = 7,
                            Style = "Wagon"
                        },
                        new
                        {
                            Id = 8,
                            Style = "Van"
                        },
                        new
                        {
                            Id = 9,
                            Style = "Truck"
                        },
                        new
                        {
                            Id = 10,
                            Style = "Minivan"
                        },
                        new
                        {
                            Id = 11,
                            Style = "Pickup"
                        },
                        new
                        {
                            Id = 12,
                            Style = "Bus"
                        },
                        new
                        {
                            Id = 13,
                            Style = "Limousine"
                        },
                        new
                        {
                            Id = 14,
                            Style = "Cabriolet"
                        },
                        new
                        {
                            Id = 15,
                            Style = "Roadster"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Honda"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Hyundai"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Kia"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Mazda"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Nissan"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Volkswagen"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gasoline"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Diesel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electric"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hybrid"
                        },
                        new
                        {
                            Id = 5,
                            Name = "LPG"
                        },
                        new
                        {
                            Id = 6,
                            Name = "CNG"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Name = "A3"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            Name = "A4"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            Name = "A5"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1,
                            Name = "A6"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 1,
                            Name = "A7"
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 1,
                            Name = "A8"
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 1,
                            Name = "Q3"
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 1,
                            Name = "Q5"
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 1,
                            Name = "Q7"
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 1,
                            Name = "Q8"
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 2,
                            Name = "X1"
                        },
                        new
                        {
                            Id = 12,
                            BrandId = 2,
                            Name = "X2"
                        },
                        new
                        {
                            Id = 13,
                            BrandId = 2,
                            Name = "X3"
                        },
                        new
                        {
                            Id = 14,
                            BrandId = 2,
                            Name = "X4"
                        },
                        new
                        {
                            Id = 15,
                            BrandId = 2,
                            Name = "X5"
                        },
                        new
                        {
                            Id = 16,
                            BrandId = 2,
                            Name = "X6"
                        },
                        new
                        {
                            Id = 17,
                            BrandId = 2,
                            Name = "X7"
                        },
                        new
                        {
                            Id = 18,
                            BrandId = 3,
                            Name = "Corvette"
                        },
                        new
                        {
                            Id = 19,
                            BrandId = 3,
                            Name = "Camaro"
                        },
                        new
                        {
                            Id = 20,
                            BrandId = 3,
                            Name = "Malibu"
                        },
                        new
                        {
                            Id = 21,
                            BrandId = 3,
                            Name = "Impala"
                        },
                        new
                        {
                            Id = 22,
                            BrandId = 4,
                            Name = "Mustang"
                        },
                        new
                        {
                            Id = 23,
                            BrandId = 4,
                            Name = "Fiesta"
                        },
                        new
                        {
                            Id = 24,
                            BrandId = 4,
                            Name = "Focus"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transmissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manual"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Automatic"
                        },
                        new
                        {
                            Id = 3,
                            Name = "CVT"
                        },
                        new
                        {
                            Id = 4,
                            Name = "DCT"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Venichle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuctionId")
                        .HasColumnType("int");

                    b.Property<int>("BodyStyleId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExteriorColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExteriorPhotosURLId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("HaveProblems")
                        .HasColumnType("bit");

                    b.Property<string>("InteriorColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteriorPhotosURLId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHTMLDescription")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHTMLProblemList")
                        .HasColumnType("bit");

                    b.Property<bool>("IsModified")
                        .HasColumnType("bit");

                    b.Property<string>("MainPhotoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufactureDate")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("Odometr")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Problems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId")
                        .IsUnique()
                        .HasFilter("[AuctionId] IS NOT NULL");

                    b.HasIndex("BodyStyleId");

                    b.HasIndex("BrandId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("ModelId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Venichles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Auction", b =>
                {
                    b.HasOne("Data.Entities.User", "Seller")
                        .WithMany("Auctions")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Data.Entities.Bid", b =>
                {
                    b.HasOne("Data.Entities.Auction", "Auction")
                        .WithMany("Bids")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "User")
                        .WithMany("Bids")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.HasOne("Data.Entities.Auction", "Auction")
                        .WithMany("Comments")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Model", b =>
                {
                    b.HasOne("Data.Entities.VenichleInfo.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Venichle", b =>
                {
                    b.HasOne("Data.Entities.Auction", "Auction")
                        .WithOne("Venichle")
                        .HasForeignKey("Data.Entities.VenichleInfo.Venichle", "AuctionId");

                    b.HasOne("Data.Entities.VenichleInfo.BodyStyle", "BodyStyle")
                        .WithMany("Venichles")
                        .HasForeignKey("BodyStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.Brand", "Brand")
                        .WithMany("Venichles")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.FuelType", "FuelType")
                        .WithMany("Venichles")
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.Model", "Model")
                        .WithMany("Venichles")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "Owner")
                        .WithMany("Venichles")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.Transmission", "Transmission")
                        .WithMany("Venichles")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("BodyStyle");

                    b.Navigation("Brand");

                    b.Navigation("FuelType");

                    b.Navigation("Model");

                    b.Navigation("Owner");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.Auction", b =>
                {
                    b.Navigation("Bids");

                    b.Navigation("Comments");

                    b.Navigation("Venichle")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Navigation("Auctions");

                    b.Navigation("Bids");

                    b.Navigation("Comments");

                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.BodyStyle", b =>
                {
                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Brand", b =>
                {
                    b.Navigation("Models");

                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.FuelType", b =>
                {
                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Model", b =>
                {
                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Transmission", b =>
                {
                    b.Navigation("Venichles");
                });
#pragma warning restore 612, 618
        }
    }
}

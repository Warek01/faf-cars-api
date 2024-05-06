﻿// <auto-generated />
using System;
using FafCarsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FafCarsApi.Migrations
{
    [DbContext(typeof(FafCarsDbContext))]
    partial class FafCarsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FafCarsApi.Models.Entities.Listing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("brand");

                    b.Property<int?>("Clearance")
                        .HasColumnType("integer")
                        .HasColumnName("clearance");

                    b.Property<string>("Color")
                        .HasMaxLength(7)
                        .HasColumnType("character varying(7)")
                        .HasColumnName("color");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(0) WITHOUT TIME ZONE")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TIMESTAMP(0) WITHOUT TIME ZONE")
                        .HasColumnName("deleted_at");

                    b.Property<string>("EngineType")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("engine_type");

                    b.Property<double?>("EngineVolume")
                        .HasColumnType("double precision")
                        .HasColumnName("engine_volume");

                    b.Property<int?>("Horsepower")
                        .HasColumnType("integer")
                        .HasColumnName("horsepower");

                    b.Property<int?>("Mileage")
                        .HasColumnType("integer")
                        .HasColumnName("mileage");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("model");

                    b.Property<string>("PreviewUrl")
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)")
                        .HasColumnName("preview_url");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uuid")
                        .HasColumnName("publisher_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("type");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(0) WITHOUT TIME ZONE")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("WheelSize")
                        .HasColumnType("integer")
                        .HasColumnName("wheel_size");

                    b.Property<int?>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("listings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2e9e7952-fdcc-4513-bf1d-63895758527e"),
                            BrandName = "BMW",
                            Clearance = 210,
                            Color = "#FFFFFF",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2024, 5, 6, 11, 3, 19, 769, DateTimeKind.Local).AddTicks(4580),
                            EngineType = "Petrol",
                            EngineVolume = 3.0,
                            Horsepower = 300,
                            Mileage = 15000,
                            ModelName = "X5",
                            Price = 35000.0,
                            PublisherId = new Guid("5a473516-a69e-4c63-8738-4dcb0b8facbd"),
                            Type = "SUV",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 20,
                            Year = 2018
                        },
                        new
                        {
                            Id = new Guid("a672397c-869c-4c27-ac88-41cb2cd4b7bd"),
                            BrandName = "Toyota",
                            Clearance = 170,
                            Color = "#007A5E",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2024, 5, 6, 11, 3, 19, 771, DateTimeKind.Local).AddTicks(4748),
                            EngineType = "Hybrid",
                            EngineVolume = 2.5,
                            Horsepower = 208,
                            Mileage = 10000,
                            ModelName = "Camry",
                            Price = 25000.0,
                            PublisherId = new Guid("5a473516-a69e-4c63-8738-4dcb0b8facbd"),
                            Type = "Sedan",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 18,
                            Year = 2020
                        },
                        new
                        {
                            Id = new Guid("b9cd61df-314b-4911-b1fc-d6d6a1da990b"),
                            BrandName = "Ford",
                            Clearance = 230,
                            Color = "#FF0000",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Gasoline",
                            EngineVolume = 3.5,
                            Horsepower = 375,
                            Mileage = 25000,
                            ModelName = "F-150",
                            PreviewUrl = "https://localhost:44391/api/files/car-1.jpg",
                            Price = 30000.0,
                            PublisherId = new Guid("5a473516-a69e-4c63-8738-4dcb0b8facbd"),
                            Type = "Truck",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 17,
                            Year = 2019
                        },
                        new
                        {
                            Id = new Guid("6a8c01ed-f38d-475e-8200-387ce2a0859f"),
                            BrandName = "Honda",
                            Clearance = 160,
                            Color = "#002366",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Gasoline",
                            EngineVolume = 1.8,
                            Horsepower = 174,
                            Mileage = 20000,
                            ModelName = "Civic",
                            Price = 18000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Sedan",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 16,
                            Year = 2017
                        },
                        new
                        {
                            Id = new Guid("5f9a4f6d-0755-42af-8183-e0848c3c0bb2"),
                            BrandName = "Mercedes-Benz",
                            Clearance = 180,
                            Color = "#1C1C1C",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Diesel",
                            EngineVolume = 2.0,
                            Horsepower = 240,
                            Mileage = 18000,
                            ModelName = "E-Class",
                            Price = 40000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Sedan",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 18,
                            Year = 2019
                        },
                        new
                        {
                            Id = new Guid("2e5d84da-14f1-4983-b32b-abc2a67eb5f1"),
                            BrandName = "Chevrolet",
                            Clearance = 250,
                            Color = "#800000",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Gasoline",
                            EngineVolume = 5.2999999999999998,
                            Horsepower = 355,
                            Mileage = 12000,
                            ModelName = "Silverado",
                            Price = 38000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Truck",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 20,
                            Year = 2021
                        },
                        new
                        {
                            Id = new Guid("c266620e-b20b-4954-8afe-8f4c18dd7fbc"),
                            BrandName = "Chevrolet",
                            Clearance = 250,
                            Color = "#800000",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Gasoline",
                            EngineVolume = 5.2999999999999998,
                            Horsepower = 355,
                            Mileage = 12000,
                            ModelName = "Silverado",
                            Price = 38000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Truck",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 20,
                            Year = 2021
                        },
                        new
                        {
                            Id = new Guid("4fda2bd6-d6ec-4f8c-9976-5e8dcd73d9aa"),
                            BrandName = "Ford",
                            Clearance = 230,
                            Color = "#0000FF",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Gasoline",
                            EngineVolume = 5.0,
                            Horsepower = 375,
                            Mileage = 10000,
                            ModelName = "F-150",
                            Price = 42000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Truck",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 18,
                            Year = 2022
                        },
                        new
                        {
                            Id = new Guid("010bf79f-1bad-4c05-a134-1c27c052c455"),
                            BrandName = "Toyota",
                            Clearance = 240,
                            Color = "#006400",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Gasoline",
                            EngineVolume = 3.5,
                            Horsepower = 278,
                            Mileage = 15000,
                            ModelName = "Tacoma",
                            Price = 34000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Truck",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 17,
                            Year = 2020
                        },
                        new
                        {
                            Id = new Guid("b4d3b071-6a76-440d-aa92-712e553001ef"),
                            BrandName = "Honda",
                            Clearance = 150,
                            Color = "#FFA500",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Gasoline",
                            EngineVolume = 2.0,
                            Horsepower = 174,
                            Mileage = 20000,
                            ModelName = "Civic",
                            Price = 22000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Sedan",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 16,
                            Year = 2019
                        },
                        new
                        {
                            Id = new Guid("5f68d3ea-7564-4e27-8ce0-131e83852a8e"),
                            BrandName = "BMW",
                            Clearance = 140,
                            Color = "#000000",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Gasoline",
                            EngineVolume = 2.0,
                            Horsepower = 255,
                            Mileage = 18000,
                            ModelName = "3 Series",
                            Price = 35000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Sedan",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 18,
                            Year = 2020
                        },
                        new
                        {
                            Id = new Guid("4d5602c4-699a-4f0f-bd4c-fcca31108773"),
                            BrandName = "Tesla",
                            Clearance = 160,
                            Color = "#FFFFFF",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EngineType = "Electric",
                            EngineVolume = 0.0,
                            Horsepower = 450,
                            Mileage = 5000,
                            ModelName = "Model 3",
                            Price = 50000.0,
                            PublisherId = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Type = "Sedan",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WheelSize = 19,
                            Year = 2021
                        });
                });

            modelBuilder.Entity("FafCarsApi.Models.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a473516-a69e-4c63-8738-4dcb0b8facbd"),
                            Password = "warek",
                            Username = "warek"
                        },
                        new
                        {
                            Id = new Guid("aff7ddad-8f4f-4e72-a20a-5090a3e6eb93"),
                            Password = "denis",
                            Username = "denis"
                        },
                        new
                        {
                            Id = new Guid("d709614d-2352-48a5-a179-ada7f26a9f65"),
                            Password = "alex",
                            Username = "alex"
                        },
                        new
                        {
                            Id = new Guid("155edea0-aecd-427f-9c33-ef089307b81f"),
                            Password = "test",
                            Username = "test"
                        },
                        new
                        {
                            Id = new Guid("6385173c-ff0c-467a-b973-5e3c1c540270"),
                            Password = "password",
                            Username = "user"
                        });
                });

            modelBuilder.Entity("FafCarsApi.Models.Entities.Listing", b =>
                {
                    b.HasOne("FafCarsApi.Models.Entities.User", "Publisher")
                        .WithMany("Listings")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("FafCarsApi.Models.Entities.User", b =>
                {
                    b.Navigation("Listings");
                });
#pragma warning restore 612, 618
        }
    }
}

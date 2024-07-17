﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FafCarsApi.Data;
using FafCarsApi.Enums;

namespace FafCarsApi.Models;

[Table("listings")]
public class Listing {
  [Key]
  [Column("id")]
  public Guid Id { get; set; }

  [StringLength(255)]
  [Column("brand_name")]
  public string BrandName { get; set; } = null!;

  [ForeignKey(nameof(BrandName))]
  [InverseProperty(nameof(Brand.Listings))]
  public Brand Brand { get; set; } = null!;

  [StringLength(255)]
  [Column("model_name")]
  public string? ModelName { get; set; }

  [ForeignKey($"{nameof(ModelName)},{nameof(BrandName)}")]
  [InverseProperty(nameof(Model.Listings))]
  public Model? Model { get; set; }

  [Column("created_at", TypeName = FafCarsDbContext.TimestampNoTimezoneSql)]
  public DateTime CreatedAt { get; set; }

  [Column("updated_at", TypeName = FafCarsDbContext.TimestampNoTimezoneSql)]
  public DateTime UpdatedAt { get; set; }

  [Range(0, double.MaxValue)]
  [Column("price")]
  public double? Price { get; set; }

  [Column("body_style")]
  public CarBodyStyle? BodyStyle { get; set; }

  [Range(0, int.MaxValue)]
  [Column("horsepower")]
  public int? Horsepower { get; set; }

  [Column("fuel_type")]
  public CarFuelType? FuelType { get; set; }

  [Column("engine_volume")]
  public double? EngineVolume { get; set; }

  [Column("color")]
  public CarColor? Color { get; set; }

  [Range(0, int.MaxValue)]
  [Column("clearance")]
  public int? Clearance { get; set; }

  [Range(0, int.MaxValue)]
  [Column("wheel_size")]
  public int? WheelSize { get; set; }

  [Range(0, int.MaxValue)]
  [Column("mileage")]
  public int? Mileage { get; set; }

  [Range(0, int.MaxValue)]
  [Column("production_year")]
  public int? ProductionYear { get; set; }

  [Column("images")]
  public List<string> Images { get; set; } = [];

  [Column("deleted_at", TypeName = FafCarsDbContext.TimestampNoTimezoneSql)]
  public DateTime? DeletedAt { get; set; }

  [Column("publisher_id")]
  public Guid PublisherId { get; set; }

  [ForeignKey(nameof(PublisherId))]
  [InverseProperty(nameof(User.Listings))]
  public User Publisher { get; set; } = null!;

  [InverseProperty(nameof(User.Favorites))]
  public List<User> UsersFavorites { get; set; } = [];

  [StringLength(2)]
  [Column("country_code")]
  public string CountryCode { get; set; } = null!;

  [ForeignKey(nameof(CountryCode))]
  [InverseProperty(nameof(Country.Listings))]
  public Country Country { get; set; } = null!;

  [StringLength(255)]
  [Column("city")]
  public string? City { get; set; }

  [StringLength(255)]
  [Column("sell_address")]
  public string? SellAddress { get; set; }

  [Column("car_status")]
  public CarStatus? CarStatus { get; set; }

  [Column("description")]
  public string? Description { get; set; }

  [Column("status")]
  [DefaultValue(ListingStatus.Available)]
  public ListingStatus Status { get; set; }

  [Column("blocked_at", TypeName = FafCarsDbContext.TimestampNoTimezoneSql)]
  public DateTime? BlockedAt { get; set; }

  [Column("sold_at", TypeName = FafCarsDbContext.TimestampNoTimezoneSql)]
  public DateTime? SoldAt { get; set; }
}

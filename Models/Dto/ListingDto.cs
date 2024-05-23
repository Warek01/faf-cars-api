﻿using AutoMapper;
using FafCarsApi.Models.Entities;

namespace FafCarsApi.Models.Dto;

public class ListingDto {
  public Guid Id { get; set; }
  public string BrandName { get; set; } = null!;
  public string ModelName { get; set; } = null!;
  public double Price { get; set; }
  public string Type { get; set; } = null!;
  public int? Horsepower { get; set; }
  public string? EngineType { get; set; }
  public double? EngineVolume { get; set; }
  public string? Color { get; set; }
  public int? Clearance { get; set; }
  public int? WheelSize { get; set; }
  public int? Mileage { get; set; }
  public int? Year { get; set; }
  public DateTime UpdatedAt { get; set; }
  public DateTime CreatedAt { get; set; }
  public UserDto? Publisher { get; set; }
  public string? Preview { get; set; }
  public List<string> Images { get; set; } = new();

  // From listings -----------------------------------------
  public static ListingDto FromListing(Listing l) {
    var config = new MapperConfiguration(
      cfg =>
        cfg.CreateMap<Listing, ListingDto>()
          .ForMember(dest => dest.Publisher, opt => opt.Ignore())
    );
    var mapper = config.CreateMapper();

    var dto = new ListingDto();
    mapper.Map(l, dto);

    dto.Publisher = UserDto.FromUser(l.Publisher);

    return dto;
  }

  public static ListingDto FromListingWithoutPublisher(Listing l) {
    var dto = FromListing(l);

    dto.Publisher = null;

    return dto;
  }
}

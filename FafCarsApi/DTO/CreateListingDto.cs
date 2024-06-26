using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FafCarsApi.Enums;

namespace FafCarsApi.Dto;

public class CreateListingDto {
  [DefaultValue("Toyota")]
  public string BrandName { get; set; } = null!;

  [DefaultValue("Camry")]
  public string ModelName { get; set; } = null!;

  [DefaultValue(12500)]
  [Range(0, double.MaxValue)]
  public double Price { get; set; }

  [DefaultValue(BodyStyle.Sedan)]
  [EnumDataType(typeof(BodyStyle))]
  public BodyStyle BodyStyle { get; set; }

  [DefaultValue(220)]
  [Range(0, int.MaxValue)]
  public int? Horsepower { get; set; }

  [DefaultValue(EngineType.Hybrid)]
  public EngineType EngineType { get; set; }

  [DefaultValue(3.5)]
  [Range(0, double.MaxValue)]
  public double? EngineVolume { get; set; }

  [DefaultValue(CarColor.Black)]
  public CarColor Color { get; set; }

  [DefaultValue(20)]
  [Range(0, int.MaxValue)]
  public int? Clearance { get; set; }

  [DefaultValue(20)]
  [Range(0, int.MaxValue)]
  public int? WheelSize { get; set; }

  [DefaultValue(80000)]
  [Range(0, int.MaxValue)]
  public int? Mileage { get; set; }

  [DefaultValue(2019)]
  [Range(0, int.MaxValue)]
  public int? ProductionYear { get; set; }

  [Length(2, 2)]
  [DefaultValue("DE")]
  public string CountryCode { get; set; } = null!;

  [StringLength(255)]
  [DefaultValue("789 Oak Rd, Berlin, DE")]
  public string? SellAddress { get; set; }

  public FileDto? PreviewFile { get; set; }

  public List<FileDto> ImagesFiles { get; set; } = [];
}
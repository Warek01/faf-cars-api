using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Request;

public class CreateModelDto {
  [StringLength(255)]
  public string Name { get; set; } = null!;
  
  [StringLength(255)]
  public string BrandName { get; set; } = null!;
}

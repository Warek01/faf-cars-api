using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Request;

public class FileDto {
  private const int MaxFileSize = 5 * 1024 * 1024 * 4 / 3; // ~5 mb in base64

  [Length(1, 255)]
  public string? FileName { get; set; }

  [StringLength(MaxFileSize)]
  public string Base64Body { get; set; } = null!;

  public void Deconstruct(out string? fileName, out string base64Body) {
    fileName = FileName;
    base64Body = Base64Body;
  }
}

using System.ComponentModel.DataAnnotations;
using Api.Enums;

namespace Api.Dtos.Request;

public class UpdateUserDto {
  [Length(1, 255)]
  public string Username { get; set; } = null!;

  [Length(1, 255)]
  public string Email { get; set; } = null!;

  public List<UserRole> Roles { get; set; } = [];
}

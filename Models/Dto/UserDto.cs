﻿using AutoMapper;
using FafCarsApi.Models.Entities;

namespace FafCarsApi.Models.Dto;

public class UserDto {
  public Guid Id { get; set; }
  public string Username { get; set; } = null!;
  public string? Email { get; set; }
  public string? PhoneNumber { get; set; }
  public List<UserRole>? Roles { get; set; }
  public DateTime CreatedAt { get; set; }
}

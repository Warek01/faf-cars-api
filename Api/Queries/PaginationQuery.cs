﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Api.Queries;

public class PaginationQuery {
  [FromQuery(Name = "page")]
  [Range(0, int.MaxValue)]
  [DefaultValue(0)]
  public int Page { get; set; } = 0;

  [FromQuery(Name = "take")]
  [Range(0, int.MaxValue)]
  [DefaultValue(10)]
  public int Take { get; set; } = 10;

  [FromQuery(Name = "order")]
  public string? Order { get; set; }
}

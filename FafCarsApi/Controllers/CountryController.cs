using Asp.Versioning;
using AutoMapper;
using FafCarsApi.Dtos;
using FafCarsApi.Dtos.Response;
using FafCarsApi.Models;
using FafCarsApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FafCarsApi.Controllers;

[ApiController]
[AllowAnonymous]
[ApiVersion(1)]
[Route("Api/v{v:apiVersion}/Country")]
public class CountryController(
  IMapper mapper,
  CountryService countryService
) : Controller {
  [HttpGet]
  public async Task<ActionResult<PaginatedResultDto<CountryDto>>> GetCountries() {
    List<Country> countries = await countryService.GetCountries();
    List<CountryDto> dtos = countries.Select(mapper.Map<CountryDto>).ToList();
    var result = new PaginatedResultDto<CountryDto> {
      Items = dtos,
      TotalItems = dtos.Count,
    };

    return result;
  }

  [HttpGet]
  [Route("{code:length(2)}/Brands")]
  public async Task<ActionResult<PaginatedResultDto<BrandDto>>> GetCountryBrands(string code) {
    List<Brand> brands = await countryService.GetCountryBrands(code);
    List<BrandDto> dtos = brands.Select(mapper.Map<BrandDto>).ToList();

    return new PaginatedResultDto<BrandDto> {
      Items = dtos,
      TotalItems = dtos.Count,
    };
  }
}

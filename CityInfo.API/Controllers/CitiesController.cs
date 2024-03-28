﻿using CityInfo.API.Models;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;


[ApiController]
[Route("api/cities")]
public class CitiesController : ControllerBase
{
    private readonly ICityInfoRepository _cityInfoRepository;

    public CitiesController(ICityInfoRepository cityInfoRepository)
    {
        _cityInfoRepository = cityInfoRepository ?? throw new ArgumentNullException(nameof(cityInfoRepository));
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CityDto>>> GetCities()
    {
        var cityEntities = await _cityInfoRepository.GetCitiesAsync();

        var results = new List<CityWithoutPointsOfInterestDto>();
        foreach (var cityEntity in cityEntities)
        {
            results.Add(new CityWithoutPointsOfInterestDto { 
                 Id = cityEntity.Id,
                 Name = cityEntity.Name,
                 Description = cityEntity.Description
            });
        }
        return Ok(results);
       
    }

    [HttpGet("{id}")]
    public ActionResult<CityDto> GetCity(int id)
    {
        //var cityToReturn = _citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);

        //if (cityToReturn == null)
        //{
        //    return NotFound();
        //}

        //return Ok(cityToReturn);
        return Ok();
    }
}

// 9/12/2022

/*
$ export DOTNET_ROOT=$HOME/.dotnet
$ export PATH=$PATH:$HOME/.dotnet:$HOME/.dotnet/tools

$ dotnet new webapi
$ dotnet run

http://localhost:5054/swagger/index.html
*/


using Microsoft.AspNetCore.Mvc;

namespace _02_Proyecto.Controllers;

[ApiController]
[Route("/v1/servicios/eltiempo")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }


/*
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
*/
    
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<string> Get()
    {
        return new [] {"Madrid", "Barcelona", "Valencia"};
    }

    
    //[HttpGet("ciudad")]
    [HttpPost("ciudad")]
    public WeatherForecast GetCiudad(string ciudad)
    {
        return new WeatherForecast()
        {
            Date = new DateOnly(1900, 1, 15),
            TemperatureC = 25,
            Summary = ciudad
        };
    }
}

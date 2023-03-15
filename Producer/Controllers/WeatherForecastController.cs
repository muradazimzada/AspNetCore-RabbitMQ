using Microsoft.AspNetCore.Mvc;
using Producer.DTOs;

namespace Producer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        static List<WeatherForecast> weatherForecasts = new();
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return weatherForecasts;
        }
        [HttpPost()]
        public IActionResult CreateWeatherForeCast(WeatherForecast weatherForecast)
        {
            try
            {
                weatherForecasts.Add(weatherForecast);
                return Created("/WeatherForecastController", weatherForecast);
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}
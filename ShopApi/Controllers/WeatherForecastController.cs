using Microsoft.AspNetCore.Mvc;

namespace ShopApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpPost(Name = "PostWeatherForecast")]
        public IActionResult Post()
        {
            return NoContent();
        }

        [HttpGet(Name = "ReadWeatherForecast")]
        public IEnumerable<WeatherForecast> Read()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPut(Name = "UpdateWeatherForecast")]
        public IActionResult Update()
        {
            return NoContent();
        }

        [HttpDelete(Name = "DeleteWeatherForecast")]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}
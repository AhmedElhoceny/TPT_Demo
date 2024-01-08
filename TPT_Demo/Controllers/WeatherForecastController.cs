using Microsoft.AspNetCore.Mvc;

namespace TPT_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Services _services;

        public WeatherForecastController(Services services)
        {
            _services = services;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            _services.Method();
            return Ok();
        }
    }
}

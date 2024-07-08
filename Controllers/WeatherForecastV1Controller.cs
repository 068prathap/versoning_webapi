using Microsoft.AspNetCore.Mvc;

namespace Versioning.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    //[Route("api/{v:apiVersion}/weather")]
    [Route("api/weather")]
    public class WeatherForecastV1Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "version 1";
        }
    }
}

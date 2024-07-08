using Microsoft.AspNetCore.Mvc;

namespace Versioning.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    //[Route("api/{v:apiVersion}/weather")]
    [Route("api/weather")]
    public class WeatherForecastV2Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "version 2";
        }
    }
}

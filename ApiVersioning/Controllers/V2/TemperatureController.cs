using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.V2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    public class TemperatureController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            return Data.Summaries.Where(x => x.StartsWith("S"));
        }
    }
}
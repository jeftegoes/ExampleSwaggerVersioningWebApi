using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.V3.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("3.0")]
    public class TemperatureController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            return Data.Summaries.Where(x => x.StartsWith("C"));
        }
    }
}
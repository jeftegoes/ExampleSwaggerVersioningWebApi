using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningWithSwagger.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class TemperatureController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return Data.Summaries.Where(x => x.StartsWith("B"));
    }
}

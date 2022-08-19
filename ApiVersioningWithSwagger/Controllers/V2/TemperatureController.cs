using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningWithSwagger.Controllers.V2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class TemperatureController : ControllerBase
{
    [HttpGet("WithS ")]
    public IEnumerable<string> GetTemperatureWithS()
    {
        return Data.Summaries.Where(x => x.StartsWith("S"));
    }

    [HttpGet("WithC")]
    public IEnumerable<string> GetTemperatureWithC()
    {   
        return Data.Summaries.Where(x => x.StartsWith("C"));
    }
}

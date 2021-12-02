using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Sample.Serilog.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly ILogger<ClientController> _logger;

    public ClientController(ILogger<ClientController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        _logger.LogInformation("Endpoint Get successful. (from ILogger)");
        Log.Information("Endpoint Get successful. (from Serilog)");

        return Ok();
    }
}

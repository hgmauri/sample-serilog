using Microsoft.AspNetCore.Mvc;

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
    public async Task<IActionResult> Post()
    {
        return Ok();
    }
}

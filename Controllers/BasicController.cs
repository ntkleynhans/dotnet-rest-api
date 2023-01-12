using dotnet_webapi.Services.BasicService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_webapi.Controllers;
[ApiController]
[Route("[controller]")]
public class BasicController : ControllerBase
{

    private readonly ILogger<BasicController> _logger;
    private readonly IBasicService _basicService;

    public BasicController(ILogger<BasicController> logger, IBasicService basicService)
    {
        _logger = logger;
        _basicService = basicService;
    }

    [HttpGet(Name="GetBasic")]
    public async Task<ActionResult<ServiceResponse<GetBasicDto>>> Get()
    {
        _logger.LogInformation(1001, "Basic enter");
        var basic = await _basicService.GetBasic();
        return Ok(basic);
    }
}

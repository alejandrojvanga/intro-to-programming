using Microsoft.AspNetCore.Mvc;

namespace Bff.Api.Status;

public class StatusController : ControllerBase
{
    [HttpGet("/status")]
    public IActionResult GetTheStatus()
    {
        return Ok("~Everyhting is groovy");
    }
}

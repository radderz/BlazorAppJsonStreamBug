using Microsoft.AspNetCore.Mvc;

namespace BlazorAppJsonStreamBug.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TimeController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<DateTime>), StatusCodes.Status200OK)]
    public async IAsyncEnumerable<DateTime> GetTimeAsync()
    {
        while (!HttpContext.RequestAborted.IsCancellationRequested)
        {
            yield return DateTime.UtcNow;

            await Task.Delay(1000, HttpContext.RequestAborted);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace PreviaturasFing.Api.Controllers
{
    [ApiController]
    [Route("HealthCheck/")]
    public class HealthCheckController : ControllerBase
    {
        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;
        }

        [HttpGet("check")]
        public IActionResult Get()
        {
            _logger.LogInformation($"{nameof(HealthCheckController)} endpoint was invoked at: {DateTimeOffset.UtcNow}.");
            return Ok($"Previas API is up and running in: {Environment.MachineName}");
        }
    }
}
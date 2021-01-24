using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DynamicLogTestService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoodLifeSecretController : ControllerBase
    {
        private readonly ILogger<GoodLifeSecretController> _logger;

        public GoodLifeSecretController(ILogger<GoodLifeSecretController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Important custom log on INFO level");
            _logger.LogDebug("Important custom log on DEBUG level");

            return "Don't worry be happy";
        }
    }
}
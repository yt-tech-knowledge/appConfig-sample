using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppConfigurationSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var keyOne = _configuration.GetValue<string>("primeirakey");
            var keyTwo = _configuration.GetValue<string>("segundakey");

            return Ok(new { KeyOne = keyOne, KeyTwo = keyTwo });
        }
    }
}

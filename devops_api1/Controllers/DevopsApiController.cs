using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace devops_api1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevopsApiController : ControllerBase
    {
        private readonly ILogger<DevopsApiController> _logger;

        public DevopsApiController(ILogger<DevopsApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = $"{Assembly.GetExecutingAssembly().GetName()} {Assembly.GetExecutingAssembly().ImageRuntimeVersion} {DateTime.UtcNow:F}";
            
            return new ObjectResult(response);
        }
    }
}

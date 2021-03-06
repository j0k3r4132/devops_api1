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
            var response = $"Production branch {DateTime.UtcNow:F}";
            
            return new ObjectResult(response);
        }
    }
}

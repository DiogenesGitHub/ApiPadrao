using Microsoft.AspNetCore.Mvc;

namespace ApiRestFull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessController : ControllerBase
    {
        private readonly ILogger<ProcessController> _logger;

        public ProcessController(ILogger<ProcessController> logger)
        {
            _logger = logger;
        }

        [HttpGet("api/v1/Start")]
        public void Get()
        {
        }
    }
}
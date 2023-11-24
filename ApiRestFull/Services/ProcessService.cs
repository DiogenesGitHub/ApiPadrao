using ApiRestFull.Services.Interfaces;

namespace ApiRestFull.Services
{
    public class ProcessService : IProcessService
    {
        private readonly ILogger<ProcessService> _logger;

        public ProcessService(ILogger<ProcessService> logger) 
        {
            _logger = logger;
        }
    }
}

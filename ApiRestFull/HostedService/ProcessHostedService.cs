namespace ApiRestFull.HostedService
{
    public class ProcessHostedService
    {
        private readonly ILogger<ProcessHostedService> _logger;

        public ProcessHostedService(ILogger<ProcessHostedService> logger)
        {
            _logger = logger;
        }
    }
}

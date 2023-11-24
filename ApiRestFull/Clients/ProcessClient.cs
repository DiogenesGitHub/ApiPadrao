using ApiRestFull.Clients.Interfaces;

namespace ApiRestFull.Clients
{
    public class ProcessClient : IProcessClient
    {
        private readonly ILogger<ProcessClient> _logger;

        public ProcessClient(ILogger<ProcessClient> logger) 
        {
            _logger = logger;
        }
    }
}

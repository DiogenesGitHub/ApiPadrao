using ApiRestFull.Clients.Interfaces;
using ApiRestFull.Repositories.Interfaces;
using ApiRestFull.Services.Interfaces;

namespace ApiRestFull.Services
{
    public class ProcessService : IProcessService
    {
        private readonly ILogger<ProcessService> _logger;
        private readonly IProcessRepositorie _processRepositorie;
        private readonly IProcessClient _processClient;

        public ProcessService(ILogger<ProcessService> logger, IProcessRepositorie processRepositorie, IProcessClient processClient) 
        {
            _logger = logger;
            _processRepositorie = processRepositorie;
            _processClient = processClient;
        }

        public async Task ExecuteProcess() 
        {
            try
            {

            }
            catch (Exception e)
            {
                _logger.LogError($"Erro na aplicacao. => Erro: {e.Message}");
            }
        }
    }
}

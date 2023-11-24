using ApiRestFull.Services.Interfaces;
using Quartz;

namespace ApiRestFull.HostedService
{
    public class ProcessHostedService : IJob
    {
        private readonly ILogger<ProcessHostedService> _logger;
        private readonly IProcessService _processService;


        public ProcessHostedService(ILogger<ProcessHostedService> logger, IProcessService processService)
        {
            _logger = logger;
            _processService = processService;
        }

        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                _logger.LogInformation($"Iniciando... {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}");

                _processService.ExecuteProcess();

                _logger.LogInformation($"Finalizando... {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}");
            }
            catch (Exception e)
            {
                _logger.LogError($"Erro na aplicacao. => Erro: {e.Message}");
            }


            return Task.FromResult(context.CancellationToken);
        }
    }
}

using ApiRestFull.Repositories.Interfaces;
using ApiRestFull.Services;

namespace ApiRestFull.Repositories
{
    public class ProcessRepositorie : IProcessRepositorie
    {
        private readonly ILogger<ProcessRepositorie> _logger;

        public ProcessRepositorie(ILogger<ProcessRepositorie> logger)
        {
            _logger = logger;
        }

        public async Task GetDados()
        {
            try
            {

            }
            catch (Exception e)
            {
                _logger.LogError
            }
        }
    }
}

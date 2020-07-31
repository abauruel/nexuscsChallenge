using Nexuscs.domain.Interfaces.Services;
using NexuscsChallenge.application.Interface;
using NexuscsChallenge.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexuscsChallenge.application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            :base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> GetClientesMaster()
        {
            return _clienteService.GetClientesMaster(_clienteService.GetAll());
        }
    }
}

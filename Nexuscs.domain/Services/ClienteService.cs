using Nexuscs.domain.Interfaces;
using Nexuscs.domain.Interfaces.Services;
using NexuscsChallenge.domain.Entities;
using NexuscsChallenge.domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexuscs.domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
            :base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetClientesMaster(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteMaster(c));
        }
    }
}

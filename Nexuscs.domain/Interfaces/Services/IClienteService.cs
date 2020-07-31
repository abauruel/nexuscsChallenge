using NexuscsChallenge.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexuscs.domain.Interfaces.Services
{
    public interface IClienteService:IServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetClientesMaster(IEnumerable<Cliente> clientes);
    }
}

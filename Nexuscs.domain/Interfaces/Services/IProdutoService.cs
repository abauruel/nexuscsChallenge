using NexuscsChallenge.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexuscs.domain.Interfaces.Services
{
    public interface IProdutoService:IServiceBase<Produto>
    {
        IEnumerable<Produto> GetByName(string name);
    }
}

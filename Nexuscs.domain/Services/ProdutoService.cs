using Nexuscs.domain.Interfaces;
using Nexuscs.domain.Interfaces.Services;
using NexuscsChallenge.domain.Entities;
using NexuscsChallenge.domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexuscsChallenge.domain.Services
{
    class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            :base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> GetByName(string name)
        {
            return _produtoRepository.GetByName(name);
        }
    }
}

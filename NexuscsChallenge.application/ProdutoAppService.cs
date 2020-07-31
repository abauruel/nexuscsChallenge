using NexocsChallenge.Domain.Entities;
using NexocsChallenge.Domain.Interfaces.Services;

using NexuscsChallenge.application.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexuscsChallenge.application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            :base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> GetByName(string name)
        {
            return _produtoService.GetByName(name);
        }
    }
}

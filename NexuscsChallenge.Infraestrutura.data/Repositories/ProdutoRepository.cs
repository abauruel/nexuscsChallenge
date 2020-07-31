using NexocsChallenge.Domain.Entities;
using NexocsChallenge.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexuscsCalenge.Infraestrutura.data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {

        public IEnumerable<Produto> GetByName(string name)
        {
            return _context.Produtos.Where(p => p.Nome == name);
        }
    }
}

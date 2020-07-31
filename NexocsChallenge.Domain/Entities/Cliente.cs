using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexocsChallenge.Domain.Entities
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteMaster(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}

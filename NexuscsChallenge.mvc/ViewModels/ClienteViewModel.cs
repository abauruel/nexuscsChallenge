using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NexuscsChallenge.mvc.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        [Required(ErrorMessage ="Campo email e requerido")]
        [EmailAddress(ErrorMessage ="Insira um email valido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
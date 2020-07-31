using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NexuscsChallenge.mvc.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage ="Insira um valor valido")]
        [Range(typeof(decimal), "0","9999999999")]
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClientId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}
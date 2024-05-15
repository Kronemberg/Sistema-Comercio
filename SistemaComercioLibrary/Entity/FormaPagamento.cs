using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class FormaPagamento
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Parcela { get; set; }
        public virtual List<FormaPagamentoVenda> FormaPagamentoVenda { get; set; }
    }
}

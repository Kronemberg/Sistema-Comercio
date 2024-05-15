using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Venda
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Data { get; set; }
        [Required]
        public string Hora { get; set; }
        [Required]
        public double Total_Venda { get; set; }
        [Required]
        public string Situacao_Venda { get; set; }
        [Required]
        public virtual Cliente Cliente { get; set; }

        public int Id_Cliente { get; set; }
        public virtual List<FormaPagamentoVenda> FormaPagamentoVenda { get; set; }
        public virtual List<ItemVenda> ItemVenda { get; set; }

    }
}

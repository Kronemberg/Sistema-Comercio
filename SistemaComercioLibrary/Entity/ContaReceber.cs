using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class ContaReceber
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime Data_Lancamento { get; set; }
        [Required]
        public DateTime Data_Vencimento { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public double Recebido { get; set; }
        [Required]
        public DateTime Data_Recebimento { get; set; }
        [Required]
        public double Valor_Recebimento { get; set; }
        public int Parcela { get; set; }
        [Required]
        public string FormaPagamento { get; set; }
        [Required]
        public virtual Cliente Cliente { get; set; }
        public int Id_Cliente { get; set; }
    }
}

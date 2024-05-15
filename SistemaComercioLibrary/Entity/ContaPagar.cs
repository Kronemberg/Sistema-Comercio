using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class ContaPagar
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
        public double Pago { get; set; }
        [Required]
        public DateTime Data_Pagamento { get; set; }
        [Required]
        public double Valor_Pagamento { get; set; }
        public int Parcela { get; set; }
        [Required]
        public string FormaPagamento { get; set; }
        [Required]
        public virtual Fornecedor Fornecedor { get; set; }
        public int Id_Fornecedor { get; set; }
    }
}

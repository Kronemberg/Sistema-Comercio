using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class FormaPagamentoVenda
    {
        [Key]
        public int Id { get; set; }
        public double Valor { get; set; }
        public virtual Venda Venda { get; set; }
        public int Id_Venda { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public int Id_FormaPagamento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class MovimentoCaixa
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Data_Movimento { get; set; }
        [Required]
        public DateTime Hora_Movimento { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Tipo_Movimento { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public virtual Caixa Caixa { get; set; }

        public int Quantidade { get; set; }

        public int Id_Caixa { get; set; }

        public string FormaPagamento { get; set; }
        public string Parcelamento { get; set; }

    }


}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaComercioLibrary.Classes
{
    public class Caixa
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Saldo { get; set; }
        public double SaldoAnterior { get; set; }


        public virtual List<MovimentoCaixa> MovimentoCaixa { get; set; } = new List<MovimentoCaixa>();


    }
}

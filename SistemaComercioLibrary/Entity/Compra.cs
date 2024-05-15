using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Compra
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Data { get; set; }
        [Required]
        public string Hora { get; set; }
        [Required]
        public double Total_Compra { get; set; }
        [Required]
        public string Situacao_Compra { get; set; }
        [Required]
        public virtual Fornecedor Fornecedor { get; set; }

        public int Id_Fornecedor { get; set; }
        public virtual List<ItemCompra> ItemCompra { get; set; }

    }
}

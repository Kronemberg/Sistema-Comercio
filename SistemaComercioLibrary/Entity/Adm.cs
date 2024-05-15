using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class Adm
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string Usuario { get; set; }
        [Required]
        public string Senha { get; set; }
       
        public double Salario { get; set; }
    }
}

using SistemaComercioBiblioteca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string Cpf_Cnpj { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }


        public virtual List<Produto> Produto { get; set; }
        public virtual List<ContaPagar> ContaPagar { get; set; }
        public virtual List<Compra> Compra { get; set; }
    }
}

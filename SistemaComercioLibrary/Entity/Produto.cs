using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaComercioBiblioteca.Classes
{

    public class Produto
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Quantidade_Estoque { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public string Unidade { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public int Id_Fornecedor { get; set; }
        public virtual List<ItemVenda> ItemVenda { get; set; }
        public virtual List<ItemCompra> ItemCompra { get; set; }

    }
}

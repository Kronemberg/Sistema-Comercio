using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double Valor_Unitario { get; set; }
        public double Total_Item { get; set; }
        public virtual Venda Venda { get; set; }
        public int Id_Venda { get; set; }
        public virtual Produto Produto { get; set; }
        public int Id_Produto { get; set; }
    }
}

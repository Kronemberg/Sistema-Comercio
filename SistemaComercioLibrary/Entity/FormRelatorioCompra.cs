using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class FormRelatorioCompra
    {
        public string Id { get; set; }
        public string Produto { get; set; }
        public string Quantidade { get; set; }
        public string ValorUnitario { get; set; }
        public string Total { get; set; }
        public string Situacao { get; set; }
        public string Data { get; set; }
        public string Fornecedor { get; set; }
        public string Hora { get; set; }
        public string xx { get; set; }

        public List<string> Produtos { get; set; }

         public FormRelatorioCompra(ItemCompra obj)
        {
            Id = obj.Id.ToString();
            Produto = obj.Produto.Nome ;
            Quantidade = obj.Quantidade.ToString();
            ValorUnitario = 5.ToString();
            Total = obj.Compra.Total_Compra.ToString();
            Situacao = obj.Compra.Situacao_Compra;
            Data = obj.Compra.Data.ToString();
            Fornecedor = obj.Compra.Fornecedor.Nome;
            Hora = obj.Compra.Hora.ToString();

        }

        public FormRelatorioCompra()
        {
            Produtos = new List<string>();

        }
    }
}

using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class FormRelatorioVenda
    {
        public string Id { get; set; }
        public string Produto { get; set; }
        public string Quantidade { get; set; }
        public string ValorUnitario { get; set; }
        public string Total { get; set; }
        public string Situacao { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Cliente { get; set; }

        public List<string> Produtos { get; set; }

        public FormRelatorioVenda(ItemVenda obj)
        {
            Id = obj.Id.ToString();
            Produto = obj.Produto.Nome;
            Quantidade = obj.Quantidade.ToString();
            ValorUnitario = 5.ToString();
            Total = obj.Venda.Total_Venda.ToString();
            Situacao = obj.Venda.Situacao_Venda;
            Data = obj.Venda.Data.ToString();
            Cliente = obj.Venda.Cliente.Nome;
            Hora = obj.Venda.Hora.ToString();

        }

        public FormRelatorioVenda()
        {
            Produtos = new List<string>();

        }
    }
}

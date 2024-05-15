using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class FormRelatorioContaReceber
    {

        public string Id { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }
        public string DataLancamento { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Recebido { get; set; }
        public string DataRecebimento { get; set; }
        public string ValorRecebimento { get; set; }
        public string FormaPagamento { get; set; }
        public string Parcelamento { get; set; }
        public string Cliente { get; set; }


        public List<string> Vendas { get; set; }

        public FormRelatorioContaReceber(ContaReceber obj)
        {
            Id = obj.Id.ToString();
            Descricao = obj.Descricao;
            DataLancamento = obj.Data_Lancamento.ToString("dd-MM-yyyy");
            DataVencimento = obj.Data_Vencimento.ToString("dd-MM-yyyy");
            Valor = obj.Valor.ToString();
            Recebido = obj.Recebido.ToString();
            DataRecebimento = obj.Data_Recebimento.ToString("dd-MM-yyyy");
            ValorRecebimento = obj.Valor_Recebimento.ToString();
            FormaPagamento = obj.FormaPagamento;
            Parcelamento = obj.Parcela.ToString();
            Cliente = obj.Cliente.Nome;

            if (!Parcelamento.Equals("0"))
                Parcelamento += "x";

        }

        public FormRelatorioContaReceber(ItemVenda itemVenda)
        {

            Id = itemVenda.Id.ToString();
            Descricao = itemVenda.Venda.ItemVenda.First().Produto.Nome;
            DataLancamento = itemVenda.Venda.Data;
            DataVencimento = Convert.ToDateTime(DataLancamento).AddDays(2).ToString("dd-MM-yyyy");
            Valor = itemVenda.Total_Item.ToString();
            Recebido = "null";
            DataRecebimento = "null";
            ValorRecebimento = "null";
            FormaPagamento = "null";
            Parcelamento = "null";
            Cliente = itemVenda.Venda.Cliente.Nome;
            Status = itemVenda.Venda.Situacao_Venda;
        }

        public FormRelatorioContaReceber()
        {
            Vendas = new List<string>();
        }
    }
}

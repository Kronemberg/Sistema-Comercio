using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaComercioLibrary.Entity
{
    public class FormRelatorioContaPagar
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }
        public string DataLancamento { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Pago { get; set; }
        public string DataPagamento { get; set; }
        public string ValorPagamento { get; set; }
        public string FormaPagamento { get; set; }
        public string Parcelamento { get; set; }
        public string Fornecedor { get; set; }


        public List<string> Compras { get; set; }

        public FormRelatorioContaPagar(ContaPagar obj)
        {
            Id = obj.Id.ToString();
            Descricao = obj.Descricao;
            DataLancamento = obj.Data_Lancamento.ToString();
            DataVencimento = obj.Data_Vencimento.ToString();
            Valor = obj.Valor.ToString();
            Pago = obj.Pago.ToString();
            DataPagamento = obj.Data_Pagamento.ToString();
            ValorPagamento = obj.Valor_Pagamento.ToString();
            FormaPagamento = obj.FormaPagamento;
            Parcelamento = obj.Parcela.ToString();
            Fornecedor = obj.Fornecedor.Nome;

            if (!Parcelamento.Equals("0"))
                Parcelamento += "x";
        }

        public FormRelatorioContaPagar()
        {
            Compras = new List<string>();
        }

        public FormRelatorioContaPagar(ItemCompra itemCompra)
        {
            Id = itemCompra.Id.ToString();
            Descricao = itemCompra.Compra.ItemCompra.First().Produto.Nome;
            DataLancamento = itemCompra.Compra.Data;
            DataVencimento = Convert.ToDateTime(DataLancamento).AddDays(2).ToString();
            Valor = itemCompra.Total_Item.ToString();
            Pago = "null";
            DataPagamento = "null";
            ValorPagamento = "null";
            FormaPagamento = "null";
            Parcelamento = "null";
            Fornecedor = itemCompra.Compra.Fornecedor.Nome;
            Status = itemCompra.Compra.Situacao_Compra;
        }
    }
}

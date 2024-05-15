using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class FormRelatorioCaixa
    {
        public int Id { get; set; }

        public DateTime Data_Movimento { get; set; }

        public DateTime Hora_Movimento { get; set; }

        public string Descricao { get; set; }

        public string TipoMovimento { get; set; }

        public double Valor { get; set; }

        public double ValorCaixa { get; set; }

        public int Quantidade { get; set; }

        public string FormaPagamento { get; set; }

        public string Parcelamento { get; set; }

        public FormRelatorioCaixa(MovimentoCaixa movimento)
        {
            Id = movimento.Id;
            Data_Movimento = movimento.Data_Movimento;
            Hora_Movimento = movimento.Hora_Movimento;
            Descricao = movimento.Descricao;
            TipoMovimento = movimento.Tipo_Movimento;
            Valor = movimento.Valor;
            Quantidade = movimento.Quantidade;
            FormaPagamento = movimento.FormaPagamento;
            Parcelamento = movimento.Parcelamento;
        }
    }

}

using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Service
{
    public class ContaReceberService : IContaReceberPort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddContaReceber(ContaReceber contaReceber)
        {
            _db.ContaReceber.Add(contaReceber);
            _db.SaveChanges();
        }

        public void DelContaReceber(ContaReceber contaReceber)
        {
            _db.ContaReceber.Remove(contaReceber);
            _db.SaveChanges();
        }

        public List<ContaReceber> GetAllContaReceber()
        {
            return _db.ContaReceber.ToList();
        }

        public ContaReceber GetByIdContaReceber(int id)
        {
            return _db.ContaReceber.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }


        public void UpdateContaReceber(ContaReceber contaReceber)
        {
            var contaR = _db.ContaReceber.FirstOrDefault(x => x.Id == contaReceber.Id); //pega o id
            contaR.Descricao = contaReceber.Descricao;
            contaR.Data_Lancamento = contaReceber.Data_Lancamento;
            contaR.Data_Vencimento = contaReceber.Data_Vencimento;
            contaR.Valor = contaReceber.Valor;
            contaR.Recebido = contaReceber.Recebido;
            contaR.Data_Recebimento = contaReceber.Data_Recebimento;
            contaR.Valor_Recebimento = contaReceber.Valor_Recebimento;
            contaR.Id_Cliente = contaReceber.Id_Cliente;
        }
    }
}

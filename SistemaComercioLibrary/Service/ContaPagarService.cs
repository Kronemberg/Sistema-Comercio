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
    public class ContaPagarService : IContaPagarPort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddContaPagar(ContaPagar contaPagar)
        {
            _db.ContaPagar.Add(contaPagar);
            _db.SaveChanges();
        }

        public void DelContaPagar(ContaPagar contaPagar)
        {
            _db.ContaPagar.Remove(contaPagar);
            _db.SaveChanges();
        }

        public void UpdateContaPagar(ContaPagar contaPagar)
        {
            var contaP = _db.ContaPagar.FirstOrDefault(x => x.Id == contaPagar.Id); //pega o id
            contaP.Descricao = contaPagar.Descricao;
            contaP.Data_Lancamento = contaPagar.Data_Lancamento;
            contaP.Data_Vencimento = contaPagar.Data_Vencimento;
            contaP.Valor = contaPagar.Valor;
            contaP.Pago = contaPagar.Pago;
            contaP.Data_Pagamento = contaPagar.Data_Pagamento;
            contaP.Valor_Pagamento = contaPagar.Valor_Pagamento;
            contaP.Id_Fornecedor = contaPagar.Id_Fornecedor;
        }

        public List<ContaPagar> GetAllContaPagar()
        {
            return _db.ContaPagar.ToList();
        }

        public ContaPagar GetByIdContaPagar(int id)
        {
            return _db.ContaPagar.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }
    }
}

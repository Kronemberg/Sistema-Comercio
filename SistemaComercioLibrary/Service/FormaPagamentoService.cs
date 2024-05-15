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
    public class FormaPagamentoService : IFormaPagamentoPort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddFormaPagamento(FormaPagamento formaPagamento)
        {
            _db.FormaPagamento.Add(formaPagamento);
            _db.SaveChanges();
        }

        public void DelFormaPagamento(FormaPagamento formaPagamento)
        {
            _db.FormaPagamento.Remove(formaPagamento);
            _db.SaveChanges();
        }

        public List<FormaPagamento> GetAllFormaPagamento()
        {
            return _db.FormaPagamento.ToList();
        }

        public FormaPagamento GetByIdFormaPagamento(int id)
        {
            return _db.FormaPagamento.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }

        public void UpdateFormaPagamento(FormaPagamento formaPagamento)
        {
            var fp = _db.FormaPagamento.FirstOrDefault(x => x.Id == formaPagamento.Id); //pega o id
            fp.Nome = formaPagamento.Nome;
        }
    }
}

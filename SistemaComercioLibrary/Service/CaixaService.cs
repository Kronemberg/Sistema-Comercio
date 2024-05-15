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
    public class CaixaService : ICaixaPort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddCaixa(Caixa caixa)
        {
            _db.Caixa.Add(caixa);
            _db.SaveChanges();
        }

        public void DelCaixa(Caixa caixa)
        {
            _db.Caixa.Remove(caixa);
            _db.SaveChanges();
        }

        public List<Caixa> GetAllCaixa()
        {
            return _db.Caixa.ToList();
        }

        public Caixa GetByIdCaixa(int id)
        {
            return _db.Caixa.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }

        public void UpdateCaixa(Caixa caixa)
        {
            var cx = _db.Caixa.FirstOrDefault(x => x.Id == caixa.Id); //pega o id
            cx.Nome = caixa.Nome;
            cx.Saldo = caixa.Saldo;
            _db.SaveChanges();
        }
    }
}

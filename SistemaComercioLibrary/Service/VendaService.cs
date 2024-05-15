using SistemaComercioBiblioteca.Classes;
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
    public class VendaService : IVendaPort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public int Count()
        {
            return _db.Venda.Count();
        }

        public void AddVenda(Venda venda)
        {
            _db.Venda.Add(venda);
            _db.SaveChanges();
        }

        public void DelVenda(Venda venda)
        {
            _db.Venda.Remove(venda);
            _db.SaveChanges();
        }

        public List<Venda> GetAllVenda()
        {
            return _db.Venda.ToList();
        }

        public void UpdateVenda(Venda venda)
        {
            var vnd = _db.Venda.FirstOrDefault(x => x.Id == venda.Id); //pega o id
            vnd.Data = venda.Data;
            vnd.Hora = venda.Hora;
            vnd.Total_Venda = venda.Total_Venda;
            vnd.Situacao_Venda = venda.Situacao_Venda;
            vnd.Id_Cliente = venda.Id_Cliente;
            _db.SaveChanges();

        }

        public Venda GetByIdVenda(int id)
        {
            return _db.Venda.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }
    }
}

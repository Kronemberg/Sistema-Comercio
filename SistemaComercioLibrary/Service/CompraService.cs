using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaComercioLibrary.Service
{
    public class CompraService : ICompraPort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public int Count()
        {
            return _db.Compra.Count();
        }

        public void AddCompra(Compra compra)
        {
            _db.Compra.Add(compra);
            _db.SaveChanges();
        }

        public void DelCompra(Compra compra)
        {
            _db.Compra.Remove(compra);
            _db.SaveChanges();
        }

        public List<Compra> GetAllCompra()
        {
            return _db.Compra.ToList();
        }

        public void UpdateCompra(Compra compra)
        {
            var cmp = _db.Compra.FirstOrDefault(x => x.Id == compra.Id); //pega o id
            cmp.Data = compra.Data;
            cmp.Hora = compra.Hora;
            cmp.Total_Compra = compra.Total_Compra;
            cmp.Situacao_Compra = compra.Situacao_Compra;
            cmp.Id_Fornecedor = compra.Id_Fornecedor;
            _db.SaveChanges();

        }

        public Compra GetByIdCompra(int id)
        {
            return _db.Compra.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }
    }
}

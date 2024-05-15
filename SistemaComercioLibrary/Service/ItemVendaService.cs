using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System.Collections.Generic;
using System.Linq;

namespace SistemaComercioLibrary.Service
{
    public class ItemVendaService : IItemVendaPort
    {
        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddItemVenda(ItemVenda itemVenda)
        {
            _db.ItemVenda.Add(itemVenda);
            _db.SaveChanges();
        }

        public void DelItemVenda(ItemVenda itemVenda)
        {
            _db.ItemVenda.Remove(itemVenda);
            _db.SaveChanges();
        }

        public List<ItemVenda> GetAllItemVenda()
        {
            return _db.ItemVenda.ToList();
        }

        public ItemVenda GetByIdItemVenda(int id)
        {
            return _db.ItemVenda.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }

        public void UpdateItemVenda(ItemVenda itemVenda)
        {
            var itemV = _db.ItemVenda.FirstOrDefault(x => x.Id == itemVenda.Id); //pega o id
            itemV.Total_Item = itemVenda.Total_Item;
            itemV.Quantidade = itemVenda.Quantidade;
            itemV.Valor_Unitario = itemVenda.Valor_Unitario;
            itemV.Id_Produto = itemVenda.Id_Produto;
            itemV.Id_Venda = itemVenda.Id_Venda;
            _db.SaveChanges();
        }
    }
}

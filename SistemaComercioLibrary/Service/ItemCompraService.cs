using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System.Collections.Generic;
using System.Linq;

namespace SistemaComercioLibrary.Service
{
    public class ItemCompraService : IItemCompraPort
    {
        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddItemCompra(ItemCompra itemCompra)
        {
            _db.ItemCompra.Add(itemCompra);
            _db.SaveChanges();
        }

        public void DelItemCompra(ItemCompra itemCompra)
        {
            _db.ItemCompra.Remove(itemCompra);
            _db.SaveChanges();
        }

        public List<ItemCompra> GetAllItemCompra()
        {
            return _db.ItemCompra.OrderBy(itemCompra => itemCompra).ToList();
        }

        public ItemCompra GetByIdItemCompra(int id)
        {
            var result =  _db.ItemCompra.FirstOrDefault(x => x.Id.Equals(id)); //pega o id

            result.Produto = _db.Produto.FirstOrDefault(x => x.Id.Equals(result.Id_Produto));
                
          return result;
        }

        public void UpdateItemCompra(ItemCompra itemCompra)
        {
            var itemC = _db.ItemCompra.FirstOrDefault(x => x.Id == itemCompra.Id); //pega o id
            itemC.Total_Item = itemCompra.Total_Item;
            itemC.Quantidade = itemCompra.Quantidade;
            itemC.Valor_Unitario = itemCompra.Valor_Unitario;
            itemC.Id_Produto = itemCompra.Id_Produto;
            itemC.Id_Compra = itemCompra.Id_Compra;
            _db.SaveChanges();
        }
    }
}

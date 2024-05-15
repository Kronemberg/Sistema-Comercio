using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IItemCompraPort
    {
        void AddItemCompra(ItemCompra itemCompra);
        void UpdateItemCompra(ItemCompra itemCompra);
        void DelItemCompra(ItemCompra itemCompra);
        List<ItemCompra> GetAllItemCompra();
        ItemCompra GetByIdItemCompra(int id);
    }
}

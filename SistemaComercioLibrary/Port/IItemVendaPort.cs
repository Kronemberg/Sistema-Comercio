using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IItemVendaPort
    {
        void AddItemVenda(ItemVenda itemVenda);
        void UpdateItemVenda(ItemVenda itemVenda);
        void DelItemVenda(ItemVenda itemVenda);
        List<ItemVenda> GetAllItemVenda();
        ItemVenda GetByIdItemVenda(int id);
    }
}


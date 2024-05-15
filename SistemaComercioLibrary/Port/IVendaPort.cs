using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IVendaPort
    {
        int Count();
        void AddVenda(Venda venda);
        void DelVenda(Venda venda);
        void UpdateVenda(Venda venda);
        List<Venda> GetAllVenda();
        Venda GetByIdVenda(int id);
    }
}

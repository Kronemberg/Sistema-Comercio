using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface ICompraPort
    {
        int Count();
        void AddCompra(Compra compra);
        void DelCompra(Compra compra);
        void UpdateCompra(Compra compra);
        List<Compra> GetAllCompra();
        Compra GetByIdCompra(int id);
    }
}

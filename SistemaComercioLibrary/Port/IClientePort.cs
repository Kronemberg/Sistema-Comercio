using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IClientePort
    {
        int Count();
        void AddCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DelCliente(Cliente cliente);
        List<Cliente> GetAllCliente();
        Cliente GetByNomeCliente(string nome);
        Cliente GetByIdCliente(int id);
    }
}

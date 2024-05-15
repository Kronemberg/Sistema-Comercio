using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IProdutoPort
    {
        int Count();
        void AddProduto(Produto produto);
        void UpdateProduto(Produto produto);
        void DelProduto(Produto produto);
        List<Produto> GetAllProduto();
        Produto GetByIdProduto(int id);
        Produto GetByName(string name);
        List<Produto> GetAllVenda();

    }
}

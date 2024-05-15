using SistemaComercioLibrary.Classes;
using System.Collections.Generic;

namespace SistemaComercioLibrary.Port
{
    public interface IFornecedorPort
    {
        int Count();
        void AddFornecedor(Fornecedor fornecedor);
        void UpdateFornecedor(Fornecedor fornecedor);
        void DelFornecedor(Fornecedor fornecedor);
        Fornecedor GetByNomeFornecedor(string nome);
        Fornecedor GetByIdFornecedor(int id);
        List<Fornecedor> GetAllFornecedor();
    }
}

using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System.Collections.Generic;
using System.Linq;

namespace SistemaComercioLibrary.Service
{
    public class ProdutoService : IProdutoPort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public int Count()
        {
            return _db.Produto.Count();
        }

        public void AddProduto(Produto produto)
        {
            _db.Produto.Add(produto);
            _db.SaveChanges();
        }

        public void DelProduto(Produto produto)
        {
            _db.Produto.Remove(produto);
            _db.SaveChanges();
        }

        public void UpdateProduto(Produto produto)
        {
            var prod = _db.Produto.FirstOrDefault(x => x.Id == produto.Id); //pega o id
            prod.Nome = produto.Nome;
            prod.Preco = produto.Preco;
            prod.Quantidade_Estoque = produto.Quantidade_Estoque;
            prod.Unidade = produto.Unidade;
            prod.Id_Fornecedor = produto.Id_Fornecedor;
            _db.SaveChanges();
        }

        public List<Produto> GetAllProduto()
        {
            return _db.Produto.ToList();
        }

        public Produto GetByIdProduto(int id)
        {
            var produto = _db.Produto.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
            var fornecedor = _db.Fornecedor.FirstOrDefault(x => x.Id.Equals(produto.Id_Fornecedor)); //pega o id
            produto.Fornecedor = fornecedor;
            return produto;
        }

        public Produto GetByName(string name)
        {
            var produto = _db.Produto.FirstOrDefault(x => x.Nome.Equals(name)); //pega o id
            return produto;
        }

        public List<Produto> GetAllVenda()
        {
            var produto = _db.Produto.Where(x => x.Quantidade_Estoque > 0).ToList();
            return produto;
        }

    }
}

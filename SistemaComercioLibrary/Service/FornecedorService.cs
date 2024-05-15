using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Service
{
    public class FornecedorService : IFornecedorPort
    {
        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public int Count()
        {
            return _db.Fornecedor.Count();
        }

        public void AddFornecedor(Fornecedor fornecedor)
        {
            _db.Fornecedor.Add(fornecedor);
            _db.SaveChanges();
        }

        public List<Fornecedor> GetAllFornecedor()
        {
            return  _db.Fornecedor.ToList();
        }

        public void UpdateFornecedor(Fornecedor fornecedor)
        {
            var forne = _db.Fornecedor.FirstOrDefault(x => x.Id == fornecedor.Id); //pega o id
            forne.Nome = fornecedor.Nome;
            forne.Cpf_Cnpj = fornecedor.Cpf_Cnpj;
            forne.Logradouro = fornecedor.Logradouro;
            forne.Numero = fornecedor.Numero;
            forne.Complemento = fornecedor.Complemento;
            forne.Bairro = fornecedor.Bairro;
            forne.Cidade = fornecedor.Cidade;
            forne.Estado = fornecedor.Estado;
            forne.Cep = fornecedor.Cep;
            forne.Telefone = fornecedor.Telefone;
            forne.Email = fornecedor.Email;
            _db.SaveChanges();
        }

        public Fornecedor GetByNomeFornecedor(string nome)
        {
            return _db.Fornecedor.OrderByDescending(x => x.Nome.Equals(nome)).FirstOrDefault(); //pega o primeiro nome
        }

        public Fornecedor GetByIdFornecedor(int id)
        {
            return _db.Fornecedor.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }

        public void DelFornecedor(Fornecedor fornecedor)
        {
            _db.Fornecedor.Remove(fornecedor);
            _db.SaveChanges();
        }
    }
}

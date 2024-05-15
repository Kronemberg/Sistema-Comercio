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
    public class ClienteService : IClientePort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public int Count()
        {
            return _db.Cliente.Count();
        }

        public void AddCliente(Cliente cliente)
        {
            _db.Cliente.Add(cliente);
            _db.SaveChanges();
        }

        public void DelCliente(Cliente cliente)
        {
            _db.Cliente.Remove(cliente);
            _db.SaveChanges();
        }

        public List<Cliente> GetAllCliente()
        {
            return _db.Cliente.ToList();
        }

        public Cliente GetByNomeCliente(string nome)
        {
            return _db.Cliente.OrderByDescending(x => x.Nome.Equals(nome)).FirstOrDefault(); //pega o primeiro nome
        }

        public Cliente GetByIdCliente(int id)
        {
            return _db.Cliente.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }

        public void UpdateCliente(Cliente cliente)
        {
            var cli = _db.Cliente.FirstOrDefault(x => x.Id == cliente.Id); //pega o id
            cli.Nome = cliente.Nome;
            cli.Cpf_Cnpj = cliente.Cpf_Cnpj;
            cli.Logradouro = cliente.Logradouro;
            cli.Numero = cliente.Numero;
            cli.Complemento = cliente.Complemento;
            cli.Bairro = cliente.Bairro;
            cli.Cidade = cliente.Cidade;
            cli.Estado = cliente.Estado;
            cli.Cep = cliente.Cep;
            cli.Telefone = cliente.Telefone;
            cli.Email = cliente.Email;
            _db.SaveChanges();
        }
    }
}

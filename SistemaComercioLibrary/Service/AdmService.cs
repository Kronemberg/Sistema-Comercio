using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Service
{
    public class AdmService : IAdmPort
    {
    
       private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddAdm(Adm adm)
        {
            _db.Adm.Add(adm);
            _db.SaveChanges();
        }

        public bool Login(string username, string password)
        {
            var usuario = _db.Adm.FirstOrDefault(x => x.Usuario.Equals(username));
            var senha = _db.Adm.FirstOrDefault(x => x.Senha.Equals(password));

            if(usuario != null & senha != null)
                return true;

            return false;
        }

        public Adm GetByUser(string user)
        {
            return _db.Adm.FirstOrDefault(x => x.Usuario.Equals(user)); 
        }

        public void Update(Adm user)
        {
            var adm = _db.Adm.FirstOrDefault(x => x.Usuario.Equals(user.Usuario));
            adm.Salario = user.Salario;
            _db.SaveChanges();
        }
    }
}

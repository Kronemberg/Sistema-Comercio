using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercioLibrary.Port
{
    public interface IAdmPort
    {
        bool Login(string username, string password);
        void AddAdm(Adm adm);

        Adm GetByUser(string user);
        void Update(Adm user);
    }
}

using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IContaPagarPort
    {
        void AddContaPagar(ContaPagar contaPagar);
        void DelContaPagar(ContaPagar contaPagar);
        void UpdateContaPagar(ContaPagar contaPagar);
        List<ContaPagar> GetAllContaPagar();
        ContaPagar GetByIdContaPagar(int id);
    }
}

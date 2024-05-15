using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IContaReceberPort
    {
        void AddContaReceber(ContaReceber contaReceber);
        void DelContaReceber(ContaReceber contaReceber);
        void UpdateContaReceber(ContaReceber contaReceber);
        List<ContaReceber> GetAllContaReceber();
        ContaReceber GetByIdContaReceber(int id);
    }
}

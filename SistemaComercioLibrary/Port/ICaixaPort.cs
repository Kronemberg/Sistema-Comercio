using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface ICaixaPort
    {
        void AddCaixa(Caixa caixa);
        void DelCaixa(Caixa caixa);
        void UpdateCaixa(Caixa caixa);
        List<Caixa> GetAllCaixa();
        Caixa GetByIdCaixa(int id);
    }
}

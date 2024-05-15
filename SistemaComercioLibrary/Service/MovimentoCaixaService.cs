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
    public class MovimentoCaixaService : IMovimentoCaixaPort
    {

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddMovimentoCaixa(MovimentoCaixa movimentoCaixa)
        {
            _db.MovimentoCaixa.Add(movimentoCaixa);
            _db.SaveChanges();
        }

        public void DelMovimentoCaixa(MovimentoCaixa movimentoCaixa)
        {
            _db.MovimentoCaixa.Remove(movimentoCaixa);
            _db.SaveChanges();
        }

        public List<MovimentoCaixa> GetAllMovimentoCaixa()
        {
            return _db.MovimentoCaixa.ToList();
        }

        public MovimentoCaixa GetByIdMovimentoCaixa(int id)
        {
            return _db.MovimentoCaixa.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }

        public void UpdateMovimentoCaixa(MovimentoCaixa movimentoCaixa)
        {
            var mc = _db.MovimentoCaixa.FirstOrDefault(x => x.Id == movimentoCaixa.Id); //pega o id
            mc.Data_Movimento = movimentoCaixa.Data_Movimento;
            mc.Hora_Movimento = movimentoCaixa.Hora_Movimento;
            mc.Descricao = movimentoCaixa.Descricao;
            mc.Tipo_Movimento = movimentoCaixa.Tipo_Movimento;
            mc.Valor = movimentoCaixa.Valor;
            mc.Id_Caixa = movimentoCaixa.Id_Caixa;
            _db.SaveChanges();

        }
    }
}

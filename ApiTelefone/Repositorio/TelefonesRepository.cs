using System.Collections.Generic;
using System.Linq;
using ApiTelefone.Models;

namespace ApiTelefone.Repositorio
{
    public class TelefonesRepository : ITelefonesRepository
    {
        private readonly TelefonesDbContext _contexto;

        //Metodo Construtor
        public TelefonesRepository(TelefonesDbContext context)
        {
            _contexto = context;
        }
        //Metodos Adicionar,Buscar,Remover,Atualizar
        public void Add(Telefones loja)//Adicionar
        {
            _contexto.tb_contatoloja.Add(loja);
            _contexto.SaveChanges();

        }

        public Telefones Find(int id)//Buscar por id
        {
            return _contexto.tb_contatoloja.FirstOrDefault(l => l.IdUser == id);
        }

        public IEnumerable<Telefones> GetAll()//Traz todos os registros.
        {
            return _contexto.tb_contatoloja.ToList();
        }
        public void Remove(int id)//Remover
        {
            var entity = _contexto.tb_contatoloja.First(u => u.IdUser == id);
            _contexto.tb_contatoloja.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(Telefones loja)//Atualizar
        {
            _contexto.tb_contatoloja.Update(loja);
            _contexto.SaveChanges();
        }
    }
}
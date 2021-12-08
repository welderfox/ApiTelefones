using System.Collections.Generic;
using ApiTelefone.Models;

namespace ApiTelefone.Repositorio
{
    public interface ITelefonesRepository
    {
        void Add(Telefones loja);
        IEnumerable<Telefones> GetAll();
        Telefones Find(long iduser);
        void Remove(long iduser);
        void Update(Telefones loja);


    }
}
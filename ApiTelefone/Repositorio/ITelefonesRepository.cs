using System.Collections.Generic;
using ApiTelefone.Models;

namespace ApiTelefone.Repositorio
{
    public interface ITelefonesRepository
    {
        void Add(Telefones loja);

        IEnumerable<Telefones> GetAll();

        Telefones Find(int idUser);

        void Remove(int idUser);

        void Update(Telefones loja);


    }
}
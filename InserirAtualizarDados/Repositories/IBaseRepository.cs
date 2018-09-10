using InserirAtualizarDados.Models;
using System;
using System.Linq;

namespace InserirAtualizarDados.Repositories
{
    public interface IBaseRepository : IDisposable
    {
        void Inserir(Entity Entity);

        void Alterar(Guid Id, Entity entity);

        IQueryable<Entity> Selecionar();
    }
}

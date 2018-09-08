using System;

namespace InserirAtualizarDados.Repositories
{
    public interface IBaseRepository : IDisposable
    {
        void Inserir(object Entity);

        void Alterar(Guid Id);

        object Selecionar();
    }
}

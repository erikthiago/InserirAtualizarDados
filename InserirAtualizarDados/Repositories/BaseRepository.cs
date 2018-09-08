using System;

namespace InserirAtualizarDados.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public void Inserir(object Entity)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public object Selecionar()
        {
            throw new NotImplementedException();
        }
    }
}

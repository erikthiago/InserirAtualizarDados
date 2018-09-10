using Dapper;
using InserirAtualizarDados.Models;
using InserirAtualizarDados.SQLConnections;
using System;
using System.Linq;

namespace InserirAtualizarDados.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public DapperDBConnection _dBConnection;

        public BaseRepository(DapperDBConnection dBConnection)
        {
            _dBConnection = dBConnection;
        }

        public void Inserir(Entity Entity)
        {
            _dBConnection
                .Connection
                .Execute("INSERT INTO TabelaMedium (ID, Nome, Sobrenome) VALUES (@ID, @Nome, @Sobrenome)", new { Entity.Id, Entity.Nome, Entity.Sobrenome });
        }

        public void Alterar(Guid Id, Entity entity)
        {
            _dBConnection
               .Connection
               .Execute("UPDATE TabelaMedium SET Nome = @Nome, Sobrenome = @Sobrenome WHERE ID = @Id", new { Id, entity.Nome, entity.Sobrenome });
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IQueryable<Entity> Selecionar()
        {
            return _dBConnection
                .Connection
                .Query<Entity>(@"SELECT [ID], [Nome], [Sobrenome]
                                   FROM TabelaMedium",
                                   new { }).AsQueryable();
        }
    }
}

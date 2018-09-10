using ExcluiDadosDuplicados.Repositories;
using System;

namespace InserirAtualizarDados.Models
{
    public class Entity : IQuery
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}

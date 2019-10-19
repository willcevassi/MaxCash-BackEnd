using System;
using maxcash.backend.model.contratos;
using maxcash.backend.model.entidades;
using maxcash.backend.repository.contexto;

namespace maxcash.backend.repository.repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(MaxCashDbContext Contexto) : base(Contexto)
        {
        }
    }
}

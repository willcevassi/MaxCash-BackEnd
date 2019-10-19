using System;
using System.Collections.Generic;
using System.Linq;
using maxcash.backend.model.contratos;
using maxcash.backend.repository.contexto;


namespace maxcash.backend.repository.repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity:class
    {
        protected readonly MaxCashDbContext Contexto;

        public BaseRepositorio(MaxCashDbContext Contexto)
        {
            this.Contexto = Contexto;
        }

        public void Adicionar(TEntity entity)
        {
            Contexto.Set<TEntity>().Add(entity);
            Contexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            Contexto.Set<TEntity>().Update(entity);
            Contexto.SaveChanges();
        }

        public void Dispose()
        {
            Contexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return Contexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return Contexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            Contexto.Remove(entity);
            Contexto.SaveChanges();
        }
    }
}

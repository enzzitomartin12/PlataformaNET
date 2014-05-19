using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace IronMan.Repositorio
{

    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected DbSet<T> DbSet;
        protected DbContext _ctx;

        public Repositorio(DbContext ctx)
        {
            _ctx = ctx;
            DbSet = ctx.Set<T>();
        }

        public void Guardar(T entidad, int Id)
        {
            if (Id == 0)
            {
                DbSet.Add(entidad);
            }
            _ctx.SaveChanges();
        }


        public T GetPorId(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetTodos()
        {
            return DbSet;
        }

    }
}

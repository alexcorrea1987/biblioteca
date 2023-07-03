using Dominio.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public void add(TEntity entity)
        {
            try
            {
                using (var context = new bibliotecaEntities())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar registro:" + ex.Message, ex);
            }
        }

        public void Modify(TEntity entity)
        {
            try
            {
                using (var context = new bibliotecaEntities())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el registro:" + ex.Message, ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new bibliotecaEntities())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el registro:" + ex.Message, ex);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new bibliotecaEntities())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar el registro:" + ex.Message, ex);
            }
        }

        public TEntity Get(int id)
        {
            try
            {
                using (var context = new bibliotecaEntities())
                {
                    return context.Set<TEntity>().Find(id);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar registro por id:" + ex.Message, ex);
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

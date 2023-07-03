using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void add(TEntity entity);
        void Modify(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
    }
}

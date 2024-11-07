using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FireSense.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);

        ICollection<TEntity> GetAll();

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>> orderBy = null, string include = "");

        IEnumerable<TEntity> GetByProc(string proc, object[] parameters);

        void Add(TEntity t);

        void Update(TEntity t);

        void Delete(TEntity t);

        void Dispose();

    }
}

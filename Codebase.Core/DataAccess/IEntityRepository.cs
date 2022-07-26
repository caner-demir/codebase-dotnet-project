using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        T? Get(int id);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}

using Codebase.DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.DAL.Concrete.EntityFramework
{
    public class EFRepository<T> : IEntityRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Add<T>(entity);
                context.SaveChanges();
            }
        }

        public T? Get(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                IQueryable<T> query = context.Set<T>();

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (includeProperties != null)
                {
                    foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(includeProp);
                    }
                }

                return query.ToList();
            }
        }

        public void Remove(T entity)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

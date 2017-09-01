using System;
using System.Data.Entity;
using System.Linq;
using TEntityFrameworkSample.Core.Data;

namespace TEntityFrameworkSample.Data
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext _context;
        private IDbSet<T> _entities;
        protected virtual IDbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());

        public EfRepository(IDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => Entities;

        public IQueryable<T> TableNoTracking => Entities.AsNoTracking();

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

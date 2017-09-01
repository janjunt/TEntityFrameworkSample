using System.Linq;

namespace TEntityFrameworkSample.Core.Data
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }

    }
}

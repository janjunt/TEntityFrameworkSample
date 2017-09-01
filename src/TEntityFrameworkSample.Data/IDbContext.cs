using System.Data.Entity;

namespace TEntityFrameworkSample.Data
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}

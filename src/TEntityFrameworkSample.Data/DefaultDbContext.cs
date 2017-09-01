using System.Data.Entity;

namespace TEntityFrameworkSample.Data
{
    public class DefaultDbContext : DbContext, IDbContext
    {
        public DefaultDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Database.SetInitializer(new NullDatabaseInitializer<DefaultDbContext>());
        }
        public new IDbSet<TEntity> Set<TEntity>() where TEntity:class
        {
            return base.Set<TEntity>();
        }
    }
}

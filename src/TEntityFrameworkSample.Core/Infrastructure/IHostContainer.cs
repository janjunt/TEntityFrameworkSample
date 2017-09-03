namespace TEntityFrameworkSample.Core.Infrastructure
{
    public interface IHostContainer
    {
        T Resolve<T>();
    }
}

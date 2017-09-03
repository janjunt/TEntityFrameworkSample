using Autofac;

namespace TEntityFrameworkSample.Core.Infrastructure
{
    public class DefaultHostContainer : IHostContainer
    {
        private readonly IContainer _container;


        public DefaultHostContainer(IContainer container)
        {
            _container = container;
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}

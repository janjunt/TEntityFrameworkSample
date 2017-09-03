using Autofac;
using System;

namespace TEntityFrameworkSample.Core.Infrastructure
{
    public static class Starter
    {
        public static IContainer CreateHostContainer(Action<ContainerBuilder> registrations)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DefaultHost>().As<IHost>().SingleInstance();

            registrations(builder);

            return builder.Build();
        }


        public static IHost CreateHost(Action<ContainerBuilder> registrations)
        {
            var container = CreateHostContainer(registrations);
            var host = container.Resolve<IHost>();
            host.Container = new DefaultHostContainer(container);

            return host;
        }
    }
}

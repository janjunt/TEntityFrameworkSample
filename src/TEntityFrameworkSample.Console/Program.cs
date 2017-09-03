using Autofac;
using System.Data.Entity;
using TEntityFrameworkSample.Core.Data;
using TEntityFrameworkSample.Core.Infrastructure;
using TEntityFrameworkSample.Data;
using TEntityFrameworkSample.Services.Data.Users;
using TEntityFrameworkSample.Services.Users;

namespace TEntityFrameworkSample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = Starter.CreateHost(RegisterDependencies);
            host.Initialize();

            var userService = host.Container.Resolve<IUserService>();
            var users = userService.GetAll();
            foreach(var user in users)
            {
                System.Console.WriteLine($"{user.Id}:{user.Name}");
            }

            System.Console.ReadLine();
        }

        static void RegisterDependencies(ContainerBuilder builder)
        {
            Database.SetInitializer(new NullDatabaseInitializer<DefaultDbContext>());

            builder.Register<IDbContext>(c => new DefaultDbContext("name=TEntityFrameworkSampleConnectionString")).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
        }
    }
}

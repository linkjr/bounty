using Bounty.Infrastructure.Web;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection DependencyRegister(this IServiceCollection services)
        {
            var allAssemblies = new List<Assembly>();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            foreach (string dll in Directory.GetFiles(path, "*.dll"))
                allAssemblies.Add(Assembly.LoadFile(dll));

            //var idependency = AppDomain.CurrentDomain.GetAssemblies()
            //    .SelectMany(m => m.GetTypes().Where(p => p.IsClass && typeof(IDependencyRegistrar).IsAssignableFrom(p)));

            var idependency = allAssemblies
                .SelectMany(m => m.GetTypes().Where(p => p.IsClass && typeof(IDependencyRegistrar).IsAssignableFrom(p)));

            foreach (var item in idependency)
            {
                var dependencyRegistrar = Activator.CreateInstance(item) as IDependencyRegistrar;
                services.Register(dependencyRegistrar);
            }

            return services;
        }

        public static IServiceCollection Register(this IServiceCollection services, IDependencyRegistrar dependency)
        {
            dependency.Register(services);

            return services;
        }
    }
}

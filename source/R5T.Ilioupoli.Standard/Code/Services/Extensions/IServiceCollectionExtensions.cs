using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Ilioupoli.Default;


namespace R5T.Ilioupoli.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ITestingDataDirectoryContentConventions"/> service.
        /// </summary>
        public static IServiceCollection AddTestingDataDirectoryContentConventions(this IServiceCollection services)
        {
            services.AddDefaultTestingDataDirectoryContentConventions();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ITestingDataDirectoryContentConventions"/> service.
        /// </summary>
        public static ServiceAction<ITestingDataDirectoryContentConventions> AddTestingDataDirectoryContentConventionsAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITestingDataDirectoryContentConventions>(() => services.AddTestingDataDirectoryContentConventions());
            return serviceAction;
        }
    }
}

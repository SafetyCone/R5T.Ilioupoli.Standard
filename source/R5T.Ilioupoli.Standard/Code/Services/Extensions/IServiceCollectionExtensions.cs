using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Ilioupoli.Default;


namespace R5T.Ilioupoli.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddTestingDataDirectoryContentConventions(this IServiceCollection services)
        {
            services.AddSingleton<ITestingDataDirectoryContentConventions, TestingDataDirectoryContentConventions>();

            return services;
        }
    }
}

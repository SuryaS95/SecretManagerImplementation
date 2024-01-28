using SecretsManagerImplementation.Data.DBContext;
using SecretsManagerImplementation.Data.Helpers;
using SecretsManagerImplementation.Data.Repositories.SecretsManager;

namespace SecretsManagerImplementation.Extensions
{
    public static class ServiceCollections
    {

        public static void AddSingletonMethods(this IServiceCollection services)
        {
            services.AddSingleton<ISecretsManagerRepository, SecretsManagerRepository>();
            services.AddSingleton<connectionConfig>();
            services.AddSingleton<DatabaseContext>();
        }
        
        public static void AddScopedMethods(this IServiceCollection services)
        {

        }
        
        public static void AddTransientMethods(this IServiceCollection services)
        {

        }
    }
}

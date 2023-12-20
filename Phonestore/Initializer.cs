using Phonestore.DAL.Interfaces;
using Phonestore.DAL.Repositories;
using Phonestore.Domain.Entity.User;
using Phonestore.Service.Implementations;
using Phonestore.Service.Interfaces;

namespace Phonestore
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IBaseRepository<Profile>, ProfileRepository>();
        }
        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();

        }
    }
}

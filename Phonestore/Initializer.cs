using Phonestore.Service.Implementations;
using Phonestore.Service.Interfaces;

namespace Phonestore
{
    public static class Initializer
    {
        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}

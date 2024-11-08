using backend.API.Repository;
using backend.API.Service;

namespace backend.API;

public static class DependendeInjector
{
    public static void InjectDependences(this IServiceCollection services)
    {
        InjectRepositories(services);
        InjectServices(services);
    }

    private static void InjectRepositories(IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
    }

    private static void InjectServices(IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}
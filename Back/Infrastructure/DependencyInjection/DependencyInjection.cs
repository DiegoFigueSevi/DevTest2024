using Back.Domain.Infrastructure;
using Back.Domain.Service;
using Back.Infrastructure.Repository;
using Back.Infrastructure.Service;

namespace Back.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddRepository().AddServices();
        return services;
    }
    
    private static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<IPollRepository, PollLocalRepository>();
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IPollService, PollService>();
        return services;
    }
    
}
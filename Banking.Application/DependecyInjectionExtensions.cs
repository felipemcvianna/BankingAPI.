using Banking.Application.Services.AutoMapper;
using Banking.Application.UseCases.Cliente.Registrar;
using Microsoft.Extensions.DependencyInjection;

namespace Banking.Application;

public static class DependecyInjectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMapper();
        services.AddUseCases();
        return services;
    }

    private static IServiceCollection AddMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
        return services;
    }

    private static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IRegistrarClienteUseCase, RegistrarClienteUseCase>();
        return services;
    }
}
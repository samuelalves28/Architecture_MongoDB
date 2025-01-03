﻿using API.Implementations.Interfaces;
using API.Implementations.Repositories;

namespace API.Configurations;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddRepositoryInjections(this IServiceCollection services)
    {
        services.AddScoped<ICadUsuarioRepository, CadUsuarioRepository>();

        return services;
    }
}

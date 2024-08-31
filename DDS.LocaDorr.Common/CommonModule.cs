using Microsoft.Extensions.DependencyInjection;
using DDS.LocaDorr.Common.MessageBus;

namespace DDS.LocaDorr.Common;

public static class CommonModule
{
    public static IServiceCollection AddCommon(this IServiceCollection services)
    {
        services.AddServices();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IMessageBusProducerService, MessageBusProducerService>();

        return services;
    }
}
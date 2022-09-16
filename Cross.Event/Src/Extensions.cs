﻿using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Cross.Event.Src.Bus;

namespace Cross.Event.Src
{
    public static class Extensions
    {
        private static readonly string RabbitMQSectionName = "rabbitmq";

        public static IServiceCollection AddRabbitMQ(this IServiceCollection services)
        {
            IConfiguration configuration;
            using (var serviceProvider = services.BuildServiceProvider())
            {
                configuration = serviceProvider.GetService<IConfiguration>();
            }

            //var options = configuration.GetOptions<RabbitMqOptions>(RabbitMQSectionName);
            services.Configure<RabbitMqOptions>(configuration.GetSection(RabbitMQSectionName));

            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory, configuration);
            });

            return services;
        }
    }
}

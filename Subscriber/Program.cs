﻿using MassTransit;
using Subscriber.Masstransit.MessageReceiver;

namespace Subscriber
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.ReceiveEndpoint("order-created-event", e =>
                {
                    e.Consumer<OrderCreatedConsumer>();
                });
            });
            await busControl.StartAsync(new CancellationToken());
            try
            {
                Console.WriteLine("Press enter to exit");
                await Task.Run(() => Console.ReadLine());
            }
            finally
            {
                await busControl.StopAsync();
            }
        }
    }
}
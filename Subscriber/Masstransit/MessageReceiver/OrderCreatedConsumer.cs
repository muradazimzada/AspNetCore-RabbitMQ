using MassTransit;
using Newtonsoft.Json;
using Producer.DTOs;
using Producer.Masstransit.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.Masstransit.MessageReceiver
{
    class OrderCreatedConsumer : IConsumer<OrderCreated>
    {
        public async Task Consume(ConsumeContext<OrderCreated> context)
        {
            Console.WriteLine("Message recieved");
            await Console.Out.WriteLineAsync(context.Message.ToString());
            var jsonMessage = JsonConvert.SerializeObject(context.Message);
            await Task.Delay(15_000);
            Console.WriteLine($"OrderCreated message: {jsonMessage}");
        }
    }
}

using ActorServer;
using Dapr.Actors;
using Dapr.Actors.Client;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ActorClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var actor = ActorProxy.Create<IDemoActor>(ActorId.CreateRandom(), "DemoActor");

            await Task.Delay(3000); //wait dapr start...

            for (int i = 50; i < 100; i++)
            {
                var testData = new byte[i * i * 1000];
                Console.WriteLine($"Testing {i} with {testData.Length} bytes..!");
                await actor.SizeTest(testData);
                await Task.Delay(100);
            }
        }
    }
}

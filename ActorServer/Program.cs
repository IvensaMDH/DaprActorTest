using Dapr.Actors.AspNetCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ActorServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
            .ConfigureKestrel(x =>
            {
                x.Limits.MaxRequestBodySize = null;
            })
            .UseActors(actorRuntime =>
            {
                actorRuntime.RegisterActor<DemoActor>();
            });
        
    }
}

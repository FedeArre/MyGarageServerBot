using DisCatSharp.Hosting.DependencyInjection;

namespace DiscordBotWorker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddDiscordHostedService<Bot>();

            var host = builder.Build();
            host.Run();
        }
    }
}
using Data;
using DisCatSharp.Hosting.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace DiscordBotWorker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            builder.Services.AddDiscordHostedService<Bot>();

            var host = builder.Build();
            host.Run();
        }
    }
}
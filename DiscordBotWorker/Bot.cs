using DisCatSharp.Hosting;

namespace DiscordBotWorker
{
    public class Bot : DiscordHostedService
    {
        public Bot(IConfiguration config,
                ILogger<Bot> logger,
                IServiceProvider provider,
                IHostApplicationLifetime appLifetime) : base(config, logger, provider, appLifetime)
        {
        }
    }
}

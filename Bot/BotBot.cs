using Bot.Bot.Commands;

namespace Bot.Bot
{
    internal class BotBot : DiscordHostedService, IBotBot
    {
        public BotBot(IConfiguration config,
            ILogger<BotBot> logger,
            IServiceProvider provider,
            IHostApplicationLifetime lifetime) : base(config, logger, provider, lifetime, "BotBot") { }

        /// <summary>
        /// Attempts to register commands from our Bot.Bot Project
        /// </summary>
        void RegisterCommands(ApplicationCommandsExtension commandsExtension)
        {
            var registeredTypes = commandsExtension.RegisterApplicationCommandsFromAssembly();

            if (registeredTypes.Count == 0)
                Logger.LogInformation($"Could not locate any commands to register...");
            else
                Logger.LogInformation($"Registered the following command classes: \n\t{string.Join("\n\t", registeredTypes)}");
        }

        protected override Task ConfigureExtensionsAsync()
        {
            base.ConfigureExtensionsAsync();

            /*
               IF YOU DO NOT WANT TO USE THE ICONFIGURATION APPROACH
               You can still register your extensions here
           
               Do note though, the IConfiguration is basically an aggregate... you can
               have config-based data come from numerous sources...
           
               Environment variables
               multiple json files
               xml
             */

            var commandsExtension = this.Client.UseApplicationCommands(new(this.ServiceProvider));
            RegisterCommands(commandsExtension);

            /*this.Client.GetApplicationCommands().RegisterCommands<MyCommand>(translationSetup: translations =>
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "translations/my_simple_command.json");
                translations.AddTranslation(path);
            });*/
            return Task.CompletedTask;
        }

        /// <summary>
        /// Could invoke this outside of the bot project, consume it from a web app or whoever
        /// has access to the DI pipeline
        /// </summary>
        /// <param name="sample"></param>
        /// <returns></returns>
        public Task<string> DoSomething(string sample)
        {
            return Task.FromResult($"I did something with {sample}");
        }
    }
}

namespace Bot.Bot
{
    public interface IBotBot : IDiscordHostedService
    {
        Task<string> DoSomething(string sample);
    }
}

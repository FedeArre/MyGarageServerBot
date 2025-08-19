using DisCatSharp.ApplicationCommands;
using DisCatSharp.ApplicationCommands.Attributes;
using DisCatSharp.ApplicationCommands.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotWorker.Commands
{
    public class TestCmd : ApplicationCommandsModule
    {
        [SlashCommand("testcmd", "Fede is testing")]
        public async Task MySlashCommand(InteractionContext ctx)
        {

        }
    }
}

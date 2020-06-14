using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

using System.Threading.Tasks;

namespace BuildermanBot.Commands
{
    public class Commands : BaseCommandModule
    {
        [Command("intro")]
        [Description("Introduces you to Roblox.")]
        public async Task Introduce(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Roblox is an online game platform and game creation system that allows users to program games and play games created by other users.[4] The platform hosts user-created games in many genres, such as racing games, role-playing games, simulations and obstacle courses, coded in the programming language Lua. As of August 2019, Roblox has over 100 million monthly active users").ConfigureAwait(false);    
        }

        [Command("add")]
        [Description("Adds two numbers together & displays result.")]
        public async Task Add(CommandContext ctx, [Description("First number")] int firstNumber, [Description("Second number")] int secondNumber)
        {
            await ctx.Channel
                .SendMessageAsync((firstNumber + secondNumber).ToString())
                .ConfigureAwait(false);

        }

    }
}

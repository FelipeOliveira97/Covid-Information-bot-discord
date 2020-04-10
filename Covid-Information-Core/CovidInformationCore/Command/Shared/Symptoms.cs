using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidInformationCore.Command.Shared
{
    public class Symptoms : ModuleBase<SocketCommandContext>
    {
        [Command("Sintomas")]
        public async Task SharedSymptoms()
        {
            var embed = new EmbedBuilder();

            var info = embed.AddField("Owner",
                       "Source Code [@FelipeOliveira97](https://github.com/FelipeOliveira97/Covid-Information-bot-discord)")
                   .WithTitle($"Sintomas do CoronaVírus")
                   .WithAuthor(Context.Client.CurrentUser)
                   .WithDescription($"• Febre \r\n" +
                                       $"• Espirros \r\n" +
                                       $"• Tosse \r\n" +
                                       $"• Coriza \r\n" +
                                       $"• Falta de ar \r\n")
                   .WithColor(new Color(255, 0, 0))
                   .WithFooter(footer => footer.Text = "@Harpya ")
                   .WithCurrentTimestamp()
                   .Build();
            await ReplyAsync(embed: info);
        }
    }
}

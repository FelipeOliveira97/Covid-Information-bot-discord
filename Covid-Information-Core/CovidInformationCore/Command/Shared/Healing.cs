using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidInformationCore.Command.Shared
{
    public class Healing : ModuleBase<SocketCommandContext>
    {
        [Command("Cura")]
        public async Task SharedHealing()
        {
            var embed = new EmbedBuilder();

            var info = embed.AddField("Owner",
                       "Source Code [@FelipeOliveira97](https://github.com/FelipeOliveira97/Covid-Information-bot-discord)")
                   .WithTitle($"Prevenção ao CoronaVírus")
                   .WithAuthor(Context.Client.CurrentUser)
                   .WithDescription($"• Mesmo sem haver tratamentos específicos para o vírus, a grande " +
                   $"maioria das pessoas contaminadas evolui para a cura. Mas, apesar dessa informação, " +
                   $"não se pode diminuir a gravidade das complicações que esse vírus pode trazer, já que os sintomas" +
                   $" são muito agressivos para o corpo. O tratamento para as doenças causadas pelo vírus, por enquanto, " +
                   $"ainda é o de suporte, ou seja, o foco é o tratamento dos sintomas da infecção, como a febre e a tosse.")
                   .WithColor(new Color(255, 0, 0))
                   .WithFooter(footer => footer.Text = "@Harpya ")
                   .WithCurrentTimestamp()
                   .Build();
            await ReplyAsync(embed: info);
        }
    }
}

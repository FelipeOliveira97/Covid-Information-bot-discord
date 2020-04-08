using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_Information.Command.Shared
{
    public class Types : ModuleBase<SocketCommandContext>
    {
        public async Task SharedTypes()
        {
            var embed = new EmbedBuilder();

            var info = embed.AddField("Owner",
                       "Source Code [@FelipeOliveira97](https://github.com/FelipeOliveira97/Covid-Information-bot-discord)")
                   .WithTitle($"Tipos de CoronaVírus;")
                   .WithAuthor(Context.Client.CurrentUser)
                   .WithDescription($"• Beta coronavírus OC43 e HKU1 \r\n" +
                                       $"• Alpha Coronavírus 229E e NL63 \r\n" +
                                       $"• MERS-CoV (Causador da Símdrome Respiratória do Oriente Médio) \r\n" +
                                       $"• SARS-CoV (Causador da Símdrome Respiratória Aguda Grave) \r\n" +
                                       $"• COVID-19 (o tipo mais recente descoberto) \r\n")
                   .WithColor(new Color(255, 0, 0))
                   .WithFooter(footer => footer.Text = "@Harpya ")
                   .WithCurrentTimestamp()
                   .Build();
            await ReplyAsync(embed: info);
        }
    }
}

using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidInformationCore.Command.Shared
{
    public class Transmission : ModuleBase<SocketCommandContext>
    {
        [Command("Transmissão")]
        public async Task SharedTransmission()
        {
            var embed = new EmbedBuilder();

            var info = embed.AddField("Owner",
                       "Source Code [@Covid-Information-bot-discord](https://github.com/FelipeOliveira97/Covid-Information-bot-discord)")
                   .WithTitle($"Transmissões;")
                   .WithAuthor(Context.Client.CurrentUser)
                   .WithDescription($"• Contato com objetos ou superfícies contaminadas, seguido de contato com a boca, nariz ou olhos; \r\n" +
                                       $"• Contato pessoal próximo, como toque ou aperto de mão; \r\n" +
                                       $"• Tosse; \r\n" +
                                       $"• Contato com secreções respiratórias. \r\n" +
                                       $"• Espirros \r\n")
                   .WithColor(new Color(255, 0, 0))
                   .WithFooter(footer => footer.Text = "@Harpya ")
                   .WithCurrentTimestamp()
                   .Build();
            await ReplyAsync(embed: info);
        }
    }
}

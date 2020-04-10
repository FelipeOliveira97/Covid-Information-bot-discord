using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidInformationCore.Command.Shared
{
    public class Prevent : ModuleBase<SocketCommandContext>
    {
        [Command("Prevenção")]
        public async Task SharedPrevent()
        {
            var embed = new EmbedBuilder();

            var info = embed.AddField("Owner",
                       "Source Code [@FelipeOliveira97](https://github.com/FelipeOliveira97/Covid-Information-bot-discord)")
                   .WithTitle($"Prevenção ao CoronaVírus")
                   .WithAuthor(Context.Client.CurrentUser)
                   .WithDescription($"• Wash hands = Lave as mãos; \r\n" +
                                       $"• Use mask properly = Use máscaras de proteção adequadamente; \r\n" +
                                       $"• Have temperature checked regularly = Verifique sua temperatura regularmente; \r\n" +
                                       $"• Avoid large crowds = Evite grandes multidões; \r\n" +
                                       $"• Never touch your face with unclean hands = Nunca toque seu rosto com as mãos sujas. \r\n")
                   .WithColor(new Color(255, 0, 0))
                   .WithFooter(footer => footer.Text = "@Harpya ")
                   .WithCurrentTimestamp()
                   .Build();
            await ReplyAsync(embed: info);
        }
    }
}

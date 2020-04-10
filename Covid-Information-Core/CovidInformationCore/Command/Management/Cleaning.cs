using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CovidInformationCore.Command.Management
{
    public class Cleaning : ModuleBase<SocketCommandContext>
    {
        //  Limpar
        [Command("Limpar", RunMode = RunMode.Async)]
        [Summary("Deleta uma quantidade específica de mensagens.")]
        [RequireUserPermission(GuildPermission.ManageMessages)]
        [RequireBotPermission(ChannelPermission.ManageMessages)]
        internal async Task ClearMessage(uint amount)
        {
            if (amount > 0)
            {
                var messages = await Context.Channel.GetMessagesAsync((int)amount + 1).FlattenAsync();
                await (Context.Channel as ITextChannel).DeleteMessagesAsync(messages);
            }
            else
            {
                await Context.Channel.SendMessageAsync(
                    "Você precisa mensurar um número maior que _0_, para serem deletadas");
            }
        }
    }
}

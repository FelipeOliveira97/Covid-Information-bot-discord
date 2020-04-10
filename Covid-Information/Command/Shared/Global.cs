using Covid_Information.Model;
using Discord;
using Discord.Commands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Covid_Information.Command.Shared
{
    public class Global : ModuleBase<SocketCommandContext>
    {
        [Command("Global")]

        public async Task SharedGlobal()
        {
            MGlobal global;
            global = new MGlobal();

            var embed = new EmbedBuilder();

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://api.covid19api.com/summary");

                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic result = JsonConvert.DeserializeObject(responseBody);

                global.NewConfirmed = result.Global.NewConfirmed;
                global.NewDeaths = result.Global.NewDeaths;
                global.NewRecovered = result.Global.NewRecovered;
                global.TotalConfirmed = result.Global.TotalConfirmed;
                global.TotalDeaths = result.Global.TotalDeaths;
                global.TotalRecovered = result.Global.TotalRecovered;
                global.Date = result.Date;
            }

            var info = embed.AddField("Owner",
                    "Source Code [@FelipeOliveira97](https://github.com/FelipeOliveira97/Covid-Information-bot-discord)")
                .WithTitle($"Informações Globais, Atualização : {global.Date}")
                .WithAuthor(Context.Client.CurrentUser)
                .WithDescription($"Novos Confirmados: {global.NewConfirmed}\r\n" +
                                    $" Novos Mortos: {global.NewDeaths}\r\n" +
                                    $" Novos Recuperados: {global.NewRecovered}\r\n" +
                                    $" Total Infectados: {global.TotalConfirmed}\r\n" +
                                    $" Total de Mortos: {global.TotalDeaths}\r\n" +
                                    $" Total de Recuperados: {global.TotalRecovered}")
                .WithColor(new Color(255, 0, 0))
                .WithFooter(footer => footer.Text = "@Harpya ")
                .WithCurrentTimestamp()
                .Build();
            await ReplyAsync(embed: info);
        }
    }
}

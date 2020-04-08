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
    public class Country : ModuleBase<SocketCommandContext>
    {
        [Command("País")]
        public async Task SharedCountry(string p)
        {
            var _p = "";
            if (p.ToUpper().Equals("BRASIL"))
            {
                _p = p.Replace(p, "Brazil"); // Gambeta temporaria 
            }

            MCountry country;
            country = new MCountry();

            var embed = new EmbedBuilder();

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://api.covid19api.com/live/country/" +
                    $"{_p}" + "/status/confirmed");

                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic result = JsonConvert.DeserializeObject(responseBody);

                country.Country = result[3].Country;
                country.Confirmed = result[3].Confirmed;
                country.Deaths = result[3].Deaths;
                country.Recovered = result[3].Recovered;
                country.Active = result[3].Active;
                country.Date = result[3].Date;

            }

            var info = embed.AddField("Owner",
                    "Source Code [@FelipeOliveira97](https://github.com/FelipeOliveira97/Covid-Information-bot-discord)")
                .WithTitle($"Informações Nacionais, Atualização : {country.Date}")
                .WithAuthor(Context.Client.CurrentUser)
                .WithDescription($"País: {country.Country}\r\n" +
                                    $" Confirmados: {country.Confirmed}\r\n" +
                                    $" Mortos: {country.Deaths}\r\n" +
                                    $" Recuperados: {country.Recovered}\r\n" +
                                    $" Ativos: {country.Active}\r\n"
                                    )
                .WithColor(new Color(255, 0, 0))
                .WithFooter(footer => footer.Text = "@Harpya ")
                .WithCurrentTimestamp()
                .Build();
            await ReplyAsync(embed: info);
        }
    }
}

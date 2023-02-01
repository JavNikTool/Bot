using Telegram.Bot;
using Telegram.Bot.Types;

namespace Contacts
{
    public static class Contacts_bot
    {
        public static async void Contacts(ITelegramBotClient bot, Update up)
        {
            var message = up.Message;

            switch (message.Text.ToLower())
            {
                case "/rgs_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\rgs.txt")));
                    break;
                case "/kig_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\kig.txt")));
                    break;
                case "/energo_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\energo.txt")));
                    break;
                case "/radel_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\radel.txt")));
                    break;
                case "/ais_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\ais.txt")));
                    break;
                case "/congr_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\congr.txt")));
                    break;
                case "/pmas_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\pmas.txt")));
                    break;
                case "/fiexpo_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\fiexpo.txt")));
                    break;
                case "/expogift_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\expogift.txt")));
                    break;
                case "/bazarspb_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\bazarspb.txt")));
                    break;
                case "/vdl_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\vdl.txt")));
                    break;
                case "/pzn_cts":
                    await bot.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\contacts\pzn.txt")));
                    break;
            }


        }
    }
}

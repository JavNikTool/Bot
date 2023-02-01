using Telegram.Bot;
using Telegram.Bot.Types;

namespace Calendar
{
    public static class Calendar_bot
    {
        public static async void Calendar(ITelegramBotClient bot, Update up)
        {
            var message = up.Message;

            switch (message.Text.ToLower())
            {
                case "/rgs_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки РОС-ГАЗ-ЭКСПО: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\rgs.txt")));
                    break;
                case "/kig_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки КОТЛЫ И ГОРЕЛКИ: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\kig.txt")));
                    break;
                case "/energo_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки ЭНЕРГОСБЕРЕЖЕНИЕ: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\energo.txt")));
                    break;
                case "/radel_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки РАДЭЛ: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\radel.txt")));
                    break;
                case "/ais_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки АВТОМАТИЗАЦИЯ: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\ais.txt")));
                    break;
                case "/congr_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки КОНГРЕСС: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\congr.txt")));
                    break;
                case "/pmas_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки ПМАС: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\pmas.txt")));
                    break;
                case "/fiexpo_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки ИНДУСТРИЯ МОДЫ(ВЕСНА): \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\fiexpo_vesna.txt")) + "\n \n" + "Дата проведения выставки ИНДУСТРИЯ МОДЫ(ОСЕНЬ): \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\fiexpo_osen.txt")));
                    break;
                case "/expogift_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки НОВОГОДНИЙ ПОДАРОК в ДК КИРОВА: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\expogift_kirova.txt")) + "\n \n" + "Дата проведения выставки НОВОГОДНИЙ ПОДАРОК в ЭКСПОФОРУМЕ: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\expogift_expoforum.txt")));
                    break;
                case "/bazarspb_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки ОСЕННИЙ БАЗАР: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\bazarspb.txt")));
                    break;
                case "/vdl_cld":
                    await bot.SendTextMessageAsync(message.Chat.Id, "Дата проведения выставки ВСЕ ДЛЯ ЛЕТА в ДК КИРОВА: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\vdl_kirova.txt")) + "\n \n" + "Дата проведения выставки ВСЕ ДЛЯ ЛЕТА в ЭКСПОФОРУМЕ: \n" + String.Join("", System.IO.File.ReadAllLines(@"..\..\materials\calendar\vdl_expoforum.txt")));
                    break;
            }
            return;
        }
    }
}

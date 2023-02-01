using Calendar;
using Contacts;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBotTest
{

    internal class Program
    {

        static TelegramBotClient Client = new TelegramBotClient("5656911283:AAGLwwIkBoZ_b0QdbSxu3lqKi_41RVQkBgw");

        static void Main(string[] args)
        {
            Client.StartReceiving(Update, Error);

            Console.Read();
        }

        private static async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)//метод обработки сообщений
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));//вывод информации о пользователях в консоль
            var message = update.Message;

            if (!String.IsNullOrEmpty(message.Text))
            {

                if (message.Text.ToLower() == "/start")
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Вас приветствует телеграмм бот компании Farexpo, чтобы увидеть список доступных команд, напишите /help");
                else if (message.Text.ToLower() == "/help")
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Список доступных команд: \n /sites - посмотреть список сайтов компании \n /calendar - посмотреть расписание проведения выставок \n /contacts - посмотреть контактные данные дирекции выставок \n /expoforum - местоположение экспофорума \n /kirova - местоположение дк кирова");
                else if (message.Text.ToLower() == "/sites")
                    await botClient.SendTextMessageAsync(message.Chat.Id, String.Join("\n", System.IO.File.ReadAllLines(@"..\..\materials\sites.txt")));
                else if (message.Text.ToLower() == "/contacts")
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Дирекцию какой выставки вы хотите узнать? \n /rgs_cts - РОС-ГАЗ-ЭКСПО. \n /kig_cts - КОТЛЫ И ГОРЕЛКИ. \n /energo_cts - ЭНЕРГОСБЕРЕЖЕНИЕ И ЭНЕРГОЭФФЕКТИВНОСТЬ. \n /radel_cts - РАДЭЛ. \n /ais_cts - АВТОМАТИЗАЦИЯ. \n /congr_cts - МЕЖДУНАРОДНЫЙ КОНГРЕСС ЭНЕРГОСБЕРЕЖЕНИЕ И ЭНЕРГОЭФФЕКТИВНОСТЬ. \n /pmas_cts - ПЕТЕРБУРГСКИЙ МЕЖДУНАРОДНЫЙ АВТОМОБИЛЬНЫЙ САЛОН. \n /fiexpo_cts - ИНДУСТРИЯ МОДЫ. \n /expogift_cts - НОВОГОДНИЙ ПОДАРОК. \n /bazarspb_cts - ОСЕННИЙ БАЗАР. \n /vdl_cts - ВСЁ ДЛЯ ЛЕТА. \n /pzn_cts - ПЕТЕРБУРГСКАЯ ЗЕЛЁНАЯ НЕДЕЛЯ.");
                else if (message.Text.ToLower() == "/calendar")
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Дату проведения какой выставки вы хотите узнать? \n /rgs_cld - РОС-ГАЗ-ЭКСПО. \n /kig_cld - КОТЛЫ И ГОРЕЛКИ. \n /energo_cld - ЭНЕРГОСБЕРЕЖЕНИЕ И ЭНЕРГОЭФФЕКТИВНОСТЬ. \n /radel_cld - РАДЭЛ. \n /ais_cld - АВТОМАТИЗАЦИЯ. \n /congr_cld - МЕЖДУНАРОДНЫЙ КОНГРЕСС ЭНЕРГОСБЕРЕЖЕНИЕ И ЭНЕРГОЭФФЕКТИВНОСТЬ. \n /pmas_cld - ПЕТЕРБУРГСКИЙ МЕЖДУНАРОДНЫЙ АВТОМОБИЛЬНЫЙ САЛОН. \n /fiexpo_cld - ИНДУСТРИЯ МОДЫ. \n /expogift_cld - НОВОГОДНИЙ ПОДАРОК. \n /bazarspb_cld - ОСЕННИЙ БАЗАР. \n /vdl_cld - ВСЁ ДЛЯ ЛЕТА. \n /pzn_cld - ПЕТЕРБУРГСКАЯ ЗЕЛЁНАЯ НЕДЕЛЯ.");
                else if (message.Text.Contains("/expoforum"))//локация экспофорума
                {
                    await botClient.SendLocationAsync(message.Chat.Id, 59.763058, 30.357056);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Петербургское ш., 64, корп. 1");
                }
                else if (message.Text.Contains("/kirova"))//локация дк кирова
                {
                    await botClient.SendLocationAsync(message.Chat.Id, 59.933764, 30.254679);
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Большой просп. Васильевского острова, 83");
                }
                else if (message.Text.Contains("_cts"))
                    Contacts_bot.Contacts(botClient, update);//Метод отображения дирекции конкретной выставки 
                else if (message.Text.Contains("_cld"))
                    Calendar_bot.Calendar(botClient, update);//Метод определения даты проведения конкретной выставки
                else
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Введена не корректная команда, чтобы увидеть список доступных команд, напишите /help");
            }
            else
                await botClient.SendTextMessageAsync(message.Chat.Id, "Введена не корректная команда, чтобы увидеть список доступных команд, напишите /help");



            return;
        }

        private static Task Error(ITelegramBotClient botClient, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    }
}
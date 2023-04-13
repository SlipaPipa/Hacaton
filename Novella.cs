using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Hakaton_2023
{
    internal class Novella
    {
        public static string Fio_Rab { get; set; }
        static string dialog1 = ":\r\nСегодня мой первый рабочий\r\nнадо выложиться по полной!!";
        static string dialog2 = "<i>Вы не успели перешагнуть\r\nпорог как вдруг перед глазами\r\nпоявился высокий силуэт.</i>";
        static string dialog3 = "Илья:\r\nЗдравствуй. Сегодня же\r\nтвой первый день не так ли?";
        static string dialog4 = ":\r\nДаа.. Илья Сергеевич. А вы мой\r\nкуратор. Верно?";
        static string dialog5 = "Илья:\r\nДа. И я все тебе расскажу.";
        static string dialog6 = "<i>Илья Сергеевич пропустил Вас,\r\nчто бы вошли. И Вы начали\r\nторопливым шагом передвигать\r\nпо офису.</i>";
        static string dialog7 = "Илья:\r\nНаша компания – это новая\r\nсемья и новый, продвинутый и\r\nинновационный российский\r\nбанк, который обрёл свою\r\nпопулярность за счёт любви и\r\nдоверия клиентов. Что\r\nтребуется от Вас? Практически\r\nничего кроме выполнение всех\r\nпоставленных нами условий и\r\nобязанностей, любовь и\r\nответственность к профессии.";
        static string dialog8 = $":\r\nА чем занимаются все\r\nсотрудники?";
        static string dialog9 = "Илья:\r\nНаши сотрудники и ты в том\r\nчисле. Отвечают на звонки\r\nклиентов, консультируют и\r\nпомогают им решать проблемы.";
        static string dialog10 = $":\r\nКстати, я слышал, что Вы\r\nиспользуете ключевые слова.";
        static string dialog11 = "Илья:\r\nВерно, есть множество\r\nключевых слов, например как:\r\nОП – Оператор; \nКЛ – Клиент;\r\nРСВ - Работа с возражениями;\r\nСУПЕРВАЙЗЕР - Человек,\r\nкоторый помогает с\r\nвозникшими вопросами, то есть\r\nЯ; \nКК - Кредитная карта и\r\nмногие другие слова. Я бы мог\r\nрассказывать долго, но время у\r\nнас не резиновое так, что если\r\nтебе что-то из этого было не\r\nпонятно, то можешь зайти в\r\n«Прочее» там будут «Ваши\r\nуроки». И в этих уроках ты\r\nсможешь найти полную\r\nинформацию.";

        public static async void Start_Novella(ITelegramBotClient bot, long call_back_id, int call_back_id_message,string Fio)
        {
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, Fio+dialog1);
            Thread.Sleep(2000);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, dialog2, parseMode: ParseMode.Html);
            Thread.Sleep(3500);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, dialog3);
            Thread.Sleep(2500);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, Fio+dialog4);
            Thread.Sleep(2500);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, dialog5);
            Thread.Sleep(2500);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, dialog6, parseMode: ParseMode.Html);
            Thread.Sleep(2500);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, dialog7);
            Thread.Sleep(8000);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, Fio + dialog8);
            Thread.Sleep(3500);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, dialog9);
            Thread.Sleep(2500);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, Fio + dialog10);
            Thread.Sleep(6500);
            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, dialog11, replyMarkup: (InlineKeyboardMarkup)Return_Home());

        }
        static IReplyMarkup Return_Home()
        {
            return new InlineKeyboardMarkup(InlineKeyboardButton.WithCallbackData(text: "Главное меню", callbackData: "/Главное меню"));
        }
    }
}

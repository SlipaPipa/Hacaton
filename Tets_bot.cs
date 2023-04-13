using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace Hakaton_2023
{
    internal class Tets_bot
    {
        static string questions_1 = "Вопрос №1: Какие должны быть базовые навыки у нашего сотрудника?\r\n1.    Грамотный письменный и устный язык, четкая и адекватная речь, компьютерная грамотность.\r\n2.    Только грамотная устная и поставленная речь, компьютерная грамотность.\r\n3.    Самодисциплина, контроль и управление своими финансами, навык ораторского искусства. \r\n4.    Скорость обработки информации, скорочтение, скоро слушание, навык непрерывного самообразования.";
        static string questions_2 = "Вопрос №2: Вы работаете в (Политех банке) службы поддержки клиентов крупного магазина сотовых телефонов. Пожилая женщина звонит и говорит, что у нее проблемы с некоторыми настройками её телефона. Говорит, что этот телефон купил ей сын и что она очень расстроена тем, что не может использовать его самостоятельно. Какой будет ваш первый ответ?\r\n1.    Порекомендуете ей обратиться к соответствующему разделу руководства пользователя, которое она получила со своим устройством.\r\n2.    Спросите её о проблемах, которые она испытывала, и проконсультируйте её о процессе изменения настроек – проведёте её шаг за шагом.\r\n3.    Предложите записать ее на прием в вашем магазине, чтобы представитель мог решить проблему для нее.\r\n4.    Предложите записать ее на семинар по использованию устройства.";
        static string questions_3 = "Вопрос №3: В какой степени вы согласны со следующим утверждением:\r\n«Я всегда демонстрирую положительный настрой».\r\n1.Не согласен\r\n2.Нейтральный\r\n3.Согласен\r\n4.Полностью согласен";
        static string questions_4 = "Вопрос №4: Сейчас очень напряженный час в колл-центре. Вы устали и голодны, но вы решили отложить свой перерыв на обед на некоторое время и помочь вашей команде обработать звонки. Ваш следующий звонок от сердитого клиента, который жалуется, что доставка, которую он заказал несколько недель назад, все еще не прибыла. Вы пытаетесь собрать информацию, необходимую для проверки вопроса, но клиент продолжает жаловаться на ваш сервис. Он говорит: «Я неделю пытаюсь до вас дозвониться, и теперь, когда кто-то наконец отвечает, вы медленны и некомпетентны». Каковы лучший способ ответить в этой ситуации?\r\n1.    Скажите клиенту, что вы пытаетесь помочь, но что вы бы оценили более уважительное обращение.\r\n2.    Позволите клиенту выразить свое разочарование и проявите сочувствие.\r\n3.    Скажите, что вы понимаете его разочарование, затем быстро переключите тему и скажите, что хотите найти решение, и хотели бы задать несколько вопросов, чтобы сделать это.\r\n4.    Немедленно предложите компенсацию, чтобы успокоить его, чтобы вы могли задать свои вопросы.";

        public static void Start_Test(ITelegramBotClient bot, long call_back_id, int call_back_id_message)
        {
            bot.EditMessageTextAsync(call_back_id, call_back_id_message, questions_1, replyMarkup: (InlineKeyboardMarkup)Question_1());
        }
        public static void Question_2(ITelegramBotClient bot, long call_back_id, int call_back_id_message)
        {
            bot.EditMessageTextAsync(call_back_id, call_back_id_message, questions_2, replyMarkup: (InlineKeyboardMarkup)Question_2());
        }
        public static void Question_3(ITelegramBotClient bot, long call_back_id, int call_back_id_message)
        {
            bot.EditMessageTextAsync(call_back_id, call_back_id_message, questions_3, replyMarkup: (InlineKeyboardMarkup)Question_3());
        }
        public static void Question_4(ITelegramBotClient bot, long call_back_id, int call_back_id_message)
        {
            bot.EditMessageTextAsync(call_back_id, call_back_id_message, questions_4, replyMarkup: (InlineKeyboardMarkup)Question_4());
        }
 

        private static IReplyMarkup Question_1()
        {
            return new InlineKeyboardMarkup
            (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "/Вопрос1-1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "/Вопрос1-2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "/Вопрос1-3"),
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "/Вопрос1-4"),
                },
            }
            );
        }

        private static IReplyMarkup Question_2()
        {
            return new InlineKeyboardMarkup
            (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "/Вопрос2-1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "/Вопрос2-2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "/Вопрос2-3"),
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "/Вопрос2-4"),
                },
            }
            );
        }

        private static IReplyMarkup Question_3()
        {
            return new InlineKeyboardMarkup
            (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "/Вопрос3-1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "/Вопрос3-2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "/Вопрос3-3"),
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "/Вопрос3-4"),
                },
            }
            );
        }

        private static IReplyMarkup Question_4()
        {
            return new InlineKeyboardMarkup
            (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "/Вопрос4-1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "/Вопрос4-2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "/Вопрос4-3"),
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "/Вопрос4-4"),
                },
            }
            );
        }
    }
}

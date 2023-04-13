using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using System.Threading;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;

namespace Hakaton_2023
{
    internal class Program
    {
        static string Telegram_Bot = "6269662619:AAHDyZ7YBvopq7oRvdwTvn96sho7pOREDqA";
        static string lesson1 = "Урок 1. Знакомство с нашей\r\nкомпанией и Вашей роли в ней\r\n\r\nЧто наша компания из себя\r\nпредставляет?\r\nНаша компания - это новый,\r\nпродвинутый и инновационный\r\nроссийский банк, который\r\nобрёл свою популярность за\r\nсчёт любви и доверия клиентов\r\nи очень важных критериев,\r\nтаких как: надёжность,\r\nкомфортное использование\r\nуслуг, выгодные кредитные\r\nпланы и отзывчивая поддержка.\r\n\r\nМногие компании, в том числе и\r\nмы, набирают специалистов\r\n(операторов Call-Центров) для\r\nработы на дому, предлагая\r\nгибкий график и возможность\r\nнеполной занятости.\r\n\r\nЧто требуется от Вас?\r\nВыполнение всех поставленных\r\nнами условий и обязанностей,\r\nлюбовь и ответственность к\r\nпрофессии и знание базовых\r\nнавыков, таких как:\r\n\r\n- Грамотный письменный и\r\nустный язык.\r\n- Четкая и адекватная речь.\r\n- Готовность к монотонной\r\nработе.\r\n- Компьютерная грамотность.\r\nНеобходимо знать, как звонить\r\nчерез интернет, пользоваться\r\nсоответствующими\r\nпрограммами, которые\r\nпредоставит работодатель.";
        static string lesson2 = "Урок 2: Основные обязанности\r\n\r\nЧем занимаются наши\r\nсотрудники?\r\n\r\n- Отвечают на звонки клиентов,\r\nконсультируют и помогают им\r\nрешать проблемы.\r\n\r\nДля этого, мы подготовили для\r\nВас удобную рабочую среду, в\r\nэтом же боте и множество\r\nинструкций и шаблонов (иными\r\nсловами скриптов), Вам\r\nостаётся найти нужные и просто\r\nих грамотно прочитать.\r\n\r\n- Должностные обязанности\r\nоператора включают:\r\n\r\n— Прием входящих звонков.\r\n— Обработку запросов от\r\nклиентов, решение их проблем.\r\n— Звонки потенциальным\r\nклиентам (холодные или\r\nтеплые).\r\n— Фиксирование результатов\r\nзвонков в CRM-системах.\r\n— Взаимодействие с другими\r\nотделами компании, например,\r\nтехническими специалистами.\r\n— Подготовка отчетности.";
        static string lesson3 = "Урок 3: Скрипты и обозначение\r\nсокращённых (ключевых) слов\r\n\r\n- Ключевые слова (обозначения)\r\nдля скриптов сотрудников:\r\n\r\nОП - Оператор\r\nКЛ - Клиент\r\nЗП - Заработная плата\r\nРСВ - Работа с возражениями\r\n(Отказ клиента от услуг на\r\nлюбом этапе обслуживания)\r\nСУПЕРВАЙЗЕР - Человек,\r\nкоторый помогает с\r\nвозникшими вопросами и не\r\nтолько (иными словами\r\nКуратор)\r\nКК - Кредитная карта\r\nЛП - Льготный период (Без\r\nпроцентный период)\r\nМинимальный платёж -\r\nежемесячный обязательный\r\nплатёж, который\r\nрассчитывается индивидуально\r\nИностранный налоговой\r\nрезидент - Человек\r\nнаходящийся за рубежом и\r\nвыплачивающий налоги в свою\r\nстрану\r\n\r\n- Для быстрого поиска и\r\nзаучивания шаблонов\r\n(скриптов), советуем\r\nраспечатать материал, вот для\r\nэтого нужные ссылки.";
        static string about_company = "PolitechBank - это новый,\r\nпродвинутый и инновационный\r\nроссийский банк, который\r\nобрёл свою популярность за\r\nсчёт любви и доверия клиентов\r\nи очень важных критериев,\r\nтаких как: надёжность,\r\nкомфортное использование\r\nуслуг, выгодные кредитные\r\nпланы и отзывчивая поддержка.\r\n\r\nНемного истории о нас:\r\nОснована наша компания в\r\nнедалеком апреле 2019 года.\r\nИдея создать банк пришла не\r\nслучайно, наши директора\r\nчасто жаловались на\r\nобслуживание и работу других\r\nпопулярных российских банков,\r\nв ходе этих событий в голову\r\nпришла именно такая мысль:\r\nсоздать собственный банк,\r\nсобственную эко-систему\r\nспособную объединенить все\r\nнегодующие население страны,\r\nи воссоздать проект по их\r\nпросьбам и жалобам.\r\n\r\nМы являемся частью этого\r\nбанка, PolitechBankCall, это\r\nоператорский центр поддержки\r\nнаших клиентов.\r\nВ нашей под-компании на\r\nданный момент работает\r\nоколо 500 сотрудников (300 из\r\nних операторы поддержки)";
        static long score = 0;

        static void Main(string[] args)
        {
            var bot = new TelegramBotClient(Telegram_Bot);
            bot.StartReceiving(Update, Error);
            Console.ReadKey();
        }

        private static async Task Update(ITelegramBotClient bot, Telegram.Bot.Types.Update update, CancellationToken arg3)
        {
            var message = update.Message;
            var call_back = update.CallbackQuery;

            if (message != null)
            {

                var id_ch = message.Chat.Id;
                switch (message.Text)
                {
                    case "/start": bool Check = Data_Base.Check_User(update);
                        if (Check == true)
                        {
                            await bot.SendTextMessageAsync(id_ch, "Здравствуйте");
                            await bot.SendTextMessageAsync(id_ch, $"{Data_Base.Fio_Rab}! Какие вопросы у Вас есть?", replyMarkup: Main_Inlane_keyboard());
                        }
                        else
                        {
                            await bot.SendTextMessageAsync(id_ch, "Вам не придоставлен доступ к данному боту.");
                        }
                        break;
                }
            }

            if (call_back != null)
            {
                var call_back_data = call_back.Data;
                var call_back_id = call_back.Message.Chat.Id;
                var call_back_id_message = call_back.Message.MessageId;
                Data_Base.Update_Data();
                switch(call_back_data)
                {
                    case "/Ссылки":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Основные ссылки для работы",replyMarkup: (InlineKeyboardMarkup)Links_Key());
                        break;
                    case "/Другое":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Здесь находиться все, что может\r\nВам пригодиться для работы:", replyMarkup: (InlineKeyboardMarkup)Others());
                        break;
                    case "/Информация":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Какую именно информации вы хотите узнать?", replyMarkup: (InlineKeyboardMarkup)Inlane_Information());
                        break;
                    case "/Условия работы":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Какие именно Вы хотите узнать условия работы:", replyMarkup: (InlineKeyboardMarkup)Information_job());
                        break;
                    case "/Помощь":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Какая у вас проблема?",replyMarkup: (InlineKeyboardMarkup)Help());
                        break;
                    case "/О компании":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: about_company, replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        break;
                    case "/О кураторе":
                        await bot.SendPhotoAsync(call_back_id,Data_Base.Foto);
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: $"Информация о Вашем кураторе:\r\n\r\nФИО: {Data_Base.Fio_cyr}\r\nВозраст: {Data_Base.Age}\r\nСтаж: {Data_Base.Stg}\r\nНомер рабочего места: {Data_Base.Mesto}", replyMarkup: (InlineKeyboardMarkup)Return_Home_Curator());
                        break;
                    case "/Главное меню":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: $"Здравствуйте, {Data_Base.Fio_Rab}! Какие вопросы у Вас есть?", replyMarkup: (InlineKeyboardMarkup)Main_Inlane_keyboard());
                        break;
                    case "/ЗП":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Что именно Вы хотели знать о своей ЗП?",replyMarkup: (InlineKeyboardMarkup)Information_pay());
                        break;
                    case "/Ставка в час":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Ставка в час - это размер оплаты труда работника за час работы у нас он составляет 130р.", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/ЗП в месяц":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: $"Ваш ежемесячный доход высчитывается по формуле {Data_Base.Hours_per_month} * 130 = {Data_Base.Payment_per_month}", replyMarkup: (InlineKeyboardMarkup)Information_pay());
                        break;
                    case "/Есть вопрос":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: $"В таком случае можете написать своему супервайзеру, он вам поможет {Data_Base.cyr_tg_id}", replyMarkup: (InlineKeyboardMarkup)Help_Help());
                        break;
                    case "/Все понятно":
                    case "/Хорошо":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Чем еще могу помочь?", replyMarkup: (InlineKeyboardMarkup)Main_Inlane_keyboard());
                        break;
                    case "/Переработки":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Один час работы оплачивается 195р.", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Премия":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: $"Премия зависит от места в рейтинге, свое место в рейтинге вы можете узнать у своего супервайзера - {Data_Base.cyr_tg_id}", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Санкции":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "О каких санкция вы хотите узнать?", replyMarkup: (InlineKeyboardMarkup)Sanctions());
                        break;
                    case "/Оскорбление":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Если вы оскорбили клиента или сбросили звонок, то вы сразу же снимаетесь с проекта", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Не выполнение обязанностей":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Если вы не озвучите все условия по КК или не сверите все пасп. данные, то при прослушивании звонка вам поставят крит. Крит - влияет на ваш рейтинг", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Не явка на работу":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Если вы не явились на работу и не придупредили об этом своего супервайзера, то вы лишаететь денег за прилежность", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Опоздание на работу":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Если вы 3 раза опоздали на работу и не придупредили об этом своему супервайзеру, то вы лишаетесь денег за прилежность", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Общие условия работы":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Условия работы: \n1) График свободный (главное отработать свое кол-во часов в месяц в зависимости от ставки) \n2) 1 час работы = 130р (до вычета налога) \n3) У нас есть печеньки)", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Обязанности":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Клиент оставил заявку на КК Вы должны: \n1) Озвучить условия КК \n2) Сверить с ним пасп. данные \n3) Назначить встречу с сотрудником банка для получения карты", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Время работы":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: $"Вы отработали {Data_Base.working_hours} рабочих часа", replyMarkup: (InlineKeyboardMarkup)Job_Time());
                        break;
                    case "/Отпуск":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Есть 2 отпуска: Оплачиваемый и не оплачиваемы \nОплачиваемый отпуск вы можете взять поистичении 6 месяцев работы \nНе оплачиваемый отпуск вы можете взять в любое время", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/Материальные проблемы":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Какая именно у вас проблема: \n1) Мне пришла не вся ЗП \n2) Почему мне не пришла премия \n3) Другое", replyMarkup: (InlineKeyboardMarkup)Material_problems());
                        break;
                    case "/1.Mat":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "С зарплаты вычитается 13% по (п. 1 ст. 226 НК РФ)", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/2.Mat":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Возможно вы не попали в лидирующие места по рейтингу (рейтинг можете узнать у своего супервизора)", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/3.Mat":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Опишите свою проблему", replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        break;
                    case "/Тех.проблемы":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Что у Вас случилось?\n1) КЛ меня не слышет\n2) Я не слышу КЛ\n3) Не работает программа\n4) Другое", replyMarkup: (InlineKeyboardMarkup)Technical_Problems());
                        break;
                    case "/1.Tec":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Попробуйте:\n1) Зайти в панель управления(Пуск, поиск и ввести панель управления)\n2) Оборудование и звук\n3) Звук далее запись, выбрать\nсвой микрофон и проверить уровень", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/2.Tec":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Попробуйте:\n1) Проверить уровень громкости наушников \n2) Перезагрузить свой компьютер \n3) Проверить работу наушников", replyMarkup: (InlineKeyboardMarkup)Question());
                        break;
                    case "/3.Tec":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Какая именно программа не работает: \n1) Звонилка \n2) VPN \n3) Просмотр анкет", replyMarkup: (InlineKeyboardMarkup)Programm_Problems());
                        break;
                    case "/4.Tec":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Опишите свою проблему", replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        break;
                    case "/Ссылки д.1":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: $"Здравствуй, {Data_Base.Fio_Rab}\r\nБудем рады познакомить Вас с\r\nнашей компанией и с Вашей\r\nдальнейшей работе в ней!\r\nВсего у вас 3 урока\r\nВы должны прочитать материал\r\nи выполнить тест по ним", replyMarkup: (InlineKeyboardMarkup)Select_Lesson());
                        break;
                    case "/Урок1":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: lesson1, replyMarkup: (InlineKeyboardMarkup)End_Lessons_1());
                        break;
                    case "/Урок2":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: lesson2, replyMarkup: (InlineKeyboardMarkup)End_Lessons_2());
                        break;
                    case "/Урок3":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: lesson3, replyMarkup: (InlineKeyboardMarkup)End_Lessons_3());
                        break;
                    case "/Конецурока1":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Хотите вернуться в главное\r\nменю?\r\nЕсли нет, то мы дадим Вам следующий\r\nурок", replyMarkup: (InlineKeyboardMarkup)Enter_Lesson_2());
                        break;
                    case "/Конецурока2":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Хотите вернуться в главное\r\nменю?\r\nЕсли нет, то мы дадим Вам следующий\r\nурок", replyMarkup: (InlineKeyboardMarkup)Enter_Lesson_3());
                        break;
                    case "/Конецурока3":
                        await bot.EditMessageTextAsync(chatId: call_back_id, messageId: call_back_id_message, text: "Вернутся на главную страницу?", replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        break;
                    case "/Вопрос1-2": case "/Вопрос1-3": case "/Вопрос1-4":
                        Tets_bot.Question_2(bot, call_back_id, call_back_id_message);
                        break;
                    case "/Вопрос1-1": score++; Tets_bot.Question_2(bot, call_back_id, call_back_id_message);
                        break;
                    case "/Вопрос2-1": case "/Вопрос2-3": case "/Вопрос2-4":
                        Tets_bot.Question_3(bot, call_back_id, call_back_id_message);
                        break;
                    case "/Вопрос2-2": score++;
                        Tets_bot.Question_3(bot, call_back_id, call_back_id_message);
                        break;
                    case "/Вопрос3-1": case "/Вопрос3-2":
                         Tets_bot.Question_4(bot, call_back_id, call_back_id_message);
                        break;
                    case "/Вопрос3-3": score++;
                        Tets_bot.Question_4(bot, call_back_id, call_back_id_message);
                        break;
                    case "/Вопрос3-4":
                        score+=2;
                        Tets_bot.Question_4(bot, call_back_id, call_back_id_message);
                        break;
                    case "/Вопрос4-1": case "/Вопрос4-2": case "/Вопрос4-4":
                        Data_Base.Write_BD(score);
                        await bot.EditMessageTextAsync(call_back_id, call_back_id_message, $"Ваши результаты теста '{score}'", replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        break;
                    case "/Вопрос4-3":
                        score++;
                        Data_Base.Write_BD(score);
                        await bot.EditMessageTextAsync(call_back_id, call_back_id_message, $"Ваши результаты теста '{score}'", replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        break;
                    case "/Ссылки д.3":
                        if (score == 0)
                        {
                            Tets_bot.Start_Test(bot, call_back_id, call_back_id_message);
                        }
                        else
                        {
                            await bot.EditMessageTextAsync(call_back_id, call_back_id_message, $"Ваши результаты теста '{score}'", replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        }
                        break;
                    case "/Ссылки д.2":
                        await bot.EditMessageTextAsync(call_back_id, call_back_id_message, $"Ваши результаты теста '{score}'",replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        break;
                    case "/Новелла":
                        Novella.Fio_Rab = Data_Base.Fio_Rab;
                        Novella.Start_Novella(bot,call_back_id,call_back_id_message, Data_Base.Fio_Rab);
                        break;
                    case "/О работе":
                        await bot.EditMessageTextAsync(call_back_id, call_back_id_message, "У нас есть две КК:\r\n1) PolitechTrebl - это карта с льготным периодом 0 дней, с процентной ставков 3 шаурмы в день и с кредитным лимитом до трех автоматов за сессию\r\n2) PolitechCigarette - это карта с льготным периодам 0 дней, с процентной ставкой 5 сигареты в день и с кредитным лимитом 3 сигареты в день \nВаш офис это ваш дом и ваша задача как оператора заключается в том, что бы после того как человек оставил заявку, вы сверили с ним паспортные данные и назначить встречу с сотрудником банка для получения карты", replyMarkup: (InlineKeyboardMarkup)Return_Home());
                        break;
                    case "/Главное меню1":
                        await bot.SendTextMessageAsync(call_back_id,"Чем еще могу помочь?", replyMarkup: (InlineKeyboardMarkup)Main_Inlane_keyboard());
                        break;
                }
            }  
        }

       

        private static IReplyMarkup Main_Inlane_keyboard()
        {
            return new InlineKeyboardMarkup 
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton> 
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Информация", callbackData: "/Информация"),
                          InlineKeyboardButton.WithCallbackData(text: "Другое", callbackData: "/Другое"),
                      },
                      new List<InlineKeyboardButton> 
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Условия работы", callbackData: "/Условия работы"),
                          InlineKeyboardButton.WithCallbackData(text: "Помощь", callbackData: "/Помощь"),
                      }
                  }  
            );
        }

        static IReplyMarkup Select_Lesson()
        {
            return new InlineKeyboardMarkup
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Урок №1", callbackData: "/Урок1"),
                      },
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Урок №2", callbackData: "/Урок2"),
                      },
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Урок №3", callbackData: "/Урок3"),
                      },
                  }
            );
        }

        static IReplyMarkup End_Lessons_1()
        {
            return new InlineKeyboardMarkup
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Прочитал", callbackData: "/Конецурока1"),
                      },
                      
                  }
            );
        }
        static IReplyMarkup Others()
        {
            return new InlineKeyboardMarkup
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Пройти урок", callbackData: "/Урок1"),
                          InlineKeyboardButton.WithCallbackData(text: "Новелла", callbackData: "/Новелла"),
                      },
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Пройти тест", callbackData: "/Ссылки д.3"),
                      },

                  }
            );
        }

        static IReplyMarkup End_Lessons_2()
        {
            return new InlineKeyboardMarkup
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Прочитал", callbackData: "/Конецурока2"),
                      },

                  }
            );
        }
        static IReplyMarkup End_Lessons_3()
        {
            return new InlineKeyboardMarkup
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Прочитал", callbackData: "/Конецурока3"),
                      },

                  }
            );
        }

        static IReplyMarkup Enter_Lesson_2()
        {
            return new InlineKeyboardMarkup
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Следующий урок", callbackData: "/Урок2"),
                          InlineKeyboardButton.WithCallbackData(text: "Главное меню", callbackData: "/Главное меню"),
                      },

                  }
            );
        }
        static IReplyMarkup Enter_Lesson_3()
        {
            return new InlineKeyboardMarkup
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "Следующий урок", callbackData: "/Урок3"),
                          InlineKeyboardButton.WithCallbackData(text: "Главное меню", callbackData: "/Главное меню"),
                      },

                  }
            );
        }

        private static IReplyMarkup Inlane_Information()
        {
            return new InlineKeyboardMarkup
            (
                  new List<List<InlineKeyboardButton>>
                  {
                      new List<InlineKeyboardButton>
                      {
                          InlineKeyboardButton.WithCallbackData(text: "О компании", callbackData: "/О компании"),
                          InlineKeyboardButton.WithCallbackData(text: "О кураторе", callbackData: "/О кураторе"),
                          InlineKeyboardButton.WithCallbackData(text: "О работе", callbackData: "/О работе"),
                      },
                  }
            );
        }

        private static IReplyMarkup Information_job()
        {
            return new InlineKeyboardMarkup
                (
                new List <List<InlineKeyboardButton>>
                {
                    new List<InlineKeyboardButton>
                    {
                        InlineKeyboardButton.WithCallbackData(text: "ЗП", callbackData: "/ЗП"),
                        InlineKeyboardButton.WithCallbackData(text: "Время работы", callbackData: "/Время работы"),
                        InlineKeyboardButton.WithCallbackData(text: "Санкции", callbackData: "/Санкции"),
                    },
                    new List<InlineKeyboardButton>
                    {
                        InlineKeyboardButton.WithCallbackData(text: "Обязанности", callbackData: "/Обязанности"),
                        InlineKeyboardButton.WithCallbackData(text: "Общие условия работы", callbackData: "/Общие условия работы"),
                    },
                }

                );
        }

        private static IReplyMarkup Information_pay()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Ставка в час", callbackData: "/Ставка в час"),
                    InlineKeyboardButton.WithCallbackData(text: "ЗП в месяц", callbackData: "/ЗП в месяц"),
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Переработки", callbackData: "/Переработки"),
                    InlineKeyboardButton.WithCallbackData(text: "Премия", callbackData: "/Премия"),
                },
            }
            );
        }


        private static IReplyMarkup Question()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Есть вопрос", callbackData: "/Есть вопрос"),
                    InlineKeyboardButton.WithCallbackData(text: "Все понятно", callbackData: "/Все понятно"),
                },
            }
            );
        }
        static IReplyMarkup Links_Key()
        {
            return new InlineKeyboardMarkup
            (
                new List<InlineKeyboardButton> 
                {
                    InlineKeyboardButton.WithCallbackData(text: "Ваши уроки", callbackData: "/Ссылки д.1"),
                    InlineKeyboardButton.WithCallbackData(text: "Результаты тестов", callbackData: "/Ссылки д.2"),
                    InlineKeyboardButton.WithCallbackData(text: "Пройти тест", callbackData: "/Ссылки д.3"),
                }
            );
        }

        private static IReplyMarkup Get_Main_Markup()
        {
            return new ReplyKeyboardMarkup
            (
               new List<List<KeyboardButton>>
               {
                   new List<KeyboardButton>
                   {
                       new KeyboardButton("Главное меню"),

                   },
               }
             
            );
            
        }

        private static IReplyMarkup Help()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Тех.проблемы", callbackData: "/Тех.проблемы"),
                    InlineKeyboardButton.WithCallbackData(text: "Материальные проблемы", callbackData: "/Материальные проблемы"),
                },
            }
            );
        }

        private static IReplyMarkup Help_Help()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Хорошо", callbackData: "/Хорошо"),
                },
            }
            );
        }


        private static IReplyMarkup Sanctions()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Опоздание на работу", callbackData: "/Опоздание на работу"),
                    InlineKeyboardButton.WithCallbackData(text: "Не явка на работу", callbackData: "/Не явка на работу"),
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Оскорбление клиента или сброс звонка", callbackData: "/Оскорбление"),
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Не выполнение своих обязанностей", callbackData: "/Не выполнение обязанностей"),
                },
            }
            );
        }
        private static IReplyMarkup Job_Time()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Отпуск", callbackData: "/Отпуск"),
                },
            }
            );
        }

        private static IReplyMarkup Material_problems()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "/1.Mat"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "/2.Mat"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "/3.Mat"),
                },
            }
            );
        }

        private static IReplyMarkup Technical_Problems()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "/1.Tec"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "/2.Tec"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "/3.Tec"),
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "/4.Tec"),
                },
            }
            );
        }

        private static IReplyMarkup Programm_Problems()
        {
            return new InlineKeyboardMarkup
                (
            new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "/1.Tec.Prog"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "/2.Tec.Prog"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "/3.Tec.Prog"),
                },
            }
            );
        }
        static IReplyMarkup Return_Home()
        {
            return new InlineKeyboardMarkup(InlineKeyboardButton.WithCallbackData(text: "Главное меню", callbackData: "/Главное меню"));
        }
        static IReplyMarkup Return_Home_Curator()
        {
            return new InlineKeyboardMarkup(InlineKeyboardButton.WithCallbackData(text: "Главное меню", callbackData: "/Главное меню1"));
        }


        private static async Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
             Console.Write($"Ошибка!{arg2}");
        }

    }
}




//размер клавы под клавой
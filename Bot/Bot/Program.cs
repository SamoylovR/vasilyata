using System;
using Telegram.Bot;
using System.Threading;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bot
{
    class Program
    {
        static ITelegramBotClient botClient;

        static void Main()
        {
           
            botClient = new TelegramBotClient("908901394:AAHdaMjhFNCqgM_wmsgUXswIDgo5Ld2rZpQ");

            var me = botClient.GetMeAsync().Result;
            Console.WriteLine(
              $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
            );

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);

        }
       
        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            e.Message.Text = e.Message.Text.ToLower();
            if (e.Message.Text.Contains("кнб") == true||e.Message.Text.Contains("камень, ножницы, бумага")==true)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Ну что, давай начнем :)\n Пиши что у тебя, и я сразу за тобой"
                   );
                botClient.OnMessage -= Bot_OnMessage;
                botClient.OnMessage += ResultResearching;
              

            }
            else 
            if(e.Message.Text.Contains("что ты можешь")==true || e.Message.Text.Contains("твои функции")==true||e.Message.Text.Contains("что ты умеешь")==true || e.Message.Text.Contains("свои функции") == true)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.Text: {e.Message.Text}");
                Message message = await botClient.SendTextMessageAsync(
  chatId: e.Message.Chat, 
  text: "Могу скинуть мем\nМогу поиграть с тобой в камень, ножницы, бумага(кнб)\nМогу попытаться угадать кто ты, если ты спросишь\nИ еще немного разной дичи, не бойся, пробуй, спрашивай что нибудь :)",
  parseMode: ParseMode.Markdown,
  disableNotification: true,
  replyToMessageId: e.Message.MessageId


  );

            }else
            if (e.Message.Text.Contains("ты хуй")==true||e.Message.Text.Contains("ты дурак")==true || e.Message.Text.Contains("ты тупой")==true || e.Message.Text.Contains("ты глупый")==true || e.Message.Text.Contains("ты идиот") == true || e.Message.Text.Contains("ты уеб") == true || e.Message.Text.Contains("ты пизд") == true || e.Message.Text.Contains("ты мразь") == true || e.Message.Text.Contains("ты животное") == true || e.Message.Text.Contains("ты дебил") == true || e.Message.Text.Contains("ты бесполезный") == true || e.Message.Text.Contains("ты олень") == true || e.Message.Text.Contains("ты бесполезный") == true || e.Message.Text.Contains("ты хуе") == true || e.Message.Text.Contains("ты конч") == true)
            {
                Console.WriteLine($"ЭЭЭЭ, он меня обозвал, чатик под номером {e.Message.Chat.Id} и сказал: {e.Message.Text}");

                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Сам такой, не обзывайся"
                );
            }else
            if (e.Message.Text.Contains("мем") == true)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                Message message = await botClient.SendPhotoAsync(
                  chatId: e.Message.Chat,
                  photo: MoreMemes.RandomMemes()
                  ) ;
            }
            else
            if (e.Message.Text.Contains("алина")==true)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Есть там 1 девушка\nСоздатель знает ее, по секрету говорил мне, что она милая, но мелкая :D"

                );
            }
            else 
           if (e.Message.Text.Contains("света") == true)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Девушка, которая нравится создателю, ты только ему не говори, что я тебе это сказал :D. Он просил никому не говорить.\nЕсли что, снизу это она :3♥♥♥"
                  );
                  Message message = await botClient.SendPhotoAsync(
                  chatId: e.Message.Chat,
                  photo: "https://vk.com/photo174135622_456242998"

                );
            }
            else
            if (e.Message.Text.Contains("настя") == true)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Лучшая староста из всех что я видел."

                );
            }
            else if (e.Message.Text.Contains("влад") == true&&e.Message.Text.Contains("хмель")==true)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Братишка создателя :D"

                );
            }
            else 
            if (e.Message.Text.Contains("булка") == true)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Крутой челик :D"

                );
            }
            else if (e.Message.Text.Contains("кто я") == true)

            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: WhoAmI.Option()

                );
            }
            else if (e.Message.Text.Contains("/start") == true)

            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Привет, я бот :D я могу делать много(нет) интересных вещей\nНапиши \"Что ты можешь\", чтобы узнать мои функции. "

                );
            }
            else if (e.Message.Text.Contains("спасибо") == true)

            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Это тебе спасибо за то, что общаешься со мной:D "

                );
            }
            else
              if (e.Message.Text != null)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}. Text: {e.Message.Text}");
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Не понимаю твою комманду, попробуй еще раз"

                );


            }
        }
        public static async void ResultResearching(object sender, MessageEventArgs e)
        {
            e.Message.Text = e.Message.Text.ToLower();
            if (e.Message.Text.Contains("бумага") == true)
            {
                string BotElement = KNB.Winner();
                if (BotElement == "Камень")
                {
                    await botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat,
                        text: "У меня камень, поздравляю ты победил :) "
                         );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;

                }
                else
                    if (BotElement == "Ножницы")
                {
                    await botClient.SendTextMessageAsync(
                       chatId: e.Message.Chat,
                       text: "У меня ножницы, я победил :) "
                        );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;

                }
                else
                {
                    await botClient.SendTextMessageAsync(
                       chatId: e.Message.Chat,
                       text: "У меня то же, что и у тебя. Победила дружба  :D "
                        );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;

                }
               
            }else
            if (e.Message.Text.Contains("камень") == true)
            {
                string BotElement = KNB.Winner();
                if (BotElement == "Камень")
                {
                    await botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat,
                        text: "У меня камень, ничья :) "
                         );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;
                }
                else
                   if (BotElement == "Ножницы")
                {
                    await botClient.SendTextMessageAsync(
                       chatId: e.Message.Chat,
                       text: "У меня ножницы, я проиграл, поздравляю тебя ты победитель :) "
                        );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;
                }
                else
                {
                    await botClient.SendTextMessageAsync(
                       chatId: e.Message.Chat,
                       text: "У меня то же, что и у тебя. Победила дружба  :D "
                        );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;
                }
                
            }
            else
             if (e.Message.Text.Contains("ножницы"))
            {
                string BotElement = KNB.Winner();
                if (BotElement == "Камень")
                {
                    await botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat,
                        text: "У меня камень, я победил. Не расстраивайся, в следующий раз повезет :D "
                         );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;
                }
                else
                   if (BotElement == "Ножницы")
                {
                    await botClient.SendTextMessageAsync(
                       chatId: e.Message.Chat,
                       text: "У меня ножницы, ничья. Как говориться у гениев мысли схожи :) "
                        );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;
                }
                else
                {
                    await botClient.SendTextMessageAsync(
                       chatId: e.Message.Chat,
                       text: "У меня бумага, а ты силен в этой игре, у меня не было ни единого шанса :D "
                        );
                    botClient.OnMessage -= ResultResearching;
                    botClient.OnMessage += Bot_OnMessage;
                }
                
            }
            else
            {
                await botClient.SendTextMessageAsync(
                      chatId: e.Message.Chat,
                      text: "Не понимаю тебя, попробуй еще раз. "
                       );
                botClient.OnMessage -= ResultResearching;
                botClient.OnMessage += ResultResearching;
            }
            

        }
       

    }
}

using System;
using Telegram.Bot;
using System.Threading;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    class KNB
    {
        static ITelegramBotClient botClient;
     public static string Winner()
        { 
            string BotElement = "";
            Random a = new Random();
            int b = a.Next(1, 3);
            if (b == 1)
                BotElement = "Камень";
            else
            if (b == 2)
                BotElement = "Ножницы";
            else
                BotElement = "Бумага";

            return BotElement;
        }
 
    }
}

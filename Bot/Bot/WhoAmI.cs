using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bot
{
    class WhoAmI
    {
        public static string Option()
        {
            ArrayList list = new ArrayList();
            list.Add("Уебан 1000го ранга");
            list.Add("Худший в мире");
            list.Add("Няша :3");
            list.Add("Умница");
            list.Add("Бомж");
            list.Add("Величайший");
            list.Add("Худший в мире");
            list.Add("Мизантропыч");
            list.Add("Красавчик");
            list.Add("Ебаклак");
            list.Add("Бездырь");
            list.Add("Талантище");
            list.Add("Лауреат премии дарвина");
            list.Add("Алкаш");
            list.Add("Гений");
            list.Add("Лучший в мире");
            list.Add("Сын портовой шл...");
            list.Add("Полотенце");
            list.Add("Наркоман");
            list.Add("Самый скилловый дотер");
            list.Add("Любимец женщин");
            list.Add("Инвалид");
            list.Add("Жертва неудачного аборта");
            list.Add("Сильный морально");
            list.Add("Сын собаки");
            list.Add("Диванный эксперт");
            list.Add("Любитель милф");
            list.Add("Маменькин сынок");
            list.Add("Сучий потрох");
            list.Add("Кусок говна");
            Random a = new Random();
            int b = a.Next(0, 29);
            return (string)list[b];
        }



    }
}

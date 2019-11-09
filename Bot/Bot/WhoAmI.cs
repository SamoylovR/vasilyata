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

        public static string WhoFromPIR()
        {
            ArrayList FaggotsFromPIR = new ArrayList();

            FaggotsFromPIR.Add("Алейников Влад");
            FaggotsFromPIR.Add("Аль-джарах Илья");
            FaggotsFromPIR.Add("Шараковский Костя");
            FaggotsFromPIR.Add("Свириденко Стасян");
            FaggotsFromPIR.Add("Короткевич Настя");
            FaggotsFromPIR.Add("Самойлов Рома");
            FaggotsFromPIR.Add("Хмельницкий Владюша");
            FaggotsFromPIR.Add("Притула Егор");
            FaggotsFromPIR.Add("Подлужный Владик");
            FaggotsFromPIR.Add("Перетра.... Перетрухин Никита ");
            FaggotsFromPIR.Add("Чеховский Володя");
            FaggotsFromPIR.Add("Думчева Лиза");
            FaggotsFromPIR.Add("Банчиков Артем");
            FaggotsFromPIR.Add("Пивоварчик Артем");
            FaggotsFromPIR.Add("Белов Стат");
            FaggotsFromPIR.Add("Степанов шре... Шон");
            FaggotsFromPIR.Add("Павлов федя");
            FaggotsFromPIR.Add("Полина Иванова");
            FaggotsFromPIR.Add("Добровольский Кирилл");
            FaggotsFromPIR.Add("Павловский Макс");
            FaggotsFromPIR.Add("Казак Владислав");
            FaggotsFromPIR.Add("Журавский Саня");
            FaggotsFromPIR.Add("Дораш Стас");
            FaggotsFromPIR.Add("Скоробогатый Рома");
            FaggotsFromPIR.Add("Лёха Шкуратов");
            FaggotsFromPIR.Add("Владислав Леванков (Бтв мать жива?)");
            FaggotsFromPIR.Add("Матьянов Андрюша");
            FaggotsFromPIR.Add("Горевая Диана");
            FaggotsFromPIR.Add("Коля Черленок");
            FaggotsFromPIR.Add("Та которая не ходит, хз ка ее зовут :D");
            Random a = new Random();
            int b = a.Next(0, 29);
            return (string)FaggotsFromPIR[b];
        }

    }
}

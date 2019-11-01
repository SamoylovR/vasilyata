using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALAH_AKBAAAAAAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            TimerCallback Defuzing = new TimerCallback(TryToDefuze);
            Timer timer = new Timer(Defuzing, num, 0, 10000);
            TimerCallback ExplosionTimer = new TimerCallback(BombTimer);
            Timer timer2 = new Timer(BombTimer, num, 0, 1000);
            Console.ReadLine();
        }
        public static void TryToDefuze (object obj)
        {
            Console.WriteLine("Попытка разминирования...");
            Random Trying = new Random();
            int Try = Trying.Next(0,100);
            if (Try >= 90)
                Console.WriteLine("Фух, чуть не взорвались");
            else
                Console.WriteLine("Неудачная попытка, но ничего, еще есть время");
        }
        public static int n = 180;
        public static void BombTimer(object obj)
        {

            Console.WriteLine("Оставшееся время: "+n+" секунд");
            n--;
            if (n == 0)
            {
                Console.WriteLine("Сапер не справился...\nПрогремел взрыв");
            }
               

        }
    }
}

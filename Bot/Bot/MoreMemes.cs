using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    class MoreMemes
    {
        public static string RandomMemes()
        {
            Random a = new Random();
            int b = a.Next(3900000, 3901908);
            Console.WriteLine(b);
            string f = "http://1001mem.ru/p" + b;
            Console.WriteLine(f);
            return f;
        }
        }
}

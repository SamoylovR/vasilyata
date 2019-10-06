using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Convertations
    {
     public static void BYN_to_USD(ref double balance)
        {
          balance=balance*0.46;
            Console.WriteLine("Теперь валюта вашего счета Доллары. Остаток"+balance);
        }
        public static void BYN_to_EURO(ref double balance)
        {
            balance = balance * 0.4;
            Console.WriteLine("Теперь валюта вашего счета Евро. Остаток" + balance);
        }
        public static void USD_to_BYN(ref double balance)
        {
            balance = balance * 2.2;
            Console.WriteLine("Теперь валюта вашего счета Белоруские рубли. Остаток" + balance);
        }
        public static void USD_to_EURO(ref double balance)
        {
            balance = balance * 0.88;
            Console.WriteLine("Теперь валюта вашего счета Евро. Остаток" + balance);
        }
        public static void EURO_to_USD(ref double balance)
        {
            balance =balance* 1.14;
            Console.WriteLine("Теперь валюта вашего счета Доллары. Остаток" + balance);
        }
        public static void EURO_to_BYN(ref double balance)
        {
            balance = balance * 2.5;
            Console.WriteLine("Теперь валюта вашего счета  Белоруские рубли. Остаток" + balance);
        }
        
    }
}

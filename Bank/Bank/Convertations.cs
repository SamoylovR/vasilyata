using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Convertations
    {
     public static void BYN_to_USD(ref double balance)
        {
          balance=balance*0.46*0.98;
            double komission = balance * 0.02;
            Console.WriteLine("Теперь валюта вашего счета Доллары. Остаток "+balance + " Коммисия за операцию:" + komission);
        }
        public static void BYN_to_EURO(ref double balance)
        {
            balance = balance * 0.4*0.98;
            double komission = balance * 0.02;
            Console.WriteLine("Теперь валюта вашего счета Евро. Остаток " + balance + " Коммисия за операцию:" + komission);
        }
        public static void USD_to_BYN(ref double balance)
        {
            balance = balance * 2.2 * 0.98;
            double komission = balance * 0.02;
            Console.WriteLine("Теперь валюта вашего счета Белоруские рубли. Остаток " + balance + " Коммисия за операцию:" + komission);
        }
        public static void USD_to_EURO(ref double balance)
        {
            balance = balance * 0.88 * 0.98;
            double komission = balance * 0.02;
            Console.WriteLine("Теперь валюта вашего счета Евро. Остаток " + balance + " Коммисия за операцию:" + komission);
        }
        public static void EURO_to_USD(ref double balance)
        {
            balance =balance* 1.14 * 0.98;
            double komission = balance * 0.02;
            Console.WriteLine("Теперь валюта вашего счета Доллары. Остаток " + balance+" Коммисия за операцию:" + komission);
        }
        public static void EURO_to_BYN(ref double balance)
        {
            balance = balance * 2.5 * 0.98;
            double komission = balance * 0.02;
            Console.WriteLine("Теперь валюта вашего счета  Белоруские рубли. Остаток " + balance+" Коммисия за операцию:"+komission);
        }
        
    }
}

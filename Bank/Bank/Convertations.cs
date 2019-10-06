using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Convertations
    {
     public static double BYN_to_USD(ref double balance)
        {
          balance=balance*0.46;
            return balance;
        }
        public static double BYN_to_EURO(ref double balance)
        {
            balance = balance * 0.4;
            return balance;
        }
        public static double USD_to_BYN(ref double balance)
        {
            balance = balance * 2.2;
            return balance;
        }
        public static double USD_to_EURO(ref double balance)
        {
            balance = balance * 0.88;
            return balance;
        }
        public static double EURO_to_USD(ref double balance)
        {
            balance =balance* 1.14;
            return balance;
        }
        public static double EURO_to_BYN(ref double balance)
        {
            balance = balance * 2.5;
            return balance;
        }
        
    }
}

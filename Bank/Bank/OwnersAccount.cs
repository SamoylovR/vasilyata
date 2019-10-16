using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class OwnersAccount
    {
        public static double OwnersMoneyBYN = 1000000;
        public static double OwnersMoneyUSD = 200000;
        public static double OwnersMoneyEURO = 300000;
        public static double ConvertationComission = 0.02;
        public static double TransactionComission = 0.01;
        public static void WorkWithOwner()
        {
            while (true)
            {
                Console.Clear();
               
                Console.WriteLine("Приветсвуем администратора банка, функции доступные вам:\n1.Посмотреть размер своего счета\n2.Изменить комиссию на перевод с карты на карту.\n3.Изменить комиссию с перевода счета пользователя в другую валюту");
               
                string OwnerMenue = "";
                
                while (true)
                {
                    
                    OwnerMenue = Console.ReadLine();
                    
                    if (Checking.ChekingNumbers(OwnerMenue,3))
                    {
                        break;
                    }

                }
                if (OwnerMenue == "1")
                {

                    Console.Clear();

                    Console.WriteLine(OwnersMoneyBYN +"\n"+OwnersMoneyEURO+"\n"+OwnersMoneyUSD+ "\nЖелаете ли продолжить работу?");

                    while (true)
                    {

                        OwnerMenue = Console.ReadLine();

                        if (Checking.ChekingWords(OwnerMenue) && (OwnerMenue == "да"||OwnerMenue=="нет"))
                       
                        break;
                    }
                }
                else if (OwnerMenue == "2")
                {

                }
                else if (OwnerMenue == "3")
                {

                }
            }
        }
    }
}

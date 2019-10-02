using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Main(string[] args)
        {
            int state = 0;
            int cash = 0;
            while (true)
            {
                Console.WriteLine("Введите сумму: \n");
                cash = Convert.ToInt32(Console.ReadLine());
                if (cash > 0)
                    break;

                Console.WriteLine("Некорректная сумма\n");
                
            }

            string answer;
            do
            {
                switch (state)
                {
                    case 0:
                        while (true)
                        {
                            Console.WriteLine("Текущий баланс:" + cash + "\n\nЧтобы пополнить счет, введите 1. \nЧтобы снять деньги, введите 2 \n\nЧтобы завершить сеанс, введите 3.\n\n");

                            answer = Console.ReadLine();
                            if (answer == "1" || answer == "2" || answer == "3")
                            {
                                state = Convert.ToInt32(answer);
                                break;
                            }

                            Console.WriteLine("Некорректная транзакция\n\n");
                        }
                        break;

                    case 1:
                        Console.WriteLine("Введите сумму: ");
                        cash += Convert.ToInt32(Console.ReadLine());
                        state = 0;
                        break;

                    case 2:
                        Console.WriteLine("Введите сумму: ");
                        int money = Convert.ToInt32(Console.ReadLine());
                        if (money > cash)
                            Console.WriteLine("Недостаточно средств. \n");

                        else
                            cash -= money;

                        state = 0;
                        break;

                    case 3:
                        state = 3;
                        break;
                }
            }
            while (state != 3);
        }
    }
}


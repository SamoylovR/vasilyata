using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			double money = 0;
			while (true)
			{
				Console.Write("Введите начальную сумму средств на счёте: ");

				if (double.TryParse(Console.ReadLine(), out money) && money > 0)
				{
					Console.Clear();
					break;
				}

				Console.WriteLine("Некорректная сумма");

			}

			string answer;
			/*do
            {
                switch (state)
                {
                    case 1:
                        Console.WriteLine("Введите сумму: ");
                        money += Convert.ToInt32(Console.ReadLine());
                        state = 0;
                        break;
                    case 2:
                        Console.WriteLine("Введите сумму: ");
                        double inputMoney = Convert.ToInt32(Console.ReadLine());
                        if (inputMoney > money)
                            Console.WriteLine("Недостаточно средств. \n");
                        else
                            money -= inputMoney;
                        state = 0;
                        break;
                    case 3:
                        state = 3;
                        break;
                }
            }
            while (state != 3);*/

			while (true)
			{
				while (true)
				{
					Console.WriteLine("Текущий баланс:" + money.ToString("C3",
														 CultureInfo.CreateSpecificCulture("be-BY")) + "\nЧтобы пополнить счет, введите 1. \nЧтобы снять деньги, введите 2 \nЧтобы завершить сеанс, введите 3.\n\n");

					answer = Console.ReadLine();
					if (answer == "1" || answer == "2" || answer == "3")
					{
						Console.Clear();
						break;
					}

					Console.WriteLine("Некорректная транзакция\n\n");
				}

				if (answer == "1")
				{
					while (true)
					{
						Console.Write("Введите сумму пополнения: ");
						if (double.TryParse(Console.ReadLine(), out double x) && x >= 0)
						{
							money += x;
							break;
						}

						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("!- Введите корректную сумму -!");
						Console.ResetColor();
					}
				}
				else if (answer == "2")
				{
					while (true)
					{
						Console.WriteLine("Введите сумму снятия: ");

						if (double.TryParse(Console.ReadLine(), out double x) && x <= money)
						{
							money -= x;
							break;
						}

						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("!- Введите корректную сумму -!");
						Console.ResetColor();
					}
				}
				else if (answer == "3")
				{
					Console.WriteLine("Вы уверены, что хотите аннулировать счёт: ");

					bool exitstatus = false;

					while (true)
					{
						string submition = Console.ReadLine();
						if (submition == "Да" || submition == "да")
						{
							exitstatus = true;
							break;
						}

						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("!- Нераспознанный ответ -!");
						Console.ResetColor();
					}

					if (exitstatus)
						break;

					if (money == 0)
					{
						Console.WriteLine("У вас не осталось средств,");
					}
				}
			}
		}
	}
}
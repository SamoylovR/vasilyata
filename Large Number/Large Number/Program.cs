using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Large_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше число, оно долно удовлетворять следующим условиям:\n1.Целое\n2.Не отрицательное\n(Да Артем, я видел как ты издевался над прогой Стаса, не надо так :D)");
            
            string Number = Transformation.Cheking();

            Console.Clear();

            Console.WriteLine(Number);
            Console.WriteLine("введите число на которое вы хотите умножить ваше, оно должно удовлетворять следующим условиям:\n1.Не отрицательное\n2.Целое");

            double Multiply = Convert.ToDouble(Transformation.Cheking());
            
            string[] UsingNumber = new string[Number.Length];
            string[] AddingNumber = new string[Number.Length];

            Transformation.Adjustment(Number, ref UsingNumber, ref AddingNumber, 5);
           
            string[] UsingNumber1 = new string[UsingNumber.Length / 5];
            string[] AddingNumber1 = new string[AddingNumber.Length / 5];
            
            int add = 0;
            for (int i = 0; i <= AddingNumber1.Length - 1; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    UsingNumber1[i] += UsingNumber[j + add];
                    AddingNumber1[i] += AddingNumber[j + add];
                }
                add += 5;
            }
            for (int f = 2; f <= Multiply; f++)
            {
                for (int i = AddingNumber1.Length - 1; i >= 0; i--)
                {
                    try
                    {

                        if (Convert.ToInt32(UsingNumber1[i]) + Convert.ToInt32(AddingNumber1[i]) >= 100000)
                        {
                            UsingNumber1[i] = Convert.ToString(Convert.ToInt32(UsingNumber1[i]) + Convert.ToInt32(AddingNumber1[i]) - 100000);
                            UsingNumber1[i - 1] = Convert.ToString(Convert.ToInt32(UsingNumber1[i - 1]) + 1);
                        }
                        else
                            UsingNumber1[i] = Convert.ToString(Convert.ToInt32(UsingNumber1[i]) + Convert.ToInt32(AddingNumber1[i]));

                    }
                    catch (IndexOutOfRangeException)
                    {
                        Transformation.Adding(ref UsingNumber1, ref AddingNumber1);
                        AddingNumber1[0] = "0";
                        UsingNumber1[0] = "1";
                    }
                }
            }
                Console.WriteLine("\n");
                Console.Write($"Полученное число равно:\n{Number}*{Multiply}=");
                for (int i = 0; i <= UsingNumber1.Length - 1; i++)
                {
                    Console.Write(UsingNumber1[i]);
                }
            
        }
    }
}

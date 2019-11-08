using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hui
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number = Console.ReadLine();
            int Multiply = Convert.ToInt32(Console.ReadLine());
            string[] UsingNumber = new string[Number.Length];
            string[] AddingNumber = new string[Number.Length];
            for (int i = 0; i <= Number.Length - 1; i++)
            {
                UsingNumber[i] = Convert.ToString(Number[i]);
                AddingNumber[i] = Convert.ToString(Number[i]);
            }
            while (UsingNumber.Length % 5 != 0 && AddingNumber.Length % 5 != 0)
            {
                string[] Help = new string[AddingNumber.Length + 1];
                Help[0] = "0";
                for (int i = 0; i <= AddingNumber.Length - 1; i++)
                {
                    Help[i + 1] = AddingNumber[i];
                }
                AddingNumber = Help;
                UsingNumber = Help;
            }
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
                        string[] Help1 = new string[AddingNumber1.Length + 1];
                        string[] Help2 = new string[UsingNumber1.Length + 1];
                        Help1[0] = "0";
                        Help2[0] = "0";
                        for (int n = 0; n <= AddingNumber1.Length - 1; i++)
                        {
                            Help1[n + 1] = AddingNumber1[n];
                            Help2[n + 1] = UsingNumber1[n];
                        }
                        AddingNumber1 = Help1;
                        UsingNumber1 = Help2;
                        AddingNumber1[0] = "1";
                        UsingNumber1[0] = "1";
                    }
                }
            }











































                Console.WriteLine("\n");
                Console.WriteLine("ITOG");
                for (int i = 0; i <= UsingNumber1.Length - 1; i++)
                {
                    Console.Write(UsingNumber1[i]);
                }
            
        }
    }
}

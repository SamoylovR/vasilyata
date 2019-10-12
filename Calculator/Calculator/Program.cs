using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversePolishNotation rpn = new ReversePolishNotation();

            while (true)
            {
                Console.WriteLine("Введите выражение:");
                Console.WriteLine("Введите Выход/Exit, чтобы закончить операцию");

                string expression = "";
                bool exitStatus = false;

                while (true)
                {
                    expression = Console.ReadLine();
                    expression = expression.ToLower();
                    expression = expression.Replace(" ", string.Empty);

                    if (expression == "выход" || expression == "exit" || expression == "ds[jl" || expression == "учше")
                    {
                        exitStatus = true;
                        break;
                    }

                    if (rpn.StringToRPN(expression) != "Decoding error, let's try again")
                        break;

                    Console.WriteLine("Try to enter expression correctly again");
                }

                if (exitStatus)
                    break;

                Console.WriteLine(rpn.StringToRPN(expression));
                Console.WriteLine(rpn.RPNToAnswer(rpn.StringToRPN(expression)));
            }   
        }
    }
}
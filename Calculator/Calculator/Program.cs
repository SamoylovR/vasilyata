using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение:");
            string expression = "";

            Calculate calculate = new Calculate();

            List<double> numbers = new List<double> { };
            List<char> operations = new List<char> { };

            bool decodingStatus = true;

            while (decodingStatus)
            {
                expression = Console.ReadLine();
                expression = expression.Replace(" ", string.Empty);


                string numberString = "";
                byte count = 0;

                for (int i = 0; i < expression.Length; i++)
                {
                    if (expression[i] == ',' || expression[i] == '.')
                        count++;

                    if ((!byte.TryParse(expression[i].ToString(), out byte x) && count == 2) || !byte.TryParse(expression[expression.Length - 1].ToString(), out byte c))
                    {
                        Console.WriteLine("Введите корректное выражение");
                        numbers.Clear();
                        break;
                    }

                    if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/' || i == expression.Length - 1 && double.TryParse(numberString, out double y))
                    {
                        if (numberString.Length == 0)
                        {
                            Console.WriteLine("Ведите корректное значение");
                            numbers.Clear();
                            break;
                        }

                        operations.Add(expression[i]);

                        if (i == expression.Length - 1 && byte.TryParse(expression[i].ToString(), out byte b))
                        {
                            numberString += expression[i];
                            decodingStatus = false;
                        }

                        numbers.Add(Convert.ToDouble(numberString));
                        numberString = string.Empty;
                    }
                    else
                    {
                        numberString += expression[i];
                        numberString = numberString.Replace('.', ',');
                    }

                    if (i == expression.Length - 1 && double.TryParse(numberString, out double a))
                    {
                        numbers.Add(Convert.ToDouble(numberString));

                        decodingStatus = false;
                    }
                }
            }
            int j = 0;

            foreach (char o in operations)
            {
                if (o == '*')
                {
                    numbers[j + 1] = calculate.Multiplication(numbers[j], numbers[j + 1]);
                    numbers[j] = 0;
                }
                else if (o == '/')
                {
                    numbers[j + 1] = calculate.Division(numbers[j], numbers[j + 1]);
                    numbers[j] = 0;
                }
                else if (o == '-')
                {
                    numbers[j + 1] = -numbers[j + 1];
                }

                j++;
            }

            double sum = 0;

            foreach (double n in numbers)
                sum += n;

            Console.WriteLine($"Результат: {sum}");
        }
    }
}
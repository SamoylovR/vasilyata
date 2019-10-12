using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class ReversePolishNotation
    {
        public sbyte GetPriority(char symbol)
        {
            if (symbol == '*' || symbol == '/')
                return 3;
            else if (symbol == '+' || symbol == '-')
                return 2;
            else if (symbol == '(')
                return 1;
            else if (symbol == ')')
                return -1;
            else if (byte.TryParse(symbol.ToString(), out byte x))
                return 0;
            else return -2;
        }

        public double RPNToAnswer(string RPN)
        {
            string number = "";
            Stack<double> stack = new Stack<double>();

            for (int i = 0; i < RPN.Length; i++)
            {
                if (RPN[i] == ' ')
                    continue;

                if (GetPriority(RPN[i]) == 0)
                {
                    while (RPN[i] != ' ' && GetPriority(RPN[i]) == 0)
                    {
                        number += RPN[i++];
                        if (i == RPN.Length)
                            break;
                    }

                    stack.Push(double.Parse(number));
                    number = string.Empty;
                }

                if (GetPriority(RPN[i]) > 1)
                {
                    double firstNumber = stack.Pop(), secondNumber = stack.Pop();

                    if (RPN[i] == '+')
                        stack.Push(firstNumber + secondNumber);
                    if (RPN[i] == '-')
                        stack.Push(firstNumber - secondNumber);
                    if (RPN[i] == '*')
                        stack.Push(firstNumber * secondNumber);
                    if (RPN[i] == '/')
                        stack.Push(firstNumber / secondNumber);
                }
            }
            return stack.Pop();
        }

        public string StringToRPN(string Expression)
        {
            string errorString = "Decoding error, let's try again";

            string current = "";
            Stack<Char> stack = new Stack<char>();

            for (int i = 0; i < Expression.Length; i++)
            {
                sbyte priority = GetPriority(Expression[i]);

                if (priority > 1 && GetPriority(Expression[i - 1]) > 1)
                    return errorString;

                if (priority == 0)
                    current += Expression[i];
                else if (priority == 1)
                    stack.Push(Expression[i]);
                else if (priority > 1)
                {
                    current += ' ';

                    while (stack.Count != 0)
                    {
                        if (GetPriority(stack.Peek()) >= priority)
                            current += stack.Pop();
                        else break;
                    }

                    stack.Push(Expression[i]);
                }
                else if (priority == -1)
                {
                    current += ' ';

                    while (GetPriority(stack.Peek()) != 1)
                        current += stack.Pop();

                    stack.Pop();
                }
                else if (priority == -2)
                    return errorString;
            }

            while (stack.Count != 0)
                current += stack.Pop();

            return current;
        }
    }
}

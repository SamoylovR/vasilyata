using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IСalculator
    {
        Task<double> Addition(int a, int b);

        Task<double> Substraction(int a, int b);

        Task<double> Multiplication(int a, int b);

        Task<double> Divison(int a, int b);

        Task<double> Result(string operations);
    }
}

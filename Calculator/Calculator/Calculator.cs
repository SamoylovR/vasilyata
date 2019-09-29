using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public double Addition(int a, int b)
        {
            return a + b;
        }

        public double Divison(int a, int b)
        {
            
        }

        public Task<double> Multiplication(int a, int b)
        {
            
        }

        public Task<double> Result(string operations)
        {
            throw new NotImplementedException();
        }

        public Task<double> Substraction(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}

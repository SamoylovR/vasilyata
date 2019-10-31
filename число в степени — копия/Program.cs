using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace число_в_степени
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double num = Convert.ToDouble(Console.ReadLine());
            BigInteger num1 =(BigInteger) num;
            Console.WriteLine(num);
            Console.WriteLine("Введите степень");
            int pow = Convert.ToInt32(Console.ReadLine());
            BigInteger result = BigInteger.Pow(num1, pow);
            Console.WriteLine(result);

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace программа_начисления_зп
{
    class Program
    {
        static void Main(string[] args)
        {
            Direction direction = new Direction("Вова",25,0);
            Boozer boozer1 = new Boozer("Петя", 15, 0);
            Boozer boozer2 = new Boozer("Вася", 20, 0);
            Boozer boozer3 = new Boozer("Анатолий", 5, 0);

            Worker[] workers = new Worker[] {
             direction,
             boozer1,
             boozer2,
             boozer3
            };


            for(int i=0;i<workers.Length;i++)
            {
                Accountant.Pay(workers[i]);
            }

        }
    }
}

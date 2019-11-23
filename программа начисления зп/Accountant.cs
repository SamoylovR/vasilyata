using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace программа_начисления_зп
{
    static class Accountant
    {
        public static void Pay (Worker worker)
        {
            double pay = worker.Oklad * worker.Time;
            Console.WriteLine($"Уважаемый {worker.Name} ваша зарплата составляет: {pay} рос. руб");
        }
    }
}

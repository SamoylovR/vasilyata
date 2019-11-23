using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace программа_начисления_зп
{
     abstract class Worker
    {
        public string Name { get; private set; }
        public int Time { get; private set; }
        public abstract int Oklad { get; set; }
        public double Money
        {
            get { return Money; }
            set
            {
                if (value>0)
                {
                    Money= value;
                }
            }
        }

        public Worker(string name, int time, double money)
        {
            Name = name;
            Time = time;
            Money = money;
        }
    }
}

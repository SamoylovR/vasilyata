using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace программа_начисления_зп
{
    class Boozer : Worker
    { 

        public Boozer(string name, int time, double money) : base(name, time, money)
        {
        }

        public override int Oklad
        {
            get
            {
                return oklad;
            }
            set
            {
                Oklad = oklad;
            }
        }
        public int oklad = 1500;
    }
}

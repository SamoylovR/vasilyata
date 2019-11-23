using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace программа_начисления_зп
{
    class Direction : Worker
    {
        public Direction(string name, int time, double money) : base(name, time, money)
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
        public int oklad = 2500;
    }
}

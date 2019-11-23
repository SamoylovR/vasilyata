using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class FinancialDepartment
    {
        private static double money  = 1000000; //My MONEY... ohhhh ... You so SWEEEEEEET
        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value <= money)
                {
                    money += value;
                }
                
            }
        }
        //method which counts and gives workers salary
        public  double GiveSalary(int hours, double moneyPerHour)
        {
            double salary = hours * moneyPerHour;

            money -= salary;
            //Console.WriteLine("money after salary"+ money);// only for testing
            
            return salary;
        }
    }
}

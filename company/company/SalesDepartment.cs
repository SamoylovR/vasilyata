using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class SalesDepartment
    {
       private static int Warehouse; // The name tells everything)
        public int warehouse
        {
            get
            {
                return Warehouse;
            }
            set
            {
                Warehouse += value;
                Console.WriteLine("WH " + Warehouse);//only for testing
            }

        }
        //method which 
        public void TryToSaleProduct()
        {
            FinancialDepartment receivedMoney = new FinancialDepartment();
            Random sale = new Random();
            receivedMoney.Money= sale.Next(0, Warehouse)*20;
            Console.WriteLine("money after sale "+ receivedMoney.Money);
        }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class SalesDepartment
    {
        private static int SoldProduction;
        
        public int soldProduction
        {
            get
            {
                return SoldProduction;
            }
            set
            {
                SoldProduction = value;
            }
        }

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
                //Console.WriteLine("WH " + Warehouse);//only for testing
            }

        }
        //method which count a number of sold production
        public void TryToSaleProduction()
        {
            FinancialDepartment receivedMoney = new FinancialDepartment();

            Random sale = new Random();

            SoldProduction = sale.Next(0, Warehouse);

            Warehouse -= SoldProduction;

            receivedMoney.Money= SoldProduction*30;

           // Console.WriteLine("money after sale "+ receivedMoney.Money);

        }
        }
    }


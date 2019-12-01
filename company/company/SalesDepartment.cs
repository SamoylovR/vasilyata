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

        private int productPrice  = 30;

        public int ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }
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

            int limit = warehouse;

            if ((Warehouse * 20) / productPrice < warehouse)
            {
                limit = (Warehouse * 20) / productPrice;
            }
            int n = 0;

            if (productPrice < 20)
            {
                n = Warehouse;
            }

            SoldProduction = sale.Next(n, limit);

            Warehouse -= SoldProduction;

            receivedMoney.Money= SoldProduction*productPrice;

           // Console.WriteLine("money after sale "+ receivedMoney.Money);

        }
        }
    }


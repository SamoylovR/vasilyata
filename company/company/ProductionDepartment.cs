using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class ProductionDepartment
    {
        public static int workOfEmployees=0;
        private static int Product;
        public int product
        {
            get
            {
                return Product;
            }
            set
            {
                Product = value;
            }
        }
        //counts and registers average work of workers from production department
       public static void WorkOfEmployees(int hours)
        {
            workOfEmployees = hours;

            //Console.WriteLine("Work of employees"+workOfEmployees);//only for testing
            ProductionDepartment prod = new ProductionDepartment();

            prod.ProduceSomething();
        }
        //produces product for sale
        public void ProduceSomething()
        {
            Random product = new Random();

            Product = product.Next(0, workOfEmployees);

            SalesDepartment wh = new SalesDepartment();

            wh.warehouse=Product;
            //Console.WriteLine("Produced "+Product);//only for testing
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class Program
    {
        delegate void EndOfTheDay();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees");

            Employees emp = new Employees(Convert.ToInt32(Console.ReadLine()));

            SalesDepartment sale = new SalesDepartment();

            emp.FillingTheListOfEmployees();

            EndOfTheDay day = emp.LeaveATimeReport;

            day += emp.GiveSalary;

            day += sale.TryToSaleProduct;

            while (true)
            {
                day();
                Console.ReadLine();
            }
        }
    }
}

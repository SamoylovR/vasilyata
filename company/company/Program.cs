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
            SalesDepartment sale = new SalesDepartment();

            FinancialDepartment fin = new FinancialDepartment();

            ProductionDepartment prod = new ProductionDepartment();
            
                Console.WriteLine("Hallo new user.\n" +
                    "This app can help you to be in charge of your own company\n" +
                    "Every company needs employees\n" +
                    "Enter the number of employees");
            Employees emp = new Employees(Convert.ToInt32(Console.ReadLine()));

            Console.Clear();

            Console.WriteLine("Well. Lets fill this list with information about your Employees");

            emp.FillingTheListOfEmployees();

            Console.WriteLine("Now you have a staff and some money.\n" +
                "you can do whatever your want");

            EndOfTheDay day;

            ConsoleKeyInfo keyPress = new ConsoleKeyInfo();

            day = emp.LeaveATimeReport; // Time report from employyes

            while (true)
            {
                while (true)
                {
                  
                    Console.WriteLine("1.Producing\n" +
                        "2.Salary\n" +
                        "3.Daily report\n" +
                        "4.Employees\n" +
                        "5.Another information\n" +
                        "6.End the day");

                    keyPress = Console.ReadKey();

                    if (keyPress.KeyChar == '1')
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1.Stock balance\n" +
                                "2.Sale product from warehouse after the end of the day\n" +
                                "3.Do not sell products after the end of the day\n" +
                                "4.Back to the main menue");
                            keyPress = Console.ReadKey();
                            if (keyPress.KeyChar == '1')
                            {
                                Console.Clear();

                                Console.WriteLine($"Stock balance is {sale.warehouse} products\n" +
                                    $"Press any button...");

                                Console.ReadLine();
                            }else if (keyPress.KeyChar == '2')
                            {
                                Console.Clear();
                                day -= sale.TryToSaleProduction;

                                day += sale.TryToSaleProduction;// Make money from selling production
                                Console.WriteLine("Some prouduction will be sold\n" +
                                    "Press any button...");
                                Console.ReadKey();
                            }else if (keyPress.KeyChar == '3')
                            {
                                Console.Clear();
                                day -= sale.TryToSaleProduction;
                                Console.WriteLine("You refuzed to sell production\n" +
                                    "Press any button...");
                                Console.ReadKey();
                            }else if (keyPress.KeyChar == '4')
                            {
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    else if (keyPress.KeyChar == '2')
                    {
                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("1.Salary of each worker for yesterday\n" +
                                "2.Give salary for every worker after the end of the day\n" +
                                "3.Refuze to pay workers salary after the end of the day\n" +
                                "4.Back to the main menue");
                            keyPress = Console.ReadKey();
                            if (keyPress.KeyChar == '1')
                            {
                                emp.DisplaySalaryReport();

                                Console.WriteLine("Press any button...");

                                Console.ReadKey();

                                Console.Clear();
                            }else if (keyPress.KeyChar == '2')
                            {
                                Console.Clear();

                                day -= emp.GiveSalary;
                                day += emp.GiveSalary;// Give salary to your slav... Employees :D

                                Console.WriteLine("Salary will be paid it the end of the day\n" +
                                    "Press any button...");

                                Console.ReadKey();
                                Console.Clear();
                            }else if(keyPress.KeyChar == '3')
                            {
                                Console.Clear();

                                day -= emp.GiveSalary;
                                Console.WriteLine("You refuzed to pay salary to your workers in the end of the day\n" +
                                    "Press any button...");
                                Console.ReadKey();
                                Console.Clear();
                            }else if (keyPress.KeyChar == '4')
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.Clear();
                            }
                        }

                    }
                    else if (keyPress.KeyChar == '3')
                    {
                        Console.Clear();

                        emp.DisplayADayReport();

                        Console.WriteLine("Press any button...");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (keyPress.KeyChar == '4')
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1.List of employees\n" +
                                "2.Fire an employee(the function is under revision)\n" +
                                "3.Add an employee(the function is under revision)\n" +
                                "4.Back to the main menue");
                            keyPress = Console.ReadKey();
                            if (keyPress.KeyChar == '1')
                            {
                                emp.DisplayLIstOfEmployees();
                                Console.WriteLine("Press any button...");
                                Console.ReadKey();
                            }
                            else if (keyPress.KeyChar == '4')
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {

                            }
                        }
                    }
                    else if (keyPress.KeyChar == '5')
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1.Current money\n" +
                                "2.Workers who did not come to work\n" +
                                "3.Back to the main menue");
                            keyPress = Console.ReadKey();
                            if (keyPress.KeyChar == '1')
                            {
                                Console.Clear();
                                Console.WriteLine($"Current money:{fin.Money}$\n" +
                                    $"Press any button...");
                                Console.ReadKey();
                                Console.Clear();
                            }else if (keyPress.KeyChar == '2')
                            {
                                Console.Clear();

                                emp.DisplayTruants();

                                Console.WriteLine("Press any button...");

                                Console.ReadKey();

                                Console.Clear();
                            }else if (keyPress.KeyChar == '3')
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.Clear();
                            }
                        }
                    }
                    else if (keyPress.KeyChar == '6')
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                Console.Clear();
                day();
                Console.WriteLine("Another day, another life. I feel smell of money in my purse\n" +
                    "Press any button...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

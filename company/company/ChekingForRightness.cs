using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class ChekingForRightness
    {
        public static string ChekingName()
        {
            string name;

            while (true)
            {
                name = Console.ReadLine(); 

                if(name.Contains("1")==true|| name.Contains("2") == true || name.Contains("3") == true || name.Contains("4") == true || name.Contains("5") == true || name.Contains("6") == true || name.Contains("7") == true || name.Contains("8") == true || name.Contains("9") == true)
                {

                    Console.Clear();
                    Console.WriteLine("The name cannot contain numbers.Please, try again ");
                }
                else
                {
                    break;
                }
            }
            return name;
        }
        public static  string ChekingDepartment()
        {
            string department;

            while (true)
            {
                department = Console.ReadLine();

                if(department!="production"&&department != "sales" && department != "financial" && department != "personnel" )
                {
                    Console.Clear();
                    Console.WriteLine("You made a mistake or wrote a nonexistent department. Please, try again");
                }
                else
                {
                    break;
                }
            }
            return department;
        }
        public static int ChekingAge()
        {
            string age;
            while (true)
            {
                age = Console.ReadLine();
                if (!int.TryParse(age, out int a))
                {
                    Console.Clear();

                    Console.WriteLine("You entered an incorrect value, try again ");
                }
                else if (Convert.ToInt32(age) < 18 || Convert.ToInt32(age) > 40)
                {
                    Console.Clear();

                    Console.WriteLine("You entered an uncorrect value.\nEmployee cant be younger than 18 years and older than 40");
                }
                else
                {
                    break;
                }
            }
            return Convert.ToInt32(age);
        }
        public static double ChekingSalary(string department)
        {
            string salary;
            byte dep;
            if (department == "production")
            {
                Console.WriteLine("This employee from production department. His maximum salary may not be more than 10");

                dep = 10;
            }else if (department == "sales")
            {
                Console.WriteLine("This employee from sales department. His maximum salary may not be more than 15");

                dep = 15;
            }else if (department == "financial")
            {
                Console.WriteLine("This employee from financial department. His maximum salary may not be more than 20");

                dep = 20;
            }
            else
            {
                Console.WriteLine("This employee from personel department. His maximum salary may not be more than 12");

                dep = 12;
            }

            while (true)
            {
                salary = Console.ReadLine();
                if (!double.TryParse(salary, out double a))
                {
                    Console.Clear();

                    Console.WriteLine("You entered an incorrect value, try again ");
                }else if (Convert.ToDouble(salary) > dep)
                {
                    Console.Clear();
                    Console.WriteLine($"This worker from {department} department. His maximum salary may not be more than {dep}");
                }else if (Convert.ToDouble(salary) <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Hey. Every worker must receive a salary. ");
                }
                else
                {
                    break;
                }
            }
            return Convert.ToDouble(salary);
            
        }
        public static int ChekingNumbers()
        {
            string number;
            while (true)
            {
                number = Console.ReadLine();

                if(!int.TryParse(number, out int x))
                {
                    Console.Clear();

                    Console.WriteLine("You entered an incorrect value, try again ");
                }
                else
                {
                    break;
                }
               
            }
            return Convert.ToInt32(number);
        }
        public static int ChekingNumbers(int barrier)
        {
            string number;
            while (true)
            {
                number = Console.ReadLine();

                if (!int.TryParse(number, out int x)||Convert.ToInt32(number)>barrier)
                {
                    Console.Clear();

                    Console.WriteLine("You entered an incorrect value, try again ");
                }
                else
                {
                    break;
                }

            }
            return Convert.ToInt32(number);
        }
    }
}

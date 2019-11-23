using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class Employee
    {
        public string Department { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double SalaryPerHour { get; set; }
        public int workingHours { get; set; }
        public double salary { get; set; }
    }
    class Employees
    {
        public int employeeCount { get; set; } //number of employees
        Employee[] worker { get; }
        public Employees(int employeeCount)
        {
            this.employeeCount = employeeCount;

            worker = new Employee[employeeCount];
        }
        public Employee this[int index]
        {
            get
            {
                return worker[index];
            }
            set
            {
                worker[index] = value;
            }
        }
        // method which fills list of employees
        public void FillingTheListOfEmployees()
        {
            Employees employee = new Employees(employeeCount);

            int n = 0;

            while (true)
            {

                Console.WriteLine("Workers name");

                string name = ChekingForRightness.ChekingName();

                Console.Clear();

                Console.WriteLine("Workers department\nSales\nFinancial\nProduction\nPersonnel");

                string department =ChekingForRightness.ChekingDepartment ();

                Console.Clear();

                Console.WriteLine("Workers age");

                int age = ChekingForRightness.ChekingAge();

                Console.Clear();

                Console.WriteLine("Workers salary per hour");

                double salaryPerHour = ChekingForRightness.ChekingSalary(department);

                employee[n] = new Employee { Name = name, Department = department, Age = age, SalaryPerHour = salaryPerHour, workingHours=0, salary=0 };

                worker[n] = employee[n];

                n += 1;
                Console.Clear();

                if (n == employeeCount)
                {
                    break;
                }
            }
        }
        //method which leave a random  time report for every eployee
        public  void LeaveATimeReport()
        {
            int averageHours = 0;
            int averageHoursOfProduction = 0;

            Random hours = new Random();

            for (int i = 0; i < employeeCount; i++)
            {
                worker[i].workingHours = hours.Next(0,20);
                if (worker[i].Department == "production")
                {
                    averageHoursOfProduction += worker[i].workingHours;//Work of production department
                  
                }
                averageHours += worker[i].workingHours;//average work
                //Console.WriteLine(worker[i].Name + " " + worker[i].workingHours);//only for testing
            }
          //  Console.WriteLine("PD worked" + averageHoursOfProduction);//test

            ProductionDepartment.WorkOfEmployees(averageHoursOfProduction);
        }
        public void GiveSalary()
        {
            FinancialDepartment finance = new FinancialDepartment();

            for (int i = 0; i < employeeCount; i++)
            {
                worker[i].salary = finance.GiveSalary(worker[i].workingHours, worker[i].SalaryPerHour);
                //Console.WriteLine($"Worker {worker[i].Name} from {worker[i].Department} department got {worker[i].salary}");// only for testing
            }
        }
        public void SetEmployeeCount(int number)
        {
            employeeCount = number;

        }
        public void DisplayADayReport()
        {
            ProductionDepartment prodRep = new ProductionDepartment();

            SalesDepartment saleRep = new SalesDepartment();

            FinancialDepartment finRep = new FinancialDepartment();

            Console.WriteLine("A day report");

            for(int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"{i+1}.Employee {worker[i].Name}. Department {worker[i].Department}." +
                    $"\nThe total number of hours worked is {worker[i].workingHours}. ");
            }
            Console.WriteLine($"Were produced {prodRep.product} units\n" +
                $"Were sold {saleRep.soldProduction} units\n" +
                $"Current money {finRep.Money}$\n" +
                $"The rest of the product in warehouse is {saleRep.warehouse} units ");
        }
        public void DisplayLIstOfEmployees()
        {
            Console.Clear();
            for(int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"Worker №{i+1}: Name:{worker[i].Name}. Age{worker[i].Age}. Works in {worker[i].Department} department.  Salary {worker[i].SalaryPerHour}$");
            }
        }
        public void DisplaySalaryReport()
        {
            Console.Clear();
            for(int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"Name:{worker[i].Name} got {worker[i].salary}$");
            }

        }
        // Shows you who didnt came to work yesterday
        public void DisplayTruants()
        {
            int n = 0;
            Console.Clear();
            for (int i =0;i<employeeCount;i++)
            {
                if (worker[i].workingHours == 0)
                {
                    n += 1;
                    Console.WriteLine($"Worker {worker[i].Name} from {worker[i].Department} department didnt came to work.");
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Every worker came to work");
            }
        }
    }
   
}

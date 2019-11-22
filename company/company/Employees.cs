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
        public int employeeCount; //number of employees
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

                string name = Console.ReadLine();

                Console.WriteLine("Workers department");

                string department = Console.ReadLine();

                Console.WriteLine("Workers age");

                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Workers salary");

                double salaryPerHour = Convert.ToDouble(Console.ReadLine());

                employee[n] = new Employee { Name = name, Department = department, Age = age, SalaryPerHour = salaryPerHour, workingHours=0, salary=0 };
                worker[n] = employee[n];
                n += 1;
                if (n == employeeCount)
                {
                    Console.WriteLine("Рабочие места кончились");
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
                Console.WriteLine(worker[i].Name + " " + worker[i].workingHours);//only for testing
            }
            Console.WriteLine("PD worked" + averageHoursOfProduction);//test
            ProductionDepartment.WorkOfEmployees(averageHoursOfProduction);
        }
        public void GiveSalary()
        {
            FinancialDepartment finance = new FinancialDepartment();
            for (int i = 0; i < employeeCount; i++)
            {
                worker[i].salary = finance.GiveSalary(worker[i].workingHours, worker[i].SalaryPerHour);
                Console.WriteLine($"Worker {worker[i].Name} from {worker[i].Department} department got {worker[i].salary}");// only for testing
            }
        }
        public void SetEmployeeCount(int number)
        {
            employeeCount = number;

        }
    }
   
}

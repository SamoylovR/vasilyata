using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Checking
    {
        public static bool ChekingNumbers(string Command, int n)
        {
           
            bool Succes = Int32.TryParse(Command, out int x);
            
            int Command1 = Convert.ToInt32(Command);
           
            if (!Succes||Command1<0||Command1>n)
            {
                
                Console.Clear();
               
                Console.WriteLine("Введено некорректное значение, опробуйте еще раз");
                
                return false;
            }
            return Succes;
        }
        public static bool ChekingWords(string Command)
        {
            bool Succes = Int32.TryParse(Command, out int x);
           
            int Command1 = Convert.ToInt32(Command);
            
            if (Succes)
            {
                Console.Clear();
               
                Console.WriteLine("Введено некорректное значение, опробуйте еще раз");
                
                return false;
            }
            return true;
        }
    }
}

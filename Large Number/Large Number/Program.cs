using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            String Number = Console.ReadLine();
            int Degree = Convert.ToInt32(Console.ReadLine());  
            string[] UsingNumber = new string[Number.Length];
            string[] AddingNumber = new string[Number.Length];
            for (int i = 0; i <= Number.Length - 1; i++)
            {
              UsingNumber[i] = Convert.ToString(Number[i]);
              AddingNumber[i] = Convert.ToString( Number[i]);
            }
            //for (int k = 2; k <=Degree; k++)
        //  {
                for (int j = 1; j < Convert.ToInt32(Number); j++)
                {
                string[] Helper2 = new string[AddingNumber.Length+1];
                string[] Helper1 = new string[UsingNumber.Length + 1];
                Helper1[0] = "0";
                Helper2[0] = "0";
                for(int n = 1; n <= AddingNumber.Length; n++)
                {
                    Helper2[n] = Convert.ToString(AddingNumber[n-1]);
                   // Console.WriteLine("Helpers2 n" + n + " " + Helper2[n]);
                }
                for (int n=1;n<=UsingNumber.Length;n++)
                {
                    Helper1[n] = Convert.ToString(UsingNumber[n - 1]);
                   // Console.WriteLine("Helpers1 n"+n+" "+Helper1[n]);
                }
                AddingNumber = Helper2;
                UsingNumber = Helper1;
                    for (int i = UsingNumber.Length - 1; i >= 0; i--)
                    {
                    if (Convert.ToInt32(UsingNumber[i]) + Convert.ToInt32(AddingNumber[i])>=10)
                    {
                        UsingNumber[i] = Convert.ToString(Convert.ToInt32(UsingNumber[i]) + Convert.ToInt32(AddingNumber[i])-10);
                        UsingNumber[i - 1] = Convert.ToString(Convert.ToInt32(UsingNumber[i - 1])+1);
                    }else 
                        UsingNumber[i] = Convert.ToString(Convert.ToInt32(UsingNumber[i]) + Convert.ToInt32(AddingNumber[i]));
                   
                    }
                }
          //  }
        






























            for (int i=0;i<= Number.Length - 1; i++)
            {
               Console.WriteLine(AddingNumber[i]);
         
            }
            Console.WriteLine("Итог");
            for (int i = 0; i <= UsingNumber.Length - 1; i++)
            {
               
                Console.Write(UsingNumber[i]);
            }

        }
    }
}

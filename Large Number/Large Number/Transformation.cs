using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_Number
{
    class Transformation
    {
     public static void Adding(ref string[] a,ref string[] b)
        {
            string[] Help1 = new string[a.Length + 1];
            string[] Help2 = new string[a.Length + 1];
            Help1[0] = "0";
            Help2[0] = "0";
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Help1[i + 1] = a[i];
            }
            a = Help1;
            for (int i = 0; i <= b.Length - 1; i++)
            {
                Help2[i + 1] = b[i];
            }
            b = Help2;
        }
        public static void Adjustment(string c, ref string[] a,ref string[] b, int n) 
        {
            for (int i = 0; i <= c.Length - 1; i++)
            {
               a[i] = Convert.ToString(c[i]);
                b[i] = Convert.ToString(c[i]);
            }
            while (a.Length % n != 0 && b.Length % n != 0)
            {
                Transformation.Adding(ref a, ref b);
            }
        }
        public static string Cheking()
        {
            string Number = "";
            while (true)
            {
                int cheking = 0;
                Number = Console.ReadLine();
                if (Number.Contains("-") != true && Number.Contains(".") != true && Number.Contains(",") != true)
                {
                    for (int i = 0; i <= Number.Length - 1; i++)
                    {
                        int e;
                        bool succes = int.TryParse(Convert.ToString(Number[i]), out e);
                        if (succes == true)
                            cheking += 1;
                    }
                    if (cheking == Number.Length)
                        break;
                }
                Console.Clear();
                Console.WriteLine("Введено некорректное число, попробуй еще раз");
            }
            return Number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public string Login;
        public string Password;
        public User()
        {
            Login = Console.ReadLine();

            Password = Console.ReadLine();

            Console.WriteLine("Регистрация прошла успешно");
            /*if (Login == "admin" && Password == "admin")
                OwnersAccount.WorkWithOwner();*/

        }
        public bool Entering()
        {
            while (true)
            {
                if (Login == Console.ReadLine() && Password == Console.ReadLine())
                {
                    Console.Clear();
                    Console.WriteLine("Обработка полученных данных...\nВход в систему... ");

                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введен неверный логин или пароль попробуйте снова");

                    return false;
                }
            }
        }
    }
}

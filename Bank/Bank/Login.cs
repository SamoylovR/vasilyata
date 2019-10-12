using System;
using System.Collections.Generic;
using System.Text;

namespace Logining
{
    class Registration
    {
        public static (string, string) registration(string UserLogin, string UserPassword)
        {
            var RegistrationField = (UserLogin, UserPassword);
            Console.Clear();
            Console.WriteLine("Регистрация прошла успешно, введите логин и пароль заново");
            return RegistrationField;
        }
    }
    class Login
    {
       public static int login(string RealLogin, string RealPassword, string WritedLogin, string WritedPassword)
        {
            RealLogin = RealLogin.Replace(" ", "");
            WritedLogin = WritedLogin.Replace(" ","");
            RealPassword = RealPassword.Replace(" ","");
            WritedPassword = WritedPassword.Replace(" ","");
            if (RealLogin == WritedLogin && RealPassword == WritedPassword)
                return 1;
            else return 0;
            }
        } 
    }


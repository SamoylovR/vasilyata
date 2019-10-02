using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гыгы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем вас, спасибо,что выбрали наш банк! Впишите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Давайте начнем работу с нашим терминалом,{name}, для просмотра списка функций напишите \"функции \". Если вы ознакомлены с функциями предлагаю начать работу.");
            string rabota = Console.ReadLine();
            if (rabota != "завершение работы")
            {
                rabota = rabota.Replace(" ", "");
            }
            rabota = rabota.ToLower();
            double ostatok = 25;
            string val = "Белорусских рублей";
            while (rabota != "завершение работы")
            {
                if (rabota != "завершение работы")
                {
                    rabota = rabota.Replace(" ", "");
                }
                switch (rabota)
                {
                    case "функции":
                        Console.WriteLine("Вы можете Проверить остаток на счете(остаток), онулировать счет(онулирование),завершить работу(завершение работы),перевести деньги со счета на счет(перевод),внести(внести) или снять(снять) деньги со счета или конвертировать свои деньги в другую валюту(конвертировать). ");
                        string rabota1 = Console.ReadLine();
                        rabota = rabota1;
                        break;
                    case "остаток":
                        Console.WriteLine("Остаток на счете составляет: " + ostatok+val);
                        Console.WriteLine($"{name},Желаете ли продолжить работу, или завершить ее?");
                        string rabota2 = Console.ReadLine();
                        rabota = rabota2;
                        break;
                    case "онулирование":
                        if (ostatok == 0)
                        {
                            Console.WriteLine("Ваш счет и так пуст, выбирайте другую операцию или завершайте работу");
                            string rabota6 = Console.ReadLine();
                            rabota = rabota6;
                            break;
                        }
                        Console.WriteLine("Вы точно уверены что хотите онулировать счет?");
                        string podtv = Console.ReadLine();
                        if (podtv == "да")
                        {
                            Console.WriteLine($"{name},вы на 100% уверены??? Вы потеряете все свои деньги");
                            string podtv2 = Console.ReadLine();
                            if (podtv2 == "да")
                            {
                                ostatok = 0;
                                Console.WriteLine("Остаток на счете: 0 " + val);
                            }
                            else
                            {
                                Console.WriteLine("Процесс онулирования отменен, желаете ли продолжить работу, или завершить ее?");
                                string rabota4 = Console.ReadLine();
                                rabota = rabota4;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Процесс онулирования отменен, желаете ли продолжить работу, или завершить ее?");
                            string rabota5 = Console.ReadLine();
                            rabota = rabota5;

                        }
                        Console.WriteLine($"{name},Желаете ли продолжить работу, или завершить ее?");
                        string rabota3 = Console.ReadLine();
                        rabota = rabota3;
                        break;
                    case "перевод":
                        Console.WriteLine("Введите номер карты получателя:");
                        string numberst = Console.ReadLine();
                        int number;
                        bool succes = Int32.TryParse(numberst, out number);

                        do
                        {
                            if ((!succes)&&(numberst.Length!=16))
                        {
                                Console.WriteLine("Введены неккоректные данные, попробуйте еще раз. Если вы хотите вернутся к выполнению других операций, введите \"отмена\"");
                                string numberst2 = Console.ReadLine();
                                numberst = numberst2;
                                int n = numberst.Length;
                        }
                             } while ((numberst != "отмена") && (numberst.Length != 16)) ;

                        if (numberst == "отмена")
                        {
                            string rabota6 = Console.ReadLine();
                            rabota = rabota6;
                            break;
                        }

                        Console.WriteLine("Введите сумму перевода");
                        string summast = Console.ReadLine();
                        summast = summast.Replace(".", ",");
                        summast = summast.Replace("-", " ");
                        double summa;
                        bool succes2;
                        do
                        {
                            succes2 = double.TryParse(summast, out summa);                     
                            if (!succes2)
                            {

                                Console.WriteLine("Введено некорректное значение, попробуйте еще раз. Если вы хотите вернутся к выполнению других операций, введите \"отмена\"");
                                string summast2 = Console.ReadLine();
                                summast = summast2;
                            }

                        } while ((!succes2)&&(summast!="отмена"));
                        if (summast == "отмена")
                        {
                            string rabota7 = Console.ReadLine();
                            rabota = rabota7;
                            break;
                        }
                        double summaint = 0;
                        do
                        {
                            summaint = Convert.ToDouble(summast);                      
                            if (summaint > ostatok)
                            {
                                Console.WriteLine("На вашем счете недостаточно средств, введите новую сумму или вернитесь к выполнению других операций(отмена)");
                                Console.WriteLine(summaint);
                                string summast3 = Console.ReadLine();
                                summast = summast3;
                            }
                        } while (summaint > ostatok);
                        string perevod;
                        do
                        {
                            Console.WriteLine($"Проверьте введенные данные. Перевод на карту {numberst}, сумма перевода {summaint} {val}. Для подтверждения введите (да), для изменения номера карты получателя (сменить получателя), для изменения суммы (сменить сумму перевода) и для отмены и возвращения к другим функциям (отмена) ");
                            perevod = Console.ReadLine();
                            switch (perevod)
                            {
                                case "да":
                                    ostatok -= summaint;
                                    Console.WriteLine($"ваш остаток на счете {ostatok} {val}.{name},Желаете ли продолжить работу, или завершить ее? ");
                                    string rabota8 = Console.ReadLine();
                                    rabota = rabota8;
                                    break;
                                case "сменить получателя":
                                    Console.WriteLine("Введите номер карты нового получателя:");
                                    string numberst2 = Console.ReadLine();
                                    numberst = numberst2;
                                    break;
                                case "сменить сумму перевода":
                                    Console.WriteLine("Введите новую сумму перевода:");
                                    string summast4 = Console.ReadLine();
                                    summast = summast4;
                                    summaint = Convert.ToDouble(summast);
                                    break;
                                case "отмена":
                                    Console.WriteLine($"{name},Желаете ли продолжить работу, или завершить ее?");
                                    string rabota9 = Console.ReadLine();
                                    rabota = rabota9;
                                    break;
                                default:
                                    do
                                    {
                                        Console.WriteLine("Введена некорректная комманда, повторите ввод ");
                                        string perevod2 = Console.ReadLine();
                                        perevod = perevod2;
                                    } while ((perevod != "отмена") && (perevod != "сменить сумму перевода") && (perevod != "сменить получателя") && (perevod != "да"));
                                    break;
                            }
                        } while ((perevod!="да")&&(perevod!="отмена"));                      
                        break;
                    case "внести":
                        Console.WriteLine("Укажите сумму, которую хотите внести на счет:");
                        string popolneniest;
                        double popolnenie;
                        bool succes3;
                        do
                        {
                            popolneniest = Console.ReadLine();
                            succes3 = double.TryParse(popolneniest, out popolnenie);
                            if (!succes3)
                            {
                                Console.WriteLine("Введено некорректное значение, попробуйте еще раз. Если вы хотите вернутся к выполнению других операций, введите \"отмена\"");
                            }
                        } while ((popolneniest!="отмена")&&(!succes3));
                        if (popolneniest == "отмена")
                        {
                            Console.WriteLine("Желаете ли продолжить работу, или завершить ее ? ");
                            string rabota12 = Console.ReadLine();
                            rabota = rabota12;
                        }
                        else
                        {
                            popolnenie = Convert.ToDouble(popolneniest);

                            ostatok += popolnenie;
                            Console.WriteLine($"Пополнение прошло успешно, остаток на счете {ostatok} {val}.Желаете ли продолжить работу, или завершить ее?");
                            rabota = Console.ReadLine();
                        }
                        break;
                    case "снять":
                        Console.WriteLine("Укажите сумму, которую хотите снять со счета:");
                        string snyatiest;
                        double snyatie;
                        bool succes4;
                        do
                        {
                            snyatiest = Console.ReadLine();
                            succes4 = double.TryParse(snyatiest, out snyatie);
                            if (!succes4)
                            {
                                Console.WriteLine("Введено некорректное значение, попробуйте еще раз. Если вы хотите вернутся к выполнению других операций, введите \"отмена\"");
                            }
                        } while ((snyatiest != "отмена") && (!succes4));
                        if (snyatiest == "отмена")
                        {
                            Console.WriteLine("Желаете ли продолжить работу, или завершить ее ? ");
                            string rabota13 = Console.ReadLine();
                            rabota = rabota13;
                        }
                        else
                        {
                            snyatie = Convert.ToDouble(snyatiest);
                            do
                            {
                                Console.WriteLine("У вас на счете недостаточно средств, введите корректное значение или вернитесь к другим операциям(отмена)");
                                string snyatiest1 = Console.ReadLine();
                                snyatiest = snyatiest1;
                                snyatie = Convert.ToDouble(snyatiest);
                            } while ((snyatie > ostatok) && (snyatiest != "отмена")) ;
                                if (snyatiest == "отмена")
                            {
                                Console.WriteLine("Желаете ли продолжить работу, или завершить ее ? ");
                                string rabota13 = Console.ReadLine();
                                rabota = rabota13;
                            }
                            else
                            {
                                ostatok -= snyatie;
                                Console.WriteLine($"Снятие прошло успешно, остаток на счете {ostatok} {val}.Желаете ли продолжить работу, или завершить ее?");
                                rabota = Console.ReadLine();
                            }
                        }
                        break;
                    case "конвертировать":
                        Console.WriteLine("Вы точно уверены что хотите сменить валюту счета?");
                        string ssd = Console.ReadLine();
                        while ((ssd!="да")&&(ssd!="нет"))
                        {
                            Console.WriteLine("Введено некорректное значение, попробуйте еще раз. Если вы хотите вернутся к выполнению других операций, введите \"отмена\"");
                            string konvst1 = Console.ReadLine();
                           ssd = konvst1;
                        }
                        if (ssd == "нет")
                        {
                            Console.WriteLine("Желаете ли продолжить работу, или завершить ее ? ");
                            string rabota16= Console.ReadLine();
                            rabota = rabota16;
                        }
                        
                        Console.WriteLine($"{name}, Выбирайте, в какую валюту вы будете переводить свои деньги, курс: 1 доллар = 2.2 Белорусских рубля или 0.88 евро. 1 евро = 2.5 Белорусских рубля или 1.14 доллара. 1 Белорусский рубль = 0.4 евро или 0.46 долларов");
                        rabota = "";
                        switch(val)
                            {
                            case "Белорусских рублей":
                                Console.WriteLine("Вы можете перевести свои деньги в доллары(доллар) или евро(евро):");
                                string konvst = Console.ReadLine();
                                while ((konvst != "доллар") && (konvst != "евро")&&(konvst!="отмена"))
                                {
                                    Console.WriteLine("Введено некорректное значение, попробуйте еще раз. Если вы хотите вернутся к выполнению других операций, введите \"отмена\"");
                                    string konvst1 = Console.ReadLine();
                                    konvst = konvst1;
                                }
                                if (konvst == "отмена")
                                {
                                    Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                    string rabota13 = Console.ReadLine();
                                    rabota = rabota13;
                                }
                                switch (konvst)
                                {
                                    case "доллар":
                                        val = "Долларов";
                                        double kurs=2.2;
                                        ostatok=ostatok/kurs;
                                        Console.WriteLine($"Теперь валюта вашего счета доллары, остаток на счете {ostatok} {val}.");
                                        Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                        string rabota14 = Console.ReadLine();
                                        rabota = rabota14;
                                        break;
                                    case"евро":
                                        val = "Евро";
                                        double kurs2 = 2.5;
                                        ostatok = ostatok / kurs2;
                                        Console.WriteLine($"Теперь валюта вашего счета евро, остаток на счете {ostatok} {val}.");
                                        Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                        string rabota15 = Console.ReadLine();
                                        rabota = rabota15;
                                        break;
                                }
                                break;
                            case "Долларов":
                                Console.WriteLine("Вы можете перевести свои деньги в Беларуские рубли(рубли) или евро(евро):");
                                konvst = Console.ReadLine();
                                while ((konvst != "рубли") && (konvst != "евро") && (konvst != "отмена"))
                                {
                                    Console.WriteLine("Введено некорректное значение, попробуйте еще раз. Если вы хотите вернутся к выполнению других операций, введите \"отмена\"");
                                    string konvst1 = Console.ReadLine();
                                    konvst = konvst1;
                                }
                                if (konvst == "отмена")
                                {
                                    Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                    string rabota13 = Console.ReadLine();
                                    rabota = rabota13;
                                }
                                switch (konvst)
                                {
                                    case "рубли":
                                        val = "Белорусских рублей";
                                        double kurs3 = 2.2;
                                        ostatok = ostatok * kurs3;
                                        Console.WriteLine($"Теперь валюта вашего счета Белорусские рубли, остаток на счете {ostatok} {val}.");
                                        Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                        string rabota14 = Console.ReadLine();
                                        rabota = rabota14;
                                        break;
                                    case "евро":
                                        val = "Евро";
                                        double kurs4 = 0.88;
                                        ostatok = ostatok * kurs4;
                                        Console.WriteLine($"Теперь валюта вашего счета евро, остаток на счете {ostatok} {val}.");
                                        Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                        string rabota15 = Console.ReadLine();
                                        rabota = rabota15;
                                        break;
                                }
                                break;
                            case "Eвро":
                                Console.WriteLine("Вы можете перевести свои деньги в доллары(доллар) или белорусские рубли(рубли):");
                               konvst = Console.ReadLine();
                                while ((konvst != "доллар") && (konvst != "рубли") && (konvst != "отмена"))
                                {
                                    Console.WriteLine("Введено некорректное значение, попробуйте еще раз. Если вы хотите вернутся к выполнению других операций, введите \"отмена\"");
                                    string konvst1 = Console.ReadLine();
                                    konvst = konvst1;
                                }
                                if (konvst == "отмена")
                                {
                                    Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                    string rabota13 = Console.ReadLine();
                                    rabota = rabota13;
                                }
                                switch (konvst)
                                {
                                    case "доллар":
                                        val = "Долларов";
                                        double kurs = 1.14;
                                        ostatok = ostatok * kurs;
                                        Console.WriteLine($"Теперь валюта вашего счета доллары, остаток на счете {ostatok} {val}.");
                                        Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                        string rabota14 = Console.ReadLine();
                                        rabota = rabota14;
                                        break;
                                    case "рубли":
                                        val = "Белоруских рублей";
                                        double kurs2 = 2.5;
                                        ostatok = ostatok * kurs2;
                                        Console.WriteLine($"Теперь валюта вашего счета Белорусские рубли, остаток на счете {ostatok} {val}.");
                                        Console.WriteLine("Желаете ли продолжить работу, или завершить ее ?");
                                        string rabota15 = Console.ReadLine();
                                        rabota = rabota15;
                                        break;
                                }
                                break;
                        }
                        break;
                    default:
                        if (rabota != "завершение работы")
                        {
                            Console.WriteLine("Введено некорректное значение, попробуйте еще раз");
                            string rabotaoshibki = Console.ReadLine();
                            rabota = rabotaoshibki;
                        }
                        
                            break;
                }
                }
           Console.WriteLine($"Работа терминала завершена, приятного дня {name}");
            Console.ReadLine();
        }
            
        }
    }


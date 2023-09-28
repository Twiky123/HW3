using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labatymakova_akalaba4
{
    internal class Program
    {
        enum Monthname
        {
            Янаврь,
            Феврь,
            Мрт,
            Апрль,
            Май,
            Июн,
            Июл,
            Агуст,
            Сентбрь,
            Октбрь,
            Нобрь,
            Декбрь
        }

        static void Main(string[] args)
        
        {
            Console.WriteLine("Упражнение 4.1/4.2");//Метод напролом(в тупую)
            try
            {
                Console.Write("Введите число от 1 до 365 (номер дня в году):");
                int day = int.Parse(Console.ReadLine());
                if ((day < 1) || (day > 365))
                {
                    throw new Exception("Вы ввели число меньше 1 или больше 365");
                }
                DateTime data  = new DateTime(2023, 1, 1).AddDays(day - 1);
                switch (data.Month)
                {
                    case 01:
                        Console.WriteLine($"{data.Day} Января");
                        break;
                    case 02:
                        Console.WriteLine($"{data.Day} Февраля");
                        break;
                    case 03:
                        Console.WriteLine($"{data.Day} Марта");
                        break;
                    case 04:
                        Console.WriteLine($"{data.Day} Апреля");
                        break;
                    case 05:
                        Console.WriteLine($"{data.Day} Мая");
                        break;
                    case 06:
                        Console.WriteLine($"{data.Day} Июня");
                        break;
                    case 07:
                        Console.WriteLine($"{data.Day} Июля");
                        break;
                    case 08:
                        Console.WriteLine($"{data.Day} Августа");
                        break;
                    case 09:
                        Console.WriteLine($"{data.Day} Сентября");
                        break;
                    case 10:
                        Console.WriteLine($"{data.Day} Октября");
                        break;
                    case 11:
                        Console.WriteLine($"{data.Day} Ноября");
                        break;
                    case 12:
                        Console.WriteLine($"{data.Day} Декабря");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число или число дробное");
            }
            catch (Exception dateException)
            {
                Console.WriteLine(dateException.Message);
            }
            Console.WriteLine("Домашняя задача 4.1"); //Метод не напролом(не в тупую)
            try
            {
                int day;
                Console.Write("Введите год:");
                int yaer = int.Parse(Console.ReadLine());
                bool leap = yaer > -46 && (yaer % 400 == 0 || //Проверка на високосный год
                yaer % 100 != 0 && yaer % 4 == 0) || yaer == -46;
                if (leap == true)
                {
                    Console.Write("Введите число от 1 до 366 (номер дня в году):");
                    day = int.Parse(Console.ReadLine());
                    if ((day < 1) || (day > 366))
                    {
                        throw new Exception("Вы ввели число меньше 1 или больше 366");
                    }
                    int[] months = new int[] { 31, leap ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    Monthname[] name = (Monthname[])Enum.GetValues(typeof(Monthname));

                    int i;
                    for (i = 0; day > months[i] && i < 12; i++) day -= months[i];
                    Console.WriteLine($"{day} {name[i]}");

                }
                else
                {
                    Console.Write("Введите число от 1 до 365 (номер дня в году):");
                    day = int.Parse(Console.ReadLine());
                    if ((day < 1) || (day > 365))
                    {
                        throw new Exception("Вы ввели число меньше 1 или больше 365");
                    }
                    int[] months = new int[] { 31, leap ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    Monthname[] name = (Monthname[])Enum.GetValues(typeof(Monthname));

                    int i;
                    for (i = 0; day > months[i] && i < 12; i++) day -= months[i];
                    Console.WriteLine($"{day} {name[i]}");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число или число дробное");
            }
            catch (Exception dateException)
            {
                Console.WriteLine(dateException.Message);
            }
            Console.ReadKey();
        }
    }
}

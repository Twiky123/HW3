using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Program
    {
        enum days_of_the_week 
        {
            Подпевельник,
            Вторни,
            Срида,
            Щитверг,
            Пьянтица,
            Суеббота,
            Воскрещение
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");

            int[] Sequence = new int[10];
            bool result = true;
            Random randNum = new Random();

            Console.Write("Получилась последовательность: ");

            for (int i = 0; i < Sequence.Length; i++)
            {
                Sequence[i] = randNum.Next(50);
                Console.Write(Sequence[i] + " ");
            }

            for (int i = 0; i < (Sequence.Length - 1); i++)
            {
                if (Sequence[i] > Sequence[i + 1])
                {
                    Console.WriteLine($"\nПоследовательность не является возрастающей. Число {Sequence[i + 1]} нарушающает последовательнось, число под номером {i + 2}");
                    result = false;
                    break;
                }
            }

            if (result)
            {
                Console.WriteLine("\nПоследовательнось является возрастающей");
            }


            Console.WriteLine("Задача 2");
            try
            {
                byte cardNum;

                Console.Write("Введите номер карты (число от 6 до 14): ");
                cardNum = byte.Parse(Console.ReadLine());

                switch (cardNum)
                {
                    case 6:
                        Console.WriteLine("Вы ввели 6 - это Шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Вы ввели 7 - это Семерка");
                        break;
                    case 8:
                        Console.WriteLine("Вы ввели 8 - это Восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("Вы ввели 9 - это Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Вы ввели 10 - это Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Вы ввели 11 - это Валет");
                        break;
                    case 12:
                        Console.WriteLine("Вы ввели 12 - это Дама");
                        break;
                    case 13:
                        Console.WriteLine("Вы ввели 13 - это Король");
                        break;
                    case 14:
                        Console.WriteLine("Вы ввели 14 - это Туз");
                        break;
                    default:
                        throw new Exception("Вы ввели число меньше 6 или больше 14");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число или число является дробным (Необходимо ввести целое число от 6 до 14)");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Вы ввели не число или число является дробным (Необходимо ввести целое число от 6 до 14)");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }


            Console.WriteLine("Задача 3");
            string String;
            Console.WriteLine("Подсказка: \n" +
                              "Jabroni - Patron Tequila\n" +
                              "School Counselor - Anything with Alcohol\n" +
                              "Programmer - Hipster Craft Beer\n" +
                              "Bike Gang Members - Moonshine\n" +
                              "Politician - Your tax dollars\n" +
                              "Rapper - Cristal\n");

            Console.Write("Введите сообщение: ");
            String = Console.ReadLine().ToLower();

            switch (String)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
            Console.WriteLine("Задача 4");

            try
            {
                byte day;

                Console.Write("Введите число дня недели: ");
                day = byte.Parse(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        days_of_the_week monday = days_of_the_week.Подпевельник;
                        Console.WriteLine($"Вы ввели {day} - это {monday}");
                        break;
                    case 2:
                        days_of_the_week tuesday = days_of_the_week.Вторни;
                        Console.WriteLine($"Вы ввели {day} - это {tuesday}");
                        break;
                    case 3:
                        days_of_the_week wednesday = days_of_the_week.Срида;
                        Console.WriteLine($"Вы ввели {day} - это {wednesday}");
                        break;
                    case 4:
                        days_of_the_week thursday = days_of_the_week.Щитверг;
                        Console.WriteLine($"Вы ввели {day} - это {thursday}");
                        break;
                    case 5:
                        days_of_the_week friday = days_of_the_week.Пьянтица;
                        Console.WriteLine($"Вы ввели {day} - это {friday}");
                        break;
                    case 6:
                        days_of_the_week saturday = days_of_the_week.Суеббота;
                        Console.WriteLine($"Вы ввели {day} - это {saturday}");
                        break;
                    case 7:
                        days_of_the_week sunday = days_of_the_week.Воскрещение;
                        Console.WriteLine($"Вы ввели {day} - это {sunday}");
                        break;
                    default:
                        Console.WriteLine("Вы ввели цифру меньше 1 или больше 7");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Необходимо ввести цифру дня от 1 до 7");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Вы ввели слишком большое или слишком маленькое число (Необходимо ввести цифру от 1 до 7)");
            }


            Console.WriteLine("Задача 5");

            string[] toys = { "Hello Kitty", "Barbie doll" };
            int count = 0;

            Console.Write("Строка: ");

            for (int i = 0; i < toys.Length; i++)
            {
                Console.Write(toys[i] + ", ");

                string toys1 = toys[i].ToLower();

                if ((toys1 == "hello kitty") || (toys1 == "barbie doll"))
                {
                    count++;
                }
            }

            Console.WriteLine($"В сумке лежит {count} кукол");
        }
    }
}

using System;

namespace домашнее_задание_2._6
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sanday
        }
        static void Main(string[] args)
            
        {
            while (true)
            {
                Console.WriteLine("Введите день недели");
                string str = Console.ReadLine();
                DayOfWeek DayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), str, ignoreCase: true);
                Console.WriteLine(DayOfWeek);
                switch (DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        Console.WriteLine("Не рабочий день № 1                        Рабочий день №2");
                        break;
                    case DayOfWeek.Tuesday:
                        Console.WriteLine("Рабочий день № 1                           Рабочий день №2");
                        break;
                    case DayOfWeek.Wednesday:  
                        Console.WriteLine("Рабочий день № 1                           Рабочий день №2");
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine("Рабочий день № 1                           Рабочий день №2");
                        break;
                    case DayOfWeek.Friday:
                        Console.WriteLine("Рабочий день № 1                           Рабочий день №2");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("Не рабочий день № 1                        Рабочий день №2");
                        break;
                    case DayOfWeek.Sanday:
                        Console.WriteLine("Не рабочий день № 1                     Не рабочий день №2");
                        break;
                    default:
                        Console.WriteLine("Неверно задан день");
                        break;
                }
            }
        }
    }
}

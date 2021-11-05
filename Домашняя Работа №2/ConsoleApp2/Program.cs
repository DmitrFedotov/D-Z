using System;

namespace ConsoleApp2
{
    class Program
    {
        enum Season
        {
            Winter = 1,     
            Spring,
            Summer,
            Autumn
            
        }
        enum Winter
        {
            December,
            January,
            February

        }
        enum Spring
        {
            March,
            April,
            May
        }
        enum Summer
        {
            June,
            July,
            August

        }
        enum Autumn
        {
            September,
            October,
            November

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите сезон (Winter, Spring, Summer, Autumn)");
                string str = Console.ReadLine();
                Season season = (Season)Enum.Parse(typeof(Season), str, ignoreCase: true);
                Console.WriteLine(season);
                switch (season)
                {
                    case Season.Winter:
                        Console.WriteLine("Вы запросили зимний сезон");
                        Console.WriteLine("Введите месяц December, January, February");
                        string q = Console.ReadLine();
                        Winter winter = (Winter)Enum.Parse(typeof(Winter), q, ignoreCase: true);
                        Console.WriteLine(winter);
                        double a;
                        double b;
                        double c;
                         Console.WriteLine("Введите минимальную t°C");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите максимальную t°C");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Средне суточная t°C в сутки {c = ((a + b) / 2)}");
                        if (c > 0)
                        {
                            Console.WriteLine("Дождливая погода");

                        }
                        break;
                    case Season.Spring:
                        Console.WriteLine("Вы запросили весенний сезон (March, April, May)");
                        Console.WriteLine("Введите месяц");
                        string w = Console.ReadLine();
                        Spring spring = (Spring)Enum.Parse(typeof(Spring), w, ignoreCase: true);
                        Console.WriteLine(spring);


                        break;
                    case Season.Summer:
                        Console.WriteLine("Вы запросили летний сезон (June, July, August)");
                        Console.WriteLine("Введите месяц");
                        string e = Console.ReadLine();
                        Summer summer = (Summer)Enum.Parse(typeof(Summer), e, ignoreCase: true);
                        Console.WriteLine(summer);
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Вы запросили осенний сезон (September, October, November)");
                        Console.WriteLine("Введите месяц");
                        string t = Console.ReadLine();
                        Autumn autumn = (Autumn)Enum.Parse(typeof(Autumn), t, ignoreCase: true);
                        Console.WriteLine(autumn);
                        break;
                    default:
                        Console.WriteLine("Неверно запрошен сезон");
                        break;


                }
                double one, two;

                Console.WriteLine("Введите минимальную t°C");
                one = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите максимальную t°C");
                two = double.Parse(Console.ReadLine());
                Console.WriteLine($"Средне суточная t°C в сутки {(one + two) / 2}");
























            }
        }
    }
}

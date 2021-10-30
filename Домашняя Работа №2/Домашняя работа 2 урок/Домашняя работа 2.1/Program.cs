using System;

namespace Домашняя_работа_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

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

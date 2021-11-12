using System;

namespace Домашнее_задание_2._2
{
    class Program
    {
        enum moth
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December



        }
        static void Main(string[] args)
        //Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        {
            bool isRun = true;
            while (isRun)
            {

                Console.WriteLine("Введите число, что-бы узнать месяц!");
                int a = int.Parse(Console.ReadLine());
                if (a > 0 && a < 13)
                {
                    Console.WriteLine($"Это месяц {(moth)a}");
                    a.ToString();

                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    Console.WriteLine("Хотите продолжить? Y/N");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer.ToUpper() == "N")
                    {
                        isRun = false;
                    }

                    Console.ReadKey();

                }
            

            }


        }
    }
}

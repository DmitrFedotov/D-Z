using System;

namespace Домашнее_задание_по_1_уроку
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя");
            String userName = Console.ReadLine();
            Console.WriteLine($"Привет {userName} {DateTime.Now}" ); // Тут добавленно настоящее время и дата когда вы просматриваете домашнее задание
        }
    }
}

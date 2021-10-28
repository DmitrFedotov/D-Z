// Напишите FizzBuzz программу - вам надо вывести на экран числа от 1 до 100,
// но когда число делится на три оно заменяется на fizz, если число делится на пять, то на buzz.
// Числа, делящиеся на три и пять одновременно заменяются на строку "fizz buzz".
// **найти способ вывести менее чем за 100 итераций цикла
using System;

namespace домашнее_задание_1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Число № {i} ");
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz & buzz)
                Console.WriteLine("FizzBuzz");
                else if (fizz)
                Console.WriteLine("Fizz");
                else if (buzz)
                Console.WriteLine("Buzz");
                



            }
        }
    }
}

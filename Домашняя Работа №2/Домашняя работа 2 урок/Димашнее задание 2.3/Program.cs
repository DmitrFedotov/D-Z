using System;

namespace Димашнее_задание_2._3
{
    class Program
    {
        static void Main(string[] args)
        //Определить, является ли введённое пользователем число чётным.
        {
            while (true)
            {


                int a;

                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    Console.WriteLine("число четное");
                }
                else
                {
                    Console.WriteLine("число нечетное");


                }
            }
        }
    }
}

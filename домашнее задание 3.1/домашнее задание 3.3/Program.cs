using System;

namespace домашнее_задание_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                string greeting = Console.ReadLine();
                for (int i = greeting.Length - 1; i >= 0; i--)
                {
                    Console.Write(greeting[i]);


                }
            }
           
        }
    }
} 

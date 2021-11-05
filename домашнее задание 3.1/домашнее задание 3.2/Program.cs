using System;

namespace домашнее_задание_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные пользователя");
            string[,] book = new string[,]
            {
              
              { "\n Ф.И.О пользователя: ", Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()},
              { "\n Номер или e-mail : ", Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()}
            
            };
            Console.WriteLine("Ваш справочник");
            for (int i = 0; i < book.GetLength(0); i++)
            {
               
                for (int q = 0; q < book.GetLength(1); q++)
                {
                    
                    Console.Write(book[i, q] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
           
        }
    }
}

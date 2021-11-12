using System;

namespace домашнее_задание_4
{
    class Program
    {
        static void GetFullName(string lastName, string firstName, string patronymic)
        {         
          GetFullName("Федотов", "Дмитрий", "Иванович");
          GetFullName("Воробьев", "Владимир", "Владимирович");
          GetFullName("Иванов", "Иван", "Иванович");
          GetFullName("Петров", "Александр", "Андреевич");               
           {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
           }
            
        }
    }
} 

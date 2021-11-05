using System;

namespace домашнее_задание_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[5,2];
            Random random = new Random();
            for (int q = 0; q < myArray.GetLength(0); q++)
            {
                for (int w = 0; w < myArray.GetLength(1); w++)
                {
                    myArray[q,w] = random.Next( 100, 150 );
                }
                Console.WriteLine();

            }



            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    Console.Write(myArray[x,y] + "\t");
                }
                Console.WriteLine();

            }



        }
    }
}

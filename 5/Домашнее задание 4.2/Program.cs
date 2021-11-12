using System;
using System.IO;

namespace Домашнее_задание_4._2
{
    class Program
    {
        static void Main(string[] args)
        {          
          string lines = DateTime.Now.ToLongTimeString();
            File.WriteAllText("startup.txt", lines);
        }
    }
}

using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Домашнее_Задание_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 255");
            var array = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("number.bin", FileMode.OpenOrCreate), array);
          
        }
    }
}

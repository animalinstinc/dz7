using System;
using System.IO;
namespace Exersice8_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите имя файла: ");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Такого файла нет");
                return;
            }

            string text = File.ReadAllText(fileName);
            string bigText = text.ToUpper();

            File.WriteAllText("output.txt", bigText);
            Console.WriteLine("результат в файле output.txt");
        }
    }
}

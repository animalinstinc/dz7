using System;
using System.IO;
namespace Homework8_1
{
    class Program
    {
        public void SearchMail(ref string s)
        {
            int index = s.IndexOf('#');
            if (index == -1)
            {
                s = "";
            }
            else
            {
                s = s.Substring(index + 1).Trim();
            }
        }
        static void Main()
        {
            Console.Write("Введите имя файла: ");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Такого файла нет");
                return;
            }
            string[] lines = File.ReadAllLines(fileName);
            StreamWriter sw = new StreamWriter("emails.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string s = lines[i];
                SearchMail(ref s);

                if (s != "")
                {
                    sw.WriteLine(s);
                }
            }
            sw.Close();
            Console.WriteLine("Адреса в emails.txt");
        }
    }
}
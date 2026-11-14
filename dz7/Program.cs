using System;

namespace Exercise8_2
{
    class Program
    {
        static string Reverse(string text)
        {
            string result = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }

            return result;
        }

        static void Main()
        {
            Console.WriteLine(Reverse("Привет"));
            Console.WriteLine(Reverse("Hello, World!"));
            Console.WriteLine(Reverse("12345"));
            Console.WriteLine(Reverse("а роза упала на лапу азора"));
        }
    }
}
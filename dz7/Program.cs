using System;
namespace Exercise8_4
{
    class Program
    {
        static void CheckFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                Console.WriteLine("is: реализует");
            }
            else
            {
                Console.WriteLine("is: не реализует");
            }
            IFormattable f = obj as IFormattable;
            if (f != null)
            {
                Console.WriteLine("as: реализует, значение " + f.ToString(null, null));
            }
            else
            {
                Console.WriteLine("as: не реализует");
            }
        }
        static void Main()
        {
            Console.WriteLine("int:");
            CheckFormattable(42);
            Console.WriteLine("double:");
            CheckFormattable(3.14);
            Console.WriteLine("DateTime:");
            CheckFormattable(DateTime.Now);
            Console.WriteLine("string:");
            CheckFormattable("привет");
        }
    }
}
using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Kata
    {
        public static bool Solution(string str, string ending)
        {
            // TODO: complete
            return str.EndsWith(ending);
        }
    }
}

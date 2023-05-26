using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time < 18 && time > 6)
            {
                System.Console.WriteLine("Greeting");
            }
            else
            {
                System.Console.WriteLine("goof evening");
            }

            bool condition = true;

            if (condition)
            {
                Console.WriteLine("Değişken: true");
            }
            else
            {
                Console.WriteLine("Değişken: false");
            }
        }
    }
}
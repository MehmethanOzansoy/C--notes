using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();
            System.Console.WriteLine("There are T lines of output");
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int p = int.Parse(Console.ReadLine());

                calculator.power(n, p);
            }
        }
    }


    class Calculator
    {
        public int power(int n, int p)
        {

            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative.");
            }

            return (int)Math.Pow(n, p);
        }
    }

    class Solution
    {
        static void Main(String[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }



        }
    }
}
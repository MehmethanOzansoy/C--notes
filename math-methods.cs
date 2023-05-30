using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Globalization;

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


    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            
            var dt = DateTime.ParseExact(s,"hh:mm:ssttt",CultureInfo.InvariantCulture);

            return $"{dt:HH:mm:ss}";
        }

    }

    class Solution2
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
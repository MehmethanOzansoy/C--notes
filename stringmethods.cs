using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string deg = "Dersimiz CSharp,Hoşgeldiniz: ";
            string deg2 = "CSharp";

            // // length
            // System.Console.WriteLine(deg.Length);

            // // Toupper tolower

            // System.Console.WriteLine(deg.ToLower());
            // System.Console.WriteLine(deg.ToUpper());

            // // Concat
            // System.Console.WriteLine(String.Concat(deg, "Merhaba"));

            // // Compare,Compare to

            // System.Console.WriteLine(deg.CompareTo(deg2)); // 0 1 -1
            // System.Console.WriteLine(deg2.CompareTo(deg));

            // System.Console.WriteLine(String.Compare(deg, deg2, true));
            // System.Console.WriteLine(String.Compare(deg, deg2, false));

            // contains

            // System.Console.WriteLine(deg.Contains(deg2));
            // System.Console.WriteLine(deg.EndsWith("Hoşgeldiniz: "));
            // System.Console.WriteLine(deg.StartsWith("Merhaba !"));


            // string S = Console.ReadLine();

            // try
            // {
            //     int a = int.Parse(S);
            //     System.Console.WriteLine(a);
            // }
            // catch (System.Exception)
            // {

            //     System.Console.WriteLine("Bad String");
            // }




            // while (0 < n)
            // {
            //     System.Console.WriteLine("Please enter a word: ");
            //     string s = Console.ReadLine();

            //     List<char> list1 = new List<char>();
            //     List<char> list2 = new List<char>();

            //     Char[] arr = s.ToArray();

            //     for (int i = 0; i < arr.Length; i++)
            //     {
            //         if (arr[i] % 2 == 0)
            //         {
            //             System.Console.Write(arr[i]);
            //         }
            //         else
            //         {
            //             System.Console.Write(arr[i]);

            //         }
            //         System.Console.Write(" ");

            //     }

            // foreach (var item in list1)
            // {
            //     System.Console.Write(list1);
            // }

            // System.Console.Write(" ");

            // foreach (var item in list2)
            // {
            //     System.Console.WriteLine(list2);
            // }
            //     n--;
            // }



            System.Console.WriteLine("Please enter aöount of the word");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                letReview(s);
            }

        }


        static void letReview(string s)
        {
            string evenStr = "";
            string oddStr = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenStr += s[i];
                }
                else
                {
                    oddStr += s[i];
                }
            }

            System.Console.WriteLine($"{evenStr} {oddStr}");
        }
    }
}
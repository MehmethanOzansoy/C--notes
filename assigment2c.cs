using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> liste = new List<char>();
            System.Console.WriteLine("Lütfen cümlenizi giriniz. ");
            string a = Console.ReadLine();
            string sesli = "aeıioöuü";
            int count = 0;


            for (int i = 0; i < a.Length; i++)
            {
                if (sesli.Contains(a[i]))
                {
                    liste.Add(a[i]);
                    count++;
                }
            }
            System.Console.WriteLine("Sesli harf sayısı: " + count);

            liste.Sort();

            System.Console.WriteLine("Sesli harf sıralı ");
            foreach (var item in liste)
            {
                System.Console.Write($"{item},");
            }
        }

    }
}
using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('a');

            // verilere erişimi

            // System.Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();
            // Addrange
            System.Console.WriteLine("****** Add Range *******");
            // string[] renkler = { "Mavi", "Yeşil", "Kırmızı" };
            List<int> sayılar = new List<int>() { 1, 11, 78, 9, 333, 77 };
            // liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            // sort

            System.Console.WriteLine("------ Sort -------");
            liste.Sort();

            foreach (var item in liste)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            // Binary Search
            System.Console.WriteLine("****** Binary Search *******");
            var a = liste.BinarySearch(111);
            System.Console.WriteLine("Binary Search: " + a);


            // Reverse 

            System.Console.WriteLine("-------- Reverse ----------");
            liste.Reverse();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            // Clear

            System.Console.WriteLine("---------- Clear -----------");
            liste.Clear();
            foreach (var item in liste)
            {
                if (item != null)
                {
                    System.Console.WriteLine(item);

                }
                else
                {
                    System.Console.WriteLine("Liste boş");

                }
            }
        }
    }
}
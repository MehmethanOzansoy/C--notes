using System;
using System.Collections;
using System.Linq;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            // 1
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            int input;
            System.Console.WriteLine("Please enter the 20 numbers");
            Console.WriteLine("Bir sayı girin:");

            for (int i = 0; i < 20; i++)
            {
                int kullaniciGirisi = int.Parse(Console.ReadLine());

                if (kullaniciGirisi > 0)
                {
                    if (asalSayi(kullaniciGirisi))
                    {
                        asalSayilar.Add(kullaniciGirisi);
                    }
                    else
                    {
                        asalOlmayanlar.Add(kullaniciGirisi);
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş!");
                }
            }

            Console.WriteLine("Asal Sayılar:");
            foreach (int sayi in asalSayilar)
            {
                Console.Write($"{sayi},");
            }
            System.Console.WriteLine();

            Console.WriteLine("Asal Olmayan Sayılar:");
            foreach (int sayi in asalOlmayanlar)
            {
                Console.Write($"{sayi},");
            }


            ToSort(asalSayilar, asalOlmayanlar);
            GetMemnbers(asalSayilar, asalOlmayanlar);
            ListMean(asalSayilar, asalOlmayanlar);



        }

        public static bool asalSayi(int sayi)
        {
            if (sayi < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }

            return true;

        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public static void ToSort(ArrayList a, ArrayList b)
        {
            a.Sort();
            System.Console.WriteLine();
            System.Console.WriteLine("Sorting a first array");
            foreach (var item in a)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine();
            b.Sort();
            System.Console.WriteLine("Sorting a second array");

            foreach (var item in b)
            {

                System.Console.Write($"{item} ");
            }
        }

        public static void GetMemnbers(ArrayList a, ArrayList b)
        {

            int m1 = a.Count;
            int m2 = b.Count;
            System.Console.WriteLine();
            System.Console.WriteLine("1. arrayin boyutu: " + m1);
            System.Console.WriteLine("2. arrayin boyutu: " + m2);

        }

        public static void ListMean(ArrayList a, ArrayList b)
        {
            double total1 = 0;
            double total2 = 0;
            int m1 = a.Count;
            int m2 = b.Count;
            double mean1 = 0;
            double mean2 = 0;


            foreach (var item in a)
            {
                total1 = total1 + (int)item;
            }

            foreach (var item in b)
            {
                total2 = total2 + (int)item;
            }

            mean1 = total1 / m1;
            mean2 = total2 / m2;

            System.Console.WriteLine("1.dizinin ortalaması: " + mean1);
            System.Console.WriteLine("2.dizinin ortalaması: " + mean2);
        }
    }
}
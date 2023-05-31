using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Plese enter 20 numbers");
            List<int> liste = new List<int>();
            ArrayList max = new ArrayList();
            ArrayList min = new ArrayList();
            int n = 0;
            while (n < 10)
            {
                int m = int.Parse(Console.ReadLine());
                liste.Add(m);
                n++;
            }

            System.Console.WriteLine("------------- Sonuclar -------------");

            getMax(liste, max);
            System.Console.WriteLine();
            getMin(liste, min);
            System.Console.WriteLine();
            System.Console.WriteLine("Min grubun ortalaması: " + MinMean(min));
            System.Console.WriteLine("Max grubun ortalaması: " + MaxMean(max));

            int a = (int)MinMean(min);
            int b = (int)MaxMean(max);

            double res = a + b;

            System.Console.WriteLine("Ortalamaların toplamı: " + res);



        }


        public static void getMax(List<int> a, ArrayList max)
        {
            a.Sort();

            for (int i = a.Count - 3; i < a.Count; i++)
            {
                max.Add(a[i]);
            }
            System.Console.WriteLine("En büyük 3 sayi");
            foreach (var item in max)
            {
                System.Console.Write($"{item},");

            }
        }

        public static void getMin(List<int> b, ArrayList min)
        {
            b.Sort();

            for (int i = 0; i < 3; i++)
            {
                min.Add(b[i]);
            }
            System.Console.WriteLine("En küçük 3 sayi");
            foreach (var item in min)
            {
                System.Console.Write($"{item},");

            }
        }

        public static double MinMean(ArrayList min)
        {
            double sum = 0;

            foreach (var item in min)
            {
                sum = sum + (int)item;
            }


            return sum / min.Count;
        }

        public static double MaxMean(ArrayList max)
        {
            double sum = 0;

            foreach (var item in max)
            {
                sum = sum + (int)item;
            }
            return sum / max.Count;
        }

    }
}
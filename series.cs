using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] renkler = new string[5];

            string[] hayvanlar = { "kedi", "köpek", "kuş", "Maymun" };

            int[] dizi;

            dizi = new int[5];

            // dizilere değer atama ve Erişim

            renkler[0] = "Mavi";

            dizi[3] = 10;


            System.Console.WriteLine(hayvanlar[0]);
            System.Console.WriteLine(renkler[0]);
            System.Console.WriteLine(dizi[3]);

            // Klavyeden girilen n sayının ortalamsını alan program

            int n;
            int sum = 0;
            double mean = 1;

            System.Console.WriteLine("Kaç tane sayı girmek istersiniz");
            n = int.Parse(Console.ReadLine());
            int[] sayilar = new int[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("{0}. index: ", i);
                sayilar[i] = int.Parse(Console.ReadLine());

            }

            foreach (var item in sayilar)
            {
                sum = item + sum;
            }

            mean = sum / n;
            System.Console.WriteLine("Sayıların ortalaması: "+mean);

        }
    }
}
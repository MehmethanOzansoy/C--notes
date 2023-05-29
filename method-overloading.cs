using System;

namespace overloading // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Topla topla = new Topla();
            topla.toplam(10, 20, out int Yazdır);

            System.Console.WriteLine(Yazdır);
            int ifade = 999;

            topla.ekranaYazdır(Convert.ToString(ifade));
            topla.ekranaYazdır(ifade);

            // method imzası 
            // method adı + parametre sayısı + parametre

            topla.ekranaYazdır("zikriye","yılmaz");

        }


    }


    class Topla
    {
        public void toplam(int a, int b, out int sonuc)
        {
            sonuc = a + b;
        }


        public void ekranaYazdır(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public void ekranaYazdır(int veri)
        {
            System.Console.WriteLine(veri);
        }

        public void ekranaYazdır(string veri1 ,string veri2)
        {
            System.Console.WriteLine(veri1 + veri2);
        }
    }
}
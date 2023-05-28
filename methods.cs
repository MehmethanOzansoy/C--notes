using System;

namespace Methods // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 15;


            int sonuc = sums(a, b);

            System.Console.WriteLine(sonuc);

            Methods methods = new Methods();

            methods.ArttırVeTopla(ref a, ref b);

            methods.EkranaYadır(Convert.ToString(sonuc));


        }

        static int sums(int a, int b)
        {
            return a + b;
        }

    }


    class Methods
    {
        public void EkranaYadır(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
    }
}
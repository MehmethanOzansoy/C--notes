using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;

            if (sıcaklık <= (int)HavaDurumu.normal)
            {
                System.Console.WriteLine("Dışarıya çıkılması önerilmiyor havanın biraz ısımansını bekle ");
            }
            else if (sıcaklık >= (int)HavaDurumu.sıcak && sıcaklık < (int)HavaDurumu.cokSıcak)
            {
                System.Console.WriteLine("Hava durumu normal");
            }
            else if (sıcaklık >= (int)HavaDurumu.cokSıcak)
            {
                 System.Console.WriteLine("Dışarı çıkmayınız");
            }
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        soguk = 5,
        normal = 20,
        sıcak = 25,
        cokSıcak = 30
    }
}

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int sayac = 0;
            Console.Write("Sayıyı Girin : ");
            int s = Convert.ToInt32(Console.ReadLine());

            if (asalmi(s))
            {
                Console.WriteLine("{0} sayısı Asal", s);
            }
            else
            {
                Console.WriteLine("{0} sayısı asal değil", s);
            }

            Console.WriteLine("===========================");
            Console.WriteLine("Sonraki 5 Asal Sayı");
            Console.WriteLine("===========================");

            while (true)
            {
                s++;
                if (asalmi(s) == true)
                {
                    Console.WriteLine("{0} sayısı asal", s);
                    sayac++;
                    if (sayac == 5)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();



        }

        public static bool asalmi(int sayi)
        {
            bool durum = false;

            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) //www.yazilimkodlama.com
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {//www.yazilimkodlama.com
                durum = true;
            }

            return durum;

        }

    }
}

// System.Console.WriteLine("Sayi giriniz");
// int sayi = Convert.ToInt32(Console.ReadLine());

// int digit1 = (int) sayi/100;

// int count = sayi/10;
// count = count%10;
// int digit2 = (int) count;

// int digit3 = sayi % 10;

// System.Console.WriteLine("Birler Basamağı: "+digit3);
// System.Console.WriteLine("Onlar Basamağı: "+digit2);
// System.Console.WriteLine("Yüzler Basamağı: "+digit1);
// count = number - 1;
// var n = number;

// for (i = 1; i < count; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write(" ");
//     }

//     for (k = 1; k < 2 * n - 1; k++)
//     {
//         Console.Write("*");
//     }
//     n = n-1;
//     Console.WriteLine();
// }

// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= number; i++)
// {

//     for (int j = 0; j < i; j++)
//     {
//         System.Console.Write("*");
//     }

//     System.Console.Write(" ");

//     for (int k = 0; k < i; k++)
//     {
//         System.Console.Write("*");
//     }
//     System.Console.WriteLine();
// }


// int n = 7;

// for (int i = 0; i < 7; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {

//         if (i == 0 || i == n - 1)
//         {
//             System.Console.Write("*");

//         }
//         else
//         {
//             if (j == 0 || j == 6)

//                 System.Console.Write("*");
//             else
//             {
//                 System.Console.Write(" ");
//             }
//         }


//     }


//     System.Console.WriteLine();



// }
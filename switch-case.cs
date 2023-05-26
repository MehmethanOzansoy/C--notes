using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // int getMonth = DateTime.Now.Month;

            // switch (getMonth)
            // {
            //     case 1:
            //         System.Console.WriteLine("Ocak");
            //         break;
            //     case 2:
            //         System.Console.WriteLine("Şubat");
            //         break;
            //     case 3:
            //         System.Console.WriteLine("Mart");
            //         break;
            //     case 4:
            //         System.Console.WriteLine("Nisan");
            //         break;
            //     case 5:
            //         System.Console.WriteLine("Mayıs");
            //         break;
            //     case 6:
            //         System.Console.WriteLine("Haziran");
            //         break;
            //     case 7:
            //         System.Console.WriteLine("Temmuz");
            //         break;
            //     case 8:
            //         System.Console.WriteLine("Ağustos");
            //         break;
            //     case 9:
            //         System.Console.WriteLine("Eylül");
            //         break;
            //     case 10:
            //         System.Console.WriteLine("Ekim");
            //         break;
            //     case 11:
            //         System.Console.WriteLine("Kasım");
            //         break;
            //     case 12:
            //         System.Console.WriteLine("Aralık");
            //         break;
            // }

            // List<int> mylist = new List<int>();
            // mylist.Add(1);
            // mylist.Add(2);
            // mylist.Add(3);

            var day = 15;

            switch (day)
            {
                case 1:
                    System.Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    System.Console.WriteLine("Salı");
                    break;
                case 3:
                    System.Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    System.Console.WriteLine("Perşembe");
                    break;
                case 5:
                    System.Console.WriteLine("Cuma");
                    break;
                case 6:
                    System.Console.WriteLine("Cumartesi");
                    break;

                case 7:
                    System.Console.WriteLine("Pazar");
                    break;

                default:
                    System.Console.WriteLine("Hatalı");
                    break;
            }

        }
    }
}
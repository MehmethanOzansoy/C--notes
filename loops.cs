using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var list = new List<int>();
            // System.Console.WriteLine("Please enter the numbers");
            // int a = Convert.ToInt32(Console.ReadLine());
            // int sum = 0;

            // for (int i = 0; i < a; i++)
            // {
            //     if (i % 2 == 1)
            //     {

            //         list.Add(i);
            //         sum += i;

            //     }

            // }
            // foreach (var item in list)
            // {
            //     System.Console.WriteLine(item);
            // }

            // System.Console.WriteLine("sum of odd numbers: " + sum);


            // int tek = 0;
            // int cift = 0;

            // for (int i = 0; i <= 1000; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         tek += i;
            //     }
            //     else if (i % 2 == 1)
            //     {
            //         cift += i;
            //     }
            // }
            // System.Console.WriteLine("tek sayi toplam: " + tek);
            // System.Console.WriteLine("Çift sayi toplam :" + cift);

            //break
            // var sum = 0;
            // for (int i = 0; i < 25; i++)
            // {
            //     if (i == 22)
            //         break;
            //     else {
            //         sum += i;
            //     }
            // }
            // System.Console.WriteLine(sum);

            for (int i = 0; i < 44; i++)
            {
                if ( i % 2 == 0)
                    continue;
                else 
                    System.Console.WriteLine(i);

            }
            
            for(;;)
            {
                
            }
        }


    }
}
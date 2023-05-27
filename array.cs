using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 12, 5, 8, 9, 489, 88, 75, 5, 33 };
            // System.Console.WriteLine("****** Sırasız Dizi ********");

            // foreach (var item in sayiDizisi)
            // {
            //     System.Console.Write(" ");
            //     System.Console.Write(item);
            // }

            // System.Console.WriteLine();

            // System.Console.WriteLine("****** Sort Sıralı Dizi ********");

            // Array.Sort(sayiDizisi);

            // foreach (var item in sayiDizisi)
            // {
            //     System.Console.Write(" ");
            //     System.Console.Write(item);

            // }

            // System.Console.WriteLine();

            // System.Console.WriteLine("********* Array Clear **************");

            // // sayi dizisi elemanlarını kullanarak sıfırlama yapar
            // Array.Clear(sayiDizisi, 2, 2);
            // foreach (var item in sayiDizisi)
            // {
            //     System.Console.Write(" ");
            //     System.Console.Write(item);

            // }

            // System.Console.WriteLine();

            // System.Console.WriteLine("********* Array Reverse **************");

            // Array.Reverse(sayiDizisi);
            // foreach (var item in sayiDizisi)
            // {
            //     System.Console.Write(" ");
            //     System.Console.Write(item);

            // }

            // int size = 0;

            // foreach (var item in sayiDizisi)
            // {
            //     size++;

            // }

            // int x;
            // int tenp;
            // for (int i = 0; i <= size+1; i++)
            // {
            //     if (i <= size)
            //     {
            //         if (sayiDizisi[i] > sayiDizisi[i + 1])
            //         {
            //             tenp = sayiDizisi[i + 1];
            //             sayiDizisi[i + 1] = sayiDizisi[i];
            //             sayiDizisi[i] = tenp;
            //         }

            //     }
            //     else {
            //         break;
            //     }

            // }

            // foreach (var item in sayiDizisi)
            // {
            //     System.Console.Write(" ");
            //     System.Console.Write(item);

            // }

            // int[] arr = new int[55];
            // int i, j, n, x, y, temp;

            // System.Console.WriteLine("Enter the size of Array: ");
            // n = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the Array elements : ");

            // for (i = 0; i < n; i++)
            // {
            //     arr[i] = int.Parse((Console.ReadLine()));
            // }

            // for (i = 0; i < (n - 1); i++)
            // {
            //     y = arr[i];
            //     x = i;

            //     for (j = i + 1; j < n; j++)
            //     {
            //         if (y > arr[j])
            //         {
            //             y = arr[j];
            //             x = j;
            //         }

            //     }

            //     temp = arr[i];
            //     arr[i] = arr[x];
            //     arr[x] = temp;
            // }
            // System.Console.WriteLine("After selection sort :");
            // foreach (var item in arr)
            // {
            //     System.Console.Write(" ");
            //     System.Console.Write(item);

            // }

            // System.Console.WriteLine();
            // System.Console.WriteLine("**** Array IndexOf *****");
            // System.Console.WriteLine(Array.IndexOf(sayiDizisi, 5));


            // System.Console.WriteLine();
            // System.Console.WriteLine("**** Array Resize *****");

            // Array.Resize<int>(ref sayiDizisi,14);


            // sayiDizisi[9] = 99;

            // foreach (var item in sayiDizisi)
            // {
            //     System.Console.WriteLine(item);
            // }

            int[] candles = { 3,2,1,3 };

            Array.Sort(candles);

            int[] x = candles;

            int counter = 0;

            for (int i = 0; i < 4; i++)
            {

                if (x[3] > x[2])
                {
                    counter = 1;
                }
                else if (x[2] > x[1])
                {

                    counter = 2;

                }
                else if (x[1] > x[0])
                {

                    counter = 3;

                }
                else
                {

                    counter = 4;
                }
            }

            if (counter == 1)
            {
                System.Console.WriteLine(1);
            }
            else if (counter == 2)
            {
                System.Console.WriteLine(2);

            }
            else if (counter == 3)
            {
                System.Console.WriteLine(3);

            }
            else if (counter == 4)
            {
                System.Console.WriteLine(4);

            }


        }
    }
}
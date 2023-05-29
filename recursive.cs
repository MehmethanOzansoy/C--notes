using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Recursive(yinemeli) function");


            int multiple = 1;
            // 3^4 3*3*3*3
            for (int i = 1; i < 5; i++)
            {

                multiple = multiple * 3;

            }

            System.Console.WriteLine(multiple);

            Islemler instance = new();
            System.Console.WriteLine(instance.Expo(3, 4));


            // Extensiom metotlar

            string ifade = "Zikriye Ürkmez Cengiz";

            bool sonuc = ifade.CheckSpaces();

            System.Console.WriteLine(ifade.CheckSpaces());

            if (sonuc)
            {
                System.Console.WriteLine(ifade.RemoveWhiteSpaces());
                System.Console.WriteLine(ifade.MakeUpperCase());
                System.Console.WriteLine(ifade.MakeLowerCase());

            }

            int[] dizi = { 5, 6, 8, 7, 93, 55, 63 };
            dizi.SortArray();
            dizi.EkranaYazdır();

        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {

            if (üs < 2)
            {
                return sayi;
            }
            else
            {
                return Expo(sayi, üs - 1) * sayi;

            }
        }
    }


    public static class Extensiom
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            int n = param.Count();
            int temp;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-1; j++)
                {   
                    if (param[j]<param[j+1])
                    {
                        temp = param[j+1];
                        param[j+1] = param[j];
                        param[j] = temp;
                    }
                }
            }
            return param;
        }

        public static void EkranaYazdır(this int[] param)
        {
            foreach (var item in param)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
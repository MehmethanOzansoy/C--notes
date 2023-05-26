using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // try
            // {
            //     // hata olması muhtememl yer
            //     Console.WriteLine("Bir sayi giriniz: ");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            // }
            // catch (Exception ex)
            // {
            //     // hata mesajını gönderir hatayı yakalar

            //     System.Console.WriteLine("Hata mesajı: " + ex.Message.ToString());
            // }
            // // finally
            // // {
            // //     // opsiyonel her koşulda çalışma sağlar

            // //     Console.Write("İşlem tamamlandı");
            // // }

            // try
            // {
            //     int a = int.Parse(null);
                
            // }
            // catch (ArgumentNullException ex)
            // {
                
            //   System.Console.WriteLine("boş değer girdiniz !!!");
            //   System.Console.WriteLine(ex);
            // }

            
            try
            {

                int a = int.Parse("11");
                
            }
            // catch (ArgumentNullException ex)
            // {
                
            //   System.Console.WriteLine("boş değer girdiniz !!!");
            //   System.Console.WriteLine(ex);
            // }
            catch (FormatException ex) {
                System.Console.WriteLine("Veri tipi uygun değil");
                System.Console.WriteLine(ex);
            }
        }
    }
}


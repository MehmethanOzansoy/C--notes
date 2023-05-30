using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(22);
            sayiListesi.Add(34);
            sayiListesi.Add(44);
            sayiListesi.Add(54);


            List<string> renklistesi = new List<string>();
            renklistesi.Add("Mavi");
            renklistesi.Add("Sari");
            renklistesi.Add("Yeşil");


            //Count

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renklistesi.Count);

            foreach (var item in renklistesi)
            {
                System.Console.WriteLine(sayiListesi);
            }

            foreach (var item in renklistesi)
            {
                System.Console.WriteLine(renklistesi);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renklistesi.ForEach(renk => Console.WriteLine(renk));


            sayiListesi.Remove(4);

            renklistesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renklistesi.RemoveAt(0);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            renklistesi.ForEach(renk => Console.WriteLine(renk));

            if (sayiListesi.Contains(10))
            {
                System.Console.WriteLine("Bulundu");
            }
            else
            {
                System.Console.WriteLine("Bulunamadı");
            }

            // eleman ile index'e erişme

            System.Console.WriteLine(renklistesi.BinarySearch("Sari"));

            // Diziyi List'e çevirme

            string[] hayvanlar = { "kedi", "köpek", "kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            // temizleme

            hayvanListesi.Clear();

            List<Kullanıcılar> kullanıcılars = new List<Kullanıcılar>();


            Kullanıcılar kullanıcılar1 = new Kullanıcılar();

            kullanıcılar1.Isim = "Ayşe";
            kullanıcılar1.Soyisim = "Yılmaz";
            kullanıcılar1.Yas = 40;

            Kullanıcılar kullanıcılar2 = new Kullanıcılar();

            kullanıcılar2.Isim = "Cem";
            kullanıcılar2.Soyisim = "Karaca";
            kullanıcılar2.Yas = 45;

            kullanıcılars.Add(kullanıcılar1);
            kullanıcılars.Add(kullanıcılar2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });


            foreach (Kullanıcılar item in kullanıcılars)
            {
                System.Console.WriteLine("Kullanıcı adı: " + item.Isim);
                System.Console.WriteLine("Kullanıcı Soyisim: " + item.Soyisim);
                System.Console.WriteLine("Kullanıcı yaş: " + item.Yas);

            }

            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);

        }


        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
              System.Console.WriteLine(item);  
            }
        }

    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
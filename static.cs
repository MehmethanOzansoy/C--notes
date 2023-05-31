using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Calışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayse", "Yılmaz", "İK");

            System.Console.WriteLine("Calışan sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz", "Can", "İK");
            Calisan calisan2 = new Calisan("Arda", "Mert", "İK");
            Calisan calisan3 = new Calisan("Gül", "Korkmaz", "İK");
            System.Console.WriteLine("Calışan sayısı: {0}", Calisan.CalisanSayisi);


        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Departmant { get => departmant; set => departmant = value; }

        private string isim;
        private string soyisim;
        private string departmant;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departmant)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departmant = departmant;
            calisanSayisi++;
        }
    }
}
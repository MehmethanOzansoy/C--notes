using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Ylmaz";
            ogrenci.OgrenciNo = 515;
            ogrenci.Sinif = 4;
            ogrenci.SinifAtlat();
            ogrenci.SinifAtlat();
            // ogrenci.SinifAtlat();
            // ogrenci.SinifAtlat();
            // ogrenci.SinifAtlat();
            // ogrenci.SinifAtlat();
            // ogrenci.SinifAtlat();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();

            ogrenci.OgrenciBilgileriniGetir();



        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value <= 1)
                {
                    System.Console.WriteLine("Sınıf sayısı en az 1 olabilir");
                    sinif = 1;
                }
                else if (value >= 8)
                {
                    System.Console.WriteLine("Sınıf sayısı en fazla 8 olabilir");
                    sinif = 8;
                }
                else
                    sinif = value;
                
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {

        }



        // public override bool Equals(object? obj)
        // {
        //     return obj is Ogrenci ogrenci &&
        //            soyisim == ogrenci.soyisim;
        // }

        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("******************** Öğrenci Bilgileri **********************");
            System.Console.WriteLine("Öğrenci adi         :{0}", this.isim);
            System.Console.WriteLine("Öğrenci Soyismi     :{0}", this.soyisim);
            System.Console.WriteLine("Öğrenci numarası    :{0}", this.OgrenciNo);
            System.Console.WriteLine("Öğrenci sınıfı      :{0}", this.Sinif);
            System.Console.WriteLine("*************************************************************");
        }

        public void SinifAtlat()
        {
            this.sinif = this.sinif + 1;
        }

        public void SinifDusur()
        {
            this.sinif = this.sinif - 1;
        }
    }
}
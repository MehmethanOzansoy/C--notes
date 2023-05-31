using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.kısakenar = 5;
            dikdörtgen.uzunkenar = 8;

            System.Console.WriteLine("Class alan hesabı: " + dikdörtgen.AlanHesapla());

            Dikdortgen_struct dikdortgen_Struct = new Dikdortgen_struct();
            dikdortgen_Struct.kısakenar = 5;
            dikdortgen_Struct.uzunkenar = 8;
            System.Console.WriteLine("Struct alan hesabı: " + dikdortgen_Struct.AlanHesapla());


            Dikdortgen_struct dikdortgen_Struct1;
            dikdortgen_Struct1.kısakenar = 15;
            dikdortgen_Struct1.uzunkenar = 82;
            System.Console.WriteLine("Struct alan hesabı: " + dikdortgen_Struct1.AlanHesapla());

            Dikdortgen_struct dikdortgen_Struct2;
            dikdortgen_Struct2.kısakenar = 1;
            dikdortgen_Struct2.uzunkenar = 9;
            System.Console.WriteLine("Struct alan hesabı: " + dikdortgen_Struct2.AlanHesapla());

        }
    }

    class Dikdörtgen
    {
        public int kısakenar;
        public int uzunkenar;


        public Dikdörtgen()
        {
            kısakenar = 1;
            uzunkenar = 3;
        }
        public long AlanHesapla()
        {
            return this.kısakenar * this.uzunkenar;
        }
    }

    struct Dikdortgen_struct
    {
        public int kısakenar;
        public int uzunkenar;

        public Dikdortgen_struct(int kısakenar = 3, int uzunkenar = 4)
        {
            this.kısakenar = kısakenar;
            this.uzunkenar = uzunkenar;
        }
        public long AlanHesapla()
        {
            return this.kısakenar * this.uzunkenar;
        }
    }
}
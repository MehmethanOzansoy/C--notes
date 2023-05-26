using System;

namespace Type_Conversions // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implict Conversion (Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("d:" + h);

            float i = h;
            Console.WriteLine("d:" + i);


            string e = "zikriye";
            char f = 'k';
            object o = e + " " + f + " " + d;

            Console.WriteLine(o);

            // Explicit Conversion (Bilinçli Döünüşüm)

            Console.WriteLine("**** Explicit Conversion ********");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y.GetType());
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t " + t);

            Console.WriteLine("*******************************************");

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v : " + v + " type of " + v.GetType());


            // ***** toString ******
            Console.WriteLine("**** ToString Method ********");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy type of: " + yy.GetType());
            Console.WriteLine("yy value of: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz type of: " + zz.GetType());
            Console.WriteLine("zz value of: " + zz);

            // ***** System.Convert Class *****
            Console.WriteLine("**** System.Convert Class ********");
            string s1 = "10",s2="20";
            int sayi1,sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1+sayi2;
            Console.WriteLine("toplam: "+ toplam + "\ntipi: "+ toplam.GetType());


            // ************ Parse ******
            Console.WriteLine("**** Parse Method ********");
            parseMethod();


        }

        public static void parseMethod(){
            string m1 = "Greeting";
            string m3 = "10";
            string m2 = "10.25";
            int rakam1;
            double double1;
            // parse her zaman string alır
            rakam1 = Int32.Parse(m3);
            double1 = Double.Parse(m2);

            var toplam = rakam1+double1;
            Console.WriteLine(toplam);
            System.Console.WriteLine("Type of: "+toplam.GetType());
        }
    }
}
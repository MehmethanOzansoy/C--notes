using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // System.Console.WriteLine("Lütfen pozitif sayiları aşağıya giriniz:");
            // System.Console.Write("Kaç tane pozitif sayıya giriniz: ");
            // int n = int.Parse(Console.ReadLine());
            // List<int> positive = new List<int> { };

            // getPositive(n, positive);
            // System.Console.Write("adeti gir:");
            // int n = int.Parse(Console.ReadLine());
            // System.Console.Write("sayiyi gir");
            // int m = int.Parse(Console.ReadLine());

            // method2(n, m);


            ReverseCharacter instance = new ReverseCharacter();
            // instance.method1(5);

            instance.getSumOfWords2();


        }


        public static List<int> getPositive(int count, List<int> a)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    a.Add(number);
                    if (count == a.Count)
                    {
                        break;
                    }
                }
            }

            foreach (var item in a)
            {
                System.Console.Write(item + " ");
            }

            return a;
        }


        public static void method2(int n, int m)
        {

            List<int> liste = new List<int>();
            List<int> dogruListe = new List<int>();

            while (true)
            {
                System.Console.Write("Sayiları giriniz: ");
                int number = int.Parse(Console.ReadLine());
                liste.Add(number);


                if (number == m || m % number == 0)
                {
                    dogruListe.Add(number);

                }


                if (liste.Count == n)
                {
                    break;
                }


            }

            foreach (var item in dogruListe)
            {
                System.Console.WriteLine(item);
            }


        }
    }



    class ReverseCharacter
    {

        public void method1(int a)
        {
            List<string> words = new List<string>();
            List<string> reverseWord = new List<string>();

            System.Console.WriteLine("Girilecek kelime sayisi: " + a);

            for (int i = 0; i < a; i++)
            {
                System.Console.WriteLine("Lütfen Kelime gir");
                string word = Console.ReadLine();
                words.Add(word);
            }

            for (int j = 0; j < words.Count; j++)
            {
                string s = words[j];
                char[] array = s.ToCharArray();
                Array.Reverse(array);
                string reverse = new string(array);
                reverseWord.Add(reverse);
            }
            System.Console.WriteLine("************************");

            foreach (var item in reverseWord)
            {
                System.Console.WriteLine(item);
            }
        }

        public void getSumOfWords()
        {
            Console.WriteLine("Bir cümle yazın:");
            string cumle = Console.ReadLine();

            int kelimeSayisi = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int harfSayisi = cumle.Replace(" ", "").Length;

            Console.WriteLine("Cümledeki toplam kelime sayısı: " + kelimeSayisi);
            Console.WriteLine("Cümledeki toplam harf sayısı: " + harfSayisi);

            Console.ReadLine();
        }

        public void getSumOfWords2()
        {
            Console.WriteLine("Bir cümle yazın:");
            string cumle = Console.ReadLine();
            char[] strArray = cumle.ToArray();
            int kelimeSayisi = 1;
            int harfsayısı = 0;

            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] != ' ')
                {
                    harfsayısı++;
                }
                else if(strArray[i] == ' ')
                {
                    kelimeSayisi ++;
                }
            }


            Console.WriteLine("Kelime sayısı: " + kelimeSayisi);
            Console.WriteLine("harf sayısı: " + harfsayısı);

        }
    }

}
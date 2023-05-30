using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "Ayşe yılmaz");
            kullanıcılar.Add(12, "Serap Can");
            kullanıcılar.Add(18, "Deniz Akar");
            kullanıcılar.Add(20, "Ozcan Çoşar");

            // Dizilerin elemanlarına erişim
            System.Console.WriteLine("******** Elemanlara Erişim **********");
            System.Console.WriteLine(kullanıcılar[12]);

            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
            }

            // Count
            System.Console.WriteLine(kullanıcılar.Count);

            // Contains
            System.Console.WriteLine(kullanıcılar.ContainsKey(12));
            System.Console.WriteLine(kullanıcılar.ContainsValue("Can Arat"));

            // Remove
            System.Console.WriteLine("------- Remove ----------");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
            }

            // keys
            foreach (var item in kullanıcılar.Keys)
            {
                System.Console.WriteLine(item);
            }

            //values
            foreach (var item in kullanıcılar.Values)
            {
                System.Console.WriteLine(item);
            }

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> members = new Dictionary<string, int>();
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int phoneNumber = int.Parse(Console.ReadLine());
                members.Add(name, phoneNumber);
                for (int j = 0; j < n; j++)
                {
                    string a = Console.ReadLine();
                    names.Add(a);
                }
            }

            foreach (var item in members.Values)
            {
                for (int i = 0; i < n; i++)
                {
                    if (item.Equals(names[i]))
                    {
                        foreach (var m in members)
                        {
                            Console.WriteLine(m.Key + "=" + m.Value);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }
            }

            int n = int.Parse(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {

                String[] s = Console.ReadLine().Split(' ');
                string name = s[0];
                string number = s[1];


                phoneBook.Add(name, number);

            }

            string search = "";
            while ((search = Console.ReadLine()) != null)
            {
                if (phoneBook.ContainsKey(search))
                {
                    Console.WriteLine(search + "=" + phoneBook[search]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

        }
    }
}
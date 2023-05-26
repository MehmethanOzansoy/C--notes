using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int deger = 2;
            // string degisken = null;

            // string degisken = " ";
            // Boolean value = true;
            // if(degisken == " "){
            //     Console.WriteLine(value);
            // }

            byte b = 5; // The byte data types allocates 1 byte of memory. (0,255)
            sbyte c = 5; // The byte variable allocates 1 byte of memory. (-128,127)
            short s = 5; // The short occupies(takes up) 2 bytes of memory. (-32.768 ,32.767)
            ushort us = 5; // The ushort data types takes up 2 bytes in memory spaces. (0,65.535) unsigned

            Int16 i16 = 2; // the int36 of data types is occupies size of memory 2 bytes 
            int i = 2; // the int of data types is takes up 4 bytes size of memory 
            Int32 i32 = 2; // 4 bytes
            Int64 i64 = 2; // 8 bytes

            uint ui = 2; // 4 bytes
            long li = 4; // 8 bytes
            ulong ul = 4;

            // real numbers 
            float f = 4.54f; // 4 bytes
            double d = 5.55454; // 8 bytes 
            decimal de = 5; // 16 bytes

            char ch = 'd'; // 2 byte 
            string str  = "dsadsa"; // this data types takes up infinite size of allocated in memory.So this transactions are huge cost for memor

            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = 'o';

            string str1 = string.Empty;
            str1 = "dsadsa";


            string str20 = "20";
            int int20 = 20;

            string yenideger = str20 + int20.ToString();
            int yenideger2 = int20 + Convert.ToInt32(str20);

            Console.WriteLine(yenideger2);

            int int22 = int20+ int.Parse(str20);
            Console.WriteLine(int22);
            

        }
    }
}
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{


    public class FileLogger : Ilogger
    {
        public FileLogger()
        {
        }

        public void WriteLog()
        {
           // throw new NotImplementedException();
           System.Console.WriteLine("Dosyaya Log yazar");
        }
    }

}
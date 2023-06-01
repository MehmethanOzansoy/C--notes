using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class DataBaseLogger : Ilogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();

            System.Console.WriteLine("Database yazar");
        }
    }

}
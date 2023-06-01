using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    public class SmsLogger : Ilogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            System.Console.WriteLine("Sms olarak log yazar");

        }
    }
}
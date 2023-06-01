using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();

            fileLogger.WriteLog();

            LogManager logManager = new LogManager(new SmsLogger());
            logManager.WriteLog();

            Ilogger ılogger = new DataBaseLogger();
            ılogger.WriteLog();
        }
    }
}
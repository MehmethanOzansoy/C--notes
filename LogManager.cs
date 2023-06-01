using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    public class LogManager:Ilogger
    {
        public Ilogger _logger;
        public LogManager(Ilogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            // throw new NotImplementedException();
            _logger.WriteLog();
        }
    }

}
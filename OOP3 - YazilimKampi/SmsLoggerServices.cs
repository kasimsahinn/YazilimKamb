using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3___YazilimKampi
{
    class SmsLoggerServices : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms gönderildi");
        }
    }
}

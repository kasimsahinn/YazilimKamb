using System;
using System.Collections.Generic;

namespace OOP3___YazilimKampi
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerServices = new DatabaseLoggerService();
            ILoggerService fileLogerServices = new FileLoggerService();
            ILoggerService smsLoggerServices = new SmsLoggerServices();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerServices, smsLoggerServices, fileLogerServices };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, loggerServices );
            basvuruManager.BasvuruYap(konutKrediManager, loggerServices );
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggerServices );
            basvuruManager.BasvuruYap(esnafKrediManager, loggerServices );




            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            

        }
    }
}

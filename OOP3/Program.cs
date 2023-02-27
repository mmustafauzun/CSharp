using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        // interface leri birbirinin aternatifi olan ama kod içerikleri farklı olan durumlar için Kullanırız

        private static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager ,loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager,tasitKrediManager};
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
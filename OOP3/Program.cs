using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            NeedCreditManager needCreditManager = new NeedCreditManager();
            ICreditManager carCreditManager = new CarCreditManager();
            HouseCreditManager houseCreditManager = new HouseCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            Console.WriteLine("-----------");

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            ReferenceManager referenceManager = new ReferenceManager();
            referenceManager.ReferenceMade(new TradeCreditManager(), loggers);

            Console.WriteLine("-----------");

            List<ICreditManager> credits = new List<ICreditManager>() { needCreditManager, carCreditManager };

            referenceManager.MakeCreditAdvanceNotification(credits);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ReferenceManager
    {
        public void ReferenceMade(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void MakeCreditAdvanceNotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}

using Log4NetPOC.BusinessLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggingUtility.Log("Entering", null, LoggingLevel.Info);

            LoggingUtility.Log("Doing", null, LoggingLevel.Warn);

            LoggingUtility.Log("Leaving", null, LoggingLevel.Debug);

            LoggingUtility.Log("Exception", new DivideByZeroException("Divinded by 0"));

            Console.ReadKey();
        }
    }
}

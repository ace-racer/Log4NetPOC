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
            LoggingUtility.Log("Entering", LoggingLevel.Info);

            LoggingUtility.Log("Doing", LoggingLevel.Warn);

            LoggingUtility.Log("Leaving", LoggingLevel.Debug);

            Console.ReadKey();
        }
    }
}

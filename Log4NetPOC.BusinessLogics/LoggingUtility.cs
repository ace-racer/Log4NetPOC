using log4net;
using log4net.Config;
using System;

[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "log4net", Watch = true)]
namespace Log4NetPOC.BusinessLogics
{
    
    public static class LoggingUtility
    {
        /// <summary>
        /// The application name
        /// </summary>
        private const string applicationName = "Log4NetExample";

        /// <summary>
        /// The log
        /// </summary>
        private static ILog logger = null;

        /// <summary>
        /// Logs the specified message to log.
        /// </summary>
        /// <param name="messageToLog">The message to log.</param>
        /// <param name="logLevel">The log level.</param>
        public static void Log(string messageToLog, LoggingLevel logLevel = LoggingLevel.Info)
        {
            if (!string.IsNullOrWhiteSpace(messageToLog))
            {
                try
                {
                    if (logger == null)
                    {
                        logger = LogManager.GetLogger(applicationName);
                        
                        // Set up a simple configuration that logs on the console.
                        BasicConfigurator.Configure();
                    }

                    switch (logLevel)
                    {
                        case LoggingLevel.Info:
                            logger.Info(messageToLog);
                            break;
                        case LoggingLevel.Debug:
                            logger.Info(messageToLog);
                            break;
                        case LoggingLevel.Warn:
                            logger.Warn(messageToLog);
                            break;
                        default:
                            logger.Info(messageToLog);
                            break;
                    }
                }
                catch(Exception)
                {
                    // An exception during logging, Yikes!
                }
            }
        }
    }
}

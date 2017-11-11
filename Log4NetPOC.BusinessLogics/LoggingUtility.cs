using log4net;
using log4net.Config;
using System;

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
        public static void Log(string messageToLog, Exception ex = null, LoggingLevel logLevel = LoggingLevel.Info)
        {
            if (!string.IsNullOrWhiteSpace(messageToLog))
            {
                try
                {
                    if (logger == null)
                    {
                        log4net.Config.XmlConfigurator.Configure();
                        logger = LogManager.GetLogger(applicationName);                                            
                    }

                    if(ex != null)
                    {
                        logLevel = LoggingLevel.Exception;
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
                        case LoggingLevel.Exception:
                            var completeMessageForException = messageToLog + " " + ex.Message;
                            logger.Error(completeMessageForException);
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

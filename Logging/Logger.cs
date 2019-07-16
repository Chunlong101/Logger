using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Logging
{
    /// <summary>
    /// Provide logging funtions, such as write logs to different targets. 
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Get a logger using a class type, the logger can help write logs to different targets such as file or database. Examples, GetLogger(this.GetType()) or GetLogger(typeof(YourClassName). 
        /// </summary>
        /// <param name="DeclaringType">Pls provide a class type, for example, GetLogger(this.GetType()) or GetLogger(typeof(YourClassName)</param>
        /// <returns>NLog.Logger</returns>
        public static NLog.Logger GetLogger(Type DeclaringType)
        {
            return LogManager.GetLogger(DeclaringType.FullName);
        }

        /// <summary>
        /// Get a logger, a type parameter is actually recommended, otherwise this method will return a logger for Core.Logging.Logger class, the actual logs will be impacted. 
        /// </summary>
        /// <returns>NLog.Logger</returns>
        public static NLog.Logger GetLogger()
        {
            return LogManager.GetCurrentClassLogger();
        }
    }
}

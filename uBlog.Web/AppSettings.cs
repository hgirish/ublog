using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace uBlog.Web
{
    public static class AppSettings
    {
        /// <summary>
        /// Current version
        /// </summary>
        public const string Version = "0.0.1";

        /// <summary>
        /// Path to database relatively the root folder
        /// </summary>
        public const string DatabasePath = "AppData/uBlog.db";

        /// <summary>
        /// Path to log files relatively the root folder
        /// </summary>
        public const string LoggerPath = "AppData/Logs/log-{Date}.txt";

        /// <summary>
        /// Returns true when database exists
        /// </summary>
        public static bool DbExists()
        {
            var dbFile = Path.Combine(Directory.GetCurrentDirectory(), DatabasePath);
            return File.Exists(dbFile) && (new FileInfo(dbFile).Length > 0);
        }
    }
}

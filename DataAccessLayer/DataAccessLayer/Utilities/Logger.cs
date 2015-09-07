using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DataAccessLayer.Utilities
{
    public static class Logger
    {
        private static String logFileName = String.Format("log_{0}.txt", DateTime.Now);
        private static StreamWriter logFile;
        private static bool ShowExceptionMessageBoxes = true;

        static Logger()
        {
            String currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            logFileName = logFileName.Replace(':', '-').Trim();
            String fullPath = String.Format(@"{0}\{1}", currentDirectory, logFileName);
            logFile = File.AppendText(fullPath);    
        }

        public static void Exception(Exception e)
        {
            StringBuilder logMessage = new StringBuilder();
            logMessage.AppendFormat("{0}: [Exception]", DateTime.Now);
            logMessage.AppendFormat(Environment.NewLine);
            logMessage.AppendFormat("Message: {0}", e.Message);
            logMessage.AppendFormat("Stack trace: {0}", e.StackTrace);
            logFile.WriteLine(logMessage.ToString());

            if (ShowExceptionMessageBoxes)
                MessageBox.Show(logMessage.ToString());
        }
    }
}

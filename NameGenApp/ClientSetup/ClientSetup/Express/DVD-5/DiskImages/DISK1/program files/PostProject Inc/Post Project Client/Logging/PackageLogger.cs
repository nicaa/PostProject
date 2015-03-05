using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostProjectClient.Logging
{
    class PackageLogger
    {
        private StreamWriter _logWriter;

        public PackageLogger(String logFileName)
        {
            String directoryPath = AppDomain.CurrentDomain.BaseDirectory + @"\Logs";
            String retrievedPackagesLogPath = directoryPath + @"\" + logFileName + ".txt";

            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);

            _logWriter = File.AppendText(retrievedPackagesLogPath);
        }

        public void AppendLogEntry(String logEntry)
        {
            _logWriter.WriteLine(DateTime.Now + " - " + logEntry);
        }

        public void Flush()
        {
            _logWriter.FlushAsync();
        }
    }
}

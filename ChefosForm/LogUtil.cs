using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ChefosForm
{
    public class LogUtil
    {

        private LogUtil() { 
            // blank
        }

        public static void LogException(Exception ex) {
            StreamWriter streamWriter = System.IO.File.AppendText("stacktrace.dat");
            streamWriter.WriteLine(ex.ToString() + " " + ex.StackTrace);
            streamWriter.WriteLine("error code is " + ex.Message);
            streamWriter.WriteLine("\n");
            streamWriter.Close(); 
        }
    }
}

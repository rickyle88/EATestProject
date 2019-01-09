using EAAutoFrameWork.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Helpers
{
    public class LogHelpers
    {
        //Log file name is dynamically generated
        //Global Declaration
        private static string logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);

        private static StreamWriter streamw = null;

        //Create a file which can store the log information
        public static void CreateLogFile()
        {
            ConfigReader.SetFrameworkSettings();

            //string currentDir = "..\\..\\Log\\";
            string currentDir = Settings.LogPath.ToString();
           
            streamw = File.AppendText(currentDir + logFileName + ".log");
        }

        //Create a method which can write the text in the log file
        public static void Write(string logMessage)
        {
            streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            streamw.WriteLine("      {0}", logMessage);
            streamw.Flush();
        }


    }
}

using EAAutoFrameWork.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Config
{
    public class Settings
    {
        public static string TestType { get; set; }
        public static string AUT { get; set; }
        public static string BuildName { get; set; }
        public static BrowserType BrowerType { get; set; }
        public static string Is_Log { get; set; }
        public static string IsReporting { get; set; }
        public static string LogPath { get; set; }

    }
}

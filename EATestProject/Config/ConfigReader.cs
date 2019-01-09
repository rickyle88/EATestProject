using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace EAAutoFrameWork.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            XPathItem aut;
            XPathItem buildname;
            XPathItem islog;
            XPathItem testType;
            XPathItem isreport;
            
            //string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            string strFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML node from GlobalConfig.xml
            aut = navigator.SelectSingleNode("EAAutoFramework/RunSettings/AUT");
            buildname = navigator.SelectSingleNode("EAAutoFramework/RunSettings/BuildName");
            testType = navigator.SelectSingleNode("EAAutoFramework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("EAAutoFramework/RunSettings/Is_Log");
            isreport = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsReport");
            

            //Set XML node to be used accross framework
            Settings.AUT = aut.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = testType.Value.ToString();
            Settings.Is_Log = islog.Value.ToString();
            Settings.IsReporting = isreport.Value.ToString();
        }
        
    }
}
